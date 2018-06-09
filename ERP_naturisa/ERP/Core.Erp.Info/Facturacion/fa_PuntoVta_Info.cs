using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion
{
  public  class fa_PuntoVta_Info
    {

      public int IdEmpresa { get; set; }
      public int IdSucursal { get; set; }
      public Nullable<int> IdBodega { get; set; }
      public int IdPuntoVta { get; set; }
      public string cod_PuntoVta { get; set; }
      public string nom_PuntoVta { get; set; }
      public string nom_PuntoVta2 { get; set; }
      public bool estado { get; set; }
      //public Nullable<int> IdBodega { get; set; }
      //Campos para vista
      public string Su_Descripcion { get; set; }

      public fa_PuntoVta_Info()
      {

      }

      public fa_PuntoVta_Info(int _IdEmpresa, int _IdSucursal, int _IdPuntoVta, string _cod_PuntoVta, string _nom_PuntoVta, int _IdBodega )
      {
          IdEmpresa = _IdEmpresa;
          IdSucursal = _IdSucursal;
          IdPuntoVta = _IdPuntoVta;
          cod_PuntoVta = _cod_PuntoVta;
          nom_PuntoVta = _nom_PuntoVta;
          IdBodega = _IdBodega;
      }


    }
}
