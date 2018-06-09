using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.General
{
    public class Cl_Parametros_data
    {
        string mensaje = "";
        //
        public DateTime GetDateServer()
        {
            try
            {
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
                return OEselecEmpresa.Database.SqlQuery<DateTime>("SELECT GETDATE()").First();

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                return DateTime.Now;
            }
            
        }



       

        public DataTable ObtenerParametrosDT()
        {
            try
            {
                return new DataTable();
            }
            catch (Exception ex)
            {
                 string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        public Cl_Parametros_data() { }
    }
}
