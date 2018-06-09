using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion
{
    
    public class fa_venta_telefonica_Data
    {
        string mensaje = "";

        public decimal GetId(int IdEmpresa, int IdSucursal)
        {
            decimal id = 0;
            try
            {
                List<fa_venta_telefonica_Info> lst = new List<fa_venta_telefonica_Info>();
                EntitiesFacturacion context = new EntitiesFacturacion();                              
               

                var selecte = context.fa_venta_telefonica.Count(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal);
                if (selecte == 0)
                {
                    id = 1;
                }
                else
                {
                    context = new EntitiesFacturacion();
                    var select = (from q in context.fa_venta_telefonica
                                          where q.IdEmpresa == IdEmpresa
                                          && q.IdSucursal == IdSucursal
                                          select q.IdVenta_tel).Max();
                    id = Convert.ToDecimal(select.ToString()) + 1;
                }
                return id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }


        public decimal GetIdCbteCble(int idempresa, int idTipoCbte)
        {
            try
            {
                decimal IdcbteCble = 0;
                EntitiesDBConta OECbtecble = new EntitiesDBConta();


                var selecte = OECbtecble.ct_cbtecble.Count(q => q.IdEmpresa == idempresa && q.IdTipoCbte == idTipoCbte);


                if (selecte == 0)
                {
                    IdcbteCble = 1;
                }
                else
                {
                    OECbtecble = new EntitiesDBConta();
                    var selectCbtecble = (from CbtCble in OECbtecble.ct_cbtecble
                                          where CbtCble.IdEmpresa == idempresa
                                          && CbtCble.IdTipoCbte == idTipoCbte
                                          select CbtCble.IdCbteCble).Max();
                    IdcbteCble = Convert.ToDecimal(selectCbtecble.ToString()) + 1;



                }
                return IdcbteCble;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_venta_telefonica_Info> Get_List_venta_telefonica(int IdEmpresa)
        {
            try
            {
                List<fa_venta_telefonica_Info> lst = new List<fa_venta_telefonica_Info>();
                EntitiesFacturacion context = new EntitiesFacturacion();

                fa_venta_telefonica_Info Info;
                var select = from q in context.fa_venta_telefonica
                             where q.IdEmpresa == IdEmpresa
                             select q;

                foreach (var item in select)
                {
                    Info = new fa_venta_telefonica_Info();

                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdVenta_tel = item.IdVenta_tel;
                    Info.IdCliente = item.IdCliente;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdMotivo = item.IdMotivo;
                    Info.Observacion = item.Observacion;
                    Info.Fecha = item.Fecha;
                    Info.Estado = item.Estado;
                    Info.Contactar_futuro = item.Contactar_futuro;

                    Info.IdUsuario = item.IdUsuario;
                    Info.Fecha_Transac = item.Fecha_Transac;
                    Info.ip = item.ip;
                    Info.nom_pc = item.nom_pc;

                    Info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Info.Fecha_UltMod = item.Fecha_UltMod;
                    Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Info.Fecha_UltAnu = item.Fecha_UltAnu;

                    lst.Add(Info);
                }
                return lst;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_venta_telefonica_Info> Get_List_venta_telefonica(int IdEmpresa, int IdSucursal)
        {
            try
            {
                List<fa_venta_telefonica_Info> lst = new List<fa_venta_telefonica_Info>();
                EntitiesFacturacion context = new EntitiesFacturacion();

                fa_venta_telefonica_Info Info;          
              
                    var select = from q in context.fa_venta_telefonica
                                 where q.IdEmpresa == IdEmpresa
                                     && q.IdSucursal == IdSucursal
                                 orderby q.IdVenta_tel descending
                                 select q;
              
                foreach (var item in select)
                {
                    Info = new fa_venta_telefonica_Info();

                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdVenta_tel = item.IdVenta_tel;
                    Info.IdCliente = item.IdCliente;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdMotivo = item.IdMotivo;
                    Info.Observacion = item.Observacion;
                    Info.Fecha = item.Fecha;
                    Info.Estado = item.Estado;
                    Info.Contactar_futuro = item.Contactar_futuro;

                    Info.IdUsuario = item.IdUsuario;
                    Info.Fecha_Transac = item.Fecha_Transac;
                    Info.ip = item.ip;
                    Info.nom_pc = item.nom_pc;

                    Info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Info.Fecha_UltMod = item.Fecha_UltMod;
                    Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Info.Fecha_UltAnu = item.Fecha_UltAnu;

                    lst.Add(Info);
                }
                return lst;
              
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_venta_telefonica_Info> Get_List_venta_telefonica(int IdEmpresa, int IdSucursal, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                List<fa_venta_telefonica_Info> lst = new List<fa_venta_telefonica_Info>();
                EntitiesFacturacion context = new EntitiesFacturacion();

                fa_venta_telefonica_Info Info;

                var select = from q in context.fa_venta_telefonica
                             where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                                 && (q.Fecha >= fechaInicio && q.Fecha <= fechaFin)
                             orderby q.IdVenta_tel descending
                             select q;


                foreach (var item in select)
                {
                    Info = new fa_venta_telefonica_Info();

                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdVenta_tel = item.IdVenta_tel;
                    Info.IdCliente = item.IdCliente;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdMotivo = item.IdMotivo;
                    Info.Observacion = item.Observacion;
                    Info.Fecha = item.Fecha;
                    Info.Estado = item.Estado;
                    Info.Contactar_futuro = item.Contactar_futuro;

                    Info.IdUsuario = item.IdUsuario;
                    Info.Fecha_Transac = item.Fecha_Transac;
                    Info.ip = item.ip;
                    Info.nom_pc = item.nom_pc;

                    Info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Info.Fecha_UltMod = item.Fecha_UltMod;
                    Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Info.Fecha_UltAnu = item.Fecha_UltAnu;

                    lst.Add(Info);

                }
                return lst;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(fa_venta_telefonica_Info Info, ref decimal Id)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();

                    var address = new fa_venta_telefonica();

                    address.IdEmpresa = Info.IdEmpresa;
                    address.IdSucursal = Info.IdSucursal;
                    address.IdVenta_tel =Id= GetId(Info.IdEmpresa, Info.IdSucursal);
                    address.IdCliente = Info.IdCliente;
                    address.IdMotivo = Info.IdMotivo;
                    address.Observacion = Info.Observacion;
                    address.Fecha = Info.Fecha;
                    address.Estado = Info.Estado;
                    address.Contactar_futuro = Info.Contactar_futuro;
                    address.IdUsuario = Info.IdUsuario;
                    address.Fecha_Transac = Convert.ToDateTime(Info.Fecha_Transac);
                    address.ip = Info.ip;
                    address.nom_pc = Info.nom_pc;
                    context.fa_venta_telefonica.Add(address);
                    context.SaveChanges();
                    return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(fa_venta_telefonica_Info Info)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();

                var address = context.fa_venta_telefonica.FirstOrDefault(var => var.IdEmpresa == Info.IdEmpresa
                                                                   && var.IdVenta_tel == Info.IdVenta_tel
                                                                   && var.IdSucursal == Info.IdSucursal);
                if (address != null)
                {
                    address.IdMotivo = Info.IdMotivo;
                    address.Observacion = Info.Observacion;
                    address.Fecha = Info.Fecha;
                    address.Contactar_futuro = Info.Contactar_futuro.Trim();
                    address.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                    address.Fecha_UltMod = Info.Fecha_UltMod;
                    context.SaveChanges();
                }
                return true;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }


        public Boolean AnularDB(fa_venta_telefonica_Info Info)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();

                var address = context.fa_venta_telefonica.FirstOrDefault(var => var.IdEmpresa == Info.IdEmpresa
                                                                   && var.IdVenta_tel == Info.IdVenta_tel
                                                                   && var.IdSucursal == Info.IdSucursal);
                if (address != null)
                {
                    address.Estado = Info.Estado;
                    address.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    address.Fecha_UltAnu = Info.Fecha_UltAnu;
                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
