using models;

namespace GestionEmpleados.repositories;

public interface IDepartamentoRepository : ICrudRepository<Departamento>
{
    public Departamento? FindByNombre(string nombre);
    public Departamento? DeleteByNombre(string nombre);
}