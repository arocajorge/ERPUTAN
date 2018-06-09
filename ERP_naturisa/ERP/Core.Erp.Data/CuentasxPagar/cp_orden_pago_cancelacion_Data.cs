using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
//DEREK MEJIA SORIA 05/03/2014
namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_orden_pago_cancelacion_Data
    {
        string mensaje = "";
        public decimal GetIdcancelacion(int IdEmpresa)
        {
            try
            {
               decimal Id=0;
                //EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

                //var select = ECXP.cp_orden_pago_cancelacion.Count(q => q.IdEmpresa == IdEmpresa);
                //if (select == 0)
                //{
                //    return Id = 1;
                //}

                //else
                //{
                //    var select_ = (from t in ECXP.cp_orden_pago_cancelacion
                //                   select t.Idcancelacion).Max();
                //    Id = Convert.ToDecimal(select_.ToString()) + 1;
                //    return Id;
                //}

                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return 0;
            }
        }

        public List<cp_orden_pago_cancelacion_Info> ConsultaGeneralOPC(int IdEmpresa, ref string mensaje) {
            try
            {
                List<cp_orden_pago_cancelacion_Info> Lst = new List<cp_orden_pago_cancelacion_Info>();
                //using (EntitiesCuentasxPagar cxp = new EntitiesCuentasxPagar())
                //{
                //    var consulta = from q in cxp.cp_orden_pago_cancelacion
                //                   where q.IdEmpresa == IdEmpresa
                //                   select q;

                //    foreach (var item in consulta)
                //    {
                //        cp_orden_pago_cancelacion_Info info = new cp_orden_pago_cancelacion_Info();
                //        info.IdEmpresa = item.IdEmpresa;
                //        info.Idcancelacion = item.Idcancelacion;
                //        info.Secuencia = item.Secuencia;
                //        info.IdEmpresa_op = item.IdEmpresa_op;
                //        info.IdOrdenPago_op = item.IdOrdenPago_op;
                //        info.Secuencia_op = item.Secuencia_op;
                //        info.IdEmpresa_cbtecble = item.IdEmpresa_cbtecble;
                //        info.IdTipoCbte_cbtecble = item.IdTipoCbte_cbtecble;
                //        info.IdCbteCble_cbtecble = item.IdCbteCble_cbtecble;
                //        info.MontoAplicado = item.MontoAplicado;
                //        info.SaldoAnterior = item.SaldoAnterior;
                //        info.SaldoActual = item.SaldoActual;
                //        info.Observacion = item.Observacion;
                //        info.NumCheque = item.NumCheque;
                //        info.Banco = item.Banco;
                //        info.fechaTransaccion = item.fechaTransaccion;
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
                mensaje = ex.InnerException + " " + ex.Message;

                return new List<cp_orden_pago_cancelacion_Info>();
            }
        }

        public List<cp_orden_pago_cancelacion_Info> ConsultaGeneralOPCxIdCancelacion(int IdEmpresa,decimal IdCancelacion, ref string mensaje)
        {
            try
            {
                List<cp_orden_pago_cancelacion_Info> Lst = new List<cp_orden_pago_cancelacion_Info>();
                //using (EntitiesCuentasxPagar cxp = new EntitiesCuentasxPagar())
                //{
                //    var consulta = from q in cxp.cp_orden_pago_cancelacion
                //                   where q.IdEmpresa == IdEmpresa
                //                   where q.Idcancelacion == IdCancelacion
                //                   select q;

                //    foreach (var item in consulta)
                //    {
                //        cp_orden_pago_cancelacion_Info info = new cp_orden_pago_cancelacion_Info();
                //        info.IdEmpresa = item.IdEmpresa;
                //        info.Idcancelacion = item.Idcancelacion;
                //        info.Secuencia = item.Secuencia;
                //        info.IdEmpresa_op = item.IdEmpresa_op;
                //        info.IdOrdenPago_op = item.IdOrdenPago_op;
                //        info.Secuencia_op = item.Secuencia_op;
                //        info.IdEmpresa_cbtecble = item.IdEmpresa_cbtecble;
                //        info.IdTipoCbte_cbtecble = item.IdTipoCbte_cbtecble;
                //        info.IdCbteCble_cbtecble = item.IdCbteCble_cbtecble;
                //        info.MontoAplicado = item.MontoAplicado;
                //        info.SaldoAnterior = item.SaldoAnterior;
                //        info.SaldoActual = item.SaldoActual;
                //        info.Observacion = item.Observacion;
                //        info.NumCheque = item.NumCheque;
                //        info.Banco = item.Banco;
                //        info.fechaTransaccion = item.fechaTransaccion;
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
                mensaje = ex.InnerException + " " + ex.Message;

                return new List<cp_orden_pago_cancelacion_Info>();
            }
        }

        public Boolean Guardar_OrdenPagoCancelacion(List<cp_orden_pago_cancelacion_Info> Lst, int Id, ref string mensaje)
        {
            try
            {
                //int Secuencia = 1;
                //decimal IdCancelacion = GetIdcancelacion(Id);
                //foreach (var Item in Lst)
                //{
                //    using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                //    {
                //        cp_orden_pago_cancelacion Cabe = new cp_orden_pago_cancelacion();

                //        Cabe.IdEmpresa = Item.IdEmpresa;
                //        Cabe.Idcancelacion = IdCancelacion;
                //        Item.Idcancelacion = IdCancelacion;//DEREK MEJIA 10/03/2014
                //        Cabe.Secuencia = Secuencia;
                //        Item.Secuencia = Secuencia;//DEREK MEJIA 10/03/2014
                //        Cabe.IdEmpresa_op = Item.IdEmpresa_op;
                //        Cabe.IdOrdenPago_op = Item.IdOrdenPago_op;
                //        Cabe.Secuencia_op = Item.Secuencia_op;
                //        Cabe.IdEmpresa_cbtecble = Item.IdEmpresa_cbtecble;
                //        Cabe.IdTipoCbte_cbtecble = Item.IdTipoCbte_cbtecble;
                //        Cabe.IdCbteCble_cbtecble = Item.IdCbteCble_cbtecble;
                //        Cabe.MontoAplicado = Item.MontoAplicado;
                //        Cabe.SaldoAnterior = Item.SaldoAnterior;
                //        Cabe.SaldoActual = Item.SaldoActual;
                //        Cabe.Observacion = Item.Observacion;
                //        Cabe.NumCheque = Item.NumCheque;
                //        Cabe.Banco = Item.Banco;
                //        Cabe.fechaTransaccion = DateTime.Now;

                //        Context.AddTocp_orden_pago_cancelacion(Cabe);
                //        Context.SaveChanges();
                //        Secuencia = Secuencia + 1;
                //    }
                //}
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
                return false;
            }
        }

       


        //DEREK MEJIA SORIA 11/03/2014
        public Boolean Eliminar_OrdenPagoCancelacion(cp_orden_pago_cancelacion_Info Info,ref string mensaje) {
            try
            {
                //using(EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
                //{
                //    var eliminar = CxP.cp_orden_pago_cancelacion.First(v => v.IdEmpresa == Info.IdEmpresa && v.Idcancelacion == Info.Idcancelacion);
                //    CxP.cp_orden_pago_cancelacion.Remove(eliminar);
                //    CxP.SaveChanges();
                //}
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

                return false;
            }
        
        }

        public Boolean ModificarDB(List<cp_orden_pago_cancelacion_Info> info)
        {
            try
            {
                //foreach (var Item in info)
                //{
                //    using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                //    {
                //        var contact = Context.cp_orden_pago_cancelacion.First(minfo => minfo.IdEmpresa == Item.IdEmpresa && minfo.Idcancelacion == Item.Idcancelacion);

                //        cp_orden_pago_cancelacion Cabe = new cp_orden_pago_cancelacion();

                //        contact.MontoAplicado = 0;
                //        contact.Observacion = " *****Anulado Por reverso ******";

                //        Context.SaveChanges();
                //    }
                //}
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return false;
            }
        }

    }
}

