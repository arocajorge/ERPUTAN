using Core.Erp.Data;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.class_sri;
using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Info.class_sri.Retencion;
using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_XML_Documento_Retencion_Bus
    {
        cp_XML_Documento_Retencion_Data odata = new cp_XML_Documento_Retencion_Data();
        public List<cp_XML_Documento_Retencion_Info> GetList(int IdEmpresa, decimal IdDocumento)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdDocumento);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        
    }
}
