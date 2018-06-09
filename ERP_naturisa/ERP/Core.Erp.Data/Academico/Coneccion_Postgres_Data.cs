using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Npgsql;
//using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Academico
{
    public class Coneccion_Postgres_Data
    {
        
        NpgsqlConnection cnn;
        public NpgsqlConnection conectar()
        {
            try
            {
                string strg = " ";
                strg = "Server=192.168.100.31;Port=5432; User Id=postgres;Password=CAH@Jupiter!!;Database =cah_prueba";
                cnn = new NpgsqlConnection(strg);
                cnn.Open();
                return cnn;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }


        } 
    }
}
