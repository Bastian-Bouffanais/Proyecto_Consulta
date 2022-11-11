using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Paciente
    {
        String rut_paciente;
        String nom_paciente;
        int edad_paciente;
        String estado_paciente;
        String historial_medico;

        public string Rut_paciente { get => rut_paciente; set => rut_paciente = value; }
        public string Nom_paciente { get => nom_paciente; set => nom_paciente = value; }
        public int Edad_paciente { get => edad_paciente; set => edad_paciente = value; }
        public string Estado_paciente { get => estado_paciente; set => estado_paciente = value; }
        public string Historial_medico { get => historial_medico; set => historial_medico = value; }
    }
}
