using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;


namespace Core.Erp.Business.Inventario
{
    public class in_movi_inve_Bus
    {

        string mensaje = "";

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        in_movi_inve_Data moviD = new in_movi_inve_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public Boolean ModificarDB_proceso_cerrado(in_movi_inve_Info info, ref string msgs)
        {
            try
            {
                return moviD.ModificarDB_proceso_cerrado(info, ref msgs);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Actualizar_estado_despacho", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };
            }
        }

        public bool Actualizar_estado_despacho(List<in_movi_inve_Info> Lista)
        {
            try
            {
                return moviD.Actualizar_estado_despacho(Lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Actualizar_estado_despacho", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };
            }
        }

        public List<in_movi_inve_Info> Get_list_Movi_inven(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin,
            int TipoMoviIni, int TipoMoviFin, DateTime FechaIni, DateTime FechaFin, string Signo_Ing_Egre = "")
        {

            try
            {
                return moviD.Get_list_Movi_inven(IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, TipoMoviIni, TipoMoviFin, FechaIni, FechaFin, Signo_Ing_Egre);


            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_list_Movi_inven", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };

            }

        }


        public List<in_movi_inve_Info> Get_list_Movi_inven_para_contabilizar(int IdEmpresa, string cm_signo, DateTime Fecha_ini, DateTime Fecha_fin, string Estado_contabilizacion)
        {
            try
            {
                return moviD.Get_list_Movi_inven_para_contabilizar(IdEmpresa, cm_signo,Fecha_ini,Fecha_fin, Estado_contabilizacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_list_Movi_inven_Recepcion", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };
            }
        }
        public Boolean GrabarDB(in_movi_inve_Info MoviInven_Info, ref decimal idMoviInven, ref string mensaje_cbte_cble ,
            ref string mensaje,Boolean Esta_Transaccion_Contabiliza =true)
        {
            try
            {
                in_movi_inven_tipo_Bus TipoMoviInvenBus = new in_movi_inven_tipo_Bus();
                in_movi_inven_tipo_Info InfoTipoMoviInven = new in_movi_inven_tipo_Info();
                Boolean ResGrabar;
                Boolean ResContabilizar;

                in_Parametro_Bus busParam = new in_Parametro_Bus();
                in_Parametro_Info infoParam = new in_Parametro_Info();
                infoParam = busParam.Get_Info_Parametro(param.IdEmpresa);

                mensaje_cbte_cble = "";
                ct_Periodo_Bus PerBus = new ct_Periodo_Bus();

                MoviInven_Info.IdUsuario = param.IdUsuario;
                MoviInven_Info.IdUsuarioUltModi = param.IdUsuario;
                MoviInven_Info.Fecha_Transac = param.Fecha_Transac;
                MoviInven_Info.Fecha_UltMod = param.Fecha_Transac;
                MoviInven_Info.ip = param.ip;
                MoviInven_Info.nom_pc = param.nom_pc;




                #region 'Validaciones '
                
                if (MoviInven_Info.listmovi_inve_detalle_Info == null ) 
                {
                    mensaje = "no hay detalle de inventario no se puede grabar ";

                    return false;
                }

                if (MoviInven_Info.listmovi_inve_detalle_Info.Count==0 )
                {
                    mensaje = "no hay detalle de inventario no se puede grabar / o No ha seleccionado un item del Detalle ";
                    return false;
                }

                          
                if (MoviInven_Info.IdMovi_inven_tipo == 0 || MoviInven_Info.IdEmpresa == 0 || MoviInven_Info.IdSucursal == 0 || MoviInven_Info.IdBodega ==0)
                {
                    mensaje = "no hay tipo de movimiento o  idEmpresa o IdSucursal o IdBodega de inventario no se puede grabar ";
                    return false;
                }

                //validar producto en bodega
                in_producto_x_tb_bodega_Data odata = new in_producto_x_tb_bodega_Data();
                List<in_producto_x_tb_bodega_Info> lista = new List<in_producto_x_tb_bodega_Info>();


                List<decimal> listProductos_a_buscar= new List<decimal>();
                foreach (var item in MoviInven_Info.listmovi_inve_detalle_Info)
                {
		            listProductos_a_buscar.Add(item.IdProducto);
                }

                if (listProductos_a_buscar.Count !=0)
                {

                    lista = odata.Get_List_ProductoxBodegaxSucursal_q_no_existen_en_sucu_bod(MoviInven_Info.IdEmpresa, MoviInven_Info.IdBodega, MoviInven_Info.IdSucursal, listProductos_a_buscar);                  
                    string mensaj = "";
                    
                    if (!odata.GrabaDB(lista, MoviInven_Info.IdEmpresa, ref mensaj))
                            {
                                mensaje = mensaj;
                                return false;
                           }                  
                }


                if (PerBus.Get_Periodo_Esta_Cerrado(MoviInven_Info.IdEmpresa, Convert.ToDateTime(MoviInven_Info.cm_fecha.ToShortDateString()), ref mensaje))
                {
                  mensaje = "no se puede guardar en esta fecha el periodo ya esta cerrado..";
                    return false;
                }

                #endregion

                InfoTipoMoviInven=TipoMoviInvenBus.Get_Info_movi_inven_tipo(MoviInven_Info.IdEmpresa,MoviInven_Info.IdMovi_inven_tipo);

                MoviInven_Info.cm_tipo = InfoTipoMoviInven.cm_tipo_movi;

                #region 'correcion  data'
                    MoviInven_Info.cm_fecha = Convert.ToDateTime(MoviInven_Info.cm_fecha.ToShortDateString());
                    MoviInven_Info.cm_anio = MoviInven_Info.cm_fecha.Year;
                    MoviInven_Info.cm_mes  = MoviInven_Info.cm_fecha.Month;

                    if (MoviInven_Info.cm_tipo == "-") // si es egreso 
                    {
                        foreach (var item in MoviInven_Info.listmovi_inve_detalle_Info)
                        {
                            if (item.dm_cantidad > 0)
                                item.dm_cantidad = item.dm_cantidad * -1;
                            if (item.dm_cantidad_sinConversion > 0)
                                item.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion * -1;
                        }
                    }

                #endregion

                ///grabando cabecera movi inven
                ResGrabar = moviD.GrabarDB(MoviInven_Info, ref idMoviInven, ref  mensaje);

                if (ResGrabar == true)
                {
                    // grabando en detalle
                    in_Producto_data dataProdcuto = new in_Producto_data();
                    foreach (var item in MoviInven_Info.listmovi_inve_detalle_Info)
                    {
                        item.IdEmpresa = MoviInven_Info.IdEmpresa;
                        item.IdSucursal = MoviInven_Info.IdSucursal;
                        item.IdBodega = MoviInven_Info.IdBodega;
                        item.IdMovi_inven_tipo = MoviInven_Info.IdMovi_inven_tipo;
                        item.IdNumMovi = idMoviInven;
                        item.mv_tipo_movi = MoviInven_Info.cm_tipo;
                        item.IdNumMovi = MoviInven_Info.IdNumMovi;                        
                        if (item.IdUnidadMedida == "" || item.IdUnidadMedida == null)
                            item.IdUnidadMedida = dataProdcuto.Get_Info_BuscarProducto(item.IdEmpresa,item.IdProducto).IdUnidadMedida_Consumo;

                        if (item.dm_cantidad_sinConversion == 0)
                            item.dm_cantidad_sinConversion = item.dm_cantidad;

                        if (item.IdUnidadMedida_sinConversion == "" || item.IdUnidadMedida_sinConversion == null)
                            item.IdUnidadMedida_sinConversion = item.IdUnidadMedida;

                        if (item.mv_costo_sinConversion == 0)
                            item.mv_costo_sinConversion = Convert.ToDouble(item.mv_costo);
                    }



                    in_movi_inve_detalle_Data MoviInvenDetB = new in_movi_inve_detalle_Data();
                    List<in_movi_inve_detalle_Info> ListInfoDet_movi_inv = new List<in_movi_inve_detalle_Info>();

                    /////******************************************
                    ///FUNCION DE COSTEO DE INVENTARIO SIEMPRE DEBE DE SER ANTES DE GRABAR EL MOVI INVEN PARA COJER EL STOCK ACTUAL 
                    ListInfoDet_movi_inv = Calcular_Costeo(MoviInven_Info);
                    ///FUNCION DE COSTEO DE INVENTARIO
                    ///************************************************

                    if (MoviInvenDetB.GrabarDB(ListInfoDet_movi_inv, ref mensaje))
                    {
                        if (infoParam.P_Grabar_Items_x_Cada_Movi_Inven==true)
                        {
                            ///// grabndo detalle x Items tabla:in_movi_inve_detalle_x_item
                            in_movi_inve_detalle_x_item_Bus Bus_mov_inv_det_i = new in_movi_inve_detalle_x_item_Bus();
                            Bus_mov_inv_det_i.GrabarDB(ListInfoDet_movi_inv);
                            ////////////////////////////    
                        }

                        /////////////// actualizando el stock por producto y el costo promedio
                        in_producto_x_tb_bodega_Bus _ProducxBodegaBus = new in_producto_x_tb_bodega_Bus();
                        _ProducxBodegaBus.ActualizarStock_x_Bodega_con_moviInven(ListInfoDet_movi_inv, ref mensaje);
                        ///////////////////////////////////////////

                        ///inserto en la tabla de Historico de Costo
                        setInfo_Costo_Historico_Graba(ListInfoDet_movi_inv,MoviInven_Info.cm_fecha);


                        // contabilizando movimiento de inventario **********************************
                        if (InfoTipoMoviInven.Genera_Diario_Contable == true)
                        {
                            if (Esta_Transaccion_Contabiliza == true)
                            {
                                ResContabilizar = Contabilizar(MoviInven_Info, ref mensaje_cbte_cble, ref mensaje);
                                // contabilizando movimiento de inventario 
                            }
                        }
                    }
                }

                return ResGrabar;
                    
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                throw new Exception(mensaje);
            }

        }

       
        
        public List<in_movi_inve_Info> Get_list_Movi_inven_x_despachar(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {
                return moviD.Get_list_Movi_inven_x_despachar(IdEmpresa, IdSucursal, IdBodega);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Movi_inven_x_despachar", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };
            }
        }

        public void setInfo_Costo_Historico_Graba(List<in_movi_inve_detalle_Info> InfoDet, DateTime cm_fecha)
        {
            try
            {
                in_producto_x_tb_bodega_Costo_Historico_Bus BusCostoHis = new in_producto_x_tb_bodega_Costo_Historico_Bus();
                in_producto_x_tb_bodega_Costo_Historico_Info InfoCostoHis = new in_producto_x_tb_bodega_Costo_Historico_Info();
                tb_Calendario_Bus busCalendario = new tb_Calendario_Bus();
                tb_Calendario_Info InfoCalendario = new tb_Calendario_Info();
                string msjError = "";

                InfoCalendario = busCalendario.Get_Info_Calendario(cm_fecha);

                foreach (var item in InfoDet)
                {
                    if (item.mv_tipo_movi == "+")
                    {
                        InfoCostoHis = new in_producto_x_tb_bodega_Costo_Historico_Info();
                        InfoCostoHis.IdEmpresa = item.IdEmpresa;
                        InfoCostoHis.IdSucursal = item.IdSucursal;
                        InfoCostoHis.IdBodega = item.IdBodega;
                        InfoCostoHis.IdProducto = item.IdProducto;
                        InfoCostoHis.IdFecha = InfoCalendario.IdCalendario;
                        InfoCostoHis.Secuencia = item.Secuencia;
                        InfoCostoHis.fecha = cm_fecha;
                        InfoCostoHis.costo = item.Costo_Promedio_x_Producto;
                        InfoCostoHis.Stock_a_la_fecha = item.dm_stock_actu == null ? 0 : Convert.ToDouble(item.dm_stock_actu);
                        InfoCostoHis.Observacion = "IdInv:#" + item.IdNumMovi + " Tip" + item.IdMovi_inven_tipo + " OC:" + item.IdOrdenCompra;

                        BusCostoHis.GuardarDB(InfoCostoHis, ref msjError);
                    }
                }               
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "setInfo_Costo_Historico_Graba", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };

            }
        }

        public List<in_movi_inve_detalle_Info> Calcular_Costeo(in_movi_inve_Info InfoDet)
        {
            try
            {
                List<in_movi_inve_detalle_Info> lstInfo = new List<in_movi_inve_detalle_Info>();
                in_producto_x_tb_bodega_Costo_Historico_Bus busPro_x_Bod_Costo = new in_producto_x_tb_bodega_Costo_Historico_Bus();
                in_producto_x_tb_bodega_Costo_Historico_Info InfoPro_x_Bod_Costo = new in_producto_x_tb_bodega_Costo_Historico_Info();

                double CantiActual = 0;
                double CantiCompra = 0;
                double CostoUlti = 0;
                double CostoCompra = 0;
                double CostoPromedio = 0;
                
                in_producto_x_tb_bodega_Bus Bus_Produ_x_Bodega = new in_producto_x_tb_bodega_Bus();


                foreach (var item in InfoDet.listmovi_inve_detalle_Info)
                {
                    if (item.mv_tipo_movi == "+")
                    {
                        //Obtengo ultimo costo del producto a esa fecha
                        InfoPro_x_Bod_Costo = busPro_x_Bod_Costo.get_UltimoCosto_x_Producto_Bodega(item.IdEmpresa, item.IdSucursal, item.IdBodega, item.IdProducto, InfoDet.cm_fecha);

                        //Lo asigno a una variable
                        CostoUlti = Convert.ToDouble(InfoPro_x_Bod_Costo.costo);

                        //Obtengo la cantidad actual a esa fecha
                        CantiActual= Bus_Produ_x_Bodega.Get_stock_a_fecha_corte(item.IdEmpresa, item.IdSucursal, item.IdBodega, item.IdProducto,InfoDet.cm_fecha);

                        //Asigno la cantidad a ingresar a una variable
                        CantiCompra = item.dm_cantidad;

                        //Asigno el nuevo costo a ingresar a una variable
                        CostoCompra = Convert.ToDouble(item.mv_costo);
                                              
                        //Calculo el costo promedio = ((cantidad a la fecha * ultimo costo a la fecha) + (cantidad a ingresar * costo a ingresar))
                        //                             /(cantidad a la fecha + cantidad a ingresar)
                        double CostoPromedio1 = 0;
                        double CostoPromedio2 = 0;

                        CostoPromedio1=((CantiActual * Math.Round(CostoUlti,6)) + (CantiCompra * Math.Round(CostoCompra,6)));
                        CostoPromedio2 = (CantiActual + CantiCompra);
                        if (CostoPromedio2 == 0)
                            CostoPromedio2 = 2;
                        CostoPromedio = CostoPromedio1 / CostoPromedio2;


                        //NO DEBE CAMBIAR EL COSTO DEL INGRESO DEBE DE SER EL MISMO DEL INGRESO
                        item.Costo_Promedio_x_Producto = Math.Round(CostoPromedio, 6,MidpointRounding.AwayFromZero);
                        item.dm_stock_ante = CantiActual;
                        item.dm_stock_actu = CantiActual + item.dm_cantidad;

                    }
                    lstInfo.Add(item);
                }
                return lstInfo;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Calcular_Costeo", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };

            }
        }

        public Boolean ModificarDB(in_movi_inve_Info prI, ref string mensaje)
        {
            try
            {

                return moviD.ModificarDB(prI, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };

            }

        }

        public Boolean AnularDB(in_movi_inve_Info MoviInvenInfo_a_anular,DateTime Fecha_Anulacion,  ref  string mensaje)
         {
             try
             {

                 in_movi_inve_detalle_Bus MoviInvenDetB = new in_movi_inve_detalle_Bus();
                 in_Parametro_Bus ParanBus_Inven = new in_Parametro_Bus();
                 in_Parametro_Info ParaInve_info = new in_Parametro_Info();
                 in_movi_inven_tipo_Bus Movi_Tipo_Bus= new in_movi_inven_tipo_Bus();
                 in_movi_inven_tipo_Info Movi_Tipo_Info = new in_movi_inven_tipo_Info();
                 List<in_movi_inve_detalle_Info> ListDeta_MoviInve = new List<in_movi_inve_detalle_Info>();
                 ct_Periodo_Bus PerBus = new ct_Periodo_Bus();

                 string mensaje_cbte_cble = "";

                 Fecha_Anulacion = Convert.ToDateTime(Fecha_Anulacion.ToShortDateString());

                 #region "validaciones antes de anular"


                     if (MoviInvenInfo_a_anular.IdEmpresa == 0 || MoviInvenInfo_a_anular.IdSucursal == 0 || MoviInvenInfo_a_anular.IdBodega == 0
                         || MoviInvenInfo_a_anular.IdMovi_inven_tipo == 0 || MoviInvenInfo_a_anular.IdNumMovi == 0)
                     {
                         mensaje = "uno de los PK estan en cero no se puede anular IdEmpresa,IdSucursal,IdBodega,IdMovi_inven_tipo,IdNumMovi...";
                         return false;
                     }


                     if (PerBus.Get_Periodo_Esta_Cerrado(MoviInvenInfo_a_anular.IdEmpresa, Convert.ToDateTime(Fecha_Anulacion.ToShortDateString()), ref mensaje_cbte_cble))
                     {
                         mensaje = "no se puede anular en esta fecha el periodo ya esta cerrado..";
                         return false;                       
                     }


                     MoviInvenInfo_a_anular.IdusuarioUltAnu = param.IdUsuario;
                     MoviInvenInfo_a_anular.Fecha_UltAnu = param.GetDateServer();
                         
                 #endregion

                 if (MoviInvenInfo_a_anular.listmovi_inve_detalle_Info.Count == 0)
                 {
                    ListDeta_MoviInve= MoviInvenDetB.Get_list_Movi_inven_det(MoviInvenInfo_a_anular.IdEmpresa, MoviInvenInfo_a_anular.IdSucursal, MoviInvenInfo_a_anular.IdBodega,
                         MoviInvenInfo_a_anular.IdMovi_inven_tipo, MoviInvenInfo_a_anular.IdNumMovi);

                    MoviInvenInfo_a_anular.listmovi_inve_detalle_Info = ListDeta_MoviInve;
                 }

                 in_movi_inve_Info MoviInven_x_anulacion = new in_movi_inve_Info();

                 decimal IdCbteCble_x_anulacion = 0;
                 int IdTipoCbteCble_x_anulacion = 0;
                                
                 ParaInve_info = ParanBus_Inven.Get_Info_Parametro(param.IdEmpresa);

                 decimal IdMovi_Inven_x_Anu = 0;
                 int _IdMovi_inven_tipo_para_anular = 0;

                 if (MoviInvenInfo_a_anular.cm_tipo == "+") //si voy a anular un ingreso debo realizar un egreso
                 {
                     _IdMovi_inven_tipo_para_anular = (ParaInve_info.IdMovi_Inven_tipo_x_anu_Ing == null) ? 0 : Convert.ToInt32(ParaInve_info.IdMovi_Inven_tipo_x_anu_Ing);
                 }
                 else
                 {
                     _IdMovi_inven_tipo_para_anular = (ParaInve_info.IdMovi_Inven_tipo_x_anu_Egr == null) ? 0 : Convert.ToInt32(ParaInve_info.IdMovi_Inven_tipo_x_anu_Egr);
                 }

                 if (_IdMovi_inven_tipo_para_anular == 0)
                 {
                     mensaje = "no se puede anular no existe tipo de movimiento de inventario para " + ((MoviInvenInfo_a_anular.cm_tipo == "+") ? "Ingreso" : "Egreso");
                     return false;
                 }

                    //_movi_inve_detalle_List_Info
                    //ACTUALIZO LA LISTA DE MOVI INVENT para actualizar si es positivo (ing) lo convirte en negativo (para q actualize como un egr)

                 (from Movi in MoviInvenInfo_a_anular.listmovi_inve_detalle_Info
                    select Movi).ToList().ForEach(varUp => { varUp.dm_cantidad = varUp.dm_cantidad * -1; });
                   
                                  
                   ///////////////////////----------*************************************************************
                   /// creando nuevo movimiento por anulacion de inventario a la fecha de hoy 
             
                    MoviInven_x_anulacion.IdEmpresa = MoviInvenInfo_a_anular.IdEmpresa;
                    MoviInven_x_anulacion.IdSucursal = MoviInvenInfo_a_anular.IdSucursal;
                    MoviInven_x_anulacion.IdBodega = MoviInvenInfo_a_anular.IdBodega;
                    MoviInven_x_anulacion.IdMovi_inven_tipo = _IdMovi_inven_tipo_para_anular;
                    MoviInven_x_anulacion.IdNumMovi = 0;
                    MoviInven_x_anulacion.cm_fecha = MoviInvenInfo_a_anular.cm_fecha.Date;
                    MoviInven_x_anulacion.cm_anio = MoviInven_x_anulacion.cm_fecha.Year;
                    MoviInven_x_anulacion.cm_mes = MoviInven_x_anulacion.cm_fecha.Month;
                    MoviInven_x_anulacion.cm_tipo = (MoviInvenInfo_a_anular.cm_tipo == "+") ? "-" : "+";
                    MoviInven_x_anulacion.co_fecha_aprobacion = null;
                    MoviInven_x_anulacion.CodMoviInven = "ANU";
                    MoviInven_x_anulacion.Estado = "A";
                    MoviInven_x_anulacion.IdUsuario = param.IdUsuario;
                    MoviInven_x_anulacion.ip = param.ip;
                    MoviInven_x_anulacion.nom_pc = param.nom_pc;
                    MoviInven_x_anulacion.cm_observacion = "Movi x Anulacion ,Anula Movi#" + MoviInvenInfo_a_anular.IdNumMovi + " " + MoviInvenInfo_a_anular.cm_observacion;

                 /// detalle de movi inven
                 /// 
                    List<in_movi_inve_detalle_Info> ListMoviInven_x_anulacion_det = new List<in_movi_inve_detalle_Info>();
         
                    foreach (var item in MoviInvenInfo_a_anular.listmovi_inve_detalle_Info)
                        {                       

                           in_movi_inve_detalle_Info MoviInven_x_anulacion_det = new in_movi_inve_detalle_Info();

                            MoviInven_x_anulacion_det.IdEmpresa = MoviInven_x_anulacion.IdEmpresa;
                            MoviInven_x_anulacion_det.IdSucursal = MoviInven_x_anulacion.IdSucursal;
                            MoviInven_x_anulacion_det.IdBodega = MoviInven_x_anulacion.IdBodega;
                            MoviInven_x_anulacion_det.IdMovi_inven_tipo = MoviInven_x_anulacion.IdMovi_inven_tipo;
                            MoviInven_x_anulacion_det.IdNumMovi = 0;
                            MoviInven_x_anulacion_det.Secuencia = item.Secuencia;
                            MoviInven_x_anulacion_det.mv_tipo_movi = (MoviInvenInfo_a_anular.cm_tipo == "+") ? "-" : "+";
                            MoviInven_x_anulacion_det.IdProducto = item.IdProducto;
                            MoviInven_x_anulacion_det.dm_cantidad = MoviInven_x_anulacion_det.mv_tipo_movi == "+" ? Math.Abs(item.dm_cantidad) : Math.Abs(item.dm_cantidad) * -1;  //  la cantidad ya esta contraria al movimiento original por la multiplicacion por -1 anterior 
                            MoviInven_x_anulacion_det.dm_cantidad_sinConversion = MoviInven_x_anulacion_det.mv_tipo_movi == "+" ? Math.Abs(item.dm_cantidad_sinConversion) : Math.Abs(item.dm_cantidad_sinConversion) * -1;
                            MoviInven_x_anulacion_det.dm_stock_ante = item.dm_stock_ante;
                            MoviInven_x_anulacion_det.dm_stock_actu = item.dm_stock_actu;
                            MoviInven_x_anulacion_det.dm_observacion = "Movi x Anulacion ,Anula Movi#" + MoviInvenInfo_a_anular.IdNumMovi + " " + item.dm_observacion;
                            MoviInven_x_anulacion_det.dm_precio = item.dm_precio;
                            MoviInven_x_anulacion_det.mv_costo = item.mv_costo;
                            MoviInven_x_anulacion_det.mv_costo_sinConversion = item.mv_costo_sinConversion;
                            MoviInven_x_anulacion_det.IdUnidadMedida = item.IdUnidadMedida;
                            MoviInven_x_anulacion_det.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                            MoviInven_x_anulacion_det.peso = item.peso;
                            ListMoviInven_x_anulacion_det.Add(MoviInven_x_anulacion_det);

                        }

                    MoviInven_x_anulacion.listmovi_inve_detalle_Info = ListMoviInven_x_anulacion_det;

                 ///grabando el movimiento de inventario por anulacion  pero no se contabilizo para reversar el diario exactamente como se genero 
                    GrabarDB(MoviInven_x_anulacion, ref IdMovi_Inven_x_Anu,ref mensaje_cbte_cble, ref mensaje,false); 
                 /////////////////////////////////////////////////////////
                    MoviInvenInfo_a_anular.IdEmpresa_x_Anu = MoviInven_x_anulacion.IdEmpresa;
                    MoviInvenInfo_a_anular.IdSucursal_x_Anu = MoviInven_x_anulacion.IdSucursal;
                    MoviInvenInfo_a_anular.IdBodega_x_Anu = MoviInven_x_anulacion.IdBodega;
                    MoviInvenInfo_a_anular.IdMovi_inven_tipo_x_Anu = MoviInven_x_anulacion.IdMovi_inven_tipo;
                    MoviInvenInfo_a_anular.IdNumMovi_x_Anu = IdMovi_Inven_x_Anu;
                  
                
                 
                 ////anulando cabecera y detalle de Movi Inven
                    moviD.AnularDB(MoviInvenInfo_a_anular, ref mensaje);
                    MoviInvenDetB.AnularDB(MoviInvenInfo_a_anular.listmovi_inve_detalle_Info, ref mensaje);
                    ////anulando cabecera y detalle de Movi Inven

                 // grabo el movimiento pero no lo contabilizo por que tengo q reversar el diario q genero el movimiento anulado 
                 //
                 ////////////////////////////////////////////////////////////////////////

                  in_movi_inve_x_ct_cbteCble_Bus MoviInve_x_ctecble_bus = new in_movi_inve_x_ct_cbteCble_Bus();
                  in_movi_inve_x_ct_cbteCble_Info MoviInve_x_ctecble_a_anular_info = new in_movi_inve_x_ct_cbteCble_Info();
                 
                 //buscando la relacion contable del movi inven a Anular
                  MoviInve_x_ctecble_a_anular_info = MoviInve_x_ctecble_bus.Get_Info_x_Movi_Inven
                      (MoviInvenInfo_a_anular.IdEmpresa, MoviInvenInfo_a_anular.IdSucursal,
                      MoviInvenInfo_a_anular.IdBodega, MoviInvenInfo_a_anular.IdMovi_inven_tipo,
                      MoviInvenInfo_a_anular.IdNumMovi);

                  /*obteniendo el tipo de comprobante contable para este tipo de movimiento */
                  Movi_Tipo_Info = Movi_Tipo_Bus.Get_Info_movi_inven_tipo(MoviInvenInfo_a_anular.IdEmpresa, _IdMovi_inven_tipo_para_anular);
                  IdTipoCbteCble_x_anulacion = (Movi_Tipo_Info.IdTipoCbte == null) ? 0 : Convert.ToInt32(Movi_Tipo_Info.IdTipoCbte);

                 //reversando el diario del movi inven anulado
                 MoviInve_x_ctecble_bus.Anular_reversar_Diario_x_Movi_Inven(MoviInvenInfo_a_anular.IdEmpresa, MoviInvenInfo_a_anular.IdSucursal,
                                                                            MoviInvenInfo_a_anular.IdBodega, MoviInvenInfo_a_anular.IdMovi_inven_tipo,
                                                                            MoviInvenInfo_a_anular.IdNumMovi, IdTipoCbteCble_x_anulacion, ref  IdCbteCble_x_anulacion);
              

                 //guardando la relacion del diario por reverso versus el Movi inven


                 in_movi_inve_x_ct_cbteCble_Info MoviInve_x_ctecble_relacion_inven_vs_conta_info = new in_movi_inve_x_ct_cbteCble_Info();

                 MoviInve_x_ctecble_relacion_inven_vs_conta_info.IdEmpresa = MoviInven_x_anulacion.IdEmpresa;
                 MoviInve_x_ctecble_relacion_inven_vs_conta_info.IdSucursal = MoviInven_x_anulacion.IdSucursal;
                 MoviInve_x_ctecble_relacion_inven_vs_conta_info.IdBodega = MoviInven_x_anulacion.IdBodega;
                 MoviInve_x_ctecble_relacion_inven_vs_conta_info.IdMovi_inven_tipo = MoviInven_x_anulacion.IdMovi_inven_tipo;
                 MoviInve_x_ctecble_relacion_inven_vs_conta_info.IdNumMovi = IdMovi_Inven_x_Anu;

                 MoviInve_x_ctecble_relacion_inven_vs_conta_info.IdEmpresa_ct = MoviInvenInfo_a_anular.IdEmpresa;
                 MoviInve_x_ctecble_relacion_inven_vs_conta_info.IdTipoCbte = IdTipoCbteCble_x_anulacion;
                 MoviInve_x_ctecble_relacion_inven_vs_conta_info.IdCbteCble = IdCbteCble_x_anulacion;
                 //guardando la relacion contable vs el movi inven
                 MoviInve_x_ctecble_bus.GuardarDB(MoviInve_x_ctecble_relacion_inven_vs_conta_info);


                 //relacion de los detalles
                 in_movi_inve_detalle_x_ct_cbtecble_det_Bus BusMoviInve_x_ctecble_det_relacion_inven_vs_conta = new in_movi_inve_detalle_x_ct_cbtecble_det_Bus();
                 List<in_movi_inve_detalle_x_ct_cbtecble_det_Info> list_movi_inve_detalle_x_ct_cbtecble_det = new List<in_movi_inve_detalle_x_ct_cbtecble_det_Info>();
                 list_movi_inve_detalle_x_ct_cbtecble_det = BusMoviInve_x_ctecble_det_relacion_inven_vs_conta.Get_List_Info_x_Movi_Inven
                                                                                    (MoviInve_x_ctecble_a_anular_info.IdEmpresa, MoviInve_x_ctecble_a_anular_info.IdSucursal, MoviInve_x_ctecble_a_anular_info.IdBodega, MoviInve_x_ctecble_a_anular_info.IdMovi_inven_tipo, MoviInve_x_ctecble_a_anular_info.IdNumMovi);
                 //actualizaco con el nuevo comprobante contable
                 // y guardo
                 foreach (var item in list_movi_inve_detalle_x_ct_cbtecble_det)
                 {
                     item.IdEmpresa_ct = MoviInvenInfo_a_anular.IdEmpresa;
                     item.IdTipoCbte_ct = IdTipoCbteCble_x_anulacion;
                     item.IdCbteCble_ct = IdCbteCble_x_anulacion;

                     item.IdEmpresa_inv = MoviInven_x_anulacion.IdEmpresa;
                     item.IdSucursal_inv = MoviInven_x_anulacion.IdSucursal;
                     item.IdBodega_inv = MoviInven_x_anulacion.IdBodega;
                     item.IdMovi_inven_tipo_inv = MoviInven_x_anulacion.IdMovi_inven_tipo;
                     item.IdNumMovi_inv = MoviInven_x_anulacion.IdNumMovi;

                     BusMoviInve_x_ctecble_det_relacion_inven_vs_conta.GuardarDB(item);
                 }

                 return true;

             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };
             }
         }

