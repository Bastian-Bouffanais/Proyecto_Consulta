using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDTO;

namespace CapaGUI_Paciente
{
    public partial class Ingreso_Rut : Form
    {
        public Ingreso_Rut()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio_Paciente auxNegocioPaciente = new Negocio_Paciente();
                if (auxNegocioPaciente.buscar_paciente(txtRut.Text) == true)
                {
                    Listado_Horas peticion = new Listado_Horas();
                    MessageBox.Show("Bienvenido");
                    peticion.ShowDialog();
                    
                }
                if (txtRut.Text == "")
                {
                    MessageBox.Show("Ingrese su rut");
                }
                else if (auxNegocioPaciente.buscar_paciente(txtRut.Text) == false)
                {
                    MessageBox.Show("Rut no valido o mal escrito Favor verificar");

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo prosesar su peticion " + ex.Message, "Sistema");
            }

        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
