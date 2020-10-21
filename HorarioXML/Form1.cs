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

        private void rellenarFila(string fila)
        {
            dgHorario.Rows.Add(fila);
        }

        private void rellenarHoras()
        {
            foreach (string item in cmbbHora.Items)
            {
                rellenarFila(item);
            }
        }

    }
}
