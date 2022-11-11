using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;
using CapaDTO;
using System.Data;

namespace CapaNegocio
{
    public class Negocio_Paciente
    {
        private Conexion conec1;

        public Conexion Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.Conec1 = new Conexion();
            this.Conec1.NombreBaseDeDatos = "Consulta";
            this.Conec1.NombreTabla = "Paciente";
            this.Conec1.CadenaConexion = "Data Source=GONZALO-PC;Initial Catalog=Consulta;Integrated Security=True";
        }

        public bool buscar_paciente(String rut)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Paciente " +
                                    " WHERE rut = '" + rut + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = this.Conec1.DbDataSet.Tables[0];

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