        public in_movi_inve_Info Get_Info_Movi_inven_Report(int IdEmpresa, int IdSucursal, int IdBodega,
         int TipoMovi, decimal IdNumMovi)
         {
             try
             {
                    return moviD.Get_list_Movi_inven_Reporte(IdEmpresa, IdSucursal, IdBodega, TipoMovi, IdNumMovi);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_list_Movi_inven_Reporte", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };

             }
           
        }

        public List<in_movi_inve_Info> Get_list_Movi_inven_x_ProdDiariaLagminadosTalme(int idcompany, int idSucursal, int IdBodega, int TipoMovi, decimal IdNumMo)
        {
            try
            {
                return moviD.Get_list_Movi_inven_x_ProdDiariaLagminadosTalme(idcompany, idSucursal, IdBodega, TipoMovi, IdNumMo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_list_Movi_inven_x_ProdDiariaLaminadosTalme", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };

            }
            
        }

        public List<in_movi_inve_Info> Get_list_Movi_inven(int IdEmpresa, int IdSucursal)
        {
            try
            {
                return moviD.Get_list_Movi_inven(IdEmpresa, IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_list_Movi_inven_All", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };
            }

        }

        public in_movi_inve_Info Get_Info_Movi_inven(int IdEmpresa, int IdSucursal, int IdBodega, int TipoMovi, decimal IdNumMovi)
        {
            try
            {
                return moviD.Get_Info_Movi_inven(IdEmpresa, IdSucursal, IdBodega, TipoMovi, IdNumMovi);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_list_Movi_inven_All", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };
            }
        }

        public Boolean Contabilizar(in_movi_inve_Info in_movi_info, ref string mensaje_cbte_cble, ref string mensaje)
        {
            try
            {

                mensaje_cbte_cble = "";
                
                string Observacion_det = "";
                decimal IdNumCbte_IngEgr = 0;
                decimal IdCbte = 0;
                string msg = "";
                Boolean resConta = true;

                



                vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Bus BusMoviInven_det_conta = new vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Bus();
                List<vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Info> listMovi_Inven = new List<vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Info>();

                in_movi_inven_tipo_Bus in_movi_tipo_B = new in_movi_inven_tipo_Bus();
                in_movi_inven_tipo_x_tb_bodega_Bus Bus_movi_tipo_x_Cta_x_Sucursal = new in_movi_inven_tipo_x_tb_bodega_Bus();
                in_movi_inven_tipo_x_tb_bodega_Info Info_movi_tipo_x_Cta_x_Sucursal = new in_movi_inven_tipo_x_tb_bodega_Info();

                in_movi_inven_tipo_Info in_movi_tipo_info = new in_movi_inven_tipo_Info();
                in_Ing_Egr_Inven_det_Info Info_Ing_Egr_Inven_det = new in_Ing_Egr_Inven_det_Info();
                in_Ing_Egr_Inven_det_Bus Bus_Ing_Egr_Inven_det = new in_Ing_Egr_Inven_det_Bus();

                in_Parametro_Bus ParamInven_bus = new in_Parametro_Bus();
                in_Parametro_Info ParamInven_info = new in_Parametro_Info();

                ParamInven_info = ParamInven_bus.Get_Info_Parametro(in_movi_info.IdEmpresa);

                ct_Cbtecble_Info cbt_Info = new ct_Cbtecble_Info();
                ct_Periodo_Bus ct_periodo_B = new ct_Periodo_Bus();

                ct_Cbtecble_Bus CbteBus = new ct_Cbtecble_Bus();

                in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Bus BusSubGx_Cta = new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Bus();
                in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info InfoSubGx_Cta = new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info();
                

                in_movi_tipo_info = in_movi_tipo_B.Get_Info_movi_inven_tipo(in_movi_info.IdEmpresa, in_movi_info.IdMovi_inven_tipo);

                Info_movi_tipo_x_Cta_x_Sucursal = Bus_movi_tipo_x_Cta_x_Sucursal.Get_Info_movi_inven_tipo_x_tb_bodega(in_movi_info.IdEmpresa, in_movi_info.IdSucursal, in_movi_info.IdBodega, in_movi_info.IdMovi_inven_tipo);

                listMovi_Inven = BusMoviInven_det_conta.Get_List_movi_inve_detalle_x_Contabilizar_x_ctacbles(in_movi_info.IdEmpresa, in_movi_info.IdSucursal,
                    in_movi_info.IdBodega,in_movi_info.IdMovi_inven_tipo , in_movi_info.IdNumMovi);

                if (listMovi_Inven.Count() > 0)// solo contabilizar si hay datos a contabilizar
                {
                    Info_Ing_Egr_Inven_det = Bus_Ing_Egr_Inven_det.Get_Info_Ing_Egr_Inven_det_x_Movi_Inven(in_movi_info.IdEmpresa, in_movi_info.IdSucursal, in_movi_info.IdBodega, in_movi_info.IdMovi_inven_tipo, in_movi_info.IdNumMovi);
                    
                    IdNumCbte_IngEgr = (in_movi_info.IdNumMovi_Ing_Egr == 0) ? Info_Ing_Egr_Inven_det.IdNumMovi : in_movi_info.IdNumMovi_Ing_Egr;

                    int IdTipoCbte_Au = 0;

                    IdTipoCbte_Au = (in_movi_tipo_info.IdTipoCbte == null) ? 0 : Convert.ToInt32(in_movi_tipo_info.IdTipoCbte);

                    if (IdTipoCbte_Au == 0)
                    {
                        mensaje = "No se puede contabilizar no hay tipo de cbte cble para este tipo de movimiento";
                        return false;
                    }

                    /* generando la cabecera */
                    cbt_Info = new ct_Cbtecble_Info();
                    cbt_Info.IdEmpresa = param.IdEmpresa;


                    /// este parametro puede q afecte al momento de volver a contabilizar
                    /// 
                    if (ParamInven_info.P_Fecha_para_contabilizacion_ingr_egr == "FEC_ACTUAL")
                        cbt_Info.cb_Fecha = (in_movi_info.Fecha_Transac == null) ? in_movi_info.cm_fecha : Convert.ToDateTime(Convert.ToDateTime(in_movi_info.Fecha_Transac).ToShortDateString());

                    else
                        cbt_Info.cb_Fecha = Convert.ToDateTime(in_movi_info.cm_fecha.ToShortDateString());


                    cbt_Info.IdPeriodo = ct_periodo_B.Get_Info_Periodo(param.IdEmpresa, cbt_Info.cb_Fecha, ref mensaje_cbte_cble).IdPeriodo;
                    cbt_Info.IdTipoCbte = (in_movi_tipo_info.IdTipoCbte == null) ? 0 : Convert.ToInt32(in_movi_tipo_info.IdTipoCbte);
                    cbt_Info.IdUsuario = param.IdUsuario;
                    cbt_Info.IdUsuarioUltModi = param.IdUsuario;
                    cbt_Info.Estado = "A";
                    cbt_Info.Anio = in_movi_info.cm_fecha.Year;
                    cbt_Info.Mes = in_movi_info.cm_fecha.Month;
                    cbt_Info.Mayorizado = "N";
                    cbt_Info.cb_FechaTransac = param.Fecha_Transac;
                    cbt_Info.cb_FechaUltModi = param.Fecha_Transac;

                  



                    /* generando la cabecera */


                    int x = 1;


                    /* generando detalle*/
                    foreach (var item_x_Movi_Inven in listMovi_Inven)
                    {
                        if (item_x_Movi_Inven.mv_costo == 0)
                        {
                            mensaje = "Producto con costo 0: " + item_x_Movi_Inven.nom_producto;
                            return false;
                        }
                        /////////////// contabilizacndo la cuenta de inventario *************************
                        ct_Cbtecble_det_Info _cbteCble_det_info = new ct_Cbtecble_det_Info();

                        item_x_Movi_Inven.dm_cantidad = Math.Abs(item_x_Movi_Inven.dm_cantidad);
                        cbt_Info.cb_Valor = Math.Round(cbt_Info.cb_Valor, 2) + Math.Round(_cbteCble_det_info.dc_Valor, 2);

                        if (item_x_Movi_Inven.mv_tipo_movi == "+") // la cuenta de inventario al debito si es ingreso  del producto 
                            _cbteCble_det_info.dc_Valor = Math.Round(item_x_Movi_Inven.dm_cantidad * item_x_Movi_Inven.mv_costo, 2);
                        else
                            // al credito si es egreso
                            _cbteCble_det_info.dc_Valor = Math.Round(item_x_Movi_Inven.dm_cantidad * item_x_Movi_Inven.mv_costo * -1, 2);

                        

                        Observacion_det = "Ing/Egr#: " + IdNumCbte_IngEgr + " " + item_x_Movi_Inven.nom_tipo_mov_inv + " "
                            + ((item_x_Movi_Inven.dm_observacion.Trim() == "") ? item_x_Movi_Inven.dm_observacion : item_x_Movi_Inven.dm_observacion.Trim())
                            + " Prod: [" + item_x_Movi_Inven.cod_producto + "]/" + item_x_Movi_Inven.nom_producto +  " Inven #MoviInven:" + item_x_Movi_Inven.IdNumMovi;


                        _cbteCble_det_info.dc_Observacion = Observacion_det;


                        _cbteCble_det_info.secuencia = x;
                        x++;
                        _cbteCble_det_info.IdTipoCbte = cbt_Info.IdTipoCbte;
                        _cbteCble_det_info.IdEmpresa = param.IdEmpresa;

                        //CUIDADO PARA CIERTOS CLIENTE PONEN EL MOTIVO SI VA A CAMBIAR ESTO CONSULTAR ANTES DE HACERLO
                        if (item_x_Movi_Inven.IdMotivo_Inv_det != null && item_x_Movi_Inven.IdCtaCble_Inven_x_Motivo_det!=null)//tiene motivo en el detalle
                            {
                                _cbteCble_det_info.IdCtaCble = item_x_Movi_Inven.IdCtaCble_Inven_x_Motivo_det;
                                _cbteCble_det_info.Forma_de_Contabili_x_Inven = eFormas_de_Contabilizar.X_MOTIVO_INV;
                            }
                            else
                            {
                                    if (string.IsNullOrEmpty(item_x_Movi_Inven.IdCtaCble_Inven_x_Prod) == false)
                                    {
                                        _cbteCble_det_info.IdCtaCble = item_x_Movi_Inven.IdCtaCble_Inven_x_Prod;
                                        _cbteCble_det_info.Forma_de_Contabili_x_Inven = eFormas_de_Contabilizar.X_PROD_BOD_X_SUBGR;
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(item_x_Movi_Inven.IdCtaCtble_Inve_x_Bod) == false)
                                        {
                                            _cbteCble_det_info.IdCtaCble = item_x_Movi_Inven.IdCtaCtble_Inve_x_Bod;
                                            _cbteCble_det_info.Forma_de_Contabili_x_Inven = eFormas_de_Contabilizar.X_BODEGA;
                                        }
                                        else
                                        {

                                            _cbteCble_det_info.IdCtaCble = ParamInven_info.IdCtaCble_Inven;
                                            _cbteCble_det_info.Forma_de_Contabili_x_Inven = eFormas_de_Contabilizar.X_PARAM;
                                        }
                                    }
                                
                            }
                    

                        if (string.IsNullOrWhiteSpace(_cbteCble_det_info.IdCtaCble))
                        { _cbteCble_det_info.IdCtaCble = ParamInven_info.IdCtaCble_Inven; }
                            


                        in_movi_inve_detalle_Info Info_Movi_Inven_det = new in_movi_inve_detalle_Info();
                        Info_Movi_Inven_det.IdEmpresa = item_x_Movi_Inven.IdEmpresa;
                        Info_Movi_Inven_det.IdSucursal = item_x_Movi_Inven.IdSucursal;
                        Info_Movi_Inven_det.IdBodega = item_x_Movi_Inven.IdBodega;
                        Info_Movi_Inven_det.IdMovi_inven_tipo = item_x_Movi_Inven.IdMovi_inven_tipo;
                        Info_Movi_Inven_det.IdNumMovi = item_x_Movi_Inven.IdNumMovi;
                        Info_Movi_Inven_det.Secuencia = item_x_Movi_Inven.Secuencia;

                        _cbteCble_det_info.Info_movi_inven_det = Info_Movi_Inven_det;
                        cbt_Info._cbteCble_det_lista_info.Add(_cbteCble_det_info);


                        //************* FIN contabilizacndo la cuenta de inventario *************************


                        //*************  contabilizacndo la cuenta costo  *************************

                        _cbteCble_det_info = new ct_Cbtecble_det_Info();
                        item_x_Movi_Inven.dm_cantidad = Math.Abs(item_x_Movi_Inven.dm_cantidad);

                        if (item_x_Movi_Inven.mv_tipo_movi == "+") // la cuenta costo al credito si es ingreso 
                            _cbteCble_det_info.dc_Valor = Math.Round(item_x_Movi_Inven.dm_cantidad * item_x_Movi_Inven.mv_costo * -1, 2);
                        else
                            _cbteCble_det_info.dc_Valor = Math.Round(item_x_Movi_Inven.dm_cantidad * item_x_Movi_Inven.mv_costo, 2);

                        Observacion_det = "";
                        Observacion_det = "Ing/Egr#: " + IdNumCbte_IngEgr + " " + item_x_Movi_Inven.nom_tipo_mov_inv + " "
                            + ((item_x_Movi_Inven.dm_observacion.Trim() == "") ? item_x_Movi_Inven.dm_observacion : item_x_Movi_Inven.dm_observacion.Trim())
                            + " Prod: [" + item_x_Movi_Inven.cod_producto + "]/" + item_x_Movi_Inven.nom_producto + " Costo #MoviInven:" + item_x_Movi_Inven.IdNumMovi;


                        _cbteCble_det_info.dc_Observacion = Observacion_det;



                        _cbteCble_det_info.secuencia = x;
                        x++;
                        _cbteCble_det_info.IdTipoCbte = cbt_Info.IdTipoCbte;
                        _cbteCble_det_info.IdEmpresa = param.IdEmpresa;

                          //Pregunto si es una transferencia
                        if (ParamInven_info.IdMovi_inven_tipo_egresoBodegaOrigen == in_movi_info.IdMovi_inven_tipo || ParamInven_info.IdMovi_inven_tipo_ingresoBodegaDestino == in_movi_info.IdMovi_inven_tipo)
                        {
                            _cbteCble_det_info.IdCtaCble = ParamInven_info.P_IdCtaCble_transitoria_transf_inven;
                        }  
                        else
                        {

                            #region Costo par movimiento de inventario q no son Transferencias



                            if (item_x_Movi_Inven.es_Inven_o_Consumo == ein_Inventario_O_Consumo.TIC_CONSU)
                            {
                                InfoSubGx_Cta = BusSubGx_Cta.Get_Info_in_subgrupo(item_x_Movi_Inven.IdEmpresa, item_x_Movi_Inven.IdCategoria, item_x_Movi_Inven.IdLinea, item_x_Movi_Inven.IdGrupo
                                            , item_x_Movi_Inven.IdSubGrupo, item_x_Movi_Inven.IdCentro_Costo_x_MoviInv, item_x_Movi_Inven.IdSubCentro_Costo_x_MoviInv);

                                _cbteCble_det_info.IdCtaCble = InfoSubGx_Cta.IdCtaCble;

                            }

                            if (item_x_Movi_Inven.es_Inven_o_Consumo == ein_Inventario_O_Consumo.TIC_INVEN)
                            {

                                if (item_x_Movi_Inven.IdMotivo_Inv_det != null && item_x_Movi_Inven.IdCtaCble_Costo_x_Motivo_det != null)//tienen motivo
                                {
                                    _cbteCble_det_info.IdCtaCble = item_x_Movi_Inven.IdCtaCble_Costo_x_Motivo_det;
                                    _cbteCble_det_info.Forma_de_Contabili_x_Inven = eFormas_de_Contabilizar.X_MOTIVO_INV;
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(item_x_Movi_Inven.IdCtaCble_Costo_x_Prod) == false)
                                    {
                                        _cbteCble_det_info.IdCtaCble = item_x_Movi_Inven.IdCtaCble_Costo_x_Prod;
                                        _cbteCble_det_info.Forma_de_Contabili_x_Inven = eFormas_de_Contabilizar.X_PROD_BOD_X_SUBGR;
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(item_x_Movi_Inven.IdCtaCtble_Costo_x_Bod) == false)
                                        {
                                            _cbteCble_det_info.IdCtaCble = item_x_Movi_Inven.IdCtaCtble_Costo_x_Bod;
                                            _cbteCble_det_info.Forma_de_Contabili_x_Inven = eFormas_de_Contabilizar.X_BODEGA;
                                        }
                                        else
                                        {

                                            if (string.IsNullOrEmpty(item_x_Movi_Inven.IdCtaCble_Costo_x_Motivo) == false)
                                            {
                                                _cbteCble_det_info.IdCtaCble = item_x_Movi_Inven.IdCtaCble_Costo_x_Motivo;
                                                _cbteCble_det_info.Forma_de_Contabili_x_Inven = eFormas_de_Contabilizar.X_MOTIVO_INV;
                                            }
                                            else
                                            {
                                                _cbteCble_det_info.IdCtaCble = ParamInven_info.IdCtaCble_CostoInven;
                                                _cbteCble_det_info.Forma_de_Contabili_x_Inven = eFormas_de_Contabilizar.X_PARAM;
                                            }


                                        }

                                    }
                                }


                            }


                            #endregion

                        }

                       



                        if (string.IsNullOrWhiteSpace(_cbteCble_det_info.IdCtaCble))
                        { _cbteCble_det_info.IdCtaCble = ParamInven_info.IdCtaCble_CostoInven; }

                        _cbteCble_det_info.IdCentroCosto = item_x_Movi_Inven.IdCentro_Costo_x_MoviInv;
                        _cbteCble_det_info.IdCentroCosto_sub_centro_costo = item_x_Movi_Inven.IdSubCentro_Costo_x_MoviInv;
                        _cbteCble_det_info.IdPunto_cargo = item_x_Movi_Inven.IdPunto_cargo;
                        _cbteCble_det_info.IdPunto_cargo_grupo = item_x_Movi_Inven.IdPunto_cargo_grupo;


                        Info_Movi_Inven_det = new in_movi_inve_detalle_Info();
                        Info_Movi_Inven_det.IdEmpresa = item_x_Movi_Inven.IdEmpresa;
                        Info_Movi_Inven_det.IdSucursal = item_x_Movi_Inven.IdSucursal;
                        Info_Movi_Inven_det.IdBodega = item_x_Movi_Inven.IdBodega;
                        Info_Movi_Inven_det.IdMovi_inven_tipo = item_x_Movi_Inven.IdMovi_inven_tipo;
                        Info_Movi_Inven_det.IdNumMovi = item_x_Movi_Inven.IdNumMovi;
                        Info_Movi_Inven_det.Secuencia = item_x_Movi_Inven.Secuencia;

                        _cbteCble_det_info.Info_movi_inven_det = Info_Movi_Inven_det;
                        cbt_Info._cbteCble_det_lista_info.Add(_cbteCble_det_info);

                    }

                    //SE CAIA XQ LA VISTA NO TRAE NOMBRE DE SUCURSAL NI DE BODEGA
                    cbt_Info.cb_Observacion = "Ing/Egr#: " + IdNumCbte_IngEgr + " " + in_movi_tipo_info.tm_descripcion + " "
                           + ((in_movi_info.cm_observacion.Trim() == "") ? Observacion_det : in_movi_info.cm_observacion.Trim())
                           + " Suc:" + in_movi_info.IdSucursal.ToString() + " Bod:" + in_movi_info.IdBodega.ToString() +
                           " #MoviInve:" + in_movi_info.IdNumMovi;


                    //// grabando encontabilidad

                    


                    resConta = CbteBus.GrabarDB(cbt_Info, ref IdCbte, ref msg);


                    //// grabando tabla intermedia de relacion contable

                    if (resConta == true)
                    {
                        in_movi_inve_x_ct_cbteCble_Info Info_movi_inv_x_cbcble = new in_movi_inve_x_ct_cbteCble_Info();
                        in_movi_inve_x_ct_cbteCble_Bus Bus_movi_inv_x_cbble = new in_movi_inve_x_ct_cbteCble_Bus();

                        Info_movi_inv_x_cbcble.IdEmpresa = in_movi_info.IdEmpresa;
                        Info_movi_inv_x_cbcble.IdBodega = in_movi_info.IdBodega;
                        Info_movi_inv_x_cbcble.IdSucursal = in_movi_info.IdSucursal;
                        Info_movi_inv_x_cbcble.IdNumMovi = in_movi_info.IdNumMovi;
                        Info_movi_inv_x_cbcble.IdMovi_inven_tipo = in_movi_info.IdMovi_inven_tipo;


                        Info_movi_inv_x_cbcble.IdEmpresa_ct = cbt_Info.IdEmpresa;
                        Info_movi_inv_x_cbcble.IdTipoCbte = cbt_Info.IdTipoCbte;
                        Info_movi_inv_x_cbcble.IdCbteCble = IdCbte;
                        Info_movi_inv_x_cbcble.Observacion = "Contabilización " + DateTime.Now.ToString();

                        Bus_movi_inv_x_cbble.GuardarDB(Info_movi_inv_x_cbcble);


                        mensaje_cbte_cble = " Tipo Cbte:" + cbt_Info.IdTipoCbte + " #Cbte:" + IdCbte;

                        in_movi_inve_detalle_x_ct_cbtecble_det_Data Bus_det_inv_x_det_conta = new in_movi_inve_detalle_x_ct_cbtecble_det_Data();

                        foreach (var item2 in cbt_Info._cbteCble_det_lista_info)
                        {

                            in_movi_inve_detalle_x_ct_cbtecble_det_Info Info_det_inv_x_det_conta = new in_movi_inve_detalle_x_ct_cbtecble_det_Info();


                            Info_det_inv_x_det_conta.IdEmpresa_ct = item2.IdEmpresa;
                            Info_det_inv_x_det_conta.IdTipoCbte_ct = item2.IdTipoCbte;
                            Info_det_inv_x_det_conta.IdCbteCble_ct = item2.IdCbteCble;
                            Info_det_inv_x_det_conta.secuencia_ct = item2.secuencia;

                            Info_det_inv_x_det_conta.IdEmpresa_inv = item2.Info_movi_inven_det.IdEmpresa;
                            Info_det_inv_x_det_conta.IdSucursal_inv = item2.Info_movi_inven_det.IdSucursal;
                            Info_det_inv_x_det_conta.IdBodega_inv = item2.Info_movi_inven_det.IdBodega;
                            Info_det_inv_x_det_conta.IdMovi_inven_tipo_inv = item2.Info_movi_inven_det.IdMovi_inven_tipo;
                            Info_det_inv_x_det_conta.IdNumMovi_inv = item2.Info_movi_inven_det.IdNumMovi;
                            Info_det_inv_x_det_conta.Secuencia_inv = item2.Info_movi_inven_det.Secuencia;
                            Info_det_inv_x_det_conta.Secuencial_reg = 0;
                            Info_det_inv_x_det_conta.observacion ="la cta se tomo de:" + item2.Forma_de_Contabili_x_Inven.ToString();

                            Bus_det_inv_x_det_conta.GuardarDB(Info_det_inv_x_det_conta);

                        }


                    }
                }

                mensaje = msg;
                return resConta;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Contabilizar", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };

                
            }

            

            

        }

