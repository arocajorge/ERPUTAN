using Core.Erp.Data.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_Aprobacion_Orden_Pago_Data
    {

        string mensaje = "";

        public decimal GetIdAprobacionOrdenPago(int IdEmpresa)
        {
            try
            {
                decimal Id;
                EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

                var select = ECXP.cp_Aprobacion_Orden_pago.Count(q => q.IdEmpresa == IdEmpresa);
                if (select == 0)
                {
                    return Id = 1;
                }

                else
                {
                    var select_ = (from t in ECXP.cp_Aprobacion_Orden_pago
                                   select t.IdAprobacion).Max();
                    Id = Convert.ToDecimal(select_.ToString()) + 1;
                    return Id;
                }
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

        public Boolean Guardar_AprobacionOrdenPago(cp_Aprobacion_Orden_Pago_Info Item, ref decimal Id, ref string mensaje)
        {
            try
            {
                
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    cp_Aprobacion_Orden_pago Cabe = new cp_Aprobacion_Orden_pago();

                    Cabe.IdEmpresa = Item.IdEmpresa;
                    Cabe.IdAprobacion = Id = GetIdAprobacionOrdenPago(Item.IdEmpresa);
                    Cabe.Fecha_Aprobacion = Item.Fecha_Aprobacion;
                    Cabe.Observacion = Item.Observacion;
                    Cabe.UsuarioAprobacion = Item.UsuarioAprobacion;
                    Cabe.Fecha_Transaccion = DateTime.Now;

                    Context.cp_Aprobacion_Orden_pago.Add(Cabe);
                    Context.SaveChanges();
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
