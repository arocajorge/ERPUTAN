using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
//13-5-2013
namespace Core.Erp.Data.Presupuesto
{
    public class pre_ordencompra_local_Data
    {
        string mensaje = "";
        pre_ordencompra_local_det_Data OCDet_D = new pre_ordencompra_local_det_Data();

        public Boolean GrabarDB(pre_ordencompra_local_Info Info, ref decimal IdOrdenCompra)
        {
            try
            {
                decimal IdOrdenCompra_ = getIdOrdenCompra(Info.IdEmpresa);
                IdOrdenCompra = IdOrdenCompra_;

                List<pre_ordencompra_local_Info> Lst = new List<pre_ordencompra_local_Info>();
                using (EntitiesPresupuesto Context = new EntitiesPresupuesto())
                {
                    var Address = new pre_ordencompra_local();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdSucursal = Info.IdSucursal;
                    Address.IdOrdenCompra = IdOrdenCompra_;
                    Address.IdProveedor = Info.IdProveedor;
                    Address.oc_NumDocumento = Info.oc_NumDocumento;
                    Address.oc_fecha = Info.oc_fecha;
                    Address.oc_observacion = Info.oc_observacion;
                    Address.Estado = Info.Estado;
                    Address.IdEstadoAprobacion = Info.IdEstadoAprobacion;
                    Address.IdUsuario = Info.IdUsuario;
                   // Address.co_fecha_aprobacion = null;// Info.co_fecha_aprobacion;
                   // Address.IdUsuario_Aprueba = Info.IdUsuario_Aprueba;
                   // Address.IdUsuario_Reprue = Info.IdUsuario_Reprue;
                   // Address.co_fechaReproba = null;// Info.co_fechaReproba;
                    Address.Fecha_Transac = Info.Fecha_Transac;
                    //Address.Fecha_UltMod = Info.Fecha_UltMod;
                    //Address.FechaHoraAnul = null;//Info.FechaHoraAnul;
                    //Address.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    Address.EstadoRecepcion = Info.EstadoRecepcion;
                    //Address.MotivoAnulacion = Info.MotivoAnulacion;
                    Address.IdTerminoPago = Info.IdTerminoPago;
                    Address.FormaEnvio = Info.FormaEnvio;
                    Address.CondicionPago = Info.CondicionPago;

                    Context.pre_ordencompra_local.Add(Address);
                    Context.SaveChanges();

                    //Graba el detalle 
                    
                    Info.LstPedidoOC_det.ForEach(var => { var.IdEmpresa = Info.IdEmpresa; var.IdSucursal = Info.IdSucursal; var.IdOrdenCompra = IdOrdenCompra_; });
                    OCDet_D.GrabarLstDB(Info.LstPedidoOC_det);
                    
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


        public decimal getIdOrdenCompra(int IdEmpresa)
        {
            try
            {
                decimal Id;
                EntitiesPresupuesto base_ = new EntitiesPresupuesto();

                var q = from C in base_.pre_ordencompra_local
                        where C.IdEmpresa == IdEmpresa
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {

                    var select_ = (from CbtCble in base_.pre_ordencompra_local
                                   where CbtCble.IdEmpresa == IdEmpresa
                                   select CbtCble.IdOrdenCompra).Max();
                    Id = select_ + 1;
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


        public List<pre_ordencompra_local_Info> ObtenerList(int IdEmpresa, int IdSucursal)
        {
            try
            {
                List<pre_ordencompra_local_Info> Lst = new List<pre_ordencompra_local_Info>();
                EntitiesPresupuesto oEnti = new EntitiesPresupuesto();
                var Query = from q in oEnti.pre_ordencompra_local
                            where q.IdEmpresa == IdEmpresa
                            select q;
                foreach (var item in Query)
                {
                    pre_ordencompra_local_Info Obj = new pre_ordencompra_local_Info();
                    Obj.IdEmpresa = item.IdEmpresa;

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdOrdenCompra = item.IdOrdenCompra;
                    Obj.IdProveedor = item.IdProveedor ;
                    Obj.oc_NumDocumento = item.oc_NumDocumento;
                    Obj.oc_fecha = item.oc_fecha;
                    Obj.oc_observacion = item.oc_observacion;
                    Obj.Estado = item.Estado;
                    Obj.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    Obj.co_fecha_aprobacion = item.co_fecha_aprobacion;
                    Obj.IdUsuario_Aprueba = item.IdUsuario_Aprueba;
                    Obj.IdUsuario_Reprue = item.IdUsuario_Reprue;
                    Obj.co_fechaReproba = item.co_fechaReproba;
                    Obj.Fecha_Transac = item.Fecha_Transac;
                    Obj.Fecha_UltMod = item.Fecha_UltMod;
                    Obj.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Obj.FechaHoraAnul = item.FechaHoraAnul;
                    Obj.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Obj.EstadoRecepcion = item.EstadoRecepcion;
                    Obj.MotivoAnulacion = item.MotivoAnulacion;
                    Obj.IdTerminoPago = item.IdTerminoPago;
                    Obj.FormaEnvio = item.FormaEnvio;
                    Obj.CondicionPago = item.CondicionPago;

                    Lst.Add(Obj);
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

        public Boolean ModificarDB(pre_ordencompra_local_Info Info)
        {
            try
            {
                using (EntitiesPresupuesto context = new EntitiesPresupuesto())
                {
                    var Address = context.pre_ordencompra_local.FirstOrDefault(minfo => minfo.IdEmpresa == Info.IdEmpresa && minfo.IdSucursal == Info.IdSucursal && minfo.IdOrdenCompra == Info.IdOrdenCompra);
                    if (Address != null)
                    {
                        Address.IdProveedor = Info.IdProveedor;
                        Address.oc_NumDocumento = Info.oc_NumDocumento;
                        Address.oc_fecha = Info.oc_fecha;
                        Address.oc_observacion = Info.oc_observacion;
                        Address.Estado = Info.Estado;
                        Address.IdEstadoAprobacion = Info.IdEstadoAprobacion;

                        // Address.co_fecha_aprobacion = null;// Info.co_fecha_aprobacion;
                        // Address.IdUsuario_Aprueba = Info.IdUsuario_Aprueba;
                        // Address.IdUsuario_Reprue = Info.IdUsuario_Reprue;
                        // Address.co_fechaReproba = null;// Info.co_fechaReproba;
                        Address.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        Address.Fecha_UltMod = Info.Fecha_UltMod;
                        //Address.FechaHoraAnul = null;//Info.FechaHoraAnul;
                        //Address.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        Address.EstadoRecepcion = Info.EstadoRecepcion;
                        //Address.MotivoAnulacion = Info.MotivoAnulacion;
                        Address.IdTerminoPago = Info.IdTerminoPago;
                        Address.FormaEnvio = Info.FormaEnvio;
                        Address.CondicionPago = Info.CondicionPago;

                        context.SaveChanges();

                        OCDet_D.ModificarLstDB(Info.LstPedidoOC_det);

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



        public Boolean AnularDB(pre_ordencompra_local_Info info)
        {
            try
            {
                using (EntitiesPresupuesto context = new EntitiesPresupuesto())
                {
                    var contact = context.pre_ordencompra_local.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdSucursal == info.IdSucursal && minfo.IdOrdenCompra == info.IdOrdenCompra);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.FechaHoraAnul = info.FechaHoraAnul;
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.MotivoAnulacion = info.MotivoAnulacion;

                        OCDet_D.EliminarLstDB(info.LstPedidoOC_det);

                        context.SaveChanges();
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


        public pre_ordencompra_local_Data()
        {
            
        }
    }
}
