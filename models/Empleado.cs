
using models;

namespace GestionEmpleados.models;

public class Empleado(string dni, string nombre, string email, int telefono, string puesto, Departamento? departamento)
{
    public string Dni { get => dni; set => dni = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Email { get => email; set => email = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    public string Puesto { get => puesto; set => puesto = value; }
    public Departamento? DepartamentoEmp { get => departamento; set => departamento = value; }

    public override string ToString() => ("Empleado -- Dni : " + Dni + " -- Nombre : " + Nombre + " -- Email " + Email + 
                                          " -- Telefono : " + Telefono + " -- Puesto : " + Puesto + " -- Departamento : "
                                          + PonerDepartamento());
    

    private string PonerDepartamento() => DepartamentoEmp != null ? DepartamentoEmp.NombreDepartamento : "------";
    
}