using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI_Paciente
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btn_Hora_Click(object sender, EventArgs e)
        {
            Ingreso_Rut ingreso = new Ingreso_Rut();
            ingreso.ShowDialog();
        }
    }
}
