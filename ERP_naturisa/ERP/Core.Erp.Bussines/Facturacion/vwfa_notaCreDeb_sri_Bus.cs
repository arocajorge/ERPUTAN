using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;


namespace Core.Erp.Business.Facturacion
{
  public  class vwfa_notaCreDeb_sri_Bus
    {
      vwfa_notaCreDeb_sri_Data Odata = new vwfa_notaCreDeb_sri_Data();

      public List<vwfa_notaCreDeb_sri_Info> Get_List_notaCreDeb_sri(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota, string CreDeb, ref string msg )
      {
          return Odata.Get_List_notaCreDeb_sri(IdEmpresa, IdSucursal, IdBodega, IdNota, CreDeb, ref msg);
      }
    }
}
