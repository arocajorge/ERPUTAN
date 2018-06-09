using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
   public class prd_PuenteGrua_Bus
    {


        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_PuenteGrua_Data data = new prd_PuenteGrua_Data();


        public Boolean GuardarDB(prd_PuenteGrua_Info info, ref string msg)
        {
            try
            {
                return data.GuardarDB(info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(prd_PuenteGrua_Bus) };
              
            }
        }

        public List<prd_PuenteGrua_Info> ListadoPuenteGrua(int IdEmpresa)
        {
            try
            {
                return data.ListadoPuenteGrua(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListadoPuenteGrua", ex.Message), ex) { EntityType = typeof(prd_PuenteGrua_Bus) };
              
            }

        }


        public Boolean ModificarDB( prd_PuenteGrua_Info info, ref string msg)
             {
                try 
	             {	

                    return data.ModificarDB(info,ref msg);
        
		
	             }
	              catch (Exception ex)
	              {
                      Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                      throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(prd_PuenteGrua_Bus) };
              
	              }
            }


        public int GedId(ref string mensaje)
        {
            try
            {

                return data.GedId(ref mensaje);


            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GedId", ex.Message), ex) { EntityType = typeof(prd_PuenteGrua_Bus) };
              
            }

        }

        }


    }

