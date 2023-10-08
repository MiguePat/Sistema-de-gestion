using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBusiness
{
    public static class ProductoVendidoBusiness
    {
        public static void ListarProductosVendido()
        {
            ProductoVendidoData.ListarProductosVendido();
        }
        public static void CrearProductoVendido(ProductoVendido productovendido)
        {
            ProductoVendidoData.CrearProductoVendido(productovendido);
        }

        public static void ModificarProductoVendido(ProductoVendido productovendido)
        {
            ProductoVendidoData.ModificarProductoVendido(productovendido);
        }

        public static void EliminarProducto(ProductoVendido productovendido)
        {
            ProductoVendidoData.EliminarProductoVendido(productovendido);
        }

    }
}
