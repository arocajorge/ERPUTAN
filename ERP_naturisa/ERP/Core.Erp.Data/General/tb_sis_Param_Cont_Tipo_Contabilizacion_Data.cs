using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{
    public class tb_sis_Param_Cont_Tipo_Contabilizacion_Data
    {
        string mensaje = "";
        public List<tb_sis_Param_Cont_Tipo_Contabilizacion_Info> ConsultarParamConta() {
            try
            {
                List<tb_sis_Param_Cont_Tipo_Contabilizacion_Info> Lst = new List<tb_sis_Param_Cont_Tipo_Contabilizacion_Info>();
                //using (EntitiesGeneral general = new EntitiesGeneral())
                //{
                //    var consultar = from q in general.xxxtb_sis_Param_Cont_Tipo_Contabilizacion
                //                    select q;
                //    foreach (var item in consultar)
                //    {
                //        tb_sis_Param_Cont_Tipo_Contabilizacion_Info info = new tb_sis_Param_Cont_Tipo_Contabilizacion_Info();
                //        info.IdTipo_Conta = item.IdTipo_Conta;
                //        info.Descripcion = item.Descripcion;
                //        Lst.Add(info);
                //    }
                //}
                return Lst;
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

        public String ConsEspeParamConta(String idConta)
        {
            try
            {
                string descripcion = "";

                //using (EntitiesGeneral General = new EntitiesGeneral())
                //{
                //    var Espe = from q in General.xxxtb_sis_Param_Cont_Tipo_Contabilizacion
                //               where q.IdTipo_Conta == idConta
                //               select q;
                    
                //    foreach (var item in Espe)
                //    {
                //        descripcion = item.Descripcion;
                //    }
                
                //}

                return descripcion;
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
    }
}
