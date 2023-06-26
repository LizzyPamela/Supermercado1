using System;

public class Supermercado
{
    private string nombre;
    private string direccion;
    private string telefono;
    public Supermercado(){}
    
    public Supermercado(string nombre, string direccion, string telefono)
    {
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
    }
    public string Nombre { get { return nombre; } set { nombre = value; } }
    public string Direccion { get { return direccion; } set { direccion = value; } }
    public string Telefono { get { return telefono; } set { telefono = value; } }

    public override string ToString()
    {
        return $"";
    }
}