        public Boolean ReversoContable_MoviInven_sin_moviinven(int IdEmpresa, int IdSucursal, int IdBodega, int IdTipoMovi_Inven, decimal IdNumMovi_Inven, ref string mensaje)
        {
            try
            {

                decimal IdCbteCble_Reverso = 0;
                int IdTipoCbte_CostoInven_Reverso = 0;

                in_Parametro_Bus ParamBus_x_Inven = new in_Parametro_Bus();
                in_Parametro_Info ParamInfo_Inven = new in_Parametro_Info();
                ct_Cbtecble_Bus bus = new ct_Cbtecble_Bus();
                in_movi_inve_x_ct_cbteCble_Info Info_moviInven_x_cbteCble = new in_movi_inve_x_ct_cbteCble_Info();
                in_movi_inve_x_ct_cbteCble_Bus bus_moviInven_x_cbteCble = new in_movi_inve_x_ct_cbteCble_Bus();


                ParamInfo_Inven = ParamBus_x_Inven.Get_Info_Parametro(param.IdEmpresa);
                Info_moviInven_x_cbteCble = bus_moviInven_x_cbteCble.Get_Info_x_Movi_Inven(IdEmpresa, IdSucursal, IdBodega, IdTipoMovi_Inven, IdNumMovi_Inven);

                IdTipoCbte_CostoInven_Reverso =  (ParamInfo_Inven.IdTipoCbte_CostoInven_Reverso == null) ? 0 : Convert.ToInt32(ParamInfo_Inven.IdTipoCbte_CostoInven_Reverso);


                if (IdTipoCbte_CostoInven_Reverso == 0)
                {
                    mensaje = "No se puede reversar falta el parametro Tipo Cbte Reverso ";
                    return false;
                }


                bus.ReversoCbteCble(Info_moviInven_x_cbteCble.IdEmpresa_ct, Info_moviInven_x_cbteCble.IdCbteCble, Info_moviInven_x_cbteCble.IdTipoCbte, IdTipoCbte_CostoInven_Reverso
                    ,ref IdCbteCble_Reverso,ref mensaje,param.IdUsuario);

                return true;
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ReversoContable_MoviInven_sin_moviinven", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };


            }
        }

