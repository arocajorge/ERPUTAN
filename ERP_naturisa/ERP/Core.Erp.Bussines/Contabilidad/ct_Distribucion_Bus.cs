using Core.Erp.Data.Contabilidad;
using Core.Erp.Info.Contabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Contabilidad
{
    public class ct_Distribucion_Bus
    {
        ct_Distribucion_Data odata = new ct_Distribucion_Data();

        public List<ct_Distribucion_Info> GetList(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
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

        public ct_Distribucion_Info GetInfo(int IdEmpresa, decimal IdDistribucion)
        {
            try
            {
                return odata.GetInfo(IdEmpresa, IdDistribucion);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool GuardarDB(ct_Distribucion_Info info)
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

        public bool ModificarDB(ct_Distribucion_Info info)
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

        public bool AnularDB(ct_Distribucion_Info info)
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
