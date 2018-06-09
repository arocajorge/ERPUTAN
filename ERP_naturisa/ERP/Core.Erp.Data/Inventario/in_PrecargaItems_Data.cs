using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
    public class in_PrecargaItems_Data
    {
        string mensaje = "";
        public List<in_PrecargaItems_Info> Get_List_PrecargaItems(int IdEmpresa)
        {
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();
                List<in_PrecargaItems_Info> lM = new List<in_PrecargaItems_Info>();
                var select = from C in OEInventario.vwin_PrecargaItemsOrdenCompra
                                     where C.IdEmpresa == IdEmpresa
                                     orderby C.IdPrecarga ascending
                                     select C;

                foreach (var item in select)
                {
                    in_PrecargaItems_Info info = new in_PrecargaItems_Info();
                    info.IdEmpresa = IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdPrecarga = item.IdPrecarga;
                    info.IdOrdenTaller = item.IdOrdenTaller;
                    info.IdProveedor = item.IdProveedor;
                    info.pre_fecha = item.pre_fecha;
                    info.pre_subtotal = item.pre_subtotal;
                    info.pre_iva = item.pre_iva;
                    info.pre_descuento = item.pre_descuento;
                    info.pre_pordesc = item.pre_pordesc;
                    info.pre_total = item.pre_total;
                    info.pre_Base_conIva = item.pre_Base_conIva;
                    info.pre_Base_sinIva = item.pre_Base_sinIva;
                    info.pre_observacion = item.pre_observacion;
                    info.Fechreg = item.Fechreg;
                    info.Estado = item.Estado;
                    info.pre_NumDocumento = item.pre_NumDocumento;
                    info.pre_PesoTotal = item.pre_PesoTotal;
                    info.pre_fecha_emision = item.pre_fecha_emision;

                    info.NomProveedor = item.pr_nombre;
                    info.NomSucursal = item.Su_Descripcion;
                    info.NomTermPago = item.pr_nombre;
                    info.CodCentroCosto = item.CodCentroCosto;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.NomCentroCosto = item.Centro_costo;

                    info.Referencia = item.CodCentroCosto.Trim() + " - " + item.Centro_costo.Trim() + " - " + item.pre_observacion.Trim();
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

        /// <summary>
        /// Consukta por Centro de costo
        /// </summary>
        public List<in_PrecargaItems_Info> Get_List_PrecargaItems(int IdEmpresa, string IdCentroCosto)
        {
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();
                List<in_PrecargaItems_Info> lM = new List<in_PrecargaItems_Info>();
                var selectCbtecble = from C in OEInventario.vwin_PrecargaItemsOrdenCompra
                                     where C.IdEmpresa == IdEmpresa && C.IdCentroCosto == IdCentroCosto
                                     orderby C.IdPrecarga ascending
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    in_PrecargaItems_Info info = new in_PrecargaItems_Info();
                    info.IdEmpresa = IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdPrecarga = item.IdPrecarga;
                    info.IdOrdenTaller = item.IdOrdenTaller;
                    info.IdProveedor = item.IdProveedor;
                    info.pre_fecha = item.pre_fecha;
                    info.pre_subtotal = item.pre_subtotal;
                    info.pre_iva = item.pre_iva;
                    info.pre_descuento = item.pre_descuento;
                    info.pre_pordesc = item.pre_pordesc;
                    info.pre_total = item.pre_total;
                    info.pre_Base_conIva = item.pre_Base_conIva;
                    info.pre_Base_sinIva = item.pre_Base_sinIva;
                    info.pre_observacion = item.pre_observacion;
                    info.Fechreg = item.Fechreg;
                    info.Estado = item.Estado;
                    info.pre_NumDocumento = item.pre_NumDocumento;
                    info.pre_PesoTotal = item.pre_PesoTotal;
                    info.pre_fecha_emision = item.pre_fecha_emision;

                    info.NomProveedor = item.pr_nombre;
                    info.NomSucursal = item.Su_Descripcion;
                    info.NomTermPago = item.pr_nombre;
                    info.CodCentroCosto = item.CodCentroCosto;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.NomCentroCosto = item.Centro_costo;

                    info.Referencia = item.CodCentroCosto.Trim() + " - " + item.Centro_costo.Trim() + " - " + item.pre_observacion.Trim();
                    info.ReferenciaOC = info.Referencia;
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
        /// <summary>
        /// Consulta por proveeeodor
        /// </summary>
        public List<in_PrecargaItems_Info> Get_List_PrecargaItems(int IdEmpresa, int IdSucursal, decimal IdProveedor)
        {
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();
                List<in_PrecargaItems_Info> lM = new List<in_PrecargaItems_Info>();
                var selectCbtecble = from C in OEInventario.vwin_PrecargaItemsOrdenCompra
                                     where C.IdEmpresa == IdEmpresa && C.IdProveedor == IdProveedor && C.IdSucursal == IdSucursal
                                     orderby C.IdPrecarga ascending
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    in_PrecargaItems_Info info = new in_PrecargaItems_Info();
                    info.IdEmpresa = IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdPrecarga = item.IdPrecarga;
                    info.IdOrdenTaller = item.IdOrdenTaller;
                    info.IdProveedor = item.IdProveedor;
                    info.pre_fecha = item.pre_fecha;
                    info.pre_subtotal = item.pre_subtotal;
                    info.pre_iva = item.pre_iva;
                    info.pre_descuento = item.pre_descuento;
                    info.pre_pordesc = item.pre_pordesc;
                    info.pre_total = item.pre_total;
                    info.pre_Base_conIva = item.pre_Base_conIva;
                    info.pre_Base_sinIva = item.pre_Base_sinIva;
                    info.pre_observacion = item.pre_observacion;
                    info.Fechreg = item.Fechreg;
                    info.Estado = item.Estado;
                    info.pre_NumDocumento = item.pre_NumDocumento;
                    info.pre_PesoTotal = item.pre_PesoTotal;
                    info.pre_fecha_emision = item.pre_fecha_emision;

                    info.NomProveedor = item.pr_nombre;
                    info.NomSucursal = item.Su_Descripcion;
                    info.NomTermPago = item.pr_nombre;
                    info.CodCentroCosto = item.CodCentroCosto;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.NomCentroCosto = item.Centro_costo;

                    info.Referencia = item.CodCentroCosto.Trim() + " - " + item.Centro_costo.Trim() + " - " + item.pre_observacion.Trim();
                    info.ReferenciaOC = info.Referencia;
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

        public Boolean GrabarDB(int IdEmpresa, in_PrecargaItems_Info info, List<in_PrecargaItemsDetalle_Info> lmDetalleInfo, ref string msg, ref int idgenerada)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    
                    var address = new in_PrecargaItemsOrdenCompra();
                    int id = GetId(IdEmpresa, info.IdSucursal);
                    address.IdEmpresa = IdEmpresa;
                    address.IdSucursal = info.IdSucursal;
                    address.IdPrecarga = id;
                    //Para pasarla al winform
                    idgenerada = id;

                    address.IdOrdenTaller = info.IdOrdenTaller;
                    address.IdProveedor = info.IdProveedor;
                    address.pre_fecha = info.pre_fecha;
                    address.pre_subtotal = info.pre_subtotal;
                    address.pre_iva = info.pre_iva;
                    address.pre_descuento = info.pre_descuento;
                    address.pre_pordesc = Convert.ToInt16(info.pre_pordesc);
                    address.pre_total = info.pre_total;
                    address.pre_PesoTotal = info.pre_PesoTotal;
                    address.pre_Base_conIva = info.pre_Base_conIva;
                    address.pre_Base_sinIva = info.pre_Base_sinIva;
                    address.pre_observacion = info.pre_observacion;
                    address.Fechreg = info.Fechreg;
                    address.Estado = info.Estado;
                    address.pre_NumDocumento = id.ToString();
                    address.IdCentroCosto = info.IdCentroCosto;

                    context.in_PrecargaItemsOrdenCompra.Add(address);
                    context.SaveChanges();

                    in_PrecargaItemsDetalle_Data datadetalle = new in_PrecargaItemsDetalle_Data();
                    if (datadetalle.GrabarDB(lmDetalleInfo, IdEmpresa, id, ref msg))
                    {
                        return true;
                        msg = "Se ha procedido a grabar el registro de la Precarga #: " + id.ToString() + " exitosamente.";
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

        public int GetId(int IdEmpresa, int idsucursal)
        {
            try
            {
                int Id;
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select = from q in OEInventario.in_PrecargaItemsOrdenCompra
                             where q.IdEmpresa == IdEmpresa && q.IdSucursal == idsucursal
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEInventario.in_PrecargaItemsOrdenCompra
                                     where q.IdEmpresa == IdEmpresa && q.IdSucursal == idsucursal
                                     select q.IdPrecarga).Max();
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

        public Boolean ModificarDB(int idempresa, in_PrecargaItems_Info info, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_PrecargaItemsOrdenCompra.FirstOrDefault(obj => obj.IdEmpresa == idempresa && obj.IdSucursal == info.IdSucursal && obj.IdPrecarga == info.IdPrecarga);
                    if (contact != null)
                    {
                        contact.IdEmpresa = idempresa;
                        contact.IdSucursal = info.IdSucursal;
                        contact.IdPrecarga = info.IdPrecarga;
                        contact.IdOrdenTaller = info.IdOrdenTaller;
                        contact.IdProveedor = info.IdProveedor;
                        contact.pre_fecha = info.pre_fecha;
                        contact.pre_subtotal = info.pre_subtotal;
                        contact.pre_iva = info.pre_iva;
                        contact.pre_descuento = info.pre_descuento;
                        contact.pre_pordesc = Convert.ToInt16(info.pre_pordesc);
                        contact.pre_total = info.pre_total;
                        contact.pre_Base_conIva = info.pre_Base_conIva;
                        contact.pre_Base_sinIva = info.pre_Base_sinIva;
                        contact.pre_observacion = info.pre_observacion;
                        contact.Fechreg = info.Fechreg;
                        contact.Estado = info.Estado;
                        contact.pre_NumDocumento = info.pre_NumDocumento;
                        contact.pre_PesoTotal = info.pre_PesoTotal;
                        contact.IdCentroCosto = info.IdCentroCosto;

                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro de la Precarga #: " + info.pre_NumDocumento + " exitosamente";
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

        public Boolean AnularReactiva(int idempresa, in_PrecargaItems_Info info, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_PrecargaItemsOrdenCompra.FirstOrDefault(A => A.IdEmpresa == idempresa && A.IdSucursal == info.IdSucursal && A.IdPrecarga == info.IdPrecarga);
                    if (contact != null)
                    {
                        contact.Estado = info.Estado;
                        context.SaveChanges();
                        msg = "Se Cambio el estado de la Precarga # :" + info.pre_NumDocumento.ToString() + " exitosamente";
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

    }
}
