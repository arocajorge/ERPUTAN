using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.CuentasxCobrar
{
    public class cxc_parametro_Data
    {
        string mensaje = "";

        public cxc_parametro_Info Get_Info_parametro(int IdEmpresa) 
        {
            try
            {
                cxc_parametro_Info info = new cxc_parametro_Info();
                EntitiesCuentas_x_Cobrar cxc=new EntitiesCuentas_x_Cobrar();
                var select = from q in cxc.cxc_Parametro where q.IdEmpresa==IdEmpresa 
                             select q;
                foreach (var item in select)
                {
                    info.IdEmpresa = item.IdEmpresa;
                    info.pa_tipoND_x_CheqProtestado = item.pa_tipoND_x_CheqProtestado;
                    info.pa_IdCaja_x_cobros_x_CXC = Convert.ToInt32(item.pa_IdCaja_x_cobros_x_CXC);
                    info.pa_IdTipoMoviCaja_x_Cobros_x_cliente = Convert.ToInt32(item.pa_IdTipoMoviCaja_x_Cobros_x_cliente);
                    info.pa_IdTipoCbteCble_CxC = Convert.ToInt32(item.pa_IdTipoCbteCble_CxC);
                    info.pa_IdTipoCbteCble_CxC_ANU = Convert.ToInt32(item.pa_IdTipoCbteCble_CxC_ANU);                    
                    info.pa_IdCaja_x_Default = item.pa_IdCaja_x_Default;
                    info.pa_IdTipoCbte_x_conciliacion = item.pa_IdTipoCbte_x_conciliacion;
                    info.pa_IdCobro_tipo_Comision_TC = item.pa_IdCobro_tipo_Comision_TC;
                    info.pa_IdCobro_tipo_default = item.pa_IdCobro_tipo_default;
                    cxc_Parametros_x_cheqProtesto_Data data = new cxc_Parametros_x_cheqProtesto_Data();
                    info.LstParamProtesto=data.Get_List_Parametros_x_cheqProtesto(IdEmpresa);

                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GuardarDB(cxc_parametro_Info Info)
        {
            try
            {
                using (EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
                {
                    var selectParam = (from C in Context.cxc_Parametro
                                        where C.IdEmpresa == Info.IdEmpresa
                                        select C).Count();
                     if (selectParam == 0)
                     {
                         var Address = new cxc_Parametro();

                         Address.IdEmpresa = Info.IdEmpresa;
                         Address.pa_tipoND_x_CheqProtestado = Info.pa_tipoND_x_CheqProtestado;
                         if (Info.pa_IdCaja_x_cobros_x_CXC == 0)
                             Address.pa_IdCaja_x_cobros_x_CXC = null;
                         else
                             Address.pa_IdCaja_x_cobros_x_CXC = Convert.ToInt32(Info.pa_IdCaja_x_cobros_x_CXC);

                         if (Info.pa_IdTipoMoviCaja_x_Cobros_x_cliente == 0)
                             Address.pa_IdTipoMoviCaja_x_Cobros_x_cliente = null;
                         else
                             Address.pa_IdTipoMoviCaja_x_Cobros_x_cliente = Info.pa_IdTipoMoviCaja_x_Cobros_x_cliente;

                         Address.pa_IdCaja_x_Default = Info.pa_IdCaja_x_Default;
                         Address.pa_IdTipoCbteCble_CxC = Convert.ToInt32(Info.pa_IdTipoCbteCble_CxC);
                         Address.pa_IdTipoCbteCble_CxC_ANU = Convert.ToInt32(Info.pa_IdTipoCbteCble_CxC_ANU);
                         
                         Address.pa_IdTipoCbte_x_conciliacion = Convert.ToInt32(Info.pa_IdTipoCbte_x_conciliacion);
                         Address.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                         Address.FechaUltMod = Info.FechaUltMod;
                         Address.pa_IdCobro_tipo_Comision_TC = Info.pa_IdCobro_tipo_Comision_TC;
                         Address.pa_IdCobro_tipo_default = Info.pa_IdCobro_tipo_default;
                         Context.cxc_Parametro.Add(Address);
                         Context.SaveChanges();

                         cxc_Parametros_x_cheqProtesto_Data data = new cxc_Parametros_x_cheqProtesto_Data();
                         data.GuardarDB(Info.LstParamProtesto,Info.IdEmpresa);
                     }
                     else
                     {
                         var Address = Context.cxc_Parametro.First(c => c.IdEmpresa == Info.IdEmpresa);
                        
                         Address.pa_tipoND_x_CheqProtestado = Info.pa_tipoND_x_CheqProtestado;
                         if (Info.pa_IdCaja_x_cobros_x_CXC == 0)
                             Address.pa_IdCaja_x_cobros_x_CXC = null;
                         else
                            Address.pa_IdCaja_x_cobros_x_CXC = Convert.ToInt32(Info.pa_IdCaja_x_cobros_x_CXC);
                       
                         if(Info.pa_IdTipoMoviCaja_x_Cobros_x_cliente == 0)
                            Address.pa_IdTipoMoviCaja_x_Cobros_x_cliente = null;
                         else
                            Address.pa_IdTipoMoviCaja_x_Cobros_x_cliente =Info.pa_IdTipoMoviCaja_x_Cobros_x_cliente;

                         Address.pa_IdTipoCbteCble_CxC = Convert.ToInt32(Info.pa_IdTipoCbteCble_CxC);
                         Address.pa_IdTipoCbteCble_CxC_ANU = Convert.ToInt32(Info.pa_IdTipoCbteCble_CxC_ANU);
                         Address.pa_IdCobro_tipo_Comision_TC = Info.pa_IdCobro_tipo_Comision_TC;
                         Address.pa_IdCobro_tipo_default = Info.pa_IdCobro_tipo_default;
                         Address.pa_IdTipoCbte_x_conciliacion = Convert.ToInt32(Info.pa_IdTipoCbte_x_conciliacion);
                         Context.SaveChanges();

                         cxc_Parametros_x_cheqProtesto_Data data = new cxc_Parametros_x_cheqProtesto_Data();
                         data.GuardarDB(Info.LstParamProtesto,Info.IdEmpresa);                 
                     }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