        public List<in_movi_inve_Info> BusquedasIngCompraBodega(int idempresa, int idsucursal, int idbodega, DateTime FechaIni, DateTime FechaFin)
        {

            try
            {
                  return moviD.Get_List_IngCompra_x_Bodega(idempresa, idsucursal, idbodega,  FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "BusquedasIngCompraBodega", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };

                
              
            }
        }

        public int GetMovimientIngresoEmpresa(int IdEmpresa)
        {
            try
            {
                return moviD.IdMovimientoEmpresa(IdEmpresa);    

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetMovimientIngresoEmpresa", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };
            }
        }

        public DateTime Get_fecha_costeo_recomendada(int IdEmpresa, int IdSucursal)
        {
            try
            {
                return moviD.Get_fecha_costeo_recomendada(IdEmpresa, IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_fecha_costeo_recomendada", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };
            }
        }

        public Boolean AprobarData(int IdEmpresa, int IdSucursal, int IdMoviInven_tipo, decimal IdNumMovi,string signo,string IdUsuario, ref string mensaje)
        {
            try
            {
                return moviD.AprobarData(IdEmpresa, IdSucursal, IdMoviInven_tipo, IdNumMovi, signo, IdUsuario, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ContabilizacionData", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };
            }
        }
        public bool ContabilizacionData(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi, string IdUsuario, ref string mensaje)
        {
            try
            {
                return moviD.ContabilizacionData(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdNumMovi, IdUsuario, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ContabilizacionData", ex.Message), ex) { EntityType = typeof(in_movi_inve_Bus) };
            }
        }

        public in_movi_inve_Bus() { }
    }
}
