using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.Importacion;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Bancos;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;


namespace Core.Erp.Business.Importacion
{
    public class imp_ordencompra_ext_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        imp_ordencompra_ext_Data oData = new imp_ordencompra_ext_Data();
        cl_parametrosGenerales_Bus Param = cl_parametrosGenerales_Bus.Instance;


        public Boolean AnularDB(imp_ordencompra_ext_Info Info)
        {
            try
            {
                    Info.IdUsuarioUltAnu = Param.IdUsuario;
                    Info.Fecha_UltAnu = Param.Fecha_Transac;
                    Info.nom_pc = Param.nom_pc;
                    Info.ip = Param.ip;

                //    return oData.Anular(Info);
                    oData.AnularDB(Info);


                    imp_ordencompra_ext_x_ct_cbtecble_Bus _BusImpxCbte = new imp_ordencompra_ext_x_ct_cbtecble_Bus();
                    ct_Cbtecble_Bus Buscbte = new ct_Cbtecble_Bus();
                    cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

                    imp_Parametros_Info ParemtrosImportacion = new imp_Parametros_Info();
                    imp_Parametros_Bus BusParametros = new imp_Parametros_Bus();

                    ParemtrosImportacion = BusParametros.Get_Info_Parametros(param.IdEmpresa);

                    imp_ordencompra_ext_x_ct_cbtecble_Info ordCompraxCbte_info = new imp_ordencompra_ext_x_ct_cbtecble_Info();
                    imp_ordencompra_ext_x_ct_cbtecble_Bus DataOrdxCbt = new imp_ordencompra_ext_x_ct_cbtecble_Bus();
                 
                    if (Info.GenDiarioTipImpo == true)
                    {
                        decimal IdComprobanteAnulado = 0;
                        string msj = "";
                        var cbte = _BusImpxCbte.Get_Info_ordencompra_ext_x_ct_cbtecble(param.IdEmpresa, Info.IdSucusal, Info.IdOrdenCompraExt);
                        Buscbte.ReversoCbteCble(param.IdEmpresa, cbte.ct_IdCbteCble, ParemtrosImportacion.IdTipoCbte_DiarioFob, ParemtrosImportacion.IdTipoCbte_DiarioFob_Anul, ref IdComprobanteAnulado, ref msj, param.IdUsuario, Info.MotiAnula);

                        ordCompraxCbte_info.ct_IdEmpresa = ordCompraxCbte_info.imp_IdEmpresa = Info.IdEmpresa;
                        ordCompraxCbte_info.imp_IdOrdenCompraExt = Info.IdOrdenCompraExt;
                        ordCompraxCbte_info.imp_IdSucusal = Info.IdSucusal;
                        ordCompraxCbte_info.ct_IdTipoCbte = ParemtrosImportacion.IdTipoCbte_DiarioFob_Anul;
                        ordCompraxCbte_info.ct_IdCbteCble = IdComprobanteAnulado;
                        ordCompraxCbte_info.TipoReg = "FOB";
                        DataOrdxCbt.GuardarDB(ordCompraxCbte_info, ref msj);
                    }

                    return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_Bus) };
            
            }
          
        }
       
        public Boolean GuardarDB(imp_ordencompra_ext_Info Info, ref decimal IdOrdeExte)
        {
            try
            {
                Info.IdUsuario = Param.IdUsuario;
                Info.IdUsuarioUltMod = Param.IdUsuario;
                Info.Fecha_UltMod = Param.Fecha_Transac;
                Info.nom_pc = Param.nom_pc;
                Info.ip = Param.ip;
                return oData.GuardarDB(Info, ref IdOrdeExte);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_Bus) };
            
            }

        }

        public List<imp_ordencompra_ext_Info> Get_List_ordencompra_ext(int idempresa, int idSucursal, DateTime FechaIn, DateTime FechaFin)
        {
            try
            {
                 return oData.Get_List_ordencompra_ext(idempresa, idSucursal, FechaIn, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsulGenera", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_Bus) };
            
            }

        }
 
        public Boolean ModificarDB(imp_ordencompra_ext_Info Info)
        {
            try
            {
                Info.IdUsuarioUltMod = Param.IdUsuario;
                Info.Fecha_UltMod = Param.Fecha_Transac;
                Info.nom_pc = Param.nom_pc;
                Info.ip = Param.ip;

               // return oData.Actualizar(Info);
                oData.ModificarDB(Info);

                imp_ordencompra_ext_x_ct_cbtecble_Bus _BusImpxCbte = new imp_ordencompra_ext_x_ct_cbtecble_Bus();
                ct_Cbtecble_Bus Buscbte = new ct_Cbtecble_Bus();
                imp_ordencompra_ext_Bus BUS = new imp_ordencompra_ext_Bus();
                cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
                imp_Parametros_Info ParemtrosImportacion = new imp_Parametros_Info();
                imp_Parametros_Bus BusParametros = new imp_Parametros_Bus();

                ParemtrosImportacion = BusParametros.Get_Info_Parametros(param.IdEmpresa);

                if (Info.GenDiarioTipImpo == true)
                {
                    if (Info.FOB != Info.setFOB)
                    {
                        string msj = "";
                        decimal IdComprobanteAnulado = 0;
                        var cbte = _BusImpxCbte.Get_Info_ordencompra_ext_x_ct_cbtecble(param.IdEmpresa, Info.IdSucusal, Info.IdOrdenCompraExt, "FOB");

                        if (cbte != null)
                        {
                            if (Buscbte.ReversoCbteCble(param.IdEmpresa, cbte.ct_IdCbteCble, ParemtrosImportacion.IdTipoCbte_DiarioFob, ParemtrosImportacion.IdTipoCbte_DiarioFob_Anul, ref IdComprobanteAnulado, ref msj, param.IdUsuario, "Anulacion por Actualizacion") == false)
                            {
                               // MessageBox.Show(msj);
                                Info.msgReversoCbteCble = msj;
                            }
                        }

                        imp_ordencompra_ext_x_ct_cbtecble_Info ordCompraxCbte_info = new imp_ordencompra_ext_x_ct_cbtecble_Info();
                        imp_ordencompra_ext_x_ct_cbtecble_Bus DataOrdxCbt = new imp_ordencompra_ext_x_ct_cbtecble_Bus();

                        ordCompraxCbte_info.ct_IdEmpresa = ordCompraxCbte_info.imp_IdEmpresa = param.IdEmpresa;
                        ordCompraxCbte_info.imp_IdOrdenCompraExt = Info.IdOrdenCompraExt;
                        ordCompraxCbte_info.imp_IdSucusal = Info.IdSucusal;
                        ordCompraxCbte_info.ct_IdTipoCbte = ParemtrosImportacion.IdTipoCbte_DiarioFob_Anul;
                        ordCompraxCbte_info.ct_IdCbteCble = IdComprobanteAnulado;
                        ordCompraxCbte_info.TipoReg = "FOB";
                        DataOrdxCbt.GuardarDB(ordCompraxCbte_info, ref msj);

                        //var idproveedor = gridLookUpEditProveedor.EditValue;
                        //var IdCtaCble_CXP = ((List<cp_proveedor_Info>)gridLookUpEditProveedor.Properties.DataSource).First(var => var.IdProveedor == Convert.ToDecimal(idproveedor)).IdCtaCble_CXP;
                        if (BUS.GenerarDiarioFOB(param.IdEmpresa, Info.IdSucusal, Info.IdOrdenCompraExt, ref msj, ref IdComprobanteAnulado, Info.IdCtaCble_CXP) == false)
                        { 
                           // MessageBox.Show(msj);
                            Info.msgGenerarDiarioFOB = msj;
                        }
                    }
                }

                return true;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Actualizar", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_Bus) };
            
            }

        }
        
        public Boolean VerificarCodigo(string Codigo, int IdEmpresa)
        {
            try
            {
                  return oData.VerificarCodigo(Codigo, IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarCodigo", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_Bus) };
            
            }
  
        
        }

        public imp_ordencompra_ext_Info Get_Info_ordencompra_ext(int IdEmpresa, string codigoOrdenCompra, int idSucursal)
        {
            try
            {
                   return oData.Get_Info_ordencompra_ext(IdEmpresa, codigoOrdenCompra, idSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "obtenerOrdenCompra", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_Bus) };
            
            }

        }

        public List<imp_ordencompra_ext_Info> Get_List_ordencompra_ext_x_Gastos(int idempresa)
        {
            try
            {
                return oData.Get_List_ordencompra_ext_x_Gastos(idempresa);
            }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsulGeneraGastos", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_Bus) };
            
            }

        }
        
        public List<vwImp_OrdenCompraExt_X_CbteCble_Info> Get_List_DiariosxImportacion(int idempresa, int IdSucursal, Decimal IdOrdenCompra)
        {
            try
            {
              return oData.Get_List_DiariosxImportacion(idempresa, IdSucursal, IdOrdenCompra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "consultaDiariosxImportacion", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_Bus) };
            
            }        
        }

        public Boolean GenerarDiarioFOB(int IdEmpresa, int IdSucursal, decimal IdImportacion, ref string msg, ref decimal idCbteCble,string idCbteCble_Proveedor) 
        {
            try
            {
                imp_ordencompra_ext_x_ct_cbtecble_Info ordCompraxCbte_info = new imp_ordencompra_ext_x_ct_cbtecble_Info();
                ct_Periodo_Info Per_I = new ct_Periodo_Info();
                ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();
                List<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info> ListaDetalle = new List<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info>();
                imp_gastosximport_x_empresa_Data BusGastosXEmpresa = new imp_gastosximport_x_empresa_Data();
                List<imp_gastosximport_x_empresa_Info> lstGastosXEmpresa = new List<imp_gastosximport_x_empresa_Info>();
                List<imp_ordencompra_ext_x_imp_gastosxImport_Info> Lst = new List<imp_ordencompra_ext_x_imp_gastosxImport_Info>();
                ba_Cbte_Ban_Bus BusCbteBanco = new ba_Cbte_Ban_Bus();
                ct_Periodo_Data Per_B = new ct_Periodo_Data();
                List<ct_Cbtecble_det_Info> LstCbteCble = new List<ct_Cbtecble_det_Info>();
                cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
                ba_Cbte_Ban_Info CbteBan_I = new ba_Cbte_Ban_Info();
                imp_Parametros_Data Data_parametros = new imp_Parametros_Data();
                var tip = Data_parametros.Get_Info_Parametros(IdEmpresa);
                imp_ordencompra_ext_x_ct_cbtecble_Data DataOrdxCbt = new imp_ordencompra_ext_x_ct_cbtecble_Data();
                cp_proveedor_Data _Prove_D = new cp_proveedor_Data();
                imp_ordencompra_ext_Info _Info = oData.Get_Info_ordencompra_ext(IdEmpresa, IdSucursal, IdImportacion);
                string MensajeError = "";
                var proveedor = _Prove_D.Get_Info_Proveedor(param.IdEmpresa, _Info.IdProveedor);
                Per_I = Per_B.Get_Info_Periodo(_Info.IdEmpresa, _Info.ci_fecha,ref MensajeError);
                ct_Cbtecble_det_Info _CbteCble_I = new ct_Cbtecble_det_Info();
                in_categorias_data producto_data = new in_categorias_data();
                //var producto = producto_data.ObtenerObjeto(param.IdEmpresa, _Info.IdCategoria).ca_Categoria;
                var producto = producto_data.Get_List_categorias(0);
                string Observacion = _CbteCble_I.dc_Observacion = proveedor.pr_nombre+".: "+_Info.CodOrdenCompraExt+": //"+IdImportacion+"//"+"Cont. de la  Importacion #" + IdImportacion +
                     @"'\'" + _Info.CodOrdenCompraExt + " Diario FOB" + _Info.ci_Observacion +" : " +producto+". "+_Info.ci_tonelaje+ " T" ;
                _CbteCble_I.IdCtaCble = _Info.IdCtaCble_import;
                _CbteCble_I.IdEmpresa = IdEmpresa;
                _CbteCble_I.IdTipoCbte = tip.IdTipoCbte_DiarioFob;
                _CbteCble_I.dc_Valor = _Info.FOB;
                LstCbteCble.Add(_CbteCble_I);
                ct_Cbtecble_det_Info obj2 = new ct_Cbtecble_det_Info();
                obj2.IdCtaCble = _Info.IdCtaCble_import;
                obj2.dc_Observacion = Observacion;// "Cont. de la  Importacion #" + IdImportacion + @"'\'" + _Info.CodOrdenCompraExt + " Diario FOB" + _Info.ci_Observacion;
                obj2.IdCtaCble = idCbteCble_Proveedor;
                obj2.IdTipoCbte = tip.IdTipoCbte_DiarioFob;
                obj2.IdEmpresa = _Info.IdEmpresa;
                obj2.dc_Valor = _Info.FOB*-1;
                LstCbteCble.Add(obj2);

                CbteCble_I.IdEmpresa = _Info.IdEmpresa;
                CbteCble_I.IdTipoCbte = tip.IdTipoCbte_DiarioFob;
                CbteCble_I.CodCbteCble = "IM";
                CbteCble_I.IdPeriodo = Per_I.IdPeriodo;
                CbteCble_I.cb_Fecha = Convert.ToDateTime(_Info.ci_fecha.ToShortDateString());
                CbteCble_I.cb_Valor = _Info.FOB;
                if (_Info.CodOrdenCompraExt == null || _Info.CodOrdenCompraExt == "") 
                {
                    _Info.CodOrdenCompraExt = "IMP" + IdImportacion;
                }
                CbteCble_I.cb_Observacion = Observacion;
                CbteCble_I.Secuencia = 0;
                CbteCble_I.Estado = "A";
                CbteCble_I.Anio = _Info.ci_fecha.Year;
                CbteCble_I.Mes = _Info.ci_fecha.Month;
                CbteCble_I.IdUsuario = param.IdUsuario;
                CbteCble_I.IdUsuarioUltModi = param.IdUsuario;
                CbteCble_I.cb_FechaTransac = param.GetDateServer();
                CbteCble_I.cb_FechaUltModi = param.GetDateServer();
                CbteCble_I.Mayorizado = "N";
                CbteCble_I._cbteCble_det_lista_info = LstCbteCble;
                ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
                string cod_CbteCble = "";
                
                if (CbteCble_B.GrabarDB(CbteCble_I, ref idCbteCble, ref msg) == false)
                {
                    return false;
                }
                ordCompraxCbte_info.ct_IdEmpresa = ordCompraxCbte_info.imp_IdEmpresa = _Info.IdEmpresa;
                ordCompraxCbte_info.imp_IdOrdenCompraExt = _Info.IdOrdenCompraExt;
                ordCompraxCbte_info.imp_IdSucusal = _Info.IdSucusal;
                ordCompraxCbte_info.ct_IdTipoCbte = tip.IdTipoCbte_DiarioFob;
                ordCompraxCbte_info.ct_IdCbteCble = idCbteCble;
                ordCompraxCbte_info.TipoReg = "FOB";
                DataOrdxCbt.GuardarDB(ordCompraxCbte_info, ref mensaje );

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "consultaDiariosxImportacion", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_Bus) };
            
            }
        }
     
        public Boolean Liquidar(imp_ordencompra_ext_Info Obj , ref string mensaje,Cl_Enumeradores.eTipo_action accion)
        {
            try
            {
                decimal IdCbteLiquidacion = 0;

                ct_Cbtecble_det_Info _detCbteCble_Info = new ct_Cbtecble_det_Info();
                List<ct_Cbtecble_det_Info> LstCbteCble = new List<ct_Cbtecble_det_Info>();
                ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();
                imp_ordencompra_ext_det_Bus ImporDet_bus = new imp_ordencompra_ext_det_Bus();
                List<imp_ordencompra_ext_det_Info> ListInfo_det_Impor = new List<imp_ordencompra_ext_det_Info>();
                in_categorias_data dataCategoria = new in_categorias_data();
                ct_Periodo_Bus Per_B = new ct_Periodo_Bus();
                ct_Periodo_Info Per_I = new ct_Periodo_Info();

                in_Parametro_Data dataInParametro = new in_Parametro_Data();                                                 
                imp_ordencompra_ext_Bus BusImportacion = new imp_ordencompra_ext_Bus();
                ct_Cbtecble_Bus Buscbte = new ct_Cbtecble_Bus();
                imp_ordencompra_ext_x_ct_cbtecble_Bus BusOrdxCbt = new imp_ordencompra_ext_x_ct_cbtecble_Bus();
                ct_cbtecble_Reversado_Bus BusReverso = new ct_cbtecble_Reversado_Bus();
                imp_Parametros_Info tip = new imp_Parametros_Info();
                imp_Parametros_Bus Data_parametros = new imp_Parametros_Bus();
                cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
                imp_ordencompra_ext_x_ct_cbtecble_Info ordCompraxCbte_info = new imp_ordencompra_ext_x_ct_cbtecble_Info();

                tip = Data_parametros.Get_Info_Parametros(param.IdEmpresa);
                
                ordCompraxCbte_info.ct_IdEmpresa = ordCompraxCbte_info.imp_IdEmpresa = param.IdEmpresa;
                ordCompraxCbte_info.imp_IdOrdenCompraExt = Obj.IdOrdenCompraExt;
                ordCompraxCbte_info.imp_IdSucusal = Obj.IdSucusal;

             //   var DiarioLiqui = BusImportacion.consultaDiariosxImportacion(param.IdEmpresa, Obj.IdSucusal, Obj.IdOrdenCompraExt).Last(var => var.TipoReg == "LQUI")             
             //   var CobteLiquidacion = Buscbte.ObtenerObjeto(param.IdEmpresa, DiarioLiqui.ct_IdTipoCbte, DiarioLiqui.IdCbte);
                                
               
                switch (accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        if (Obj.ci_tonelaje == null || Obj.ci_tonelaje == 0)
                    {
                        mensaje = "Error al generar Diario de Importación ya que no se puede dividir el total de liquidación para un valor de tonelaje = 0 ";
                    }
                    else
                    {
                        string cod_CbteCble = "";
                        decimal idCbteCble = 0;
                        string MensajeError = "";

                        cp_proveedor_Data _Prove_D = new cp_proveedor_Data();
                        var proveedor = _Prove_D.Get_Info_Proveedor(param.IdEmpresa, Obj.IdProveedor);

                        Per_I = Per_B.Get_Info_Periodo(Obj.IdEmpresa, Obj.ci_fecha_liquidacion, ref MensajeError);
                    
                        string Observacion = "Cont. x Imp. #" + Obj.CodOrdenCompraExt + "'\'" + Obj.IdOrdenCompraExt + " Liquidacion de Importacion :" + proveedor.pr_nombre + "//" + Obj.ci_Observacion;
                        ListInfo_det_Impor = ImporDet_bus.Get_List_ordencompra_ext_det(Obj);

                        int contItems = ListInfo_det_Impor.Count();

                        foreach (var item in ListInfo_det_Impor)
                        {
                            _detCbteCble_Info = new ct_Cbtecble_det_Info();

                            var Categoria = dataCategoria.Get_Info_categorias(param.IdEmpresa, item.IdCategoria);

                            if (Categoria.IdCtaCtble_Inve == null)
                            {
                                in_Parametro_Info Info_InParametro = new in_Parametro_Info();

                                Info_InParametro = dataInParametro.Get_Info_Parametro(param.IdEmpresa);

                                _detCbteCble_Info.IdCtaCble = Info_InParametro.IdCtaCble_Inven;
                                _detCbteCble_Info.dc_Observacion = "Cta. Ctble tomada de los parámetros de inventario / " + Observacion;
                            }
                            else
                            {
                                _detCbteCble_Info.IdCtaCble = Categoria.IdCtaCtble_Inve;
                                _detCbteCble_Info.dc_Observacion = Observacion;

                            }
                            _detCbteCble_Info.IdEmpresa = param.IdEmpresa;
                            _detCbteCble_Info.IdTipoCbte = tip.IdTipoCbte_DiarioLiquidacion;
                            _detCbteCble_Info.dc_Valor = Convert.ToDouble(item.di_subtotal) + (Obj.TotGastosImp / contItems); // debe
                            LstCbteCble.Add(_detCbteCble_Info);
                        }

                        ct_Cbtecble_det_Info obj2 = new ct_Cbtecble_det_Info();
                        obj2.IdCtaCble = Obj.IdCtaCble_import;
                        obj2.dc_Observacion = Observacion;//"Contabilizacion por Importacion Diario Importacion FOB" + Obj.ci_Observacion;
                        obj2.IdCtaCble = Obj.IdCtaCble_import;
                        obj2.IdTipoCbte = tip.IdTipoCbte_DiarioLiquidacion;
                        obj2.IdEmpresa = Obj.IdEmpresa;
                       
                        obj2.dc_Valor = Obj.TotalLiquidacion * -1; //haber

                        LstCbteCble.Add(obj2);

                        // cabecer ade diario 
                        CbteCble_I.IdEmpresa = param.IdEmpresa;
                        CbteCble_I.IdTipoCbte = tip.IdTipoCbte_DiarioLiquidacion;
                        CbteCble_I.CodCbteCble = "IM";
                        CbteCble_I.IdPeriodo = Per_I.IdPeriodo;                      
                        CbteCble_I.cb_Fecha = Obj.ci_fecha_liquidacion;
                        CbteCble_I.cb_Observacion = Observacion;// "Cont. de la  Importacion #" + Obj.CodOrdenCompraExt + " Diario FOB" + Obj.ci_Observacion + Categoria.ca_Categoria;
                        CbteCble_I.Secuencia = 0;
                        CbteCble_I.Estado = "A";
                        CbteCble_I.Anio = Obj.ci_fecha.Year;
                        CbteCble_I.Mes = Obj.ci_fecha.Month;
                        CbteCble_I.IdUsuario = param.IdUsuario;
                        CbteCble_I.IdUsuarioUltModi = param.IdUsuario;
                        CbteCble_I.cb_FechaTransac = param.GetDateServer();
                        CbteCble_I.cb_FechaUltModi = param.GetDateServer();
                        CbteCble_I.Mayorizado = "N";                      
                        CbteCble_I.cb_Valor = Obj.TotalLiquidacion;
                        CbteCble_I._cbteCble_det_lista_info = LstCbteCble;

                        Buscbte.GrabarDB(CbteCble_I, ref idCbteCble, ref MensajeError);
                        IdCbteLiquidacion = idCbteCble;
                      
                        ordCompraxCbte_info.ct_IdTipoCbte = tip.IdTipoCbte_DiarioLiquidacion;
                        ordCompraxCbte_info.ct_IdCbteCble = idCbteCble;
                        ordCompraxCbte_info.TipoReg = "LQUI";
                        BusOrdxCbt.GuardarDB(ordCompraxCbte_info, ref MensajeError);

                        var DiarioLiqui = BusImportacion.Get_List_DiariosxImportacion(param.IdEmpresa, Obj.IdSucusal, Obj.IdOrdenCompraExt).Last(var => var.TipoReg == "LQUI");
                        var Diario_Reverso = BusReverso.Get_Info_cbtecble_Reversado(param.IdEmpresa, DiarioLiqui.ct_IdTipoCbte, DiarioLiqui.IdCbte);
                        var CobteLiquidacion = Buscbte.Get_Info_CbteCble(param.IdEmpresa, DiarioLiqui.ct_IdTipoCbte, DiarioLiqui.IdCbte, ref mensaje);
                        Obj.CodCbteCble = CobteLiquidacion.CodCbteCble.ToString();

                        return oData.Liquidar(Obj, ref mensaje);
                    
                        }  
                           
                       break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        decimal IdComprobanteAnulado = 0;
                        string msj = "";
                        if (IdCbteLiquidacion == 0)
                        {
                            var DiarioLiqui = BusImportacion.Get_List_DiariosxImportacion(param.IdEmpresa, Obj.IdSucusal, Obj.IdOrdenCompraExt).Last(var => var.TipoReg == "LQUI");
                            var CobteLiquidacion = Buscbte.Get_Info_CbteCble(param.IdEmpresa, DiarioLiqui.ct_IdTipoCbte, DiarioLiqui.IdCbte, ref mensaje);
                            IdCbteLiquidacion = CobteLiquidacion.IdCbteCble;
                        }

                        string motiAnulacion = Obj.motiAnulacion;

                        if (Buscbte.ReversoCbteCble(param.IdEmpresa, IdCbteLiquidacion, tip.IdTipoCbte_DiarioLiquidacion, tip.IdTipoCbte_DiarioLiquidacion_Anul, ref IdComprobanteAnulado, ref msj, param.IdUsuario, motiAnulacion))
                        {
                           // MessageBox.Show("Anulado");
                            mensaje="*** Anulado ***";

                            ordCompraxCbte_info.ct_IdTipoCbte = tip.IdTipoCbte_DiarioLiquidacion_Anul;
                            ordCompraxCbte_info.ct_IdCbteCble = IdComprobanteAnulado;
                            ordCompraxCbte_info.TipoReg = "ALQUI";
                            BusOrdxCbt.GuardarDB(ordCompraxCbte_info, ref msj);                   

                            var DiarioLiqui = BusImportacion.Get_List_DiariosxImportacion(param.IdEmpresa, Obj.IdSucusal, Obj.IdOrdenCompraExt).Last(var => var.TipoReg == "LQUI");
                            var CobteLiquidacion = Buscbte.Get_Info_CbteCble(param.IdEmpresa, DiarioLiqui.ct_IdTipoCbte, DiarioLiqui.IdCbte, ref mensaje);

                            var Diario_Reverso = BusReverso.Get_Info_cbtecble_Reversado(param.IdEmpresa, DiarioLiqui.ct_IdTipoCbte, DiarioLiqui.IdCbte);

                            if (Diario_Reverso.IdTipoCbte_Anu != 0)
                            {
                                var CobteLiquidacionAnulado = Buscbte.Get_Info_CbteCble(param.IdEmpresa, Diario_Reverso.IdTipoCbte_Anu, Diario_Reverso.IdCbteCble_Anu, ref mensaje);

                                Obj.msgAnuladoReverso = "**Anulado ** Reversado Con diario" + "\n" + CobteLiquidacionAnulado.CodCbteCble;                        
                            }
                            return oData.Liquidar(Obj, ref mensaje);
                        }
                                                                                                             
                        break;               
                    default:
                        
                        break;                       
                }
              

                return true;                 
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Liquidar", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_Bus) };
            
            }

        }

        public imp_ordencompra_ext_Info Get_Info_ordencompra_ext(int idempresa, int IdSucursal, Decimal IdOrdenCompra)
        {
            try
            {
              return oData.Get_Info_ordencompra_ext(idempresa, IdSucursal, IdOrdenCompra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsulTarObjeto", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_Bus) };
            
            }

        }

    }
}
