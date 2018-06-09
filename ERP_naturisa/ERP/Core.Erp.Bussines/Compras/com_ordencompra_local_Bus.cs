using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;


namespace Core.Erp.Business.Compras
{
    public class com_ordencompra_local_Bus
    {
        #region declaracion de variable
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        com_ordencompra_local_Data BusOC = new com_ordencompra_local_Data();
        com_ordencompra_local_det_Data BusOC_det = new com_ordencompra_local_det_Data();
        com_Catalogo_Bus CatCom = new com_Catalogo_Bus();
        com_TerminoPago_Bus BusTerPago = new com_TerminoPago_Bus();
        com_ordencompra_local_det_Bus BusDetOC = new com_ordencompra_local_det_Bus();
        List<com_ordencompra_local_det_Info> templst = new List<com_ordencompra_local_det_Info>();
        #endregion

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local(int IdEmpresa)
        {
            try
            {
                string msg = "";
                return BusOC.Get_List_ordencompra_local(IdEmpresa, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        }

        public com_ordencompra_local_Info Get_Info_ordencompra_local(int IdEmpresa, int IdSucursal, decimal IdOrdencompra)
        {
            try
            {
                return BusOC.Get_Info_ordencompra_local(IdEmpresa, IdSucursal, IdOrdencompra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_ordencompra_local", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };

            }

        }

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_sin_Guia_x_traspaso_bodega(int IdEmpresa, int IdSucursal, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return BusOC.Get_List_ordencompra_local_sin_Guia_x_traspaso_bodega(IdEmpresa, IdSucursal, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local_sin_Guia_x_traspaso_bodega", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }               
        }

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_sin_Guia_x_traspaso_bodega_det(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
                return BusOC.Get_List_ordencompra_local_sin_Guia_x_traspaso_bodega_det(IdEmpresa, IdSucursal, IdOrdenCompra);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local_sin_Guia_x_traspaso_bodega", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        }

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_x_Solicitud(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra)
        {
            try
            {
                return BusOC.Get_List_ordencompra_local_x_Solicitud(IdEmpresa, IdSucursal, IdSolicitudCompra);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local_x_Solicitud", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        }

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_sin_Guia_x_traspaso_bodega(int IdEmpresa, decimal IdGuia)
        {
            try
            {
                return BusOC.Get_List_ordencompra_local_sin_Guia_x_traspaso_bodega( IdEmpresa, IdGuia);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local_sin_Guia_x_traspaso_bodega", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        }

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string EstadoAprob, string Estado)
        {
            try
            {
                return BusOC.Get_List_ordencompra_local(IdEmpresa ,FechaIni, FechaFin, EstadoAprob, Estado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        }

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_x_Proveedor(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                return BusOC.Get_List_ordencompra_local_x_Proveedor(IdEmpresa, IdProveedor);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local_x_Proveedor", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }


        }

        public Boolean Validar_objeto(com_ordencompra_local_Info Info, ref string msg)
        {

            try
            {
                if (Info.IdEmpresa == 0 || Info.IdSucursal == 0 || Info.IdProveedor == 0 || Info.IdDepartamento == 0)
                {
                    msg = "las variables estan en cero... Info.IdEmpresa == 0 || Info.IdSucursal == 0 || Info.IdProveedor == 0 || Info.IdDepartamento == 0 " ;
                    return false;
                }
                /*
                if (Info.IdMotivo == null || Info.IdMotivo == 0)
                {
                    msg = "Ingrese el motivo de la Compra";
                    com_Catalogo_Bus bUS = new com_Catalogo_Bus();
                    List<com_Catalogo_Info> listc = new List<com_Catalogo_Info>(bUS.Get_List_Catalogo());
                    return false;

                }*/

                if (Info.listDetalle.Count == 0)
                {
                    msg = "la OC no tiene items q grabar";
                    return false;
                }

                int c = 0;

                foreach (var item in Info.listDetalle)
                {
                    if (item.do_Cantidad == 0 )
                    {
                        msg = "Ingrese la cantidad al item : " + item.codproducto + "  ";
                        return false;
                    }

                    if (item.do_precioCompra == 0 )
                    {
                        msg = "Ingrese el costo al item : " + item.codproducto + "  ";
                        return false;
                    }

                    if (item.IdUnidadMedida == "" || item.IdUnidadMedida == null)
                    {
                        in_producto_Bus BusProducto = new in_producto_Bus();
                        in_Producto_Info InfoProducto = new in_Producto_Info();
                        InfoProducto =BusProducto.Get_info_Product(item.IdEmpresa, item.IdProducto);
                        item.IdUnidadMedida = InfoProducto.IdUnidadMedida;
                    }


                    if (item.IdCentroCosto == "" )
                    {
                        item.IdCentroCosto = null;
                    }

                    if (item.IdCentroCosto_sub_centro_costo == "")
                    {
                        item.IdCentroCosto_sub_centro_costo = null;
                    }

                    if (item.IdCod_Impuesto == "" || item.IdCod_Impuesto==null) // Arreglando si no viene iva y codigo de iva
                    {
                        tb_sis_impuesto_Bus BusImpuestoIva = new tb_sis_impuesto_Bus();
                        List<tb_sis_impuesto_Info> ListInfo_Impuesto = new List<tb_sis_impuesto_Info>();
                        tb_sis_impuesto_Info Info_Impuesto = new tb_sis_impuesto_Info();
                        ListInfo_Impuesto  = BusImpuestoIva.Get_List_impuesto_para_Compras("IVA");

                        Info_Impuesto = ListInfo_Impuesto.FirstOrDefault();
                        item.IdCod_Impuesto = Info_Impuesto.IdCod_Impuesto;
                        item.Por_Iva = Info_Impuesto.porcentaje;
                    }


                    //item.do_ManejaIva = (item.do_iva == 0) ? false : true;
                    c = c + 1;
                    item.Secuencia = c;


                    item.IdEmpresa = Info.IdEmpresa;
                    item.IdSucursal = Info.IdSucursal;
                    item.IdOrdenCompra = Info.IdOrdenCompra;

                }

                if (Info.IdMotivo == 0 && Info.IdMotivo == null)
                {
                    //consulta motivo compra
                    com_Motivo_Orden_Compra_Data odataMoti = new com_Motivo_Orden_Compra_Data();
                    List<com_Motivo_Orden_Compra_Info> listMoti = new List<com_Motivo_Orden_Compra_Info>();

                    listMoti = odataMoti.Get_List_Motivo_Orden_Compra(Info.IdEmpresa);
                    var itemMoti = listMoti.FirstOrDefault(q => q.IdMotivo == Info.IdMotivo);
                    Info.IdMotivo = itemMoti.IdMotivo;
                }


                if (Info.IdEstadoAprobacion_cat == "" || Info.IdEstadoAprobacion_cat == null)
                {
                    List<com_Catalogo_Info> listEstadoAproba = new List<com_Catalogo_Info>();
                    listEstadoAproba = CatCom.Get_ListEstadoAprobacion();
                    com_Catalogo_Info resEstadoApro = new com_Catalogo_Info();
                    resEstadoApro = listEstadoAproba.FirstOrDefault();
                    Info.IdEstadoAprobacion_cat = resEstadoApro.IdCatalogocompra;
                }

                if (Info.IdEstadoRecepcion_cat=="" || Info.IdEstadoRecepcion_cat==null)
                {
                    List<com_Catalogo_Info> listEstadoRecep = new List<com_Catalogo_Info>();
                    com_Catalogo_Info resEstadoRece = new com_Catalogo_Info();
                    listEstadoRecep = CatCom.Get_ListEstadoRecepcion();
                    resEstadoRece = listEstadoRecep.First();
                    Info.IdEstadoRecepcion_cat = resEstadoRece.IdCatalogocompra;
                }


                if (Info.IdTerminoPago=="" || Info.IdTerminoPago==null)
                {
                    List<com_TerminoPago_Info> listTerminoPago = new List<com_TerminoPago_Info>();
                    listTerminoPago = BusTerPago.Get_List_TerminoPago();
                    com_TerminoPago_Info TerminoPago = new com_TerminoPago_Info();
                    TerminoPago = listTerminoPago.FirstOrDefault();
                    Info.IdTerminoPago = TerminoPago.IdTerminoPago;
                }


                if (Info.IdEstado_cierre == null || Info.IdEstado_cierre=="")
                {
                    com_estado_cierre_Bus busEstCierre = new com_estado_cierre_Bus();
                    com_parametro_Bus paraBus = new com_parametro_Bus();
                    string idestadoCierrexDefault = "";
                    idestadoCierrexDefault=paraBus.Get_List_parametro(Info.IdEmpresa).FirstOrDefault().IdEstado_cierre;
                    Info.IdEstado_cierre = busEstCierre.Get_List_estado_cierre().FirstOrDefault(v => v.IdEstado_cierre == idestadoCierrexDefault).IdEstado_cierre;
                }


                

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_objeto", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
                
            }

        }

        public Boolean GuardarDB(com_ordencompra_local_Info Info, ref decimal id,ref string msg)
        {
            try
            {     
                Boolean res = true;
                if (Validar_objeto(Info,ref msg))
                {
                    //cabecera
                    res= BusOC.GuardarDB(Info, ref id);

                    foreach (var item in Info.listDetalle)
                    {
                        item.IdEmpresa = Info.IdEmpresa;
                        item.IdSucursal = Info.IdSucursal;
                        item.IdOrdenCompra = id;
                        //item.IdUnidadMedida=Info.listDetalle.
                    }
                    //detalle
                    res= BusOC_det.GuardarDB(Info.listDetalle,ref msg );


                    // opcion habilitada cuando se graba desde la pantalla aprobacion de solicitudes con generacion de orden compra
                    
                    #region grabar en tabla intermedia com_ordencompra_local_det_x_com_solicitud_compra_det

                    if (Info.listDetSoliciComp.Count() != 0)
                    {
                        // consulto detalle orden compra
                        com_ordencompra_local_det_Data odata = new com_ordencompra_local_det_Data();
                        List<com_ordencompra_local_det_Info> listDetComp = new List<com_ordencompra_local_det_Info>();
                        listDetComp = odata.Get_List_ordencompra_local_det(Info.IdEmpresa, Info.IdSucursal, Info.IdOrdenCompra);

                        List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> listDetCompra = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();
                        List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> listDetSoliCompra = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();

                        com_ordencompra_local_det_x_com_solicitud_compra_det_Info info;

                        foreach (var item in listDetComp)
                        {
                            info = new com_ordencompra_local_det_x_com_solicitud_compra_det_Info();

                            info.ocd_IdEmpresa = item.IdEmpresa;
                            info.ocd_IdSucursal = item.IdSucursal;
                            info.ocd_IdOrdenCompra = item.IdOrdenCompra;
                            info.ocd_Secuencia = item.Secuencia;

                            listDetCompra.Add(info);
                        }

                        foreach (var item in Info.listDetSoliciComp)
                        {
                            info = new com_ordencompra_local_det_x_com_solicitud_compra_det_Info();

                            info.scd_IdEmpresa = item.IdEmpresa;
                            info.scd_IdSucursal = item.IdSucursal;
                            info.scd_IdSolicitudCompra = item.IdSolicitudCompra;
                            info.scd_Secuencia = item.Secuencia;

                            listDetSoliCompra.Add(info);
                        }

                        int scd_IdEmpresa = 0;
                        int scd_IdSucursal = 0;
                        decimal scd_IdSolicitudCompra = 0;
                        int scd_Secuencia = 0;

                        foreach (var item in listDetCompra)
                        {
                            var items = listDetSoliCompra.First(v => v.ocd_IdEmpresa == 0 && v.ocd_IdSucursal == 0 && v.ocd_IdOrdenCompra == 0 && v.ocd_Secuencia == 0);

                            scd_IdEmpresa = items.scd_IdEmpresa;
                            scd_IdSucursal = items.scd_IdSucursal;
                            scd_IdSolicitudCompra = items.scd_IdSolicitudCompra;
                            scd_Secuencia = items.scd_Secuencia;

                            listDetSoliCompra.Remove(items);

                            item.scd_IdEmpresa = scd_IdEmpresa;
                            item.scd_IdSucursal = scd_IdSucursal;
                            item.scd_IdSolicitudCompra = scd_IdSolicitudCompra;
                            item.scd_Secuencia = scd_Secuencia;
                        }

                        com_ordencompra_local_det_x_com_solicitud_compra_det_Bus bus_Inter = new com_ordencompra_local_det_x_com_solicitud_compra_det_Bus();

                        if (bus_Inter.GrabarDB(listDetCompra, ref mensaje))
                        {
                        }
                    }
                    #endregion

                }
                else
                {
                    res = false; 
                }

                return res;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }

        }

        public Boolean ModificarDB(com_ordencompra_local_Info Info, ref  string msg)
        {
            try
            {
                Boolean resp1 = true;


                if (Validar_objeto(Info, ref msg))
                {
                    resp1 = BusOC.ModificarDB(Info, ref msg);


                    List<com_ordencompra_local_det_Info> generados = new List<com_ordencompra_local_det_Info>();
                    List<com_ordencompra_local_det_Info> agregados = new List<com_ordencompra_local_det_Info>();

                    in_Guia_x_traspaso_bodega_det_Info info_guia = new in_Guia_x_traspaso_bodega_det_Info();
                    in_Guia_x_traspaso_bodega_det_Bus bus_guia = new in_Guia_x_traspaso_bodega_det_Bus();
                    string sGuias = "";
                    if (!bus_guia.Existe_OC_en_guia(Info, ref sGuias))
                    {
                        int secuencia = 0;
                        secuencia = BusDetOC.GetSecuencia_x_OC(Info.IdEmpresa, Info.IdSucursal, Info.IdOrdenCompra);


                        // consultar tabla intermedia

                        com_ordencompra_local_det_x_com_solicitud_compra_det_Bus bus_Inter = new com_ordencompra_local_det_x_com_solicitud_compra_det_Bus();
                        List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> listInter = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();
                        listInter = bus_Inter.Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_OrdenCompra(Info.IdEmpresa, Info.IdSucursal, Info.IdOrdenCompra);

                        List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> listInter_AUX = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();

                        if (listInter.Count() != 0)
                        {
                            // recupero los datos tabla intermedia
                            foreach (var item in listInter)
                            {
                                com_ordencompra_local_det_x_com_solicitud_compra_det_Info infoInter = new com_ordencompra_local_det_x_com_solicitud_compra_det_Info();

                                infoInter.ocd_IdEmpresa = item.ocd_IdEmpresa;
                                infoInter.ocd_IdSucursal = item.ocd_IdSucursal;
                                infoInter.ocd_IdOrdenCompra = item.ocd_IdOrdenCompra;
                                infoInter.ocd_Secuencia = item.ocd_Secuencia;
                                infoInter.scd_IdEmpresa = item.scd_IdEmpresa;
                                infoInter.scd_IdSucursal = item.scd_IdSucursal;
                                infoInter.scd_IdSolicitudCompra = item.scd_IdSolicitudCompra;
                                infoInter.scd_Secuencia = item.scd_Secuencia;
                                infoInter.observacion = item.observacion;

                                listInter_AUX.Add(infoInter);
                            }
                            //eliminar detalle tabla intermedia
                            if (bus_Inter.Eliminar_Detalle_OCDxSCD(Info.IdEmpresa, Info.IdSucursal, Info.IdOrdenCompra, ref msg))
                            {

                            }
                        }
                        if (BusDetOC.EliminarDetalle_OC(Info.IdEmpresa, Info.IdSucursal, Info.IdOrdenCompra, ref msg))
                        {
                            resp1 = BusOC_det.GuardarDB(Info.listDetalle, ref msg);

                            //grabar tabla intermedia
                            if (listInter.Count() != 0)
                            {
                                if (bus_Inter.GrabarDB(listInter_AUX, ref mensaje))
                                {
                                }
                            }
                        }
                    }
                    else
                    {
                        // aqui existe guias con esta OC verifico q los registro sean los mismos para poder modificar la OC sino NO
                        com_ordencompra_local_Info InfoVali = new com_ordencompra_local_Info();
                        //InfoVali = BusOC.Get_Info_ordencompra_local_x_Total_RegOC_vs_Total_RegGuia(Info.IdEmpresa, Info.IdSucursal, Info.IdOrdenCompra);

                        resp1 = BusDetOC.ModificarDB(Info.listDetalle, ref msg);
                    }
                }
                else
                { //

                    resp1 = false;
                }

                return resp1;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }

        }

        public Boolean Modificar_Estado_Aprob(com_ordencompra_local_Info Info, ref  string msg)
        {

            try
            {
               return BusOC.Modificar_Estado_Aprob(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar_Estado_Aprob", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        }

        public Boolean Modificar_Estado_Recep(com_ordencompra_local_Info Info, ref  string msg)
        {
            try
            {
                return BusOC.Modificar_Estado_Recep(Info, ref msg);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar_Estado_Recep", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }

        }

        public Boolean Modificar_Estado_Cierre(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, string Estado_cierre)
        {
            try
            {
                return BusOC.Modificar_Estado_Cierre(IdEmpresa, IdSucursal,  IdOrdenCompra,  Estado_cierre);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar_Estado_Cierre", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        
        
        }

        public Boolean AnularDB(com_ordencompra_local_Info Info, ref  string msg)
        {
            try
            {
                Info.FechaHoraAnul = DateTime.Now;
                if (Info.IdUsuarioUltAnu == null)
                    Info.IdUsuarioUltAnu = "";
                return BusOC.AnularDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }

        }

        public Boolean VerificarCodigo(string NumDoc,int IdEmpresa,int IdSucursal,decimal IdOrdenCompra)
        {
            try
            {
                return BusOC.VerificarCodigo(NumDoc,IdEmpresa, IdSucursal, IdOrdenCompra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarCodigo", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        }

        public Boolean ReversarOC(com_ordencompra_local_Info Info, ref  string msg)
        {
            try
            {
                return BusOC.ReversarOC(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ReversarOC", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        }

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_x_devolver(int IdEmpresa, decimal IdProveedor, ref string msg)
        {
            try
            {
                return BusOC.Get_List_ordencompra_local_x_devolver(IdEmpresa, IdProveedor, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local_x_devolver", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        }

        public decimal GetId(int IdEmpresa, int IdSucursal)
        {
            try
            {
                return BusOC.GetId(IdEmpresa, IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        

        }

        public com_ordencompra_local_Bus()
        {

        }

    }
}
