using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Academico
{
   public class Aca_Beca_Bus
    {

       Aca_Beca_Data OData;
       tb_sis_Log_Error_Vzen_Bus oLog;


        public Aca_Beca_Bus ()
        {
           oLog = new tb_sis_Log_Error_Vzen_Bus();
           OData = new Aca_Beca_Data();
        }



        #region "Get"

        public int GetId(int IdInstitucion)
        {
            int Id = 0;
            try
            {
                Id = OData.GetId(IdInstitucion);
                return Id;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(Aca_Beca_Bus) };
            }

        }

        public List<Aca_Beca_Info> Get_List_Beca(int IdInstitucion)
        {
            List<Aca_Beca_Info> lstAspirante = new List<Aca_Beca_Info>();
            try
            {
                lstAspirante = OData.Get_List_Beca(IdInstitucion);
                return lstAspirante;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Beca", ex.Message), ex) { EntityType = typeof(Aca_Beca_Bus) };
            }

        }
        #endregion

        #region "Insert,update, delete"
        public bool GrabarDB(Aca_Beca_Info Info, ref int IdBeca, ref string msj)
        {
            try
            {
                return OData.GrabarDB(Info, ref IdBeca, ref msj);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Beca_Bus) };
            }
        }

        public Boolean ActualizarDB(Aca_Beca_Info info, ref string msj)
        {
            try
            {
                return OData.ActualizarDB(info, ref msj);
               
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_Beca_Bus) };
            }
        }


        public Boolean AnularDB(Aca_Beca_Info Info, ref string msj)
        {
            try
            {
                return OData.AnularDB(Info, ref msj);
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(Aca_Beca_Bus) };
            }
        }
        #endregion


    }
}
