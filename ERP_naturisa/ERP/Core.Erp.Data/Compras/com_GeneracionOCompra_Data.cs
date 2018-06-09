using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Compras
{
    public class com_GeneracionOCompra_Data
    {
        string mensaje = "";
        
        public int GetId(int IdEmpresa)
        {
            try
            {
                  int Id;
                    EntitiesCompras OEProd = new EntitiesCompras();
                    var select = from q in OEProd.com_GenerOCompra
                                 where q.IdEmpresa == IdEmpresa

                                 select q;

                    if (select.ToList().Count == 0)
                    {
                        Id = 1;
                    }
                    else
                    {
                        var select_pv = (from q in OEProd.com_GenerOCompra
                                         where q.IdEmpresa == IdEmpresa

                                         select q.IdTransaccion).Max();
                        Id = Convert.ToInt32(select_pv.ToString()) + 1;
                    }
                    return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(com_GeneracionOCompra_Info  Info, ref string msg)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                    var address = context.com_GenerOCompra.FirstOrDefault
                        (A => A.IdEmpresa == Info.IdEmpresa
                             && A.IdTransaccion == Info.IdTransaccion
                            );
                    if (address != null)
                    {
                        address.Estado = "I";
                        address.IdUsuarioAnula = Info.IdUsuarioAnula;
                        address.FechaAnula = Info.FechaAnula;
                        address.MotivoAnulacion = Info.MotivoAnulacion;
                        context.SaveChanges();
                    }
                }
                msg = "Guardado con exito";
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

                msg = "Error no se guardó " + ex.Message + " ";
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(com_GeneracionOCompra_Info info, ref decimal id, ref string msg)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                    var address = new com_GenerOCompra();
                    decimal idEmp = GetId(info.IdEmpresa);
                    id = idEmp;
                    address.IdSucursal = info.IdSucursal;
                    address.IdTransaccion = id;
                    address.IdEmpresa = info.IdEmpresa;
                    address.FechaReg = info.FechaReg;
                    address.Usuario = info.Usuario;
                    address.g_ocObservacion = info.g_ocObservacion;
                    if (info.g_ocObservacion.Length > 1000)
                        address.g_ocObservacion = info.g_ocObservacion.Substring(0, 1000);
                    address.Estado = "A";

                    
                    context.com_GenerOCompra.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el Listado de Materiales #: " + id.ToString() + " exitosamente.";
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

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        
        public Boolean ModificarDB(com_GeneracionOCompra_Info info, ref string msg)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                    var contact = context.com_GenerOCompra.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa
                        && obj.IdTransaccion == info.IdTransaccion);

                    if (contact != null)
                    {
                        contact.FechaReg = info.FechaReg;
                        contact.Usuario = info.Usuario;
                        contact.g_ocObservacion = info.g_ocObservacion;


                        context.SaveChanges();
                        msg = "Se ha procedido actualizar elListado de Materiales #: " + info.IdTransaccion.ToString() + " exitosamente.";
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

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<com_GeneracionOCompra_Info> Get_List_GeneracionOCompra(int IdEmpresa)
        {
                List<com_GeneracionOCompra_Info> Lst = new List<com_GeneracionOCompra_Info>();
                EntitiesCompras oEnti = new EntitiesCompras();
            try
            {
                var Query = from q in oEnti.com_GenerOCompra
                            where q.IdEmpresa == IdEmpresa
                            select q;
                foreach (var item in Query)
                {

                    com_GeneracionOCompra_Info Obj = new com_GeneracionOCompra_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdTransaccion = item.IdTransaccion;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.FechaReg = item.FechaReg;
                    Obj.Usuario = item.Usuario;
                    Obj.g_ocObservacion = item.g_ocObservacion;
                    Obj.Estado = item.Estado;
                    Obj.check = false;

                    Lst.Add(Obj);
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }

        }

        public com_GeneracionOCompra_Info Get_Info_GeneracionOCompra(int IdEmpresa, int IdTransaccion)
        {
            try
            {
                com_GeneracionOCompra_Info info = new com_GeneracionOCompra_Info();
                EntitiesCompras oEnti = new EntitiesCompras();

                var select = from A in oEnti.com_GenerOCompra
                             where A.IdEmpresa == IdEmpresa
                             && A.IdTransaccion == IdTransaccion

                             select A;

                foreach (var item in select)
                {
                   
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTransaccion = item.IdTransaccion;
                    info.FechaReg = item.FechaReg;
                    info.Usuario = item.Usuario;
                    info.g_ocObservacion = item.g_ocObservacion;
                    info.Estado = item.Estado;


                }
                return (info);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
