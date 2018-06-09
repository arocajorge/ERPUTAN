using Core.Erp.Data.General;
using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Academico
{
    public class tb_banco_x_mg_banco_Data
    {
        string mensaje = "";
        public List<tb_banco_x_mg_banco_Info> Get_Listado_Banco_Aca()
        {
            try
            {
            List<tb_banco_x_mg_banco_Info> Lista = new List<tb_banco_x_mg_banco_Info>();
              Entities_Academico conex = new Entities_Academico();

             var bancos = from q in conex.tb_banco_x_mg_banco
                             select q;
                foreach (var item in bancos)
                {
                    tb_banco_x_mg_banco_Info info = new tb_banco_x_mg_banco_Info();

                    info.Id_tb_banco_x_mgbanco = item.Id_tb_banco_x_mgbanco;
                    info.nombre = item.nombre;
                    info.IdBanco_Erp = item.IdBanco_Erp;
                    info.IdBanco_Academico = item.IdBanco_Academico;

                    Lista.Add(info);   
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }

        }
    }
}
