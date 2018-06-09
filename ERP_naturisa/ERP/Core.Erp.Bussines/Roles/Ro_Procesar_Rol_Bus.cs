using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;
///katiuska unific 08012014 1441
namespace Core.Erp.Business.Roles
{///Prog: Héctor Ayauca
    ///V 10.13 22022014
    ///


    public class ro_Procesar_Rol_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_Procesar_Rol_data obj = new ro_Procesar_Rol_data();
        ro_calculos_formula_IESS_bus calc = new ro_calculos_formula_IESS_bus();
    
        // haac 09/01/2014   
        public Boolean Pago_Decimo_XIII(int IdPeriodo_Ini, int IdPeriodo_Fin)
        {
            Boolean procesado = false;
            
            try
            {
                procesado = obj.Pago_Decimo_XIII( IdPeriodo_Ini, IdPeriodo_Fin);
               
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Pago_Decimo_XIII", ex.Message), ex) { EntityType = typeof(ro_Procesar_Rol_Bus) };
            }
            return procesado;
        }// haac 09/01/2014

      
    }
}
