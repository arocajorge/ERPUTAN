using Core.Erp.Data.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_orden_pago_cancelaciones_Data
    {
        string mensaje = "";
      
        public List<cp_orden_pago_cancelaciones_Info> Get_List_OPCxIdCancelaciones(int IdEmpresa, decimal IdCancelacion, ref string mensaje)
        {
            try
            {
                List<cp_orden_pago_cancelaciones_Info> Lst = new List<cp_orden_pago_cancelaciones_Info>();
                using (EntitiesCuentasxPagar cxp = new EntitiesCuentasxPagar())
                {


                    var consulta = from q in cxp.cp_orden_pago_cancelaciones
                                   where q.IdEmpresa == IdEmpresa
                                   where q.Idcancelacion == IdCancelacion
                                   select q;

                    foreach (var item in consulta)
                    {
                        cp_orden_pago_cancelaciones_Info info = new cp_orden_pago_cancelaciones_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.Idcancelacion = item.Idcancelacion;
                        info.Secuencia = item.Secuencia;
                        info.IdEmpresa_op = item.IdEmpresa_op;
                        info.IdOrdenPago_op = item.IdOrdenPago_op;
                        info.Secuencia_op = item.Secuencia_op;
                        info.IdEmpresa_op_padre = item.IdEmpresa_op_padre;
                        info.IdOrdenPago_op_padre = item.IdOrdenPago_op_padre;
                        info.Secuencia_op_padre = item.Secuencia_op_padre;
                        info.IdEmpresa_cxp = item.IdEmpresa_cxp;
                        info.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                        info.IdCbteCble_cxp = item.IdCbteCble_cxp;
                        info.IdEmpresa_pago = item.IdEmpresa_pago;
                        info.IdTipoCbte_pago = item.IdTipoCbte_pago;
                        info.IdCbteCble_pago = item.IdCbteCble_pago;
                        info.MontoAplicado = item.MontoAplicado;
                        info.SaldoAnterior = item.SaldoAnterior;
                        info.SaldoActual = item.SaldoActual;
                        info.Observacion = item.Observacion;
                        info.fechaTransaccion = item.fechaTransaccion;

                        Lst.Add(info);
                    }
                }
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

        public List<cp_orden_pago_cancelaciones_Info> Get_List_OPCxOP(int IdEmpresa, decimal IdOrdenPago, ref string mensaje)
        {
            try
            {
                List<cp_orden_pago_cancelaciones_Info> Lst = new List<cp_orden_pago_cancelaciones_Info>();
                using (EntitiesCuentasxPagar cxp = new EntitiesCuentasxPagar())
                {
                    var consulta = from q in cxp.cp_orden_pago_cancelaciones
                                   where q.IdEmpresa == IdEmpresa
                                   where q.IdOrdenPago_op == IdOrdenPago
                                  
                                   select q;

                    foreach (var item in consulta)
                    {
                        cp_orden_pago_cancelaciones_Info info = new cp_orden_pago_cancelaciones_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.Idcancelacion = item.Idcancelacion;
                        info.Secuencia = item.Secuencia;
                        info.IdEmpresa_op = item.IdEmpresa_op;
                        info.IdOrdenPago_op = item.IdOrdenPago_op;
                        info.Secuencia_op = item.Secuencia_op;
                        info.IdEmpresa_op_padre = item.IdEmpresa_op_padre;
                        info.IdOrdenPago_op_padre = item.IdOrdenPago_op_padre;
                        info.Secuencia_op_padre = item.Secuencia_op_padre;
                        info.IdEmpresa_cxp = item.IdEmpresa_cxp;
                        info.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                        info.IdCbteCble_cxp = item.IdCbteCble_cxp;
                        info.IdEmpresa_pago = item.IdEmpresa_pago;
                        info.IdTipoCbte_pago = item.IdTipoCbte_pago;
                        info.IdCbteCble_pago = item.IdCbteCble_pago;
                        info.MontoAplicado = item.MontoAplicado;
                        info.SaldoAnterior = item.SaldoAnterior;
                        info.SaldoActual = item.SaldoActual;
                        info.Observacion = item.Observacion;
                        info.fechaTransaccion = item.fechaTransaccion;

                        Lst.Add(info);
                    }
                }
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

        public List<cp_orden_pago_cancelaciones_Info> Get_list_Cancelacion_x_Pagos(int IdEmpresa_pago, int IdTipoCbte_pago , decimal IdCbteCble_pago , ref string mensaje)
        {
            try
            {
             
                List<cp_orden_pago_cancelaciones_Info> Lst = new List<cp_orden_pago_cancelaciones_Info>();
                  
                using (EntitiesCuentasxPagar cxp = new EntitiesCuentasxPagar())
                {
                    var consulta = from q in cxp.cp_orden_pago_cancelaciones
                                   where q.IdEmpresa_pago == IdEmpresa_pago
                                   && q.IdTipoCbte_pago == IdTipoCbte_pago
                                   && q.IdCbteCble_pago == IdCbteCble_pago
                                   select q;

                    foreach (var item in consulta)
                    {
                        cp_orden_pago_cancelaciones_Info info = new cp_orden_pago_cancelaciones_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.Idcancelacion = item.Idcancelacion;
                        info.Secuencia = item.Secuencia;
                        info.IdEmpresa_cxp = item.IdEmpresa_cxp;
                        info.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                        info.IdCbteCble_cxp = item.IdCbteCble_cxp;
                        info.IdEmpresa_pago = item.IdEmpresa_pago;
                        info.IdTipoCbte_pago = item.IdTipoCbte_pago;
                        info.IdCbteCble_pago = item.IdCbteCble_pago;
                        info.MontoAplicado = Convert.ToDouble(item.MontoAplicado);
                        info.SaldoAnterior = Convert.ToDouble(item.SaldoAnterior);
                        info.SaldoActual = Convert.ToDouble(item.SaldoActual);

                        Lst.Add(info);
                    }
                }
                  
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


        public List<cp_orden_pago_cancelaciones_Info> Get_list_Cancelacion_x_CXP(int IdEmpresa_cxp, int IdTipoCbte_cxp, decimal IdCbteCble_cxp)
        {
            try
            {

                List<cp_orden_pago_cancelaciones_Info> Lst = new List<cp_orden_pago_cancelaciones_Info>();

                using (EntitiesCuentasxPagar cxp = new EntitiesCuentasxPagar())
                {
                    var consulta = from q in cxp.cp_orden_pago_cancelaciones
                                   where q.IdEmpresa_cxp == IdEmpresa_cxp
                                   && q.IdTipoCbte_cxp == IdTipoCbte_cxp
                                   && q.IdCbteCble_cxp == IdCbteCble_cxp
                                   select q;

                    foreach (var item in consulta)
                    {
                        cp_orden_pago_cancelaciones_Info info = new cp_orden_pago_cancelaciones_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.Idcancelacion = item.Idcancelacion;
                        info.Secuencia = item.Secuencia;
                        info.IdEmpresa_cxp = item.IdEmpresa_cxp;
                        info.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                        info.IdCbteCble_cxp = item.IdCbteCble_cxp;
                        info.IdEmpresa_pago = item.IdEmpresa_pago;
                        info.IdTipoCbte_pago = item.IdTipoCbte_pago;
                        info.IdCbteCble_pago = item.IdCbteCble_pago;
                        info.MontoAplicado = Convert.ToDouble(item.MontoAplicado);
                        info.SaldoAnterior = Convert.ToDouble(item.SaldoAnterior);
                        info.SaldoActual = Convert.ToDouble(item.SaldoActual);

                        Lst.Add(info);
                    }
                }

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

        public List<cp_orden_pago_cancelaciones_Info> Get_List_OP_x_CbteCtble(int IdEmpresa_pago, int IdTipoCbte_pago, decimal IdCbteCble_pago, ref string mensaje)
        {
            try
            {
                List<cp_orden_pago_cancelaciones_Info> Lst = new List<cp_orden_pago_cancelaciones_Info>();
                using (EntitiesCuentasxPagar cxp = new EntitiesCuentasxPagar())
                {
                    var consulta = from q in cxp.cp_orden_pago_cancelaciones
                                   where q.IdEmpresa_pago == IdEmpresa_pago
                                   && q.IdTipoCbte_pago == IdTipoCbte_pago
                                   && q.IdCbteCble_pago == IdCbteCble_pago
                                   group q by new
                                   {
                                       q.IdEmpresa_op,
                                       q.IdOrdenPago_op,
                                       q.IdEmpresa_pago,
                                       q.IdTipoCbte_pago,
                                       q.IdCbteCble_pago
                                   }
                                       into gruoping
                                       select new { gruoping.Key };

                    foreach (var item in consulta)
                    {
                        cp_orden_pago_cancelaciones_Info info = new cp_orden_pago_cancelaciones_Info();

                        info.IdEmpresa_op = (item.Key.IdEmpresa_op == null) ? 0 : Convert.ToInt32(item.Key.IdEmpresa_op);
                        info.IdOrdenPago_op = (item.Key.IdOrdenPago_op == null) ? 0 : Convert.ToDecimal(item.Key.IdOrdenPago_op);
                        info.IdEmpresa_pago = item.Key.IdEmpresa_pago;
                        info.IdTipoCbte_pago = item.Key.IdTipoCbte_pago;
                        info.IdCbteCble_pago = item.Key.IdCbteCble_pago;
                                                
                        Lst.Add(info);
                    }
                }
                return Lst;
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

        public List<cp_orden_pago_cancelaciones_Info> Get_List_Cancelacion_x_Pagos_Anticipos(int IdEmpresa_pago, int IdTipoCbte_pago, decimal IdCbteCble_pago, ref string mensaje)
        {
            try
            {
                List<cp_orden_pago_cancelaciones_Info> Lst = new List<cp_orden_pago_cancelaciones_Info>();
                using (EntitiesCuentasxPagar cxp = new EntitiesCuentasxPagar())
                {
                    var consulta = from q in cxp.cp_orden_pago_cancelaciones
                                   where q.IdEmpresa_pago == IdEmpresa_pago
                                   && q.IdTipoCbte_pago == IdTipoCbte_pago
                                   && q.IdCbteCble_pago == IdCbteCble_pago
                                   select q;

                    foreach (var item in consulta)
                    {
                        cp_orden_pago_cancelaciones_Info info = new cp_orden_pago_cancelaciones_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.Idcancelacion = item.Idcancelacion;
                        info.Secuencia = item.Secuencia;
                        info.IdEmpresa_op = item.IdEmpresa_op;
                        info.IdOrdenPago_op = item.IdOrdenPago_op;
                        info.Secuencia_op = item.Secuencia_op;
                        info.IdEmpresa_op_padre = item.IdEmpresa_op_padre;
                        info.IdOrdenPago_op_padre = item.IdOrdenPago_op_padre;
                        info.Secuencia_op_padre = item.Secuencia_op_padre;
                        info.IdEmpresa_cxp = item.IdEmpresa_cxp;
                        info.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                        info.IdCbteCble_cxp = item.IdCbteCble_cxp;
                        info.IdEmpresa_pago = item.IdEmpresa_pago;
                        info.IdTipoCbte_pago = item.IdTipoCbte_pago;
                        info.IdCbteCble_pago = item.IdCbteCble_pago;
                        info.MontoAplicado = item.MontoAplicado;
                        info.SaldoAnterior = item.SaldoAnterior;
                        info.SaldoActual = item.SaldoActual;
                        info.Observacion = item.Observacion;
                        info.fechaTransaccion = item.fechaTransaccion;


                        Lst.Add(info);
                    }
                }
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

        public Boolean Eliminar_OrdenPagoCancelaciones(cp_orden_pago_cancelaciones_Info Info, ref string mensaje)
        {
            try
            {
                using (EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
                {
                    var eliminar = CxP.cp_orden_pago_cancelaciones.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.Idcancelacion == Info.Idcancelacion);
                    if (eliminar != null)
                    {
                        CxP.cp_orden_pago_cancelaciones.Remove(eliminar);
                        CxP.SaveChanges();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    
        public decimal GetIdcancelacion(int IdEmpresa)
        {
            try
            {
                decimal Id;
                EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

                var select = ECXP.cp_orden_pago_cancelaciones.Count(q => q.IdEmpresa == IdEmpresa);
                if (select == 0)
                {
                    return Id = 1;
                }

                else
                {
                    var select_ = (from t in ECXP.cp_orden_pago_cancelaciones
                                   where t.IdEmpresa == IdEmpresa
                                  select t.Idcancelacion).Max();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(List<cp_orden_pago_cancelaciones_Info> Lst, int Id, ref string mensaje)
        {
            try
            {
                int Secuencia = 1;
                decimal IdCancelacion = GetIdcancelacion(Id);
                foreach (var Item in Lst)
                {
                    using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                    {
                        cp_orden_pago_cancelaciones Cabe = new cp_orden_pago_cancelaciones();

                        Cabe.IdEmpresa = Item.IdEmpresa;
                        Cabe.Idcancelacion = IdCancelacion;
                        Item.Idcancelacion = IdCancelacion;//DEREK MEJIA 10/03/2014
                        Cabe.Secuencia = Secuencia;
                        Item.Secuencia = Secuencia;//DEREK MEJIA 10/03/2014
                        Cabe.IdEmpresa_op = Item.IdEmpresa_op;
                        Cabe.IdOrdenPago_op = (Item.IdOrdenPago_op == null) ? 0 : Convert.ToDecimal(Item.IdOrdenPago_op);
                        Cabe.Secuencia_op = (Item.Secuencia_op == null) ? 0 : Convert.ToInt32(Item.Secuencia_op);
                        Cabe.IdEmpresa_op_padre = Item.IdEmpresa_op_padre;
                        Cabe.IdOrdenPago_op_padre = Item.IdOrdenPago_op_padre;
                        Cabe.Secuencia_op_padre = Item.Secuencia_op_padre;
                        Cabe.IdEmpresa_cxp = Item.IdEmpresa_cxp;
                        Cabe.IdTipoCbte_cxp = Item.IdTipoCbte_cxp;
                        Cabe.IdCbteCble_cxp = Item.IdCbteCble_cxp;

                      
                        Cabe.IdEmpresa_pago = Convert.ToInt32(Item.IdEmpresa_pago);
                        Cabe.IdTipoCbte_pago = Convert.ToInt32(Item.IdTipoCbte_pago);
                        Cabe.IdCbteCble_pago = Convert.ToDecimal(Item.IdCbteCble_pago);

                    


                        Cabe.MontoAplicado = Item.MontoAplicado;
                        Cabe.SaldoAnterior = Item.SaldoAnterior;
                        Cabe.SaldoActual = Item.SaldoActual;
                        Cabe.Observacion = Item.Observacion;
                        Cabe.fechaTransaccion = DateTime.Now;

                        Context.cp_orden_pago_cancelaciones.Add(Cabe);
                        Context.SaveChanges();
                        Secuencia = Secuencia + 1;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        
        public Boolean GuardarDB(cp_orden_pago_cancelaciones_Info Info, int Id, ref string mensaje)
        {
            try
            {
                decimal IdCancelacion = GetIdcancelacion(Id);
                
                    using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                    {
                        cp_orden_pago_cancelaciones Cabe = new cp_orden_pago_cancelaciones();

                        Cabe.IdEmpresa = Info.IdEmpresa;
                        Cabe.Idcancelacion = IdCancelacion;
                        Cabe.Secuencia = Info.Secuencia;
                        Cabe.IdEmpresa_op = Info.IdEmpresa_op;
                        Cabe.IdOrdenPago_op = (Info.IdOrdenPago_op == null) ? 0 : Convert.ToDecimal(Info.IdOrdenPago_op);
                        Cabe.Secuencia_op = (Info.Secuencia_op == null) ? 0 : Convert.ToInt32(Info.Secuencia_op);
                        Cabe.IdEmpresa_op_padre = Info.IdEmpresa_op_padre;
                        Cabe.IdOrdenPago_op_padre = Info.IdOrdenPago_op_padre;
                        Cabe.Secuencia_op_padre = Info.Secuencia_op_padre;
                        Cabe.IdEmpresa_cxp = Info.IdEmpresa_cxp;
                        Cabe.IdTipoCbte_cxp = Info.IdTipoCbte_cxp;
                        Cabe.IdCbteCble_cxp = Info.IdCbteCble_cxp;
                        Cabe.IdEmpresa_pago = Convert.ToInt32(Info.IdEmpresa_pago);
                        Cabe.IdTipoCbte_pago = Convert.ToInt32(Info.IdTipoCbte_pago);
                        Cabe.IdCbteCble_pago = Convert.ToDecimal(Info.IdCbteCble_pago);
                        Cabe.MontoAplicado = Info.MontoAplicado;
                        Cabe.SaldoAnterior = Info.SaldoAnterior;
                        Cabe.SaldoActual = Info.SaldoActual;
                        Cabe.Observacion = Info.Observacion;
                        Cabe.fechaTransaccion = DateTime.Now;
                        Context.cp_orden_pago_cancelaciones.Add(Cabe);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(List<cp_orden_pago_cancelaciones_Info> info)
        {
            try
            {
                foreach (var Item in info)
                {
                    using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                    {
                        Context.Database.ExecuteSqlCommand("delete cp_orden_pago_cancelaciones where IdEmpresa = " + Item.IdEmpresa + " and Idcancelacion = " + Item.Idcancelacion + " and Secuencia=" + Item.Secuencia + "and IdEmpresa_op=" + Item.IdEmpresa_op + "and IdOrdenPago_op=" + Item.IdOrdenPago_op + "and Secuencia_op=" + Item.Secuencia_op);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool Eliminar_OrdenPagoCancelaciones_List(List<cp_orden_pago_cancelaciones_Info> Lst, int Id, ref string mensaje)
        {
            try
            {
             
                foreach (var Item in Lst)
                {
                    using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                    {
                        Context.Database.ExecuteSqlCommand("delete cp_orden_pago_cancelaciones where IdEmpresa = " + Item.IdEmpresa + " and Idcancelacion = " + Item.Idcancelacion);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool Eliminar_OrdenPagoCancelaciones(int IdEmpresa_pago, int IdTipoCbte_pago, decimal IdCbteCble_pago, ref string mensaje)
        {
            try
            {               
                    using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                    {
                        Context.Database.ExecuteSqlCommand("delete cp_orden_pago_cancelaciones where IdEmpresa_pago = " + IdEmpresa_pago + " and IdTipoCbte_pago = " + IdTipoCbte_pago + " and IdCbteCble_pago=" + IdCbteCble_pago);
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
                throw new Exception(ex.ToString());
            }
        }
    }
}
