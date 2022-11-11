using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class psicologo
    {
        String Rut;
        String nombre_completo;
        int edad;
        String especialidad;
        String centro_atencion;
        DateTime hotas_disponible;
        String modalidad;

        public string Rut1 { get => Rut; set => Rut = value; }
        public string Nombre_completo { get => nombre_completo; set => nombre_completo = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Centro_atencion { get => centro_atencion; set => centro_atencion = value; }
        public DateTime Hotas_disponible { get => hotas_disponible; set => hotas_disponible = value; }
        public string Modalidad { get => modalidad; set => modalidad = value; }
    }
}
