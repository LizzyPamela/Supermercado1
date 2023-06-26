using System;

public class GuiaRemision
{
	private Empleado empleado;
	private Producto productos;
	private DateOnly fechaSalida;
	private  int itemsDespachados;
	private int cantidadDeProductos;

	public GuiaRemision(){}

	public GuiaRemision(Empleado empleado, Producto productos, DateOnly fechaSalida, int
		itemsDespachados, int cantidadDeProductos)
	{
		this.empleado = empleado;
		this.productos = productos;
		this.fechaSalida = fechaSalida;
		this.itemsDespachados = itemsDespachados;
		this.cantidadDeProductos = cantidadDeProductos;
	}

	public Empleado Empleado { get { return empleado; } set { empleado = value; } }
	public Producto Productos { get {  return productos; } set {  productos = value; } }
	public DateOnly FechaSalida { get {  return fechaSalida; } set {  fechaSalida = value; } }
	public int ItemsDespachados { get { return itemsDespachados; } set {  itemsDespachados = value; } }
	public int CantidadDeProductos { get { return cantidadDeProductos; } set {  cantidadDeProductos = value; }}

}
