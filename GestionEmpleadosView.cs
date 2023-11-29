using GestionEmpleados.models;
using models;
using System.Net.Mail;
using GestionEmpleados.controllers;

namespace GestionEmpleados
{
    public partial class GestionEmpleadosView : Form, IGestionEmpleadosView
    {

        public string NombreEmpleado { get => nombreTextBox.Text; set => nombreTextBox.Text = value; }
        public string DniEmpleado { get => dniTextBox.Text; set => dniTextBox.Text = value; }
        public string TelefonoEmpleado { get => telefonoTextBox.Text; set => telefonoTextBox.Text = value; }
        public string PuestoEmpleado { get => puestoTextBox.Text; set => puestoTextBox.Text = value; }
        public string DepartamentoEmpleado { get => departamentoComboBox.Text; set => departamentoComboBox.Text = value; }
        public string EmailEmpleado { get => emailTextBox.Text; set => emailTextBox.Text = value; }

        public event EventHandler SaveEmpleado;
        public event EventHandler DeleteEmpleado;
        public event EventHandler NewEmpleado;
        public event EventHandler ShowEmpleados;

        public event EventHandler ShowEmpleadoDetails;

        public GestionEmpleadosView()
        {
            InitializeComponent();
            AttachEventHandlers();
            listaDepartamentosView.View = View.Details;
            listaEmpleadosView.View = View.Details;
            changeEditState(false);
            Text = "Gestion de Empleados";
        }

        public ListView SendEmpleadoList() => listaEmpleadosView;
        public ListView SendDepartamentoList() => listaDepartamentosView;
        public ComboBox SendComboBoxDepartamento() => departamentoComboBox;

        public void changeEditState (bool state)
        {
            nombreTextBox.ReadOnly = !state;
            emailTextBox.ReadOnly = !state;
            telefonoTextBox.ReadOnly = !state;
            puestoTextBox.ReadOnly = !state;
            departamentoComboBox.Enabled = state;
            eliminarEmpleadoButton.Enabled = state;
            guardarEmpleadoButton.Enabled = state;
        }

        private void AttachEventHandlers()
        {
            guardarEmpleadoButton.Click += (sender, e) => SaveEmpleado(sender, e);
            eliminarEmpleadoButton.Click += (sender, e) => DeleteEmpleado(sender, e);
            nuevoEmpleadoButton.Click += (sender, e) => NewEmpleado(sender, e);
            listaDepartamentosView.SelectedIndexChanged += (sender, e) => ShowEmpleados(sender, e);
            listaEmpleadosView.SelectedIndexChanged += (sender, e) => ShowEmpleadoDetails(sender, e);
        }
    }
}