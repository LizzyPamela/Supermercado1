using System;

public class Producto
{
	private string nombre;
	private string codigo;
	private double precioCompra;
	private double precioVenta;
	private DateOnly fechaElaboracion;
	private DateOnly fechaVencimiento;
    private Categoria categoria;
	public Producto(){}

	public Producto(string nombre, string codigo, double precioCompra, double precioVenta,
        DateOnly fechaElaboracion, DateOnly fechaVencimiento, Categoria categoria)
    {
        this.nombre = nombre;
        this.codigo = codigo;
        this.precioCompra = precioCompra;
        this.precioVenta = precioVenta;
        this.fechaElaboracion = fechaElaboracion;
        this.fechaVencimiento = fechaVencimiento;
        this.categoria = categoria;
    } 

    public string Nombre { get { return nombre; } set { nombre = value; } }
    public string Codigo { get {  return codigo; } set {  codigo = value; } }
    public double PrecioCompra { get {  return precioCompra; } set {  precioCompra = value; } }
    public double PrecioVenta { get { return PrecioVenta;  } set {  PrecioVenta = value; } }
    
    public DateOnly FechaElaboracion { get {  return fechaElaboracion; } set {  fechaElaboracion = value; }}

    public DateOnly FechaVencimiento { get {  return fechaVencimiento; } set { fechaVencimiento = value;} }
    public Categoria Categoria { get { return categoria;  } set { categoria = value; } }

    public override string ToString()
    {
        return $"";
    }
}
