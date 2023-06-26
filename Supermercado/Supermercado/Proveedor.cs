using System;

public class Proveedor
{	
	private string nombre;
	private string telefono;
	private int codigoProveedor;
	public Proveedor()
	{
	}
	
	public Proveedor(string  nombre, string telefono, int codigoProveedor)
	{
		this.nombre = nombre;
		this.telefono = telefono;
		this.codigoProveedor = codigoProveedor;
	}
	public string Nombre { get { return nombre; } set {  nombre = value; } }
	public string Telefono { get {  return telefono; } set {  telefono = value; } }

	public int CodigoProveedor { get {  return codigoProveedor; } set {  codigoProveedor = value; } }

	public override string ToString()
	{
		return $"Nombre: {nombre} \nTelefono: {telefono} \nCodigo: {codigoProveedor}";
	}

}
