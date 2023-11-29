using GestionEmpleados.models;
using GestionEmpleados.repositories;
using GestionEmpleados.validators;
using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmpleados
{
    public partial class NuevoEmpleadoView : Form
    {

        public IEmpleadoRepository EmpleadoRepository { get; set; }

        public string NombreEmpleado { get => nombreTextBox.Text; set => nombreTextBox.Text = value; }
        public string EmailEmpleado { get => emailTextBox.Text.ToLower(); set => emailTextBox.Text = value.ToLower(); }
        public string DniEmpleado { get => dniTextBox.Text; set => dniTextBox.Text = value; }
        public string TelefonoEmpleado { get => telefonoTextBox.Text; set => telefonoTextBox.Text = value; }
        public string PuestoEmpleado { get => puestoTextBox.Text; set => puestoTextBox.Text = value; }
        public string DepartamentoEmpleado { get => departamentoComboBox.Text;}

        public bool GuardarEmpleado { get; set; }

        public List<Departamento> AllDepartamentos { get; set; }
        

        public NuevoEmpleadoView(List<Departamento> allDepartmentos, EmpleadoRepository repositorioEmpleados)
        {
            InitializeComponent();
            this.Text = "Nuevo Empleado";
            AllDepartamentos = allDepartmentos;
            EmpleadoRepository = repositorioEmpleados;
            FillComboBox();
            GuardarEmpleado = false;

            cancelarButton.Click += (_, _) => CancelarButton();
            limpiarButton.Click += (_, _) => LimpiarButton();
            guardarButton.Click += (_, _) => GuardarButton();
        }

        private void CancelarButton()
        {
            GuardarEmpleado = false;
            Close();
        }

        private void GuardarButton() {
            if (!EmpleadoValidator.ValidarDni(DniEmpleado))
            {
                MessageBox.Show("El Dni no es valido ( 8 Numeros + Letra )", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (EmpleadoRepository.FindByDni(DniEmpleado) != null) 
            {
                MessageBox.Show("Ya hay un empleado con este DNI ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!EmpleadoValidator.ValidarNombre(NombreEmpleado))
            {
                MessageBox.Show("El nombre no puede estar vacío", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!EmpleadoValidator.ValidarEmail(EmailEmpleado))
            {
                MessageBox.Show("El email no tiene formato valido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!EmpleadoValidator.ValidarTelefono(TelefonoEmpleado))
            {
                MessageBox.Show("El telefono no tiene formato valido ( 9 Digitos ) ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!EmpleadoValidator.ValidarPuesto(PuestoEmpleado))
            {
                MessageBox.Show("El puesto no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(DepartamentoEmpleado))
            {
                MessageBox.Show("Tienes que seleccionar un Departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                GuardarEmpleado=true;
                Close();
            }
            
        }

        private void LimpiarButton()
        {
            NombreEmpleado = string.Empty;
            EmailEmpleado = string.Empty;
            DniEmpleado = string.Empty;
            TelefonoEmpleado = string.Empty;
            PuestoEmpleado = string.Empty;

        }

        private void FillComboBox()
        {
           
            foreach (Departamento departamento in AllDepartamentos)
            {
                departamentoComboBox.Items.Add(departamento.NombreDepartamento);
            }


        }

        
    }
}
