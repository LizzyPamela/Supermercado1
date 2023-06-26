using System;

public class Compra
{
    private Proveedor proveedor;
    private DateOnly fecha;
    private double valorTotal;
    public Compra() { }

    public Compra(Proveedor proveedor, DateOnly fecha, double valorTotal)
    {
        this.proveedor = proveedor;
        this.fecha = fecha;
        this.valorTotal = valorTotal;
    }

    public Proveedor Proveedor {get { return proveedor;  } set { proveedor = value; } }

    public DateOnly Fecha { get { return fecha; } set { fecha = value; } }

    public double ValorTotal { get { return valorTotal; } set { valorTotal = value; } }


}
