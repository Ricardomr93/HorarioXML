using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace HorarioXML
{
    public partial class Form1 : Form
    {
        string ruta;
        bool cargado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            crearTabla();
        }

        /**
         * Cuando el raton permanece quieto en una celda
         */
        private void dgHorario_MouseHover(object sender, EventArgs e)
        {

        }
        private void rellenarHoras()
        {
            
            foreach (string item in cmbbHora.Items)
            {
                dsDatos.Tables[0].Rows.Add(item);
            }
        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (is_valideAdd())
            {
                try
                {
                    //coge la columna del combobox de hora y dia y los mete en columna y fila (a dia hay que sumarle 1 por la celda extra de hora)
                    dgHorario.Rows[cmbbHora.SelectedIndex].Cells[cmbbDia.SelectedIndex + 1].Value = lstModulo.Text;
                    aniadirToolTip();

                }
                catch (Exception)
                { }
            }
            else
            {
                MessageBox.Show("Introduzca los campos obligatorios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool is_valideAdd()
        {
            int cont_error = 0;
            bool no_error = true;
            cont_error += errorCbb(cmbbCurso);
            cont_error += errorCbb(cmbbDia);
            cont_error += errorCbb(cmbbHora);
            cont_error += errorLst(lstCiclo, lblCiclo);
            cont_error += errorLst(lstModulo, lblModulos);
            if (cont_error > 0)
            {
                no_error = false;
            }

            return no_error;
        }

        private int errorLst(ListBox lst, Label lbl)
        {
            if (lst.SelectedIndex < 0)
            {
                ep.SetError(lbl, "Campo obligatorio");
                return 1;
            }
            return 0;
        }
        private int errorCbb(ComboBox cmbb)
        {
            if (cmbb.SelectedIndex < 0)
            {
                ep.SetError(cmbb, "Campo obligatorio");
                return 1;
            }
            return 0;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (is_valideDelete())
            {
                try
                {
                    //coge la columna del combobox de hora y dia y los mete en columna y fila (a dia hay que sumarle 1 por la celda extra de hora)
                    dgHorario.Rows[cmbbHora.SelectedIndex].Cells[cmbbDia.SelectedIndex + 1].Value = null;
                    quitarToolTip();
                }
                catch (ArgumentException)
                {
                }
            }
            else
            {
                MessageBox.Show("Introduzca los campos obligatorios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool is_valideDelete()
        {
            int cont_error = 0;
            bool no_error = true;
            cont_error += errorCbb(cmbbDia);
            cont_error += errorCbb(cmbbHora);
            if (cont_error > 0)
            {
                no_error = false;
            }
            return no_error;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                ruta = ofdAbrir.FileName;
                dsDatos.Reset();
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(ruta);
                XmlNodeList horario;

                //Añadimos la tabla al horario directamente, con las columnas fijas
                dsDatos.Tables.Add(new DataTable("horario"));
                dsDatos.Tables[0].Columns.Add("Hora", typeof(string));
                dsDatos.Tables[0].Columns.Add("Lunes", typeof(string));
                dsDatos.Tables[0].Columns.Add("Martes", typeof(string));
                dsDatos.Tables[0].Columns.Add("Miercoles", typeof(string));
                dsDatos.Tables[0].Columns.Add("Jueves", typeof(string));
                dsDatos.Tables[0].Columns.Add("Viernes", typeof(string));
                try
                {
                    //Recorremos el XMLDocument y vamos rellenando el DataSet junto con los tooltiptext
                    horario = xDoc.GetElementsByTagName("horario");
                    XmlNodeList horas = ((XmlElement)horario[0]).GetElementsByTagName("hora");
                    int cont_hora = 0;
                    foreach (XmlElement hora in horas)
                    {
                        //Construimos dos arrays de strings, uno para los textos a mostrar y otros con las ayudas
                        string[] fila_pant = new string[6];
                        string[] fila_ayu = new string[6];
                        //La primera columna de cada fila será la hora: primera, segunda, etc.
                        fila_pant[0] = hora.GetAttribute("id").ToString();
                        fila_ayu[0] = "";
                        int col = 1;
                        XmlNodeList dias = hora.GetElementsByTagName("dia");
                        foreach (XmlElement dia in dias)
                        {
                            XmlNodeList entrada_pant = dia.GetElementsByTagName("pantalla");
                            fila_pant[col] = ((XmlElement)entrada_pant[0]).InnerText.ToString();
                            XmlNodeList entrada_ayu = dia.GetElementsByTagName("ayuda");
                            fila_ayu[col] = ((XmlElement)entrada_ayu[0]).InnerText.ToString();
                            col++;
                        }
                        dsDatos.Tables[0].Rows.Add(fila_pant);
                        //Antes de pasar a la siguiente fila, se enlaza el dataGridView y el DataSet
                        //Y así podemos establecer los textos de ayuda
                        dgHorario.DataSource = dsDatos.Tables[0];
                        for (int c = 1; c < fila_ayu.Length; c++)
                        {
                            dgHorario.Rows[cont_hora].Cells[c].ToolTipText = fila_ayu[c];
                        }
                        cont_hora++;
                    }
                    tablaFija();
                }
                catch (Exception)
                {
                    MessageBox.Show("Intentando cargar un archivo no compatible", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!campoVacio())
            {
                XmlDocument xDoc;
                XmlTextWriter xtw;
                if (sfdGuardar.ShowDialog() == DialogResult.OK)
                {
                    xtw = new XmlTextWriter(sfdGuardar.FileName, Encoding.UTF8);
                    xtw.Formatting = Formatting.Indented;
                    xDoc = new XmlDocument();
                    //Construir un nuevo XMLDocument vacío, el cuál se irá rellenando con los datos
                    //del Dataset asociado al DataGridView y se le irán añadiendo para cada día
                    //una nueva etiqueta con la información del toltiptext
                    XmlElement elementoRaiz = xDoc.CreateElement(string.Empty, "horario", string.Empty);
                    xDoc.AppendChild(elementoRaiz);
                    for (int f = 0; f < dgHorario.Rows.Count; f++)
                    {
                        XmlElement xHora = xDoc.CreateElement(string.Empty, "hora", string.Empty);
                        //El atributo id con la hora se puede sacar de la primera columna del DataGridView
                        xHora.SetAttribute("id", dgHorario.Rows[f].Cells[0].Value.ToString());
                        for (int c = 1; c < dgHorario.Columns.Count; c++)
                        {
                            XmlElement xDia = xDoc.CreateElement(string.Empty, "dia", string.Empty);
                            XmlElement xPantalla = xDoc.CreateElement(string.Empty, "pantalla", string.Empty);
                            XmlElement xAyuda = xDoc.CreateElement(string.Empty, "ayuda", string.Empty);
                            XmlText xTxTPantalla = xDoc.CreateTextNode(dgHorario.Rows[f].Cells[c].Value.ToString());
                            xPantalla.AppendChild(xTxTPantalla);
                            XmlText xTxTAyuda = xDoc.CreateTextNode(dgHorario.Rows[f].Cells[c].ToolTipText);
                            xAyuda.AppendChild(xTxTAyuda);
                            xDia.AppendChild(xPantalla);
                            xDia.AppendChild(xAyuda);
                            xHora.AppendChild(xDia);
                            
                        }
                        elementoRaiz.AppendChild(xHora);
                    }
                    //Por último, escribir el contenido del XMLDocument en el archivo y cerrar conexión
                    xDoc.Save(xtw);
                    xtw.Close();
                    MessageBox.Show("Se ha guardado el horario", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void tablaFija()
        {
            foreach (DataGridViewColumn column in dgHorario.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.Resizable = DataGridViewTriState.False;
            }
        }
        public void crearTabla()
        {
            dsDatos.Reset();
            dsDatos.Tables.Add(new DataTable("horario"));
            dsDatos.Tables[0].Columns.Add("HORA");
            dsDatos.Tables[0].Columns.Add("LUNES");
            dsDatos.Tables[0].Columns.Add("MARTES");
            dsDatos.Tables[0].Columns.Add("MIERCOLES");
            dsDatos.Tables[0].Columns.Add("JUEVES");
            dsDatos.Tables[0].Columns.Add("VIERNES");
            rellenarHoras();
            dgHorario.DataSource = dsDatos.Tables[0];
            tablaFija();


        }

        private void dgHorario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            int c = e.ColumnIndex;
            if (f != -1 && c != -1)
            {
                cmbbHora.SelectedIndex = f;
                cmbbDia.SelectedIndex = c - 1;

            }
        }
        public bool campoVacio()
        {
            bool bCampoVacio = true;
            if (dgHorario.RowCount > 0)
            {
                bCampoVacio = false;
                foreach (DataGridViewRow dr in dgHorario.Rows)
                {
                    foreach (DataGridViewCell dc in dr.Cells)
                    {
                        if (dc.Value == null || string.IsNullOrEmpty(dc.Value.ToString()) || dc.Value.Equals(""))
                        {
                            bCampoVacio = true;
                        }
                    }
                }
                if (bCampoVacio)
                {
                    MessageBox.Show("Hay algún campo vacío","Atención!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    bCampoVacio = true;
                }

            }
            return bCampoVacio;
        }

        public void aniadirToolTip()
        {
            string[] tooltip = { "Joaquín - Aula 209", "José Alberto - Aula 209", "Inmaculada - Aula 209", "María - Aula 209", "Fernando - Aula 209", "José Luis - Aula 209" };
            dgHorario.Rows[cmbbHora.SelectedIndex].Cells[cmbbDia.SelectedIndex + 1].ToolTipText = tooltip[lstModulo.SelectedIndex];
        }
        public void quitarToolTip()
        {
            dgHorario.Rows[cmbbHora.SelectedIndex].Cells[cmbbDia.SelectedIndex + 1].ToolTipText = null;
        }

    }
}

