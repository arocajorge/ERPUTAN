using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_XML_DocumentoRetAnulado_Bus
    {
        cp_XML_DocumentoRetAnulado_Data odata = new cp_XML_DocumentoRetAnulado_Data();

        public List<cp_XML_DocumentoRetAnulado_Info> GetList(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return odata.GetList(IdEmpresa, FechaIni, FechaFin);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int GetId(int IdEmpresa, decimal IdDocumento)
        {
            return odata.GetId(IdEmpresa, IdDocumento);
        }
    }
}
