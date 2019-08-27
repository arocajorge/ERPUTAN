using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Compras
{
    public class com_ordencompra_local_Data
    {
        string mensaje = "";

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local(int IdEmpresa, ref string msg)
        {
               List<com_ordencompra_local_Info> Lst = new List<com_ordencompra_local_Info>();
                EntitiesCompras  OEComp = new EntitiesCompras();
            try
            { 
                var Select  = from q in OEComp.vwcom_ordencompra_local
                              where q.IdEmpresa == IdEmpresa 
                            select q;
                foreach (var item in Select)
                {
                    com_ordencompra_local_Info OrdCompInfo = new com_ordencompra_local_Info();
                    OrdCompInfo.IdEmpresa = item.IdEmpresa;
                    OrdCompInfo.IdSucursal = item.IdSucursal;
                    OrdCompInfo.IdOrdenCompra = item.IdOrdenCompra;
                    OrdCompInfo.IdProveedor = item.IdProveedor;
                    OrdCompInfo.oc_NumDocumento = item.oc_NumDocumento;
                    OrdCompInfo.Tipo = item.Tipo;
                    OrdCompInfo.IdTerminoPago = item.IdTerminoPago;
                    OrdCompInfo.oc_plazo = item.oc_plazo;
                    OrdCompInfo.oc_fecha = item.oc_fecha;
                    OrdCompInfo.oc_flete = item.oc_flete;
                    OrdCompInfo.oc_observacion = item.oc_observacion;
                    OrdCompInfo.Estado = item.Estado;
                    OrdCompInfo.IdEstadoAprobacion_cat = item.IdEstadoAprobacion_cat;
                    OrdCompInfo.co_fecha_aprobacion = item.co_fecha_aprobacion;
                    OrdCompInfo.IdUsuario_Aprueba = item.IdUsuario_Aprueba;
                    OrdCompInfo.IdUsuario_Reprue = item.IdUsuario_Reprue;
                    OrdCompInfo.co_fechaReproba = item.co_fechaReproba;
                    OrdCompInfo.Fecha_Transac = item.Fecha_Transac;
                    OrdCompInfo.Fecha_UltMod = item.Fecha_UltMod;
                    OrdCompInfo.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    OrdCompInfo.FechaHoraAnul = item.FechaHoraAnul;
                    OrdCompInfo.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    OrdCompInfo.IdEstadoRecepcion_cat = item.IdEstadoRecepcion_cat;
                    OrdCompInfo.AfectaCosto = item.AfectaCosto;
                    OrdCompInfo.iva = item.iva;
                    OrdCompInfo.total = item.total;
                    OrdCompInfo.peso = item.peso;
                    OrdCompInfo.ap_descripcion = item.ap_descripcion;
                    OrdCompInfo.tp_descripcion = item.tp_descripcion;
                    OrdCompInfo.rec_descripcion = item.rec_descripcion;
                    OrdCompInfo.pr_nombre = item.pr_nombre;
                    OrdCompInfo.Su_Descripcion = item.Su_Descripcion;
                    OrdCompInfo.MotivoReprobacion = item.MotivoReprobacion;
                    OrdCompInfo.Solicitante = item.Solicitante;

                    OrdCompInfo.Nom_Comprador = item.Nom_Comprador;
                    OrdCompInfo.Nom_Solicita = item.Nom_Solicita;
                    OrdCompInfo.SDepartamento = item.SDepartamento;

                    OrdCompInfo.oc_fechaVencimiento = Convert.ToDateTime(item.oc_fechaVencimiento);

                    OrdCompInfo.IdEstado_cierre = item.IdEstado_cierre;
                    OrdCompInfo.subtotal = item.subtotal;
                    OrdCompInfo.nom_motivo_OC = item.nom_motivo_OC;

                    Lst.Add(OrdCompInfo);
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
                mensaje = ex.ToString();
                msg = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public List<com_ordencompra_local_sin_guia_consulta> Get_List_ordencompra_local_sin_Guia_x_traspaso_bodega(int IdEmpresa, int IdSucursal, DateTime FechaIni, DateTime FechaFin)
        {
            List<com_ordencompra_local_sin_guia_consulta> Lst = new List<com_ordencompra_local_sin_guia_consulta>();
            EntitiesCompras OEComp = new EntitiesCompras();
            try
            {
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                Lst = (from q in OEComp.vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega
                              where q.IdEmpresa == IdEmpresa
                              && q.oc_fecha <= FechaFin
                              && q.oc_fecha >= FechaIni
                              && q.IdSucursal == IdSucursal
                              && q.Saldo_x_Enviar > 0
                              && q.Estado == "A"
                              select new com_ordencompra_local_sin_guia_consulta
                              {
                                  IdEmpresa = q.IdEmpresa,
                                  IdSucursal = q.IdSucursal,
                                  IdOrdenCompra = q.IdOrdenCompra,
                                  oc_fecha = q.oc_fecha,
                                  oc_observacion = q.oc_observacion,
                                  IdEstadoAprobacion_cat = q.IdEstadoAprobacion_cat,
                                  Estado = q.Estado,
                                  IdProveedor = q.IdProveedor,
                                  nom_proveedor = q.nom_proveedor,
                              }).ToList();
                              
                
                return Lst;
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

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_sin_Guia_x_traspaso_bodega_det(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            List<com_ordencompra_local_Info> Lst = new List<com_ordencompra_local_Info>();
            EntitiesCompras OEComp = new EntitiesCompras();
            try
            {
                Lst = (from q in OEComp.vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega_det
                       where q.IdEmpresa == IdEmpresa
                       && q.IdOrdenCompra == IdOrdenCompra
                       && q.IdSucursal == IdSucursal
                       && q.Saldo_x_Enviar > 0
                       select new com_ordencompra_local_Info
                       {
                           IdEmpresa = q.IdEmpresa,
                           IdSucursal = q.IdSucursal,
                           IdOrdenCompra = q.IdOrdenCompra,
                           oc_fecha = q.oc_fecha,
                           oc_observacion = q.co_observacion,
                           IdEstadoAprobacion_cat = q.IdEstadoAprobacion_cat,
                           Estado = q.Estado,
                           IdProveedor = q.IdProveedor,
                           nom_proveedor = q.nom_proveedor,
                           do_Cantidad = q.Saldo_x_Enviar,
                           nom_producto = q.nom_producto,
                           IdProducto = q.IdProducto,
                           Secuencia = q.Secuencia,
                           nom_punto_cargo = q.nom_punto_cargo,
                       }).ToList();

                return Lst;
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

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_sin_Guia_x_traspaso_bodega(int IdEmpresa, decimal IdGuia)
        {
            List<com_ordencompra_local_Info> Lst = new List<com_ordencompra_local_Info>();
            EntitiesCompras OEComp = new EntitiesCompras();
            try
            {
                Lst = (from q in OEComp.vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega_consul
                              where q.IdEmpresa == IdEmpresa
                              && q.IdGuia == IdGuia
                              select new com_ordencompra_local_Info
                              {
                                  IdEmpresa = q.IdEmpresa,
                                  IdSucursal = q.IdSucursal,
                                  IdOrdenCompra = q.IdOrdenCompra,
                                  oc_fecha = q.oc_fecha,
                                  oc_observacion = q.oc_observacion,
                                  IdEstadoAprobacion_cat = q.IdEstadoAprobacion_cat,
                                  Estado = q.Estado,
                                  IdProveedor = q.IdProveedor,
                                  nom_proveedor = q.nom_proveedor,
                                  IdProducto = q.IdProducto,
                                  cod_producto = q.cod_producto,
                                  nom_producto = q.nom_producto,
                                  do_Cantidad = q.do_Cantidad,
                                  do_precioCompra = q.do_precioCompra,
                                  do_subtotal = q.do_subtotal,
                                  Su_Descripcion = q.Su_Descripcion,
                                  oc_NumDocumento = q.oc_NumDocumento,
                                  Secuencia = q.Secuencia,
                                  Cantidad_enviar = q.Cantidad_enviar,
                                  IdGuia = q.IdGuia,
                                  oc_fechaVencimiento = q.oc_fechaVencimiento,

                                  observacion_det_gui = q.observacion_det_gui,
                                  Referencia_guia = q.Referencia,
                                  nom_punto_cargo = q.nom_punto_cargo,
                              }).ToList();

                return Lst;
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

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_x_devolver(int IdEmpresa, decimal IdProveedor, ref string msg)
        {
            List<com_ordencompra_local_Info> Lst = new List<com_ordencompra_local_Info>();
            EntitiesCompras OEComp = new EntitiesCompras();
            try
            {
                var Select = from q in OEComp.vwcom_ordencompra_local_con_cant_devolver
                             where q.IdEmpresa == IdEmpresa
                             && q.IdProveedor ==  IdProveedor
                             && q.SaldoxDevolver>0
                             group q by new { q.IdEmpresa, q.IdSucursal,q.IdOrdenCompra,q.oc_fecha,q.do_observacion,q.IdProveedor,q.pr_nombre,q.Su_Descripcion}
                                 into grouping
                                 select new { grouping.Key};

                foreach (var item in Select)
                {
                    com_ordencompra_local_Info OrdCompInfo = new com_ordencompra_local_Info();
                    OrdCompInfo.IdEmpresa = item.Key.IdEmpresa;
                    OrdCompInfo.IdSucursal = item.Key.IdSucursal;
                    OrdCompInfo.IdOrdenCompra = item.Key.IdOrdenCompra;
                    OrdCompInfo.IdProveedor = item.Key.IdProveedor;
                    OrdCompInfo.pr_nombre = item.Key.pr_nombre;
                    OrdCompInfo.oc_fecha = item.Key.oc_fecha;
                    OrdCompInfo.oc_observacion = item.Key.do_observacion;
                    OrdCompInfo.Su_Descripcion = item.Key.Su_Descripcion;

                            var Selectdet = from q in OEComp.vwcom_ordencompra_local_con_cant_devolver
                                            where q.IdEmpresa == item.Key.IdEmpresa
                                         && q.IdProveedor == IdProveedor
                                         && q.IdSucursal == item.Key.IdSucursal
                                         && q.IdOrdenCompra == item.Key.IdOrdenCompra
                                         && q.SaldoxDevolver > 0
                                         select q;

                            foreach (var item_d in Selectdet)
                            {

                                    com_ordencompra_local_det_Info det_info_OC = new com_ordencompra_local_det_Info();

                                    det_info_OC.IdEmpresa=item.Key.IdEmpresa;
                                    det_info_OC.IdSucursal=item.Key.IdSucursal;
                                    det_info_OC.IdOrdenCompra=item.Key.IdOrdenCompra;
                                    det_info_OC.Secuencia = item_d.Secuencia;
                                    det_info_OC.IdProducto = item_d.IdProducto;
                                    det_info_OC.do_Cantidad = item_d.do_Cantidad;
                                    det_info_OC.do_precioCompra = item_d.do_precioCompra;
                                    det_info_OC.do_porc_des = item_d.do_porc_des;
                                    det_info_OC.do_descuento = item_d.do_descuento;
                                    det_info_OC.do_subtotal = item_d.do_subtotal;
                                    det_info_OC.do_iva = item_d.do_iva;
                                    det_info_OC.do_total = item_d.do_total;
                                    //det_info_OC.do_ManejaIva = item_d.do_ManejaIva;
                                    det_info_OC.do_Costeado = item_d.do_Costeado;
                                    det_info_OC.do_peso = item_d.do_peso;
                                    det_info_OC.do_observacion = item_d.oc_observacion;
                                    det_info_OC.cant_devuelta = item_d.cant_devuelta;
                                    det_info_OC.saldo_x_devolver = item_d.SaldoxDevolver;

                                OrdCompInfo.listDetalle.Add(det_info_OC); 
                            }
                    Lst.Add(OrdCompInfo);
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
                msg = mensaje;
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
       
        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_x_Proveedor(int IdEmpresa, decimal IdProveedor)
        {
            List<com_ordencompra_local_Info> Lst = new List<com_ordencompra_local_Info>();
            EntitiesCompras OEComp = new EntitiesCompras();
            try
            {
                var Select = from q in OEComp.vwcom_ordencompra_local_con_cant_devolver
                             where q.IdEmpresa == IdEmpresa
                             && q.IdProveedor == IdProveedor

                             && q.SaldoxDevolver > 0
                             group q by new { q.IdEmpresa, q.IdSucursal, q.IdOrdenCompra, q.oc_fecha, q.do_observacion, q.IdProveedor, q.pr_nombre, q.Su_Descripcion }
                                 into grouping
                                 select new { grouping.Key };

                foreach (var item in Select)
                {
                    com_ordencompra_local_Info OrdCompInfo = new com_ordencompra_local_Info();
                    OrdCompInfo.IdEmpresa = item.Key.IdEmpresa;
                    OrdCompInfo.IdSucursal = item.Key.IdSucursal;
                    OrdCompInfo.IdOrdenCompra = item.Key.IdOrdenCompra;
                    OrdCompInfo.IdProveedor = item.Key.IdProveedor;
                    OrdCompInfo.pr_nombre = item.Key.pr_nombre;
                    OrdCompInfo.oc_fecha = item.Key.oc_fecha;
                    OrdCompInfo.oc_observacion = item.Key.do_observacion;
                    OrdCompInfo.Su_Descripcion = item.Key.Su_Descripcion;

                    var Selectdet = from q in OEComp.vwcom_ordencompra_local_con_cant_devolver
                                    where q.IdEmpresa == item.Key.IdEmpresa
                                 && q.IdSucursal == item.Key.IdSucursal
                                 && q.IdOrdenCompra == item.Key.IdOrdenCompra
                                 && q.IdProveedor == IdProveedor
                                    select q;

                    foreach (var item_d in Selectdet)
                    {
                        com_ordencompra_local_det_Info det_info_OC = new com_ordencompra_local_det_Info();

                        det_info_OC.IdEmpresa = item.Key.IdEmpresa;
                        det_info_OC.IdSucursal = item.Key.IdSucursal;
                        det_info_OC.IdOrdenCompra = item.Key.IdOrdenCompra;
                        det_info_OC.Secuencia = item_d.Secuencia;
                        det_info_OC.IdProducto = item_d.IdProducto;
                        det_info_OC.do_Cantidad = item_d.do_Cantidad;
                        det_info_OC.do_precioCompra = item_d.do_precioCompra;
                        det_info_OC.do_porc_des = item_d.do_porc_des;
                        det_info_OC.do_descuento = item_d.do_descuento;
                        det_info_OC.do_subtotal = item_d.do_subtotal;
                        det_info_OC.do_iva = item_d.do_iva;
                        det_info_OC.do_total = item_d.do_total;
                        //det_info_OC.do_ManejaIva = item_d.do_ManejaIva;
                        det_info_OC.do_Costeado = item_d.do_Costeado;
                        det_info_OC.do_peso = item_d.do_peso;
                        det_info_OC.do_observacion = item_d.oc_observacion;
                        det_info_OC.cant_devuelta = item_d.cant_devuelta;
                        det_info_OC.saldo_x_devolver = item_d.SaldoxDevolver;
                        OrdCompInfo.listDetalle.Add(det_info_OC);
                    }
                    Lst.Add(OrdCompInfo);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string EstadoAprob, string Estado)
        {
            try
            {
                #region Antigua consulta
            List<com_ordencompra_local_Info> Lst = new List<com_ordencompra_local_Info>();
            
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                string Aprob_Estado = (EstadoAprob == "TODOS") ? "" : EstadoAprob;
                

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    db.SetCommandTimeOut(10000);

                    Lst = db.vwcom_ordencompra_local.Where(q => q.IdEmpresa == IdEmpresa && FechaIni <= q.oc_fecha && q.oc_fecha <= FechaFin && q.Estado.Contains(Estado) && q.IdEstadoAprobacion_cat.StartsWith(EstadoAprob)).Select(q => new com_ordencompra_local_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdSucursal = q.IdSucursal,
                        IdOrdenCompra = q.IdOrdenCompra,
                        IdProveedor = q.IdProveedor,
                        oc_NumDocumento = q.oc_NumDocumento,
                        Tipo = q.Tipo,
                        IdTerminoPago = q.IdTerminoPago,
                        oc_plazo = q.oc_plazo,
                        oc_fecha = q.oc_fecha,
                        oc_flete = q.oc_flete,
                        oc_observacion = q.oc_observacion,
                        Estado = q.Estado,
                        IdEstadoAprobacion_cat = q.IdEstadoAprobacion_cat,
                        IdEstadoAprobacion_AUX = q.IdEstadoAprobacion_cat,
                        co_fecha_aprobacion = q.co_fecha_aprobacion,
                        IdUsuario_Aprueba = q.IdUsuario_Aprueba,
                        IdUsuario_Reprue = q.IdUsuario_Reprue,
                        co_fechaReproba = q.co_fechaReproba,
                        Fecha_Transac = q.Fecha_Transac,
                        Fecha_UltMod = q.Fecha_UltMod,
                        IdUsuarioUltMod = q.IdUsuarioUltMod,
                        FechaHoraAnul = q.FechaHoraAnul,
                        IdUsuarioUltAnu = q.IdUsuarioUltAnu,
                        IdEstadoRecepcion_cat = q.IdEstadoRecepcion_cat,
                        AfectaCosto = q.AfectaCosto,
                        iva = q.iva,
                        total = q.total,
                        peso = q.peso,
                        ap_descripcion = q.ap_descripcion,
                        tp_descripcion = q.tp_descripcion,
                        rec_descripcion = q.rec_descripcion,
                        pr_nombre = q.pr_nombre,
                        Su_Descripcion = q.Su_Descripcion,
                        MotivoReprobacion = q.MotivoReprobacion,
                        Solicitante = q.Solicitante,
                        IdDepartamento = q.IdDepartamento,
                        IdComprador = q.IdComprador,
                        IdSolicitante = q.IdSolicitante,
                        Nom_Comprador = q.Nom_Comprador,
                        Nom_Solicita = q.Nom_Solicita,
                        SDepartamento = q.SDepartamento,
                        IdMotivo = q.IdMotivo,
                        oc_fechaVencimiento = q.oc_fechaVencimiento,
                        IdEstado_cierre = q.IdEstado_cierre,
                        Mostrar_Solicitud = true,
                        subtotal = q.subtotal,
                        nom_motivo_OC = q.nom_motivo_OC,
                        nom_EstadoCierre = q.nom_EstadoCerrado,
                        En_guia = q.En_guia,
                    }).ToList();
                }

             
                return Lst;
                #endregion
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

        public List<com_ordencompra_local_consulta> Get_List_ordencompra_local(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                FechaIni = FechaIni.Date;
                FechaFin = FechaFin.Date;
                List<com_ordencompra_local_consulta> Lista;

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    Lista = db.vwcom_ordencompra_local_consulta.Where(q => q.IdEmpresa == IdEmpresa && FechaIni <= q.oc_fecha && q.oc_fecha <= FechaFin).Select(q => new com_ordencompra_local_consulta
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdSucursal = q.IdSucursal,
                        IdOrdenCompra = q.IdOrdenCompra,
                        Codigo = q.Codigo,
                        Su_Descripcion = q.Su_Descripcion,
                        oc_fecha = q.oc_fecha,
                        pe_nombreCompleto = q.pe_nombreCompleto,
                        Total = q.Total,
                        IdEstadoAprobacion_cat = q.IdEstadoAprobacion_cat,
                        EstadoAprobacion = q.EstadoAprobacion,
                        oc_observacion = q.oc_observacion,
                        Descripcion = q.Descripcion,
                        IdEstado_cierre = q.IdEstado_cierre,
                        EstadoCierre = q.EstadoCierre,
                        en_guia = q.en_guia,
                        Estado = q.Estado,
                        TerminoPago = q.TerminoPago,
                        oc_plazo = q.oc_plazo,
                    }).ToList();
                }

                return Lista;
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


        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_x_Solicitud(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra)
        {
            List<com_ordencompra_local_Info> Lst = new List<com_ordencompra_local_Info>();
            EntitiesCompras OEComp = new EntitiesCompras();
            try
            {

                var Select = from q in OEComp.vwcom_ordencompra_local_det_x_com_solicitud_compra_det
                             where q.scd_IdEmpresa == IdEmpresa
                                   && q.scd_IdSucursal == IdSucursal
                                   && q.scd_IdSolicitudCompra == IdSolicitudCompra
                                 select q;

                    foreach (var item in Select)
                    {
                        com_ordencompra_local_Info OrdCompInfo = new com_ordencompra_local_Info();
                        OrdCompInfo.IdEmpresa = item.IdEmpresa;
                        OrdCompInfo.IdSucursal = item.IdSucursal;
                        OrdCompInfo.IdOrdenCompra = item.IdOrdenCompra;
                        OrdCompInfo.IdProveedor = item.IdProveedor;
                        OrdCompInfo.oc_NumDocumento = item.oc_NumDocumento;
                        OrdCompInfo.Tipo = item.Tipo;
                        OrdCompInfo.IdTerminoPago = item.IdTerminoPago;
                        OrdCompInfo.oc_plazo = item.oc_plazo;
                        OrdCompInfo.oc_fecha = item.oc_fecha;
                        OrdCompInfo.oc_flete = item.oc_flete;
                        OrdCompInfo.oc_observacion = item.oc_observacion;
                        OrdCompInfo.Estado = item.Estado;
                        OrdCompInfo.IdEstadoAprobacion_cat = item.IdEstadoAprobacion_cat;
                        OrdCompInfo.IdEstadoAprobacion_AUX = item.IdEstadoAprobacion_cat;
                        OrdCompInfo.co_fecha_aprobacion = item.co_fecha_aprobacion;
                        OrdCompInfo.IdUsuario_Aprueba = item.IdUsuario_Aprueba;
                        OrdCompInfo.IdUsuario_Reprue = item.IdUsuario_Reprue;
                        OrdCompInfo.co_fechaReproba = item.co_fechaReproba;
                        OrdCompInfo.Fecha_Transac = item.Fecha_Transac;
                        OrdCompInfo.Fecha_UltMod = item.Fecha_UltMod;
                        OrdCompInfo.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        OrdCompInfo.FechaHoraAnul = item.FechaHoraAnul;
                        OrdCompInfo.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        OrdCompInfo.IdEstadoRecepcion_cat = item.IdEstadoRecepcion_cat;
                        OrdCompInfo.AfectaCosto = item.AfectaCosto;
                        OrdCompInfo.iva = item.iva;
                        OrdCompInfo.total = item.total;
                        OrdCompInfo.peso = item.peso;
                        OrdCompInfo.ap_descripcion = item.ap_descripcion;
                        OrdCompInfo.tp_descripcion = item.tp_descripcion;
                        OrdCompInfo.rec_descripcion = item.rec_descripcion;
                        OrdCompInfo.pr_nombre = item.pr_nombre;
                        OrdCompInfo.Su_Descripcion = item.Su_Descripcion;
                        OrdCompInfo.MotivoReprobacion = item.MotivoReprobacion;
                        OrdCompInfo.Solicitante = item.Solicitante;
                        OrdCompInfo.IdDepartamento = item.IdDepartamento;
                        OrdCompInfo.IdComprador = item.IdComprador;
                        OrdCompInfo.IdSolicitante = item.IdSolicitante;
                        OrdCompInfo.Nom_Comprador = item.Nom_Comprador;
                        OrdCompInfo.Nom_Solicita = item.Nom_Solicita;
                        OrdCompInfo.SDepartamento = item.SDepartamento;
                        OrdCompInfo.IdMotivo = item.IdMotivo;
                        OrdCompInfo.oc_fechaVencimiento = Convert.ToDateTime(item.oc_fechaVencimiento);


                        OrdCompInfo.IdEstado_cierre = item.IdEstado_cierre;

                        OrdCompInfo.subtotal = item.subtotal;
                        OrdCompInfo.nom_motivo_OC = item.nom_motivo_OC;

                        Lst.Add(OrdCompInfo);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }


        public Boolean GuardarDB(com_ordencompra_local_Info Info, ref decimal id)
        {
            try
            {
                List<com_ordencompra_local_Info> Lst = new List<com_ordencompra_local_Info>();
                using (EntitiesCompras Context = new EntitiesCompras())
                {
                    
                    var Address = new com_ordencompra_local();
                    decimal idoc = GetId(Info.IdEmpresa , Info.IdSucursal);
                    id = idoc;

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdSucursal = Info.IdSucursal;
                    Info.IdOrdenCompra = idoc;
                    Address.IdOrdenCompra = idoc;

                    if (Info.oc_NumDocumento == null || Info.oc_NumDocumento=="")
                    {
                        Info.oc_NumDocumento = "OC"+idoc;                    
                    }
                  
                    Address.oc_NumDocumento = Info.oc_NumDocumento;
                    Address.Tipo = Info.Tipo == null ? "" : Info.Tipo;
                    Address.IdTerminoPago = Info.IdTerminoPago;
                    Address.oc_plazo = Info.oc_plazo;
                    Address.oc_fecha = (DateTime)Info.oc_fecha;
                    Address.Fecha_Transac = (Info.Fecha_Transac == null) ? DateTime.Now : Info.Fecha_Transac;
                    Address.oc_flete = Info.oc_flete;
                    Address.oc_observacion = Info.oc_observacion;
                    Address.Estado = "A";
                    Address.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                    Address.IdEstadoAprobacion_cat = Info.IdEstadoAprobacion_cat;
                    Address.IdUsuario_Aprueba = Info.IdUsuario_Aprueba;
                    Address.IdEstadoRecepcion_cat = Info.IdEstadoRecepcion_cat;
                    Address.AfectaCosto = (Info.AfectaCosto == null) ? "S" : Info.AfectaCosto;
                    Address.IdProveedor = Info.IdProveedor;
                    Address.IdComprador = Info.IdComprador;
                    Address.IdSolicitante = Info.IdSolicitante;
                    Address.IdDepartamento = Info.IdDepartamento;
                    Address.IdUsuario = Info.IdUsuario;
                    Address.oc_fechaVencimiento = Info.oc_fechaVencimiento;
                    Address.IdEstado_cierre = Info.IdEstado_cierre;
                    Address.IdMotivo = Info.IdMotivo;
                    Address.Solicitante = Info.Solicitante == null ? null : Info.Solicitante.Trim();

                    Context.com_ordencompra_local.Add(Address);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public com_ordencompra_local_Info Get_Info_ordencompra_local(int IdEmpresa, int idsucursal, decimal idordencompra)
        {
            EntitiesCompras oEnti = new EntitiesCompras();
           com_ordencompra_local_Info Info = new com_ordencompra_local_Info();
            try
            {
                var Objeto = oEnti.vwcom_ordencompra_local.FirstOrDefault(
                 var => var.IdEmpresa == IdEmpresa && var.IdSucursal == idsucursal
                     && var.IdOrdenCompra == idordencompra);

                if (Objeto != null)
                {

                    Info.IdEmpresa = Objeto.IdEmpresa;
                    Info.IdSucursal = Objeto.IdSucursal;
                    Info.IdOrdenCompra = Objeto.IdOrdenCompra;
                    Info.IdProveedor = Objeto.IdProveedor;
                    Info.oc_NumDocumento = Objeto.oc_NumDocumento;
                    Info.Tipo = Objeto.Tipo;
                    Info.IdTerminoPago = Objeto.IdTerminoPago;
                    Info.oc_plazo = Objeto.oc_plazo;
                    Info.oc_fecha = Objeto.oc_fecha;
                    Info.oc_flete = Objeto.oc_flete;
                    Info.oc_observacion = Objeto.oc_observacion;
                    Info.Estado = Objeto.Estado;
                    Info.IdEstadoAprobacion_cat = Objeto.IdEstadoAprobacion_cat;
                    Info.co_fecha_aprobacion = Objeto.co_fecha_aprobacion;
                    Info.IdUsuario_Aprueba = Objeto.IdUsuario_Aprueba;
                    Info.IdUsuario_Reprue = Objeto.IdUsuario_Reprue;
                    Info.co_fechaReproba = Objeto.co_fechaReproba;
                    Info.Fecha_Transac = Objeto.Fecha_Transac;
                    Info.Fecha_UltMod = Objeto.Fecha_UltMod;
                    Info.IdUsuarioUltMod = Objeto.IdUsuarioUltMod;
                    Info.FechaHoraAnul = Objeto.FechaHoraAnul;
                    Info.IdUsuarioUltAnu = Objeto.IdUsuarioUltAnu;
                    Info.IdEstadoRecepcion_cat = Objeto.IdEstadoRecepcion_cat;
                    Info.AfectaCosto = Objeto.AfectaCosto;
                    Info.Su_Descripcion = Objeto.Su_Descripcion;
                    Info.pr_nombre = Objeto.pr_nombre;
                    Info.tp_descripcion = Objeto.tp_descripcion;
                    Info.Solicitante = Objeto.Solicitante;

                    Info.IdDepartamento = Objeto.IdDepartamento;
                    Info.IdComprador = Objeto.IdComprador;
                    Info.IdSolicitante = Objeto.IdSolicitante;

                    Info.Nom_Comprador = Objeto.Nom_Comprador;
                    Info.Nom_Solicita = Objeto.Nom_Solicita;
                    Info.SDepartamento = Objeto.SDepartamento;

                    Info.oc_fechaVencimiento = Convert.ToDateTime(Objeto.oc_fechaVencimiento);


                    Info.IdEstado_cierre = Objeto.IdEstado_cierre;

                    Info.total = Objeto.total;
                    Info.ap_descripcion = Objeto.ap_descripcion;
                    Info.rec_descripcion = Objeto.rec_descripcion;

                    Info.subtotal = Objeto.subtotal;
                    Info.nom_motivo_OC = Objeto.nom_motivo_OC;
                }

                return Info;
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


        public com_ordencompra_local_Info Get_Info_ordencompra_local_x_Total_RegOC_vs_Total_RegGuia(int IdEmpresa, int idsucursal, decimal idordencompra)
        {
            EntitiesCompras oEnti = new EntitiesCompras();
            com_ordencompra_local_Info Info = new com_ordencompra_local_Info();
            try
            {
                var Objeto = oEnti.vwcom_ordencompra_local_vs_in_Guia_x_traspaso_bodega_Total_Reg.FirstOrDefault(
                 var => var.IdEmpresa == IdEmpresa && var.IdSucursal == idsucursal
                     && var.IdOrdenCompra == idordencompra);

                if (Objeto != null)
                {

                    Info.IdEmpresa = Objeto.IdEmpresa;
                    Info.IdSucursal = Objeto.IdSucursal;
                    Info.IdOrdenCompra = Objeto.IdOrdenCompra;
                    Info.Total_Reg_x_Guia = Objeto.Total_reg_x_Guia;
                    Info.Total_Reg_x_OC = Objeto.Total_reg_x_OC;

                }
                return Info;
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

        public Boolean ModificarDB(com_ordencompra_local_Info Info, ref  string msg)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                    var contact = context.com_ordencompra_local.FirstOrDefault(obj => obj.IdOrdenCompra == Info.IdOrdenCompra &&
                         obj.IdSucursal == Info.IdSucursal && obj.IdEmpresa == Info.IdEmpresa);

                    if (contact != null)
                    {

                        contact.IdProveedor = Info.IdProveedor;
                        contact.oc_NumDocumento = Info.oc_NumDocumento;
                        contact.Tipo = Info.Tipo;
                        contact.IdTerminoPago = Info.IdTerminoPago;
                        contact.oc_plazo = Info.oc_plazo;
                        contact.oc_fecha = (DateTime)Info.oc_fecha;
                        contact.oc_flete = Info.oc_flete;
                        contact.oc_observacion = Info.oc_observacion;
                        contact.Estado = Info.Estado;
                        contact.IdEstadoAprobacion_cat = Info.IdEstadoAprobacion_cat;
                        contact.co_fecha_aprobacion = Info.co_fecha_aprobacion;
                        contact.IdUsuario_Aprueba = Info.IdUsuario_Aprueba;
                        contact.IdUsuario_Reprue = Info.IdUsuario_Reprue;
                        contact.co_fechaReproba = Info.co_fechaReproba;
                        contact.Fecha_UltMod = DateTime.Now;
                        contact.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        contact.IdEstadoRecepcion_cat = Info.IdEstadoRecepcion_cat;
                        contact.AfectaCosto = Info.AfectaCosto;
                        contact.MotivoReprobacion = Info.MotivoReprobacion;
                        contact.Solicitante = Info.Solicitante;

                        contact.IdDepartamento = Info.IdDepartamento;
                        contact.IdComprador = Info.IdComprador;
                        contact.IdSolicitante = Info.IdSolicitante;

                        contact.oc_fechaVencimiento = Info.oc_fechaVencimiento;

                        contact.IdMotivo = Info.IdMotivo;

                        contact.IdEstado_cierre = Info.IdEstado_cierre;

                        context.SaveChanges();
                        msg = "Se ha procedido a modificar el registro de Orden Compra #: " + Info.IdOrdenCompra.ToString() + " exitosamente";
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
                mensaje = ex.ToString();

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Modificar_Estado_Aprob(com_ordencompra_local_Info Info, ref  string msg)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                    var contact = context.com_ordencompra_local.FirstOrDefault(obj => obj.IdOrdenCompra == Info.IdOrdenCompra &&
                         obj.IdSucursal == Info.IdSucursal && obj.IdEmpresa == Info.IdEmpresa);

                    if (contact != null)
                    {

                        switch (Info.IdEstadoAprobacion_cat)
                        {

                            case "xAPRO":
                                contact.IdEstadoAprobacion_cat = Info.IdEstadoAprobacion_cat;

                                break;

                            case "APRO":

                                contact.IdEstadoAprobacion_cat = Info.IdEstadoAprobacion_cat;
                                contact.MotivoReprobacion = Info.MotivoReprobacion;
                                contact.co_fecha_aprobacion = Info.co_fecha_aprobacion;
                                contact.IdUsuario_Aprueba = Info.IdUsuario_Aprueba;
                                break;

                            case "REP":

                                contact.IdEstadoAprobacion_cat = Info.IdEstadoAprobacion_cat;
                                contact.MotivoReprobacion = Info.MotivoReprobacion;
                                contact.co_fechaReproba = Info.co_fechaReproba;
                                contact.IdUsuario_Reprue = Info.IdUsuario_Reprue;
                                break;

                            default:
                                break;

                        }

                        context.SaveChanges();
                        msg = "Se ha procedido a modificar el registro de Orden Compra #: " + Info.IdOrdenCompra.ToString() + " exitosamente";

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
                mensaje = ex.ToString();

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Modificar_Estado_Recep(com_ordencompra_local_Info Info, ref  string msg)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                    var contact = context.com_ordencompra_local.First(obj => obj.IdOrdenCompra == Info.IdOrdenCompra &&
                         obj.IdSucursal == Info.IdSucursal && obj.IdEmpresa == Info.IdEmpresa);

                    contact.IdEstadoRecepcion_cat = Info.IdEstadoRecepcion_cat;
                   
                    context.SaveChanges();
                    msg = "Se ha procedido a actualizar el estado de recepción de Orden Compra #: " + Info.IdOrdenCompra.ToString() + " exitosamente";

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

        public Boolean Modificar_Estado_Cierre(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra,string Estado_cierre)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                    var contact = context.com_ordencompra_local.FirstOrDefault(obj => obj.IdOrdenCompra == IdOrdenCompra &&
                         obj.IdSucursal == IdSucursal && obj.IdEmpresa == IdEmpresa);

                    if (contact != null)
                    {
                        contact.IdEstado_cierre = Estado_cierre;
                        context.SaveChanges();
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

               // msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean AnularDB(com_ordencompra_local_Info Info, ref  string msg)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                    var contact = context.com_ordencompra_local.FirstOrDefault(obj => obj.IdOrdenCompra == Info.IdOrdenCompra &&
                         obj.IdSucursal == Info.IdSucursal && obj.IdEmpresa == Info.IdEmpresa);

                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.IdEstadoAprobacion_cat = Info.IdEstadoAprobacion_cat;
                        contact.FechaHoraAnul = Info.FechaHoraAnul;
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.MotivoAnulacion = Info.MotivoAnulacion;
                        contact.oc_observacion = Info.oc_observacion;
                        context.SaveChanges();

                        var lst_solicitudes = context.com_ordencompra_local_det_x_com_solicitud_compra_det.Where(q => q.ocd_IdEmpresa == Info.IdEmpresa && q.ocd_IdSucursal == Info.IdSucursal && q.ocd_IdOrdenCompra == Info.IdOrdenCompra).ToList();
                        foreach (var item in lst_solicitudes)
                        {
                            var entity_sol = context.com_solicitud_compra_det_aprobacion.Where(q => q.IdEmpresa == item.scd_IdEmpresa && q.IdSucursal_SC == item.scd_IdSucursal && q.IdSolicitudCompra == item.scd_IdSolicitudCompra).FirstOrDefault();
                            if(entity_sol != null)
                                entity_sol.IdEstadoAprobacion = "PEN_SOL";
                        }
                        context.SaveChanges();

                        context.Database.ExecuteSqlCommand("DELETE com_ordencompra_local_det_x_com_solicitud_compra_det where ocd_IdEmpresa = "+Info.IdEmpresa+" and ocd_IdSucursal = "+Info.IdSucursal+" and ocd_IdOrdenCompra = "+Info.IdOrdenCompra);

                        msg = "Se ha procedido a anular el registro de Orden Compra #: " + Info.IdOrdenCompra.ToString() + " exitosamente";
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
                mensaje = ex.ToString();

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
      
        public Boolean ReversarOC(com_ordencompra_local_Info Info,  ref  string msg)
        {
            try
            {
                com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Info TIDetGOC = new com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Info();
                com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Data dataTIGOC = new com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Data();
                com_GenerOCompraDet_Data DetDataGOC = new com_GenerOCompraDet_Data();
                List<com_ordencompra_local_det_Info> DetOC = new List<com_ordencompra_local_det_Info>();
                com_ordencompra_local_det_Data DetOCData = new com_ordencompra_local_det_Data();
                  
                if (AnularDB(Info, ref msg)) //anula O/C cambiando el Estado a I y el Estado de Aprobacion a REP
                {
                    DetOC = DetOCData.Get_List_ordencompra_local_det(Info.IdEmpresa, Info.IdSucursal, Info.IdOrdenCompra);
                    foreach (var item in DetOC)
                    {
                        com_ListadoMateriales_Det_Info infoDetGOC = new com_ListadoMateriales_Det_Info();
                        com_ListadoMateriales_Det_Data dataDetListM = new com_ListadoMateriales_Det_Data();
                        TIDetGOC = dataTIGOC.Get_List_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider(item, ref msg);
                        infoDetGOC = DetDataGOC.Get_Info_ListadoMateriales_Det(TIDetGOC.goc_IdEmpresa, TIDetGOC.goc_IdTransaccion, TIDetGOC.goc_IdDetTrans);
                        infoDetGOC.lm_IdEstadoAprobado = "X APRO";  //al listado de requerimientos de materiales se le deja X APROBAR
                        infoDetGOC.go_IdEstadoAprob = "REP"; // a la generacion de o/c se la reprueba
                        if (dataDetListM.ActualizarEstadoAprob(infoDetGOC, ref msg))
                            if (DetDataGOC.ModificarEstadoGOCDet(infoDetGOC, ref msg) == false) return false;                                                
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }       
        
        }

        public decimal GetId( int idempresa, int idsucursal)
        {
            try
            {
                int Id;
                EntitiesCompras OECompras = new EntitiesCompras();
                var select = from q in OECompras.com_ordencompra_local
                             where q.IdEmpresa == idempresa &&
                                     q.IdSucursal == idsucursal
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OECompras.com_ordencompra_local where q.IdEmpresa == idempresa &&
                                     q.IdSucursal == idsucursal
                                     select q.IdOrdenCompra).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                    Id = (Id == 0) ? 1 : Id;
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
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public Boolean VerificarCodigo(string NumDoc,int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
               EntitiesCompras oen = new EntitiesCompras();
               var select = from q in oen.com_ordencompra_local
                             where q.oc_NumDocumento == NumDoc

                             && q.IdEmpresa != IdEmpresa
                             && q.IdSucursal != IdSucursal
                             && q.IdOrdenCompra != IdOrdenCompra
                             select q;

                if (select.ToList().Count() >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
    }
}
