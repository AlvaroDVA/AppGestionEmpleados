using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpleados.controllers
{
    internal interface IGestionEmpleadosView
    {
        public event EventHandler SaveEmpleado;
        public event EventHandler DeleteEmpleado;
        public event EventHandler NewEmpleado;

        public event EventHandler ShowEmpleados;
        public event EventHandler ShowEmpleadoDetails;

    }
}
