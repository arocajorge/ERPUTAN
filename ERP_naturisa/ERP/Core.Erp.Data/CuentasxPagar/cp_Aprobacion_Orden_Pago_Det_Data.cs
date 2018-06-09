using Core.Erp.Data.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_Aprobacion_Orden_Pago_Det_Data
    {
        string mensaje = "";
        List<cp_Aprobacion_Orden_Pago_Det_Info> lista = new List<cp_Aprobacion_Orden_Pago_Det_Info>();

        public int GetSecuencia(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

                var select = ECXP.cp_Aprobacion_Orden_pago_det.Count(q => q.IdEmpresa == IdEmpresa);
                if (select == 0)
                {
                    return Id = 1;
                }

                else
                {
                    var select_ = (from t in ECXP.cp_Aprobacion_Orden_pago_det
                                   where t.IdEmpresa == IdEmpresa 
                                   select t.secuencia).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
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

        public List<cp_Aprobacion_Orden_Pago_Det_Info> Get_List_Aprobacion_Orden_Pago_Det(int IdEmpresa, string Estado, string IdUsuario)
        {
            try
            {
                lista = new List<cp_Aprobacion_Orden_Pago_Det_Info>();


                EntitiesCuentasxPagar ORol = new EntitiesCuentasxPagar();

                var sresult = from A in ORol.spcp_Get_Data_orden_pago_con_cancelacion_data(IdEmpresa, 1, 99999, "", 1, 99999, Estado, IdUsuario, true)
                              select A;

                foreach (var item in sresult)
                {
                    cp_Aprobacion_Orden_Pago_Det_Info Reg = new cp_Aprobacion_Orden_Pago_Det_Info();

                    Reg.IdEmpresa_OP = item.IdEmpresa;
                    Reg.IdOrdenPago_OP = item.IdOrdenPago;
                    Reg.Fecha_OP = item.Fecha_OP;
                    Reg.Nom_Beneficiario = item.Nom_Beneficiario;
                    Reg.Referencia = item.Referencia;
                    Reg.Fecha_Pago = item.Fecha_Pago;
                    Reg.Saldo_x_Pagar_OP = item.Saldo_x_Pagar_OP;
                    Reg.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                    Reg.IdFormaPago = item.IdFormaPago;
                    Reg.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    Reg.IdEntidad = item.IdEntidad;
                    Reg.IdPersona = Convert.ToDecimal(item.IdPersona);
                    Reg.IdTipoPersona = item.IdTipoPersona;
                    Reg.TotalCancelado = item.Total_cancelado_OP;
                    Reg.Secuencia_OP = item.Secuencia_OP;

                    lista.Add(Reg);
                }
                return lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                      "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GuardarDB(List<cp_Aprobacion_Orden_Pago_Det_Info> Lst, ref decimal Id, ref string mensaje)
        {
            try
            {
                foreach (var Item in Lst)
                {
                    using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                    {
                        cp_Aprobacion_Orden_pago_det Deta = new cp_Aprobacion_Orden_pago_det();

                        Deta.IdEmpresa = Item.IdEmpresa;
                        Deta.IdAprobacion = Id;
                        Deta.secuencia = GetSecuencia(Item.IdEmpresa);
                        Deta.IdEmpresa_OP = Item.IdEmpresa_OP;
                        Deta.IdOrdenPago_OP = Convert.ToDecimal(Item.IdOrdenPago_OP);
                        Deta.Secuencia_OP = Convert.ToInt32(Item.Secuencia_OP);

                        Context.cp_Aprobacion_Orden_pago_det.Add(Deta);
                        Context.SaveChanges();

                        //Actualizar Orden de Pago
                        cp_orden_pago_det_Info ActDetalle = new cp_orden_pago_det_Info();

                        ActDetalle.IdFormaPago = Item.IdFormaPago;
                        ActDetalle.Fecha_Pago = Convert.ToDateTime(Item.Fecha_Pago);
                        ActDetalle.IdEstadoAprobacion = Item.IdEstadoAprobacion;
                      //  ActDetalle.IdEstadoAprobacion = "APRO";
                        ActDetalle.IdUsuario_Aproba = Item.Usuario;
                        ActDetalle.fecha_hora_Aproba = Convert.ToDateTime(Item.Fecha_Pago);
                        ActDetalle.Motivo_aproba = Item.Motivo;
                        ActDetalle.IdEmpresa = Item.IdEmpresa;
                        ActDetalle.IdOrdenPago = Convert.ToDecimal(Item.IdOrdenPago_OP);
                        ActDetalle.Secuencia = Convert.ToInt32(Item.Secuencia_OP);

                        cp_orden_pago_det_Data oData = new cp_orden_pago_det_Data();

                        oData.ModificarDB(ActDetalle);
                    }
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
