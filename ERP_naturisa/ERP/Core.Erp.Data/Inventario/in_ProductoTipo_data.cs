using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
    public class in_ProductoTipo_Data
    {
        string mensaje = "";
        public List<in_ProductoTipo_Info> Get_List_ProductosTipo(int idempresa)
        {
            try
            {
                List<in_ProductoTipo_Info> lM = new List<in_ProductoTipo_Info>();
                EntitiesInventario OEPProductoTipo = new EntitiesInventario();
                
                var select = from A in OEPProductoTipo.in_ProductoTipo
                             where A.IdEmpresa == idempresa
                             select A;

                foreach (var item in select)
                {
                    in_ProductoTipo_Info info = new in_ProductoTipo_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProductoTipo = item.IdProductoTipo;
                    info.tp_descripcion = item.tp_descripcion;
                    info.tp_EsCombo = item.tp_EsCombo ;
                    info.tp_ManejaInven = item.tp_ManejaInven ;
                    info.Estado = item.Estado;
                    info.EsMateriaPrima = item.EsMateriaPrima;
                    info.EsProductoTerminado = item.EsProductoTerminado;
                    lM.Add(info);
                }
                return (lM);
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

        public Boolean ModificarDB(in_ProductoTipo_Info info, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_ProductoTipo.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdProductoTipo== info.IdProductoTipo);
                    if (contact != null)
                    {
                        contact.tp_descripcion = info.tp_descripcion;
                        contact.tp_EsCombo = info.tp_EsCombo;
                        contact.tp_ManejaInven = info.tp_ManejaInven;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.ip = info.ip;
                        contact.Estado = info.Estado;
                        contact.EsMateriaPrima = info.EsMateriaPrima;
                        contact.EsProductoTerminado = info.EsProductoTerminado;
                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro del Tipo de Producto: " + info.tp_descripcion + " exitosamente";
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

        public int GetId(int idempresa)
        {
            try
            {
                int Id;
                EntitiesInventario OEPProductoTipo = new EntitiesInventario();
                var select = from q in OEPProductoTipo.in_ProductoTipo
                             where q.IdEmpresa == idempresa
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    EntitiesInventario OEPProductoTipo1 = new EntitiesInventario();
                    var select_pv = (from q in OEPProductoTipo1.in_ProductoTipo
                                     where q.IdEmpresa == idempresa
                                     select q.IdProductoTipo).Max();
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

        public Boolean GrabarDB(in_ProductoTipo_Info info, ref int id, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    
                    var address = new in_ProductoTipo();
                    int idpv = GetId(info.IdEmpresa);
                    id = idpv;
                    address.IdEmpresa = info.IdEmpresa;
                    address.IdProductoTipo = id;
                    address.tp_descripcion = info.tp_descripcion;
                    address.tp_EsCombo = info.tp_EsCombo ;
                    address.tp_ManejaInven = info.tp_ManejaInven ;
                    address.IdUsuario = info.IdUsuario;
                    address.Fecha_Transac = info.Fecha_Transac;
                    address.nom_pc = info.nom_pc;
                    address.ip = info.ip;
                    address.Estado = info.Estado;
                    address.EsMateriaPrima = info.EsMateriaPrima;
                    address.EsProductoTerminado = info.EsProductoTerminado;
                    context.in_ProductoTipo.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el registro del Tipo de Producto: " + info.tp_descripcion + " exitosamente.";
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

        public Boolean EliminarDB(in_ProductoTipo_Info info, ref  string msg)
        {
            try
            {
                EntitiesInventario OEPProductoTipo = new EntitiesInventario();
                var select = from q in OEPProductoTipo.in_ProductoTipo
                             where q.IdEmpresa == info.IdEmpresa && q.IdProductoTipo==info.IdProductoTipo
                             select q;

                if (select.ToList().Count > 0)
                {
                    using (EntitiesInventario context = new EntitiesInventario())
                    {
                        var contact = context.in_ProductoTipo.First(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdProductoTipo == info.IdProductoTipo);
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = info.Fecha_UltAnu;
                        contact.MotivoAnulacion = info.MotivoAnulacion;
                        contact.Estado = "I";
                        context.SaveChanges();
                        msg = "Se ha procedido anular el registro del Tipo de Producto: " + info.tp_descripcion + " exitosamente";
                    }
                    return true;
                }
                else
                {
                    msg = "No es posible anular el registro del Tipo de Producto: " + info.tp_descripcion + " debido a que ya se encuentra anulado.";
                    return false;
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


        public in_ProductoTipo_Info BuscarTipo(int idtipo, int idempresa)
        {
            try
            {
                in_ProductoTipo_Info tipoProd = new in_ProductoTipo_Info();
                EntitiesInventario OEt = new EntitiesInventario();
                var tipo = OEt.in_ProductoTipo.FirstOrDefault(var => var.IdProductoTipo == idtipo && var.IdEmpresa == idempresa);
                if (tipo != null)
                {
                    tipoProd.IdEmpresa = tipo.IdEmpresa;
                    tipoProd.tp_descripcion = tipo.tp_descripcion;
                    tipoProd.IdProductoTipo = tipo.IdProductoTipo;
                    tipoProd.Estado = tipo.Estado;
                }
                return tipoProd;
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
        public in_ProductoTipo_Data() { }
    }
}
