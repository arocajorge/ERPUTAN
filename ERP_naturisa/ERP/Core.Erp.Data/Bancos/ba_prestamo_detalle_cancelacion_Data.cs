using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Bancos;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Bancos
{
   public class ba_prestamo_detalle_cancelacion_Data
    {
       string mensaje = "";
       
       //MIGRADO ba_prestamo_detalle_cancelacion
        private int Get_Secuencia(int idempresa, decimal idprestamo, int numcuota)
        {
            int Id = 0;
            try
            {
                EntitiesBanco oEnt = new EntitiesBanco();
                {
                    var select = oEnt.ba_prestamo_detalle_cancelacion.Count(q => q.IdEmpresa == idempresa
                        && q.IdPrestamo == idprestamo
                        && q.NumCuota == numcuota);
                    if (select == 0)
                    {
                        Id = 1;
                    }
                    else
                    {
                        var select_ = (from t in oEnt.ba_prestamo_detalle_cancelacion
                                        where t.IdEmpresa == idempresa
                                        && t.IdPrestamo == idprestamo
                                        && t.NumCuota == numcuota

                                        select t.Secuencia).Max();
                        Id = Convert.ToInt32(select_.ToString()) + 1;
                    }
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

        //MIGRADO  ba_prestamo_detalle_cancelacion
        public Boolean ActualizarDetallePrestamosCancelados(ba_prestamo_detalle_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesBanco Entity = new EntitiesBanco())
                {
                    ba_prestamo_detalle_cancelacion cancelacion = Entity.ba_prestamo_detalle_cancelacion.FirstOrDefault(v => v.IdPrestamo == Info.IdPrestamo && v.IdEmpresa == Info.IdEmpresa && v.NumCuota == Info.NumCuota && v.Secuencia == Info.Secuencia);
                    if (cancelacion != null)
                    {
                        cancelacion.FechaPago = Info.FechaPago;
                        cancelacion.Observacion_canc = Info.Observacion_canc;
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
                msg = ex.Message + ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        // MIGRADO  ba_prestamo_detalle_cancelacion
        public Boolean AnularDetallePrestamosCancelados(ba_prestamo_detalle_Info Info, ref string msg)
        {
            try
            {
                Boolean resu = false;
                try
                {
                    using (EntitiesBanco Entity = new EntitiesBanco())
                    {
                        ba_prestamo_detalle_cancelacion cancelacion = Entity.ba_prestamo_detalle_cancelacion.First(v => v.IdPrestamo == Info.IdPrestamo && v.IdEmpresa == Info.IdEmpresa && v.NumCuota == Info.NumCuota && v.Secuencia == Info.Secuencia);
                        if (cancelacion != null)
                        {
                            cancelacion.Monto_Canc = 0;
                            cancelacion.Observacion_canc = "**ANULADO**" + Info.Observacion_canc;
                            cancelacion.MotiAnula = Info.MotiAnula;
                            cancelacion.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                            cancelacion.Fecha_UltAnu = Info.Fecha_UltAnu;
                            Entity.SaveChanges();
                            resu = true;
                        }
                    }
                    return resu;
                }
                catch (Exception ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                        "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.ToString() + " " + ex.Message;
                    msg = ex.Message + ex.ToString();
                    throw new Exception(ex.ToString());
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

        // MIGRADO  ba_prestamo_detalle_cancelacion
        public Boolean GuardarDetallePrestamosCancelados(List<ba_prestamo_detalle_Info> Listado, ref string msg)
        {
            try
            {
                Boolean resu = false;
                try
                {
                    using (EntitiesBanco context = new EntitiesBanco())
                    {
                        foreach (var item in Listado)
                        {
                            ba_prestamo_detalle_cancelacion reg = new ba_prestamo_detalle_cancelacion();

                            reg.IdEmpresa = item.IdEmpresa;
                            reg.IdPrestamo = item.IdPrestamo;
                            reg.FechaPago = item.FechaPago;
                            reg.Monto_Canc = Convert.ToDouble(item.Monto_x_Canc);
                            reg.NumCuota = item.NumCuota;
                            reg.Saldo = item.Saldo;
                            reg.Observacion_canc = item.Observacion_canc;
                            reg.Secuencia = Get_Secuencia(item.IdEmpresa, item.IdPrestamo, item.NumCuota);
                            if (reg.Secuencia == 0) { mensaje = "Error al Obtener la Secuencia de Pago"; return false; }
                            reg.Fecha_Transac = item.Fecha_Transac;
                            reg.IdUsuario = item.IdUsuario;
                            reg.ip = item.ip;
                            reg.nom_pc = item.nom_pc;

                            context.ba_prestamo_detalle_cancelacion.Add(reg);
                        }
                        context.SaveChanges();
                    }
                    return resu = true;
                }
                catch (Exception ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                        "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.InnerException + " " + ex.Message;

                    msg = ex.Message + ex.InnerException;
                    throw new Exception(ex.InnerException.ToString());
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

        public Boolean GuardarDetallePrestamosCancelados(ba_prestamo_detalle_Info Info, ref string msg)
        {
            try
            {
                Boolean resu = false;
                try
                {
                    using (EntitiesBanco context = new EntitiesBanco())
                    {
                        //foreach (var item in Listado)
                        //{
                            ba_prestamo_detalle_cancelacion reg = new ba_prestamo_detalle_cancelacion();

                            reg.IdEmpresa = Info.IdEmpresa;
                            reg.IdPrestamo = Info.IdPrestamo;
                            
                            reg.FechaPago = Info.FechaPago;
                            reg.Monto_Canc = Convert.ToDouble(Info.Monto_Canc);
                            reg.NumCuota = Info.NumCuota;
                            reg.Saldo = Info.Saldo;
                            reg.Observacion_canc = Info.Observacion_canc;
                            reg.Secuencia = Get_Secuencia(Info.IdEmpresa, Info.IdPrestamo, Info.NumCuota);
                            if (reg.Secuencia == 0) { mensaje = "Error al Obtener la Secuencia de Pago"; return false; }
                            reg.Fecha_Transac = Info.Fecha_Transac;
                            reg.IdUsuario = Info.IdUsuario;
                            reg.ip = Info.ip;
                            reg.nom_pc = Info.nom_pc;

                            context.ba_prestamo_detalle_cancelacion.Add(reg);
                       // }
                        context.SaveChanges();
                    }
                    return resu = true;
                }
                catch (Exception ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                        "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.InnerException + " " + ex.Message;

                    msg = ex.Message + ex.InnerException;
                    throw new Exception(ex.InnerException.ToString());
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
    }
}
