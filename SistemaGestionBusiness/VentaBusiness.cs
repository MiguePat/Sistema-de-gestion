using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBusiness
{
    public static class VentaBusiness
    {
        public static List<Venta> ListarVenta()
        {
            return VentaData.ListarVenta();
        }
        public static void CrearVenta(Venta venta)
        {
            VentaData.CrearVenta(venta);
        }

        public static void ModificarVenta(Venta venta)
        {
            VentaData.ModificarVenta(venta);
        }

        public static void EliminarVenta(Venta venta)
        {
            VentaData.EliminarVenta(venta);
        }

    }
}
