using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
namespace Core.Erp.Business.Roles
{
 public   class ro_Novedad_Subida_Bach_Bus
    {
     ro_Novedad_Subida_Bach_Data Data = new ro_Novedad_Subida_Bach_Data();
        public bool SiArchivoFueSubido(int IdEmpresa, string IdCalendario, string IdRubro)
        {
            try
            {
                return Data.SiArchivoFueSubido(IdEmpresa, IdCalendario, IdRubro);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "SiArchivoFueSubido", ex.Message), ex) { EntityType = typeof(ro_Novedad_Subida_Bach_Bus) };
            }
        }


        public bool GrabarDB(int IdEmpresa, string IdCalendario, string IdRubro)
        {
            try
            {
                return Data.GrabarDB(IdEmpresa, IdCalendario, IdRubro,DateTime.Now);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Novedad_Subida_Bach_Bus) };
            }
        }


        public Boolean AnularDB(ro_Novedad_Subida_Bach_Info info)
        {
            try
            {
                return Data.AnularDB(info);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Novedad_Subida_Bach_Bus) };
       
            }
        }

        public List<ro_Novedad_Subida_Bach_Info> ConsultaGeneral(int IdEmpresa)
        {
            List<ro_Novedad_Subida_Bach_Info> Lst = new List<ro_Novedad_Subida_Bach_Info>();
            try
            {
                return Data.ConsultaGeneral(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Novedad_Subida_Bach_Bus) };
       
            }
        }



    }
}
