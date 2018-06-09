using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Inventario
{
    public class in_RecepcionMaterialesCab_Data
    {
        string mensaje = "";
        public int GetId(int idempresa, int idsucursal)
        {
            try
            {
                int Id;
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select = from q in OEInventario.in_recepcion_material_cab
                             where q.IdEmpresa == idempresa 
                             && q.IdSucursal==idsucursal
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEInventario.in_recepcion_material_cab
                                     where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal
                                     select q.IdRecepcionMaterial).Max();
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

        public Boolean GrabarDB(int idempresa, in_RecepcionMaterialesCab_Info info, List<in_RecepcionMaterialesDet_Info> lmDetalleInfo, ref string msg, ref int idgenerada)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    
                    var address = new in_recepcion_material_cab();
                    int id = GetId(idempresa, info.IdSucursal);
                    address.IdEmpresa = idempresa;
                    address.IdSucursal = info.IdSucursal;
                    address.IdOrdenCompra = info.IdOrdenCompra;
                    address.IdRecepcionMaterial = id;
                    address.NumRecepcion = info.NumRecepcion;
                    address.Fecha = info.Fecha;
                    address.Estado = info.Estado;
                    address.EstadoRecepcion = info.EstadoRecepcion;
                    //Para pasarla al winform
                    idgenerada = id;
                    context.in_recepcion_material_cab.Add(address);
                    context.SaveChanges();

                    //Graba el detalle
                    in_RecepcionMaterialesDet_Data datadet = new in_RecepcionMaterialesDet_Data();
                    if (datadet.GrabarDB(lmDetalleInfo, idempresa, id, ref msg))
                    {
                        return true;
                        msg = "Se ha procedido a grabar el registro de la Recepción de Material #: " + info.NumRecepcion + " exitosamente.";
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

        public Boolean ModificarDB(int idempresa, in_RecepcionMaterialesCab_Info info, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_recepcion_material_cab.FirstOrDefault(obj => obj.IdEmpresa == idempresa && obj.IdSucursal == info.IdSucursal && obj.IdRecepcionMaterial == info.IdRecepcionMaterial);
                    if (contact != null)
                    {
                        contact.IdEmpresa = idempresa;
                        contact.IdSucursal = info.IdSucursal;
                        contact.IdRecepcionMaterial = info.IdRecepcionMaterial;
                        contact.IdOrdenCompra = info.IdOrdenCompra;
                        contact.Fecha = info.Fecha;
                        contact.EstadoRecepcion = info.EstadoRecepcion;
                        contact.Estado = info.Estado;
                        contact.NumRecepcion = info.NumRecepcion;

                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro de la Recepción de materiales #: " + info.NumRecepcion + " exitosamente";
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

        public Boolean AnularDB(int idempresa, in_RecepcionMaterialesCab_Info info, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_recepcion_material_cab.FirstOrDefault(obj => obj.IdEmpresa == idempresa && obj.IdSucursal == info.IdSucursal && obj.IdRecepcionMaterial == info.IdRecepcionMaterial);
                    if (contact != null)
                    {
                        contact.Estado = info.Estado;
                        context.SaveChanges();
                        msg = "Se Cambio el estado de la Recepción de Materiales # :" + info.NumRecepcion + " exitosamente";
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
