using GestionEmpleados.models;
using GestionEmpleados.models.factories;
using GestionEmpleados.repositories;
using GestionEmpleados.validators;
using models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmpleados.controllers
{
    internal class EmpleadoPresenter
    {
        private GestionEmpleadosView view;
        private List<Departamento> allDepartmentos;
        private DepartamentoRepository departamentoRepository;
        private EmpleadoRepository empleadoRepository;

        public string NombreEmpleado {  get => view.NombreEmpleado ; set => view.NombreEmpleado = value; }
        public string EmailEmpleado { get => view.EmailEmpleado; set => view.EmailEmpleado = value; }
        public string TelefonoEmpleado { get => view.TelefonoEmpleado; set => view.TelefonoEmpleado = value; }
        public string Puesto { get => view.PuestoEmpleado; set => view.PuestoEmpleado = value; }
        public string Departamento { get => view.DepartamentoEmpleado; set => view.DepartamentoEmpleado = value; }
        public string Dni { get => view.DniEmpleado; set => view.DniEmpleado = value; }

        public EmpleadoPresenter(GestionEmpleadosView view) {
            this.view = view;

            departamentoRepository = new DepartamentoRepository();
            empleadoRepository = new EmpleadoRepository();

            IniciarValoresDemo();
            GestionarEventos();
            IniciarListas();
        
        }

        private void IniciarValoresDemo()
        {
            departamentoRepository.AddAll(DepartamentoFactory.GenerarDepartamentos());
            empleadoRepository.AddAll(EmpleadoFactory.GenerarListaEmpleados());
            
        }

        private void GestionarEventos()
        {
            view.NewEmpleado += (_, _) => NuevoEmpleado();
            view.SaveEmpleado += (_, _) => SaveEmpleado();
            view.DeleteEmpleado += (_, _) => DeleteEmpleado();
            view.ShowEmpleados += (sender, _) => ShowEmpleadoByDepartamento(sender);
            view.ShowEmpleadoDetails += (sender, _) => ShowEmpleadoDetails(sender);
            
        }

        

        private void IniciarListas()
        {
            allDepartmentos = departamentoRepository.FindAll().ToList();
            cargarDepartamentos();
            foreach (var item in allDepartmentos)
            {
                view.SendComboBoxDepartamento().Items.Add(item.NombreDepartamento);
            }
            
        }

        private void cargarDepartamentos()
        {
            var listView = view.SendDepartamentoList();
            listView.View = View.Details;

            foreach (var departamento in allDepartmentos)
            {
                ListViewItem item = new ListViewItem(departamento.NombreDepartamento);

                listView.Items.Add(item);
            }

            listView.Columns[0].Width = -1;

        }

        private void ShowEmpleadoByDepartamento(object sender)
        {
            var listView = sender as ListView;
            if (listView.SelectedItems.Count > 0)
            {
                var departamento = listView.SelectedItems[0].Text;
                Debug.WriteLine("Departamento seleccionado: " + departamento);
                var listViewEmpleados = view.SendEmpleadoList();
                listViewEmpleados.Items.Clear();
                listViewEmpleados.Columns.Clear();
                listViewEmpleados.View = View.Details;

                

                var listaEmpleados = empleadoRepository.FilterByDepartamento(new Departamento(departamento));
                listViewEmpleados.BeginUpdate();
                foreach (Empleado empleado in listaEmpleados)
                {
                    Debug.WriteLine("Nombre del empleado: " + empleado.Nombre + ", DNI: " + empleado.Dni);

                    ListViewItem item = new ListViewItem(new[] { empleado.Nombre, empleado.Dni });
                    listViewEmpleados.Items.Add(item);
                }

                listViewEmpleados.EndUpdate();

                listViewEmpleados.Columns.Add("Nombre", -1);
                listViewEmpleados.Columns.Add("DNI", -2);

            }
        }

        private void ShowEmpleadoDetails(object sender)
        {
            var listView = sender as ListView;
            if (listView.SelectedItems.Count > 0)
            {
                string dniEmpleado = listView.SelectedItems[0].SubItems[1].Text;
                Empleado empleado = empleadoRepository.FindByDni(dniEmpleado);
                Dni = empleado.Dni;
                NombreEmpleado = empleado.Nombre;
                EmailEmpleado = empleado.Email;
                TelefonoEmpleado = empleado.Telefono.ToString();
                Puesto = empleado.Puesto;
                Departamento = empleado.DepartamentoEmp.NombreDepartamento;

                view.changeEditState(true);
            }
        }

        private void ClearEmpleado ()
        {
            Dni = "";
            NombreEmpleado = "";
            EmailEmpleado = "";
            TelefonoEmpleado = "";
            Puesto = "";
            Departamento = "";
            view.changeEditState (false);
        }

        private void ClearListEmpleado ()
        {
            var listView = view.SendEmpleadoList();
            listView.Clear();
            view.SendDepartamentoList().SelectedItems.Clear();
        }

        private void NuevoEmpleado()
        {
            var view = new NuevoEmpleadoView(allDepartmentos, empleadoRepository);
            view.ShowDialog();

            if (view.GuardarEmpleado)
            {
                empleadoRepository.AddItem(
                   new Empleado(
                         view.DniEmpleado,
                         view.NombreEmpleado,
                         view.EmailEmpleado,
                         int.Parse(view.TelefonoEmpleado),
                         view.PuestoEmpleado,
                         departamentoRepository.FindByNombre(view.DepartamentoEmpleado)
                   )
                );
                MessageBox.Show("Empleado Guardado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearEmpleado();
                ClearListEmpleado();
            }
        }

        private void SaveEmpleado()
        {
            if (ValidacionesEmpleado())
            {
                DialogResult resultado = MessageBox.Show("¿ Seguro que quieres modificar este empleado ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    var empleado = empleadoRepository.FindByDni(Dni);
                    empleado.Nombre = NombreEmpleado;
                    empleado.Dni = Dni;
                    empleado.Email = EmailEmpleado.ToLower();
                    empleado.Telefono = int.Parse(TelefonoEmpleado);
                    empleado.Puesto = Puesto;
                    empleado.DepartamentoEmp = departamentoRepository.FindByNombre(Departamento);

                    MessageBox.Show("Empleado Modificado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearEmpleado();
                    ClearListEmpleado();
                }
            }
            
        }

        private bool ValidacionesEmpleado()
        {
            if (!EmpleadoValidator.ValidarDni(Dni))
            {
                MessageBox.Show("El Dni no es valido ( 8 Numeros + Letra )", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!EmpleadoValidator.ValidarNombre(NombreEmpleado))
            {
                MessageBox.Show("El nombre no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!EmpleadoValidator.ValidarEmail(EmailEmpleado))
            {
                MessageBox.Show("El email no tiene formato valido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!EmpleadoValidator.ValidarTelefono(TelefonoEmpleado))
            {
                MessageBox.Show("El telefono no tiene formato valido ( 9 Digitos ) ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!EmpleadoValidator.ValidarPuesto(Puesto))
            {
                MessageBox.Show("El puesto no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(Departamento))
            {
                MessageBox.Show("Tienes que seleccionar un Departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void DeleteEmpleado()
        {
            DialogResult resultado = MessageBox.Show("¿ Seguro que quieres eliminar este empleado ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var empleado = empleadoRepository.FindByDni(Dni);
                empleadoRepository.DeleteItem(empleado);

                ClearEmpleado();
                ClearListEmpleado();
            }
            
        }
    }
}
