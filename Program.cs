

using GestionEmpleados.controllers;

namespace GestionEmpleados
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var view = new GestionEmpleadosView();
            var presenter = new EmpleadoPresenter(view);
            Application.Run(view);
        }
    }
}