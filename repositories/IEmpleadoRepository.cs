using GestionEmpleados.models;
using models;

namespace GestionEmpleados.repositories;

public interface IEmpleadoRepository : ICrudRepository<Empleado>
{

    public Empleado? FindByDni(string dni);
    public Empleado? DeleteByDni(string dni);
    public List<Empleado> FilterByDepartamento(Departamento departamento);
    public List<Empleado> RemoveDepartamento(Departamento departamento);
}