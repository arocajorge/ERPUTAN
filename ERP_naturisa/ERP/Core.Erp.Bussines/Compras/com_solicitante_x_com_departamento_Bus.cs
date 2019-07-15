using Core.Erp.Data.Compras;
using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Compras
{
    public class com_solicitante_x_com_departamento_Bus
    {
        com_solicitante_x_com_departamento_Data odata = new com_solicitante_x_com_departamento_Data();

        public List<com_solicitante_x_com_departamento_Info> GetList(int IdEmpresa, decimal IdSolicitante)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdSolicitante);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
