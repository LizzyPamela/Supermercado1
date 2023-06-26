using System;

public class Venta
{	
	private Cliente cliente;
	private int numeroDeVenta;
	private DateOnly fechaVenta;
	private double valorTotal;

	public Venta(){}

	public Venta(Cliente cliente, int numeroDeVenta, DateOnly fechaVenta, double valorTotal)
    {
        this.cliente = cliente;
        this.numeroDeVenta = numeroDeVenta;
        this.fechaVenta = fechaVenta;
        this.valorTotal = valorTotal;
    }

    public Cliente Cliente { get { return cliente; } set { cliente = value; } }

    public int NumeroDeVenta { get { return numeroDeVenta; } set {  numeroDeVenta = value; }}

    public DateOnly FechaVenta { get { return fechaVenta; } set {  fechaVenta = value; } }
    public double ValorTotal { get { return valorTotal; } set { valorTotal = value; } }

    public override string ToString()
    {
        return $"";
    }
}
