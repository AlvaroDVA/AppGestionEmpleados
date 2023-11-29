namespace models;

public class Departamento (string nombreDepartamento)
{
    public string NombreDepartamento { get => nombreDepartamento; set => nombreDepartamento = value; }

    public bool Equals(Departamento dep) => NombreDepartamento == dep.NombreDepartamento;

    public override string ToString()
    {
        return NombreDepartamento;
    }
}