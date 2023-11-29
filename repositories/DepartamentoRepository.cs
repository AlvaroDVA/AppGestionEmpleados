using models;

namespace GestionEmpleados.repositories;

public class DepartamentoRepository : IDepartamentoRepository
{
    private List<Departamento> lista = new();
    public Departamento? AddItem(Departamento item)
    {
        if (FindByNombre(item.NombreDepartamento) != null)
        {
            return null;
        }
        lista.Add(item);
        return item;
    }

    public Departamento DeleteItem(Departamento item)
    {
        Departamento eliminado = FindByNombre(item.NombreDepartamento);
        lista.Remove(item);
        return eliminado;
    }

    public void DeleteAll()
    {
        lista = new List<Departamento>();
    }

    public List<Departamento> AddAll(List<Departamento> listaItem)
    {
        foreach (var departamento in listaItem)
        {
            lista.Add(departamento);
        }

        return lista;
    }

    public List<Departamento> FindAll() => lista;

    public Departamento? FindByNombre(string nombre) =>
        lista.Find(departamento => departamento.NombreDepartamento == nombre);

    public Departamento DeleteByNombre(string nombre)
    {
        var deleteBorrar = FindByNombre(nombre);

        if (deleteBorrar == null)
        {
            return null;
        }

        lista.Remove(deleteBorrar);
        return deleteBorrar;
    }
}