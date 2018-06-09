using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Data.CuentasxPagar;

namespace Core.Erp.Data.Inventario
{
    public class in_presupuesto_Data
    {
        string mensaje = "";
        public List<in_presupuesto_Info> Get_List_presupuesto(int IdEmpresa)
        {
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();
                List<in_presupuesto_Info> lM = new List<in_presupuesto_Info>();
                var selectCbtecble = from C in OEInventario.vwin_presupuesto
                                     where C.IdEmpresa == IdEmpresa
                                     orderby C.IdPresupuesto ascending
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    in_presupuesto_Info info = new in_presupuesto_Info();
                    info.IdEmpresa = IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdPresupuesto = item.IdPresupuesto;
                    info.Tipo = item.Tipo;
                    info.IdProveedor = item.IdProveedor;
                    info.pr_plazo = item.pr_plazo;
                    info.pr_fecha = item.pr_fecha;
                    info.pr_subtotal = item.pr_subtotal;
                    info.pr_iva = item.pr_iva;
                    info.pr_descuento = item.pr_descuento;
                    info.pr_pordesc = item.pr_pordesc;
                    info.pr_flete = item.pr_flete;
                    info.pr_total = item.pr_total;
                    info.pr_Base_conIva = item.pr_Base_conIva;
                    info.pr_Base_sinIva = item.pr_Base_sinIva;
                    info.pr_observacion = item.pr_observacion;
                    info.Fechreg = item.Fechreg;
                    info.Estado = item.Estado;
                    info.pr_NumDocumento = item.pr_NumDocumento;
                    info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    info.co_fecha_aprobacion = item.co_fecha_aprobacion;
                    info.IdTerminoPago = item.IdTerminoPago;
                    info.co_FechaFactProv = item.co_FechaFactProv;
                    info.co_DiasFecFacProv = item.co_DiasFecFacProv;
                    info.co_fecha_salida = item.co_fecha_salida;
                    info.co_fecha_llegada = item.co_fecha_llegada;
                    info.IdUsuario_Aprueba = item.IdUsuario_Aprueba;
                    info.IdUsuario_Reprue = item.IdUsuario_Reprue;
                    info.co_fechaReproba = item.co_fechaReproba;
                    info.Fecha_Transac = item.Fecha_Transac;
                    info.Fecha_UltMod = item.Fecha_UltMod;
                    info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    info.FechaHoraAnul = item.FechaHoraAnul;
                    info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    info.pr_PesoTotal = item.pr_PesoTotal;
                    info.IdUsuario_Emicion = item.IdUsuario_Emicion;
                    info.pr_fecha_emision = item.pr_fecha_emision;
                    info.IdUsuarioSolicitante = item.IdUsuario_Solicitante;

                    info.NomProveedor = item.NomProveedor;
                    info.NomSucursal = item.NomSucursal;
                    //info.NomTermPago = item.TerPagoDescripcion;
                    info.CodCentroCosto = item.CodCentroCosto;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.NomCentroCosto = item.NomCentroCosto;
                    lM.Add(info);
                }
                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public in_presupuesto_Info Get_Info_presupuesto(int IdEmpresa, int IdSucursal, decimal IdPresupuesto)
        {
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();
                var selectCbtecble = from C in OEInventario.vwin_presupuesto
                                     where C.IdEmpresa == IdEmpresa && C.IdSucursal == IdSucursal && C.IdPresupuesto == IdPresupuesto
                                     select C;

                if (selectCbtecble.ToList().Count > 0)
                {
                    in_presupuesto_Info info = new in_presupuesto_Info();
                    foreach (var item in selectCbtecble)
                    {
                        info.IdEmpresa = IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdPresupuesto = item.IdPresupuesto;
                        info.Tipo = item.Tipo;
                        info.IdProveedor = item.IdProveedor;
                        info.pr_plazo = item.pr_plazo;
                        info.pr_fecha = item.pr_fecha;
                        info.pr_subtotal = item.pr_subtotal;
                        info.pr_iva = item.pr_iva;
                        info.pr_descuento = item.pr_descuento;
                        info.pr_pordesc = item.pr_pordesc;
                        info.pr_flete = item.pr_flete;
                        info.pr_total = item.pr_total;
                        info.pr_Base_conIva = item.pr_Base_conIva;
                        info.pr_Base_sinIva = item.pr_Base_sinIva;
                        info.pr_observacion = item.pr_observacion;
                        info.Fechreg = item.Fechreg;
                        info.Estado = item.Estado;
                        info.pr_NumDocumento = item.pr_NumDocumento;
                        info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                        info.co_fecha_aprobacion = item.co_fecha_aprobacion;
                        info.IdTerminoPago = item.IdTerminoPago;
                        info.co_FechaFactProv = item.co_FechaFactProv;
                        info.co_DiasFecFacProv = item.co_DiasFecFacProv;
                        info.co_fecha_salida = item.co_fecha_salida;
                        info.co_fecha_llegada = item.co_fecha_llegada;
                        info.IdUsuario_Aprueba = item.IdUsuario_Aprueba;
                        info.IdUsuario_Reprue = item.IdUsuario_Reprue;
                        info.co_fechaReproba = item.co_fechaReproba;
                        info.Fecha_Transac = item.Fecha_Transac;
                        info.Fecha_UltMod = item.Fecha_UltMod;
                        info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        info.FechaHoraAnul = item.FechaHoraAnul;
                        info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        info.pr_PesoTotal = item.pr_PesoTotal;
                        info.IdUsuario_Emicion = item.IdUsuario_Emicion;
                        info.pr_fecha_emision = item.pr_fecha_emision;
                        info.IdUsuarioSolicitante = item.IdUsuario_Solicitante;

                        info.NomProveedor = item.NomProveedor;
                        info.NomSucursal = item.NomSucursal;
                        //info.NomTermPago = item.TerPagoDescripcion;
                        info.CodCentroCosto = item.CodCentroCosto;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.NomCentroCosto = item.NomCentroCosto;
                    }
                    return info;
                }
                else
                    return new in_presupuesto_Info();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public Boolean CambiaEstado(int IdEmpresa, in_presupuesto_Info info, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_presupuesto.FirstOrDefault(A => A.IdEmpresa == IdEmpresa && A.IdSucursal == info.IdSucursal && A.IdPresupuesto == info.IdPresupuesto);
                    if (contact != null)
                    {
                        contact.IdEstadoAprobacion = info.IdEstadoAprobacion;
                        if (info.IdEstadoAprobacion == "REC")
                        {
                            contact.pr_observacion = info.pr_observacion;
                            contact.co_fechaReproba = info.co_fechaReproba;
                            contact.IdUsuario_Reprue = info.IdUsuario_Reprue;
                        }
                        else if (info.IdEstadoAprobacion == "APR")
                        {
                            contact.pr_observacion = info.pr_observacion;
                            contact.co_fecha_aprobacion = info.co_fecha_aprobacion;
                            contact.IdUsuario_Aprueba = info.IdUsuario_Aprueba;
                        }
                        else if (info.IdEstadoAprobacion == "ESP")
                        {
                            contact.pr_observacion = "";
                            contact.co_fecha_aprobacion = null;
                            contact.IdUsuario_Aprueba = string.Empty;
                        }
                        context.SaveChanges();
                        msg = "Se Cambio el estado del presupuesto # :" + info.pr_NumDocumento.ToString() + " exitosamente";
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
                msg = "Error del Sistema :" + ex.Message + " ";
                throw new Exception(mensaje);
            }
        }

        public Boolean GrabarDB(int IdEmpresa, in_presupuesto_Info info, List<in_presupuestoDetalle_Info> lmDetalleInfo, ref string msg, ref int idgenerada)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    
                  
                    var address = new in_presupuesto();
                    int id = GetId(IdEmpresa,info.IdSucursal);
                    address.IdEmpresa = IdEmpresa;
                    address.IdSucursal = info.IdSucursal;
                    address.IdPresupuesto = id;
                    //Para pasarla al winform
                    idgenerada = id;

                    address.Tipo = info.Tipo;
                    address.IdProveedor = info.IdProveedor;
                    address.pr_plazo = info.pr_plazo;
                    address.pr_fecha = info.pr_fecha;
                    address.pr_subtotal = info.pr_subtotal;
                    address.pr_iva = info.pr_iva;
                    address.pr_descuento = info.pr_descuento;
                    address.pr_pordesc = Convert.ToInt16(info.pr_pordesc);
                    address.pr_flete = info.pr_flete;
                    address.pr_total = info.pr_total;
                    address.pr_PesoTotal = info.pr_PesoTotal;
                    address.pr_Base_conIva = info.pr_Base_conIva;
                    address.pr_Base_sinIva = info.pr_Base_sinIva;
                    address.pr_observacion = info.pr_observacion;
                    address.Fechreg = info.Fechreg;
                    address.Estado = info.Estado;
                    address.pr_NumDocumento = id.ToString();
                    address.IdEstadoAprobacion = info.IdEstadoAprobacion;
                    address.co_fecha_aprobacion = info.co_fecha_aprobacion;
                    address.IdTerminoPago = info.IdTerminoPago;
                    address.co_FechaFactProv = info.co_FechaFactProv;
                    address.co_DiasFecFacProv = info.co_DiasFecFacProv;
                    address.co_fecha_salida = info.co_fecha_salida;
                    address.co_fecha_llegada = info.co_fecha_llegada;
                    address.IdUsuario_Aprueba = info.IdUsuario_Aprueba;
                    address.IdUsuario_Reprue = info.IdUsuario_Reprue;
                    address.co_fechaReproba = info.co_fechaReproba;
                    address.Fecha_Transac = info.Fecha_Transac;
                    address.Fecha_UltMod = info.Fecha_UltMod;
                    address.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    address.FechaHoraAnul = info.FechaHoraAnul;
                    address.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                    address.IdCentroCosto = info.IdCentroCosto;
                    address.IdUsuario_Solicitante = info.IdUsuarioSolicitante;

                    context.in_presupuesto.Add(address);
                    context.SaveChanges();

                    in_presupuestoDetalle_Data datadetalle = new in_presupuestoDetalle_Data();
                    if (datadetalle.GrabarDB(lmDetalleInfo, IdEmpresa, id, ref msg))
                    {
                        msg = "Se ha procedido a grabar el registro del Presupuesto #: " + id.ToString() + " exitosamente.";
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }


            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public int GetId(int IdEmpresa, int IdSucursal)
        {
            try
            {
                int Id;
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select= from q in OEInventario.in_presupuesto
                             where q.IdEmpresa == IdEmpresa && q.IdSucursal==IdSucursal
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEInventario.in_presupuesto
                                     where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                                     select q.IdPresupuesto).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }

        }

