using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
   public class in_kardex_det_info
    {

       public int IdEmpresa { get; set; }
       public int IdSucursal { get; set; }
       public int IdBodega { get; set; }
       public decimal IdProducto { get; set; }
       public decimal Secuencia { get; set; }
       public string kr_Motivo { get; set; }
       public string Transaccion { get; set; }
       public string kr_Tipo { get; set; }
       public DateTime kr_fecha { get; set; }
       public string kr_Observacion { get; set; }
       public double kr_CostoUni { get; set; }
       public double kr_Ent_Cantidad { get; set; }
       public double kr_Ent_valor { get; set; }
       public double kr_Sali_Cantidad { get; set; }
       public double kr_Sali_valor { get; set; }
       public double kr_Saldo_Cant { get; set; }
       public double kr_Saldo_CostoUni { get; set; }
       public double kr_Saldo_valor { get; set; }


       public decimal peso { get; set; }
       public string CodProducto { get; set; }
       public string NomProducto { get; set; }
       public string Marca { get; set; }
       public string categoria { get; set; }
       public DateTime Fecha { get; set; }
       public string CodMoviInven { get; set; }
       public string CodTipoMoviInven { get; set; }
       public string TipoMoviInven { get; set; }



       public in_kardex_det_info() { }



    }
}
