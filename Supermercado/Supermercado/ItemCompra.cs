using System;

public class ItemCompra
{
	private int codigoProducto;
	private int codigoCompra;
	private int cantidad;
	private double valorUnitario;
	public ItemCompra(){}

	public ItemCompra(int codigoProducto, int codigoCompra, int cantidad, double valorUnitario)
	{
		this.codigoProducto = codigoProducto;
		this.codigoCompra = codigoCompra;
		this.cantidad = cantidad;
		this.valorUnitario = valorUnitario;
	}

	public int CodigoProducto { get { return codigoProducto; } set { codigoProducto = value; } }
	public int CodigoCompra { get { return codigoCompra; } set { codigoCompra = value; } }
	public int Cantidad { get {  return cantidad; } set {  cantidad = value; } }
	public double ValorUnitario { get {  return valorUnitario; } set {  valorUnitario = value; } }
}
