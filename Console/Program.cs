using System;
using Factura;

namespace AppConsole

{
    class Program
    {
        static void Main(string[] args)
        {
            var factura = new Fact
            {
                Cliente = new Cliente
                {
                    Nombre = "Daniela",
                    Apellido = "Freire",
                    Cedula = "0705947422",
                    Direccion = "Guayaquil"
                },

                FechaEmision = DateTime.Now,
                NumeroFactura = "0001",

                Detalles = new System.Collections.Generic.List<DetalleFactura>
                {
                    new DetalleFactura
                    {
                        Cantidad= 5,
                        PrecioUnitario= 0.5,
                        Producto= new Producto
                        {
                            NombreProducto="Lapiz",
                            CodigoProducto="94827492044"
                        }
                    },
                    new DetalleFactura
                    {
                        Cantidad= 20,
                        PrecioUnitario= 0.30,
                        Producto= new Producto
                        {
                            NombreProducto="borrador",
                            CodigoProducto="947254492083"
                        }
                    },
                    new DetalleFactura
                    {
                        Cantidad= 10,
                        PrecioUnitario= 2,
                        Producto= new Producto
                        {
                            NombreProducto="sacapunta",
                            CodigoProducto="75958748690"
                        }

                    }
                }


            };

            var miCalculadora = new CalculadoraFact();

            miCalculadora.CalcularTotal(factura);
        }
    }
}
