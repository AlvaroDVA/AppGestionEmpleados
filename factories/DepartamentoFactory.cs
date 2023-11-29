using models;

namespace GestionEmpleados.models.factories;

public static class DepartamentoFactory
{
    public static List<Departamento> GenerarDepartamentos ()
    {
        var lista = new List<Departamento>();
        lista.Add(new Departamento("RR.HH"));
        lista.Add(new Departamento("Administración"));
        lista.Add(new Departamento("Contabilidad"));
        lista.Add(new Departamento("Almacen"));
        lista.Add(new Departamento("Transporte"));
        return lista;
    }
}