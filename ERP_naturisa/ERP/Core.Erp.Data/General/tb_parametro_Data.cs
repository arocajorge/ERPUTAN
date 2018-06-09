using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;


namespace Core.Erp.Data.General
{
   public class tb_parametro_Data
    {
        string mensaje = "";


        public List<tb_parametro_Info> Get_List_parametro()
        {
            try
            {
                List<tb_parametro_Info> lM = new List<tb_parametro_Info>();
                EntitiesGeneral OEGeneral = new EntitiesGeneral();

                var select_pv = from A in OEGeneral.tb_parametro
                                select A;

                foreach (var item in select_pv)
                {

                    tb_parametro_Info info = new tb_parametro_Info();
                    info.IdParametro = item.IdParametro;
                    info.IdTipoParam = item.IdTipoParam;
                    info.Valor = item.Valor;
                    info.descripcion = item.descripcion;

                    
                    lM.Add(info);
                }
                return (lM);
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

        public Boolean ModificarDB(tb_parametro_Info info, ref string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                
                        var contact = context.tb_parametro.First(obj => obj.IdParametro == info.IdParametro );
                        contact.IdParametro = info.IdParametro;
                        contact.IdTipoParam = info.IdTipoParam;
                        contact.Valor = info.Valor;
                        contact.descripcion = info.descripcion;
                        context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public Boolean GuardarDB(tb_parametro_Info info, ref string msg)
        {
            try
            {
                Boolean resultado = false;
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = new tb_parametro();
                    address.IdParametro = info.IdParametro;
                    address.IdTipoParam = info.IdTipoParam;
                    address.Valor = info.Valor;
                    address.descripcion = info.descripcion;

                    context.tb_parametro.Add(address);
                    context.SaveChanges();
                    resultado = true;
                }
                return resultado;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

    }
}
