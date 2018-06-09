using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Academico;
using Core.Erp.Info.Academico;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Academico
{
    public class Aca_Catalogo_Bus
    {
        Aca_Catalogo_Data Odata;
        tb_sis_Log_Error_Vzen_Bus oLog;

        public Aca_Catalogo_Bus()
        {
            Odata = new Aca_Catalogo_Data();
            oLog = new tb_sis_Log_Error_Vzen_Bus();
        }

        public List<Aca_Catalogo_Info> Get_List_Catalogo()
        {
            try
            {
                return Odata.Get_List_Catalogo();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };
            }
        }

        public List<Aca_Catalogo_Info> Get_List_CatalogoXtipo(string IdTipoCatalogo)
        {
            try
            {
                return Odata.Get_List_CatalogoXtipo(IdTipoCatalogo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_CatalogoXtipo", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };
            }
        }

        public bool GrabarDB(Aca_Catalogo_Info info, ref string mensaje)
        {
            try
            {
                return Odata.GrabarDB(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };
            }
        }

        public bool ActualizarDB(Aca_Catalogo_Info info, ref string mensaje)
        {
            try
            {
                return Odata.ActualizarDB(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };
            }
        }

        public bool EliminarDB(Aca_Catalogo_Info info,ref string mensaje)
        {
            try
            {
                return Odata.AnularDB(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };
            }
        }
    }
}
