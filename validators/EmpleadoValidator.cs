using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestionEmpleados.validators
{
    public static class EmpleadoValidator
    {
        public static bool ValidarNombre(string nombreEmpleado) => !string.IsNullOrEmpty(nombreEmpleado);

        public static bool ValidarEmail (string emailEmpleado)
        {
            string patron = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            return Regex.IsMatch(emailEmpleado, patron);
        }

        public static bool ValidarTelefono(string telefonoEmpleado) 
        {
            string patron = @"^\s*[0-9]{1}\s*[0-9\s]{8}\s*$";
            return Regex.IsMatch(telefonoEmpleado, patron);
        }

        public static bool ValidarPuesto (string puestoEmpleado) => !string.IsNullOrEmpty(puestoEmpleado);

        internal static bool ValidarDni(string dniEmpleado)
        {
            string patron = "^[0-9]{8}[A-Za-z]$";
            return Regex.IsMatch(dniEmpleado, patron);
        }

    }
}