        public Boolean ModificarDB(int IdEmpresa, in_presupuesto_Info info, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_presupuesto.FirstOrDefault(obj => obj.IdEmpresa == IdEmpresa && obj.IdSucursal == info.IdSucursal && obj.IdPresupuesto == info.IdPresupuesto);
                    if (contact != null)
                    {
                        contact.IdEmpresa = IdEmpresa;
                        contact.IdSucursal = info.IdSucursal;
                        contact.IdPresupuesto = info.IdPresupuesto;
                        contact.Tipo = info.Tipo;
                        contact.IdProveedor = info.IdProveedor;
                        contact.pr_plazo = info.pr_plazo;
                        contact.pr_fecha = info.pr_fecha;
                        contact.pr_subtotal = info.pr_subtotal;
                        contact.pr_iva = info.pr_iva;
                        contact.pr_descuento = info.pr_descuento;
                        contact.pr_pordesc = Convert.ToInt16(info.pr_pordesc);
                        contact.pr_total = info.pr_total;
                        contact.pr_Base_conIva = info.pr_Base_conIva;
                        contact.pr_Base_sinIva = info.pr_Base_sinIva;
                        contact.pr_observacion = info.pr_observacion;
                        contact.Fechreg = info.Fechreg;
                        contact.Estado = info.Estado;
                        contact.pr_NumDocumento = info.pr_NumDocumento;
                        contact.IdTerminoPago = info.IdTerminoPago;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.pr_PesoTotal = info.pr_PesoTotal;
                        contact.IdCentroCosto = info.IdCentroCosto;
                        CambiaEstado(IdEmpresa, info, ref msg);
                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro del Presupuesto #: " + info.pr_NumDocumento + " exitosamente";
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
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public Boolean AnularReactiva(int IdEmpresa, in_presupuesto_Info info, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_presupuesto.FirstOrDefault(A => A.IdEmpresa == IdEmpresa && A.IdSucursal == info.IdSucursal && A.IdPresupuesto == info.IdPresupuesto);
                    if (contact != null)
                    {
                        contact.Estado = info.Estado;
                        if (info.Estado == "I")
                        {
                            contact.FechaHoraAnul = info.FechaHoraAnul;
                            contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        }
                        context.SaveChanges();
                        msg = "Se Cambio el estado del Presupuesto # :" + info.pr_NumDocumento.ToString() + " exitosamente";
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
                msg = "Error del Sistema :" + ex.Message + " ";
                throw new Exception(mensaje);
            }
        }

        public in_presupuesto_Reporte_Info Get_Info_presupuesto(int IdEmpresa, int IdSucursal, int IdPresupuesto)
        {
            try
            {
                in_presupuesto_Reporte_Info Datos = new in_presupuesto_Reporte_Info();
                tb_Empresa_Data Empresa_D = new tb_Empresa_Data();
                in_presupuestoDetalle_Data DetallePres_D = new in_presupuestoDetalle_Data();
                in_presupuesto_Info PresInfo = new in_presupuesto_Info();
                Datos.Empresa = Empresa_D.Get_Info_Empresa(IdEmpresa);
                //PresInfo = Get_Info_presupuesto(IdEmpresa, IdSucursal, IdPresupuesto);
                Datos.Pres_CabeceraInfo = PresInfo;
                Datos.Pres_DetalleInfo = DetallePres_D.Get_List_presupuestoDetalle(IdPresupuesto, IdEmpresa);
                return Datos;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }
    }
}
