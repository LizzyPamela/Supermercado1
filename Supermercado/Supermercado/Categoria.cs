using System;

public class Categoria
{
	private string codigo;
	private string nombre;
	public Categoria(){}

	public Categoria(string codigo, string nombre)
	{
		this.codigo = codigo;
		this.nombre = nombre;
	}

	public string Codigo { get { return codigo; } set { codigo = value; } }

	public string Nombre { get {  return nombre; } set {  nombre = value; } }

    public override string ToString()
    {
		return $"";
    }
}
