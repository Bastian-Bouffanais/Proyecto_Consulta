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
    public class Negocio_Medico
    {
        private Conexion conec1;

        public Conexion Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.Conec1 = new Conexion();
            this.Conec1.NombreBaseDeDatos = "Consulta";
            this.Conec1.NombreTabla = "Psicologo";
            this.Conec1.CadenaConexion = "Data Source=GONZALO-PC;Initial Catalog=Consulta;Integrated Security=True";
        }
        public psicologo retornarPsicologo(int posicion)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Psicologo ";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = this.Conec1.DbDataSet.Tables[0];

            if (dt.Rows.Count > 0)
            {
                psicologo auxPsicologo = new psicologo();
                auxPsicologo.Rut = (String)dt.Rows[posicion]["rut"];
                auxPsicologo.Nombre = (String)dt.Rows[posicion]["nombre"];
                return auxPsicologo;
            }
            else
            {
                psicologo auxPsicologo = new psicologo();
                auxPsicologo.Rut = String.Empty;
                auxPsicologo.Nombre = String.Empty;
                return auxPsicologo;


            }

        }
    }
    }

}
