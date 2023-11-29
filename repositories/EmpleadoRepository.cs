using GestionEmpleados.models;
using models;

namespace GestionEmpleados.repositories;

public class EmpleadoRepository() : IEmpleadoRepository
{

    private List<Empleado> listaEmpleados = new();
    
    public Empleado? AddItem(Empleado item)
    {
        if (FindByDni(item.Dni) != null)
        {
            return null;
        }
        listaEmpleados.Add(item);
        return item;
    }

    public Empleado DeleteItem(Empleado item)
    {
        Empleado eliminado = FindByDni(item.Dni)!;
        listaEmpleados.Remove(item);
        return eliminado;
    }

    public void DeleteAll()
    {
        listaEmpleados = new List<Empleado>();
    }

    public List<Empleado> AddAll(List<Empleado> listaItem)
    {
        listaItem.ForEach(empleado => listaEmpleados.Add(empleado));
        return listaEmpleados;
    }

    public List<Empleado> FindAll() => listaEmpleados;

    public Empleado? FindByDni(string dni) => listaEmpleados.Find(empleado => empleado.Dni == dni);
    

    public Empleado? DeleteByDni(string dni)
    {
        var empladoBorrar = FindByDni(dni);

        if (empladoBorrar == null)
        {
            return null;
        }

        listaEmpleados.Remove(empladoBorrar);
        return empladoBorrar;
    }

    public List<Empleado> FilterByDepartamento(Departamento departamento) =>
        listaEmpleados.FindAll(empleado => empleado.DepartamentoEmp?.NombreDepartamento == departamento.NombreDepartamento);

    public List<Empleado> RemoveDepartamento(Departamento departamento)
    {
        var lista = listaEmpleados.FindAll(empleado => empleado.DepartamentoEmp?.NombreDepartamento == departamento.NombreDepartamento);

        foreach (var empleado in lista)
        {
            empleado.DepartamentoEmp = null;
        }

        return lista;
    }
}