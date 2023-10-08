
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBusiness
{
    public static class ProductoBusiness
    {
        public static List<Producto> ListarProductos()
        {
            return ProductoData.ListarProductos();
        }
        public static void CrearProducto(Producto producto)
        {
           ProductoData.CrearProducto(producto);
        }

        public static void ModificarProducto(Producto producto)
        {
            ProductoData.ModificarProducto(producto);
        }

        public static void EliminarProducto(Producto producto)
        {
            ProductoData.EliminarProducto(producto);
        }


    }
}
