using System;

public class Cliente
{
	private string nombre;
	private string direccion;
	private string numeroDeTarjeta;// debe ser unico
	private string telefono;
	private string email;
	public Cliente(){}

	public Cliente(string nombre, string direccion, string numeroDeTarjeta, string telefono, string email)
    {
        this.nombre = nombre;
        this.direccion = direccion;
        this.numeroDeTarjeta = numeroDeTarjeta;
        this.telefono = telefono;
        this.email = email;
    }
    
    public string Nombre { get { return nombre; } set { nombre = value; } }
    public string Direccion { get {  return direccion; } set {  direccion = value; } }
    public string NumeroDeTarjeta { get { return numeroDeTarjeta; } set { numeroDeTarjeta= value; } }
    public string Telefono { get { return telefono; } set { telefono = value; } }
    public string Email { get { return email; } set { email = value; } }

    public override string ToString()
    {
        return $"";
    }
}
