using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_XML_Documento_Bus
    {
        cp_XML_Documento_Data odata = new cp_XML_Documento_Data();

        public bool GuardarDB(cp_XML_Documento_Info info)
        {
            try
            {
                return odata.GuardarDB(info);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int Existe(int IdEmpresa, string Ruc, string CodDocumento, string Establecimiento, string PuntoEmision, string secuencial)
        {
            try
            {
                return odata.Existe(IdEmpresa, Ruc, CodDocumento, Establecimiento, PuntoEmision, secuencial);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<cp_XML_Documento_Info> GetList(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
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
    }
}
