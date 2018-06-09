using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.General
{
    public class tb_banco_estado_reg__resp_bancaria_Data
    {
        string mensaje = string.Empty;

        public List<tb_banco_estado_reg__resp_bancaria_Info> Get_Lista_Estados()
        {
            try
            {
                List<tb_banco_estado_reg__resp_bancaria_Info> Lista = new List<tb_banco_estado_reg__resp_bancaria_Info>();

                using (EntitiesGeneral Conexion = new EntitiesGeneral())
                {
                    var lst = from q in Conexion.tb_banco_estado_reg__resp_bancaria
                              select q;

                    foreach (var item in lst)
                    {
                        tb_banco_estado_reg__resp_bancaria_Info Info = new tb_banco_estado_reg__resp_bancaria_Info();
                        Info.IdBanco = item.IdBanco;
                        Info.IdEstado_Reg_cat = item.IdEstado_Reg_cat;
                        Info.IdEstado_Reg_Bancario = item.IdEstado_Reg_Bancario.Trim();
                        Info.IdEstado_Reg_Bancario = Info.IdEstado_Reg_Bancario.Replace(Environment.NewLine, "");
                        Info.observacion = item.observacion;
                        Info.Genera_anulacion = item.Genera_anulacion == null ? false : item.Genera_anulacion;
                        Lista.Add(Info);
                    }
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
