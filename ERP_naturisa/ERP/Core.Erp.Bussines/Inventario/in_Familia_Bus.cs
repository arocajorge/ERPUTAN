using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Inventario
{
    public class in_Familia_Bus
    {
        in_Familia_Data odata = new in_Familia_Data();

        public List<in_Familia_Info> GetList(int IdEmpresa)
        {
            try
            {
                return odata.GetList(IdEmpresa);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public in_Familia_Info GetInfo(int IdEmpresa, int IdFamilia)
        {
            try
            {
                return odata.GetInfo(IdEmpresa, IdFamilia);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool GuardarDB(in_Familia_Info info)
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

        public bool ModificarDB(in_Familia_Info info)
        {
            try
            {
                return odata.ModificarDB(info);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AnularDB(in_Familia_Info info)
        {
            try
            {
                return odata.AnularDB(info);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
