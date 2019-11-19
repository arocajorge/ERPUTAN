using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_RutaPorEmpresaPorUsuario_Bus
    {
        cp_RutaPorEmpresaPorUsuario_Data odata = new cp_RutaPorEmpresaPorUsuario_Data();

        public cp_RutaPorEmpresaPorUsuario_Info GetInfo(int IdEmpresa, string IdUsuario)
        {
            try
            {
                return odata.GetInfo(IdEmpresa, IdUsuario);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool GuardarDB(cp_RutaPorEmpresaPorUsuario_Info info)
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
    }
}
