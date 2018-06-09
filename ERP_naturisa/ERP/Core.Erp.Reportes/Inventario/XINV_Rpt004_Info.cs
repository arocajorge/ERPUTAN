using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.Inventario
{
     public class XINV_Rpt004_Info
    {
        public int IdEmpresa{ get; set; }
        public int IdSucursal_oc { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public DateTime Fecha_oc { get; set; }
        public string Observacion_oc { get; set; }
        public string Estado_oc { get; set; }
        public decimal IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public decimal IdProducto { get; set; }
        public string nom_producto { get; set; }
        public int IdSucursal_inv { get; set; }
        public int IdBodega_inv { get; set; }
        public double Cant_Pedida_oc { get; set; }
        public double Cant_Recibida_inv { get; set; }
        public double Cant_x_Recivir_inv{ get; set; }
        public string EstadoPago { get; set; }
        public string Empresa { get; set; }
        public Image Logo { get; set; }

        public XINV_Rpt004_Info()
        {
           
        }
    }
}
