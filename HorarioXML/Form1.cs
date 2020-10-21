using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorarioXML
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rellenarHoras();
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
                dgHorario.Rows.Add(item);
            }
        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (is_valideAdd())
            {
                //coge la columna del combobox de hora y dia y los mete en columna y fila (a dia hay que sumarle 1 por la celda extra de hora)
                dgHorario.Rows[cmbbHora.SelectedIndex].Cells[cmbbDia.SelectedIndex+1].Value = lstModulo.Text;
            }
            else
            {
                MessageBox.Show("Introduzca los campos obligatorios","Atención",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private int errorLst(ListBox lst,Label lbl)
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
                //coge la columna del combobox de hora y dia y los mete en columna y fila (a dia hay que sumarle 1 por la celda extra de hora)
                dgHorario.Rows[cmbbHora.SelectedIndex].Cells[cmbbDia.SelectedIndex + 1].Value = null;
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
    }
}
