using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Bancos
{
    public class ba_prestamo_Data
    {
        string mensaje = "";
        public decimal GetIdPrestamo(int idempresa)
        {
            try
            {
                decimal Id;
                EntitiesBanco  OECbtecble = new EntitiesBanco();

                var q = from C in OECbtecble.ba_prestamo
                          where C.IdEmpresa == idempresa ///&& C.IdEmpleado == idEmpleado
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from t in OECbtecble.ba_prestamo
                                   where t.IdEmpresa == idempresa 
                                   select t.IdPrestamo).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                    return Id;
                }
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

        public Boolean GuardarDB(ba_prestamo_Info Item, ref decimal Id, ref string msg)
        {
            try
            {
                using (EntitiesBanco Context = new EntitiesBanco())
                {
                    ba_prestamo Cabe = new ba_prestamo();

                    Cabe.IdEmpresa = Item.IdEmpresa;
                    Cabe.IdPrestamo = Id = GetIdPrestamo(Item.IdEmpresa);
                    Cabe.IdBanco = Item.IdBanco;
                    Cabe.CodPrestamo = Item.CodPrestamo;
                    Cabe.IdMotivo_Prestamo = Item.IdMotivo_Prestamo;
                    Cabe.Fecha = Convert.ToDateTime(Item.Fecha.ToShortDateString());
                    Cabe.MontoSol = Item.MontoSol;
                    Cabe.TasaInteres = Item.TasaInteres;
                    Cabe.TotalPrestamo = Item.TotalPrestamo;
                    Cabe.NumCuotas = Item.NumCuotas;
                    Cabe.IdTipo_Pago = Item.IdTipo_Pago;
                    Cabe.IdMetCalc = Item.IdMetCalc;
                    Cabe.Fecha_PriPago = Item.Fecha_PriPago;
                    Cabe.Observacion = Item.Observacion;
                    Cabe.IdUsuario = Item.IdUsuario;
                    Cabe.Estado ="A";
                    Cabe.Fecha_Transac = Item.Fecha_Transac;
                    Cabe.nom_pc = Item.nom_pc;
                    Cabe.ip = Item.ip;
                    Cabe.Pago_contado = Item.Pago_contado;
                    Cabe.IdTipoFlujo = Item.IdTipoFlujo;
                    Cabe.IdCtaCble = Item.IdCtaCble;
                    Cabe.IdCliente = Item.IdCliente;
                    Context.ba_prestamo.Add(Cabe);
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
                msg = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        //todo el codigo que se encuentra en esta región esta comentado, para revisión de ricardo
        #region
        //public List<ba_prestamo_detalle_Info> Get_List_EstadoCuenta(ba_prestamo_Info Item, ref string msg)
        //{
        //    try
        //    {
        //    List<ba_prestamo_detalle_Info> listado = new List<ba_prestamo_detalle_Info>();
        //            try
        //            {
        //                string q =

        //                    "SELECT     det.IdEmpresa, det.IdPrestamo, det.NumCuota," +
        //                                " det.SaldoInicial, det.Interes, det.AbonoCapital, " +
        //                                " det.TotalCuota, det.Saldo, det.FechaPago, " +
        //                                " det.EstadoPago, det.Estado, " +
        //                                " det.Observacion_det, canc.Secuencia, " +
        //                                " canc.Monto_Canc, canc.Saldo AS Saldo_Canc," +
        //                                " canc.FechaPago AS Fecha_Canc, canc.Observacion_canc" +
        //                                " FROM         dbo.ba_prestamo_detalle AS det LEFT OUTER JOIN" +
        //                                                      " dbo.ba_prestamo_detalle_cancelacion AS canc ON " +
        //                                                      "det.IdEmpresa = canc.IdEmpresa AND " +
        //                                                      "det.IdPrestamo = canc.IdPrestamo AND" +
        //                                                      " det.NumCuota = canc.NumCuota" +
        //                                " WHERE     (det.IdEmpresa = {0}) AND (det.IdPrestamo = {1})";

        //                                //" select * from ba_prestamo_detalle det left join " +
        //                                //" ba_prestamo_detalle_cancelacion canc" +
        //                                //" on det.IdEmpresa = canc.IdEmpresa and" +
        //                                //" det.IdPrestamo = canc.IdPrestamo and" +
        //                                //" det.NumCuota = canc.NumCuota " +
        //                                //" where det.IdEmpresa = {0} and det.IdPrestamo = {1}";

        //                string query = string.Format(q, Item.IdEmpresa, Item.IdPrestamo);
        //                EntitiesBanco oEnt = new EntitiesBanco();
        //                listado = oEnt.Database.SqlQuery<ba_prestamo_detalle_Info>(query).ToList();

        //            }
        //            catch (Exception ex)
        //            {
        //                string arreglo = ToString();
        //                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                                    "", "", "", "", DateTime.Now);
        //                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //                mensaje = ex.InnerException + " " + ex.Message;
        //                msg = ex.Message + ex.InnerException;
        //                listado = new List<ba_prestamo_detalle_Info>();

        //            }
        //            return listado;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return new List<ba_prestamo_detalle_Info>();
        //    }
        //}
        
        //public List<ba_prestamo_detalle_Info> Get_List_DetallePrestamosxCancelar(ba_prestamo_Info Item, ref string msg)
        //{
        //    List<ba_prestamo_detalle_Info> listado = new List<ba_prestamo_detalle_Info>();
        //    try
        //    {
        //        string query = "select * from vwba_prestamo_detalle_cancelacion where IdEmpresa = "+Item.IdEmpresa+
        //            " and IdPrestamo = "+Item.IdPrestamo;
        //        EntitiesBanco oEnt = new EntitiesBanco();
        //        listado = oEnt.Database.SqlQuery<ba_prestamo_detalle_Info>(query).ToList();
                
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;

        //        listado = new List<ba_prestamo_detalle_Info>();
        //        msg = ex.Message+ex.InnerException;
        //    }
        //    return listado;
        //}

        //private int Get_Secuencia(int idempresa, decimal idprestamo, int numcuota)
        //{
        //    try
        //    {
        //      int res = 1;
        //            try
        //            {
        //                EntitiesBanco oEnt = new EntitiesBanco();
        //                int Sec = (from C in oEnt.ba_prestamo_detalle_cancelacion
        //                               where C.IdEmpresa == idempresa
        //                               && C.IdPrestamo == idprestamo
        //                               && C.NumCuota == numcuota
        //                               select C.Secuencia).Max();
        //                if (Sec != null && Sec != 0)
        //                    res = Sec+1;
                
        //            }
        //            catch (Exception ex)
        //            {
        //                string arreglo = ToString();
        //                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                                    "", "", "", "", DateTime.Now);
        //                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //                mensaje = ex.InnerException + " " + ex.Message;
        //                return 0;
        //            }
        //            return res;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return 0;
        //    }
        //}

        //public Boolean ActualizarDetallePrestamosCancelados(ba_prestamo_detalle_Info Info, ref string msg)
        //{
        //    try
        //    {
        //      Boolean resu = false;
           
        //            try
        //            {
        //                using (EntitiesBanco Entity = new EntitiesBanco())
        //                {

        //                    ba_prestamo_detalle_cancelacion  cancelacion = Entity.ba_prestamo_detalle_cancelacion.First(v => v.IdPrestamo == Info.IdPrestamo 
        //                        && v.IdEmpresa == Info.IdEmpresa && v.NumCuota == Info.NumCuota && v.Secuencia == Info.Secuencia);

        //                    cancelacion.FechaPago = Info.FechaPago;
        //                    cancelacion.Observacion_canc = Info.Observacion_canc;
                    
        //                    Entity.SaveChanges();
        //                }
        //                resu = true;
        //            }
        //            catch (Exception ex)
        //            {
        //                string arreglo = ToString();
        //                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                                    "", "", "", "", DateTime.Now);
        //                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //                mensaje = ex.InnerException + " " + ex.Message;
                
        //                msg = ex.Message + ex.InnerException;
        //                 return false;
        //            }
        //            return resu;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return false;
        //    }
        
        //}

        //public Boolean AnularDetallePrestamosCancelados(ba_prestamo_detalle_Info Info, ref string msg)
        //{
        //    try
        //    {
        //      Boolean resu = false;

        //                try
        //                {
        //                    using (EntitiesBanco Entity = new EntitiesBanco())
        //                    {

        //                        ba_prestamo_detalle_cancelacion cancelacion = Entity.ba_prestamo_detalle_cancelacion.First(v => v.IdPrestamo == Info.IdPrestamo
        //                            && v.IdEmpresa == Info.IdEmpresa && v.NumCuota == Info.NumCuota && v.Secuencia == Info.Secuencia);

        //                        cancelacion.Monto_Canc  = 0;
                    
        //                        cancelacion.Observacion_canc = "**ANULADO**" + Info.Observacion_canc;
        //                        cancelacion.MotiAnula = Info.MotiAnula;
        //                        cancelacion.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
        //                        cancelacion.Fecha_UltAnu = Info.Fecha_UltAnu;

        //                        Entity.SaveChanges();
        //                    }
        //                    resu = true;
        //                }
        //                catch (Exception ex)
        //                {
        //                    string arreglo = ToString();
        //                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                                        "", "", "", "", DateTime.Now);
        //                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //                    mensaje = ex.InnerException + " " + ex.Message;
              
        //                    msg = ex.Message + ex.InnerException;
        //                    return false;
        //                }
        //                return resu;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return false;
        //    }

        //}

        //public Boolean GuardarDetallePrestamosCancelados(List<ba_prestamo_detalle_Info> Listado, ref string msg)
        //{
        //    try
        //    {
        //         Boolean resu = false;
        //                try
        //                {
        //                    using (EntitiesBanco context = new EntitiesBanco())
        //                    {
        //                        foreach (var item in Listado)
        //                        {
        //                            ba_prestamo_detalle_cancelacion reg = new ba_prestamo_detalle_cancelacion();

        //                            reg.IdEmpresa = item.IdEmpresa;
        //                            reg.IdPrestamo = item.IdPrestamo;
        //                            reg.FechaPago = item.FechaPago;
        //                            reg.Monto_Canc = Convert.ToDouble (item.Monto_x_Canc);
        //                            reg.NumCuota = item.NumCuota;
        //                            reg.Saldo = item.Saldo;
        //                            reg.Observacion_canc = item.Observacion_canc;
        //                            reg.Secuencia = Get_Secuencia(item.IdEmpresa, item.IdPrestamo, item.NumCuota);
        //                            if (reg.Secuencia == 0) { mensaje = "Error al Obtener la Secuencia de Pago"; return false; }
        //                            reg.Fecha_Transac = item.Fecha_Transac;
        //                            reg.IdUsuario = item.IdUsuario;
        //                            reg.ip = item.ip;
        //                            reg.nom_pc = item.nom_pc;

        //                            context.ba_prestamo_detalle_cancelacion.Add(reg);
        //                        }
        //                        context.SaveChanges();
        //                    }
        //                    resu = true;
        //                }
        //                catch (Exception ex)
        //                {
        //                    string arreglo = ToString();
        //                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                                        "", "", "", "", DateTime.Now);
        //                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //                    mensaje = ex.InnerException + " " + ex.Message;
                            
        //                    msg = ex.Message + ex.InnerException; 
        //                    return false;
        //                }
        //                return resu;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return false;
        //    }
        //}
        #endregion

        public List<ba_prestamo_Info> Get_List_Prestamo(int IdEmpresa, DateTime FechaInicio, DateTime FechaFin)
        {
            try
            {
                List<ba_prestamo_Info> lista= new List<ba_prestamo_Info>();

                using (EntitiesBanco oen = new EntitiesBanco())
                {
                    FechaInicio = Convert.ToDateTime(FechaInicio.ToShortDateString());
                    FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
                    var Consulta = from q in oen.vwba_prestamo
                                   where q.IdEmpresa == IdEmpresa && q.Fecha >= FechaInicio && q.Fecha <= FechaFin
                                   select q;

                    foreach (var item in Consulta)
                    {
                       ba_prestamo_Info info= new ba_prestamo_Info();
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdPrestamo = item.IdPrestamo;
                       info.IdBanco = item.IdBanco;
                       info.NomBanco = item.NomBanco;
                       info.NomMotivo_Prestamo = item.NomMotivo_Prestamo;
                       info.MetodoCalculo = item.MetodoCalculo;
                       info.CodPrestamo = item.CodPrestamo;
                       info.Estado = item.Estado;
                       info.Fecha = item.Fecha;
                       info.MontoSol = item.MontoSol;
                       info.TasaInteres = item.TasaInteres;
                       info.NumCuotas = item.NumCuotas;
                       info.Observacion = item.Observacion;
                       info.TotalPrestamo = item.TotalPrestamo;
                       info.Fecha_PriPago = item.Fecha_PriPago;
                       info.IdMotivo_Prestamo = item.IdMotivo_Prestamo;
                       info.IdPeriPago = item.IdPeriPago;
                       info.IdMetCalc = item.IdMetCalc;
                       info.IdTipo_Pago = item.IdPeriPago;
                       info.IdTipoFlujo = item.IdTipoFlujo;
                       info.IdCtaCble = item.IdCtaCble_Prestamo;
                       info.IdCtaCble_Banco = item.IdCtaCble;
                       info.Pago_contado = item.Pago_contado;                                    
                              lista.Add(info);                                   
                        
                    }

                    return lista;
                }

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
        }//haac 02/10/13

        public ba_prestamo_Info Get_Info_Prestamo(int IdEmpresa, decimal IdPrestamo, decimal IdBanco)
        {
            try
            {
                EntitiesBanco ORol = new EntitiesBanco();
                var item = ORol.vwba_prestamo.FirstOrDefault(A => A.IdEmpresa == IdEmpresa
                              && A.IdPrestamo == IdPrestamo
                              && A.IdBanco == IdBanco);

                ba_prestamo_Info Reg = new ba_prestamo_Info();
                if (item != null)
                {
                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdPrestamo = item.IdPrestamo;
                    Reg.Estado = item.Estado;
                    Reg.Fecha = item.Fecha;
                    Reg.MontoSol = item.MontoSol;
                    Reg.TasaInteres = item.TasaInteres;
                    Reg.NumCuotas = item.NumCuotas;
                    Reg.Observacion = item.Observacion;
                    Reg.TotalPrestamo = item.TotalPrestamo;
                    Reg.Fecha_PriPago = item.Fecha_PriPago;
                    Reg.IdTipoFlujo = item.IdTipoFlujo;
                    Reg.IdCtaCble = item.IdCtaCble_Prestamo;
                }
                return Reg;
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

        public List<ba_prestamo_Info> Get_List_PrestamoxIdPrestamo(int IdEmpresa, decimal IdPrestamo)
        {
            try
            {
                using (EntitiesBanco oen = new EntitiesBanco())
                {
                    IQueryable<ba_prestamo_Info> Consulta = from q in oen.vwba_prestamo
                                                            // where q.IdPrestamo== idPrestamo
                                                            where q.IdEmpresa == IdEmpresa && q.IdPrestamo == IdPrestamo
                                                            select new ba_prestamo_Info
                                                            {
                                                                IdBanco = q.IdBanco,
                                                                CodPrestamo = q.CodPrestamo,
                                                                IdEmpresa = IdEmpresa,
                                                                IdPrestamo = IdPrestamo,
                                                                
                                                                Estado = q.Estado,
                                                                Fecha = q.Fecha,
                                                                MontoSol = q.MontoSol,
                                                                TasaInteres = q.TasaInteres,
                                                                NumCuotas = q.NumCuotas,
                                                                Observacion = q.Observacion,
                                                                TotalPrestamo = q.TotalPrestamo,
                                                                Fecha_PriPago = q.Fecha_PriPago,
                                                                IdTipoFlujo=q.IdTipoFlujo,
                                                                IdCtaCble=q.IdCtaCble_Prestamo,
                                                                Pago_contado=q.Pago_contado
                                                            };
                    return Consulta.ToList();
                }

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
        }//haac 08/10/13

        public Boolean ModificarDB(ba_prestamo_Info Info)
        {
            try
            {
                using (EntitiesBanco Entity = new EntitiesBanco())
                {
                    ba_prestamo prestamo = Entity.ba_prestamo.FirstOrDefault(v => v.IdPrestamo == Info.IdPrestamo && v.IdEmpresa == Info.IdEmpresa);
                    if (prestamo != null)
                    {
                       
                        prestamo.CodPrestamo = Info.CodPrestamo;
                        prestamo.Fecha = Info.Fecha;
                        prestamo.IdMotivo_Prestamo = Info.IdMotivo_Prestamo;
                        prestamo.MontoSol = Info.MontoSol;
                        prestamo.TasaInteres = Info.TasaInteres;
                        prestamo.TotalPrestamo = Info.TotalPrestamo;
                        prestamo.IdTipo_Pago = Info.IdTipo_Pago;
                        prestamo.Fecha_PriPago = Info.Fecha_PriPago;
                        prestamo.Observacion = Info.Observacion;
                        prestamo.Fecha_UltMod = DateTime.Now;//Info.Fecha_UltMod;
                        prestamo.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        prestamo.IdTipoFlujo = Info.IdTipoFlujo;
                        prestamo.Pago_contado = Info.Pago_contado;
                        prestamo.IdCtaCble = Info.IdCtaCble;
                        prestamo.IdCliente = Info.IdCliente;
                        Entity.SaveChanges();
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

        public Boolean AnularDB(ba_prestamo_Info _Info)
        {
            try
            {
                using (EntitiesBanco Entity = new EntitiesBanco())
                {
                    ba_prestamo cabecera = Entity.ba_prestamo.FirstOrDefault(v => v.IdPrestamo == _Info.IdPrestamo && v.IdEmpresa == _Info.IdEmpresa);
                    if (cabecera != null)
                    {
                        cabecera.IdUsuarioUltAnu = _Info.IdUsuarioUltAnu;
                        cabecera.Fecha_UltAnu = _Info.Fecha_UltAnu;
                        cabecera.MotiAnula = _Info.MotiAnula;
                        cabecera.Estado = "I";
                        Entity.SaveChanges();
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
    }
}
