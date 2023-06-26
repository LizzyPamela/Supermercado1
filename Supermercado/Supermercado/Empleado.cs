using System;

public class Empleado
{
	private string nombre;
	private string numeroDeSeguroSocial;// debe ser unico
	private string telefono;
	private string email;
	public Empleado(){}

	public Empleado(string nombre, string direccion, string numeroDeSeguroSocial, string telefono, string email)
    {
        this.nombre = nombre;
        this.numeroDeSeguroSocial= numeroDeSeguroSocial;
        this.telefono = telefono;
        this.email = email;
    }
    
    public string Nombre { get { return nombre; } set { nombre = value; } }
    public string NumeroDeTarjeta { get { return numeroDeTarjeta; } set { numeroDeTarjeta= value; } }
    public string Telefono { get { return telefono; } set { telefono = value; } }
    public string Email { get { return email; } set { email = value; } }

    public override string ToString()
    {
        return $"";
    }
}
