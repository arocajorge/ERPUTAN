using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.Importacion;
using Core.Erp.Data.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.General;

namespace Core.Erp.Business.Importacion
{
    public class imp_ordencompra_ext_x_imp_gastosxImport_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        string MensajeError = "";
        imp_ordencompra_ext_x_imp_gastosxImport_Data oData = new imp_ordencompra_ext_x_imp_gastosxImport_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public List<imp_ordencompra_ext_x_imp_gastosxImport_Info> Get_List_ordencompra_ext_x_imp_gastosxImpor(int IdEmpresa, int IdSucursal, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                  return oData.Get_List_ordencompra_ext_x_imp_gastosxImpor(IdEmpresa, IdSucursal,FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "consulta", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_imp_gastosxImport_Bus) };
            
            }

        }

        public Boolean GuardarDB(ref imp_ordencompra_ext_x_imp_gastosxImport_Info info)
        {
            try
            {
                    info.IdUsuario = param.IdUsuario;
                    info.Fecha_Transac = param.Fecha_Transac;
                    info.Fecha_UltMod = param.Fecha_Transac;
                    info.IdUsuarioUltMod = param.IdUsuario;
            
                    return oData.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_imp_gastosxImport_Bus) };
            
            }
    
        }
        public Boolean AnularDB(imp_ordencompra_ext_x_imp_gastosxImport_Info info)
        {
            try
            {
                    info.IdUsuarioUltAnu = param.IdUsuario;
                    info.Fecha_UltAnu = param.Fecha_Transac;
            
                    return oData.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_imp_gastosxImport_Bus) };
            
            }
      
        
        }

        public List<imp_ordencompra_ext_x_imp_gastosxImport_Info> Get_List_ordencompra_ext_x_imp_gastosxImport_Para_Contabilizar(int IdEmpresa, int IdSucursal, decimal IdRegistro)
        {
            try
            {
                 return oData.Get_List_ordencompra_ext_x_imp_gastosxImport_Para_Contabilizar(IdEmpresa, IdSucursal, IdRegistro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaParaContabilizar", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_imp_gastosxImport_Bus) };
            
            }
        }

        private string Get_Descripcion(int IdgastoImportacion) {
            try
            {
                string descripcion = "";
                imp_gastosxImport_Bus BusGastos = new imp_gastosxImport_Bus();
                var Gastos = BusGastos.Get_List_gastosxImport().Find(var => var.IdGastoImp == IdgastoImportacion); ;

                descripcion = Gastos.ga_decripcion;
                return descripcion;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerDescripcion", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_imp_gastosxImport_Bus) };
            
            }
        }

        public Boolean GenerarDiario(int IdEmpresa, int IdSucursal, decimal IdRegistroGasto, ref string msg, ref decimal idCbteCble, ref string CodTipod)
        {
            try{
                #region Declaracion
                ct_Periodo_Info Per_I = new ct_Periodo_Info();
                ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();
                List<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info> ListaDetalle = new List<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info>();
                imp_gastosximport_x_empresa_Data BusGastosXEmpresa = new imp_gastosximport_x_empresa_Data();
                List<imp_gastosximport_x_empresa_Info> lstGastosXEmpresa = new List<imp_gastosximport_x_empresa_Info>();
                List<imp_ordencompra_ext_x_imp_gastosxImport_Info> Lst = new List<imp_ordencompra_ext_x_imp_gastosxImport_Info>();
                imp_ordencompra_ext_x_imp_gastosxImport_Info _Info = new imp_ordencompra_ext_x_imp_gastosxImport_Info();
                int IdTipoCbte = 0;
                ba_Cbte_Ban_Bus BusCbteBanco = new ba_Cbte_Ban_Bus();
                ct_Periodo_Data Per_B = new ct_Periodo_Data();
                List<ct_Cbtecble_det_Info> LstCbteCble = new List<ct_Cbtecble_det_Info>();
                cl_parametrosGenerales_Bus param =   cl_parametrosGenerales_Bus.Instance;
                ba_Cbte_Ban_Info CbteBan_I = new ba_Cbte_Ban_Info();
                string MensajeError = "";
                #endregion
                #region ObtenerGastoImportacion
                Lst = Get_List_ordencompra_ext_x_imp_gastosxImport_Para_Contabilizar(IdEmpresa, IdSucursal, IdRegistroGasto);
                foreach (var item in Lst)
                {
                    _Info.IdOrdenCompraExt = item.IdOrdenCompraExt;
                    _Info.IdProveedor = item.IdProveedor;
                    _Info.IdEmpresa = item.IdEmpresa;
                    _Info.IdSucusal = item.IdSucusal;
                    _Info.IdRegistroGasto = item.IdRegistroGasto;
                    _Info.Observacion = item.Observacion;
                    _Info.IdCtaCble_Banco = item.IdCtaCble_Banco;
                    _Info.IdBanco = item.IdBanco;
                    _Info.CodOrdenCompraExt = item.CodOrdenCompraExt;
                    IdTipoCbte = item.IdTipoCbte;
                    _Info.Fecha = item.Fecha;
                    _Info.IdCtaCble_Importacion = item.IdCtaCble_Importacion;
                 
                    imp_ordencompra_ext_x_imp_gastosxImport_Det_Info Det = new imp_ordencompra_ext_x_imp_gastosxImport_Det_Info();
                    Det.IdGastoImp = item.IdGastoImp;
                    Det.Valor = item.Valor;
                    _Info.ListaGastos.Add(Det);
                }
                #endregion
                Per_I = Per_B.Get_Info_Periodo(_Info.IdEmpresa, _Info.Fecha, ref MensajeError);
                lstGastosXEmpresa = BusGastosXEmpresa.Get_List_gastosximport_x_empresa(IdEmpresa);
                var DatosDiario = from p in _Info.ListaGastos
                                  join w in lstGastosXEmpresa
                                  on new { p.IdGastoImp } equals new { w.IdGastoImp }
                                  select new { p.IdGastoImp, w.IdCtaCble, p.Valor, w.debCre_Provicion , w.debcre_DebBanco};

                if (DatosDiario.ToList().Count != _Info.ListaGastos.Count)
                {
                    msg = "No existen parametros contables verifique que los parametros Contables Esten Llenados correctametne /n Comunicarce Cons sistemas";
                    return false;
                }
                #region CbteCble_Detalle
                foreach (var item in DatosDiario)
                {
                    ct_Cbtecble_det_Info obj = new ct_Cbtecble_det_Info();
                    obj.dc_Observacion = "Cont. X gastos De Imp " + _Info.CodOrdenCompraExt + " / " + _Info.IdOrdenCompraExt + " / " + _Info.Observacion + " / " + Get_Descripcion(item.IdGastoImp);
                    obj.IdCtaCble = item.IdCtaCble;
                    obj.IdTipoCbte = IdTipoCbte;
                    obj.IdEmpresa = _Info.IdEmpresa;
                    if (CodTipod == "DEBBAN")
                    {
                        if (item.debcre_DebBanco == "C")
                        {
                            obj.dc_Valor = item.Valor * -1;
                        }
                        else
                        {
                            obj.dc_Valor = item.Valor;
                        }
                    }
                    if (CodTipod == "PROVI")
                    {
                        if (item.debcre_DebBanco == "D")
                        {
                            obj.dc_Valor = item.Valor * -1;
                        }
                        else
                        {
                            obj.dc_Valor = item.Valor;
                        }
                    
                    }
                    LstCbteCble.Add(obj);
                }
                ct_Cbtecble_det_Info obj2 = new ct_Cbtecble_det_Info();
                double Valor = 0;
                foreach (var item in _Info.ListaGastos)
                {
                    Valor = Valor + item.Valor;
                }
                obj2.dc_Observacion = "Cont. X gastos De Imp " + _Info.CodOrdenCompraExt + " / " + _Info.IdOrdenCompraExt +" / "+ _Info.Observacion +" / Importacion";
                obj2.IdCtaCble = _Info.IdCtaCble_Banco;
                obj2.IdTipoCbte = IdTipoCbte;
                obj2.IdEmpresa = _Info.IdEmpresa;
                ba_Banco_Cuenta_Bus B_banco = new ba_Banco_Cuenta_Bus();
                var Banco = B_banco.Get_Info_Banco_Cuenta(param.IdEmpresa, _Info.IdBanco);
                if (CodTipod == "DEBBAN")
                {
                    obj2.IdCtaCble = Banco.IdCtaCble;
                    obj2.dc_Valor = Valor * -1;
                }
                if (CodTipod == "PROVI")
                {
                    obj2.IdCtaCble = _Info.IdCtaCble_Importacion;
                    obj2.dc_Valor = Valor ;
                }
                LstCbteCble.Add(obj2);
                #endregion
                #region CbteCble
                CbteCble_I.IdEmpresa = _Info.IdEmpresa;
                CbteCble_I.IdTipoCbte = IdTipoCbte;
                CbteCble_I.IdPeriodo = Per_I.IdPeriodo;
                CbteCble_I.cb_Fecha = Convert.ToDateTime(_Info.Fecha.ToShortDateString());
                CbteCble_I.cb_Valor = Valor;
                if (CodTipod == "DEBBAN")
                {
                    CbteCble_I.CodCbteCble = "DEBBAN";
                }
                if (CodTipod == "PROVI")
                {
                    CbteCble_I.CodCbteCble = "PROVI";
                }
                CbteCble_I.cb_Observacion = "Cont. X Imp. " + _Info.CodOrdenCompraExt + " / " + _Info.IdOrdenCompraExt + "Gastos de Importacion. / " + _Info.Observacion;
                CbteCble_I.Secuencia = 0;
                CbteCble_I.Estado = "A";
                CbteCble_I.Anio = _Info.Fecha.Year;
                CbteCble_I.Mes = _Info.Fecha.Month;
                CbteCble_I.IdUsuario = param.IdUsuario;
                CbteCble_I.IdUsuarioUltModi = param.IdUsuario;
                CbteCble_I.cb_FechaTransac = param.GetDateServer();
                CbteCble_I.cb_FechaUltModi = param.GetDateServer();
                CbteCble_I.Mayorizado = "N";
                CbteCble_I._cbteCble_det_lista_info = LstCbteCble;
                // decimal idCbteCble = 0;
                    string cod_CbteCble = "";
                ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();        
                if (CbteCble_B.GrabarDB(CbteCble_I, ref idCbteCble, ref msg) == false) 
                {
                    return false;
                }
                oData.ModificarDB(_Info, idCbteCble);
                #endregion
                if (CodTipod == "DEBBAN")
                {
                    #region CbteBan_I
                    CbteBan_I.IdEmpresa = param.IdEmpresa;
                    CbteBan_I.IdTipocbte = IdTipoCbte;
                    CbteBan_I.IdCbteCble = idCbteCble;
                    CbteBan_I.Cod_Cbtecble = cod_CbteCble;
                    CbteBan_I.IdPeriodo = Per_I.IdPeriodo;
                    CbteBan_I.IdBanco = _Info.IdBanco;
                    CbteBan_I.cb_Fecha = Convert.ToDateTime(_Info.Fecha.ToShortDateString());
                    CbteBan_I.cb_Observacion = _Info.Observacion.Trim();
                    CbteBan_I.cb_Valor = Valor;
                    CbteBan_I.Estado = "A";
                    CbteBan_I.IdUsuario = param.IdUsuario;
                    CbteBan_I.IdUsuario_Anu = param.IdUsuario;
                    CbteBan_I.FechaAnulacion = param.Fecha_Transac;
                    CbteBan_I.Fecha_Transac = param.Fecha_Transac;
                    CbteBan_I.Fecha_UltMod = param.Fecha_Transac;
                    CbteBan_I.IdUsuarioUltMod = param.IdUsuario;
                    CbteBan_I.ip = param.ip;
                    CbteBan_I.nom_pc = param.nom_pc;
                    if (BusCbteBanco.GrabarDB(CbteBan_I,ref MensajeError) == false)
                    {
                        return false;
                    }
                    #endregion
                }
                imp_ordencompra_ext_x_ct_cbtecble_Data DataOrdxCbt = new imp_ordencompra_ext_x_ct_cbtecble_Data();
                imp_ordencompra_ext_x_ct_cbtecble_Info ordCompraxCbte_info = new imp_ordencompra_ext_x_ct_cbtecble_Info();
                ordCompraxCbte_info.ct_IdEmpresa = ordCompraxCbte_info.imp_IdEmpresa = _Info.IdEmpresa;
                ordCompraxCbte_info.imp_IdOrdenCompraExt = _Info.IdOrdenCompraExt;
                ordCompraxCbte_info.imp_IdSucusal = _Info.IdSucusal;
                ordCompraxCbte_info.ct_IdTipoCbte = IdTipoCbte;
                ordCompraxCbte_info.ct_IdCbteCble = idCbteCble;
                ordCompraxCbte_info.TipoReg = "Gast";
                DataOrdxCbt.GuardarDB(ordCompraxCbte_info, ref mensaje);


                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GenerarDiario", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_imp_gastosxImport_Bus) };
            
            }
        }

        public Boolean ACtualizarAnulado(imp_ordencompra_ext_x_imp_gastosxImport_Info info, decimal IdCbteCble)
        {
            try
            {
                   return oData.ActualizarAnulado(info, IdCbteCble);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ACtualizarAnulado", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_imp_gastosxImport_Bus) };
            
            }

        }

        public imp_ordencompra_ext_x_imp_gastosxImport_Info Get_Info_ordencompra_ext_x_imp_gastosxImpor(int IdEmpresa, int IdSucursa, Decimal IdRegistroGasto)
        {
            try
            {
                   return oData.Get_Info_ordencompra_ext_x_imp_gastosxImpor(IdEmpresa, IdSucursa, IdRegistroGasto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_imp_gastosxImport_Bus) };
            
            }

        }

        public List<imp_ordencompra_ext_x_imp_gastosxImport_Info> Get_List_ordencompra_ext_x_imp_gastosxImport(int IdEmpresa, int IdSucursa, Decimal IdOrdenCompraExterna)
        {
            try
            {
                 return oData.Get_List_ordencompra_ext_x_imp_gastosxImport(IdEmpresa, IdSucursa, IdOrdenCompraExterna);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaxImportacion", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_imp_gastosxImport_Bus) };
            
            }

        }
        public List<vwImp_OrdenCompraExt_X_CbteCble_Info> Get_List_OrdenCompraExt_X_CbteCble_x_DiariosXgastos(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, decimal IdRegistrosGasto)
        {
            try
            {
               return oData.Get_List_OrdenCompraExt_X_CbteCble_x_DiariosXgastos(IdEmpresa, IdSucursal, IdOrdenCompra, IdRegistrosGasto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "DiariosXgastos", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_imp_gastosxImport_Bus) };
            
            }

        }

        public Boolean GuardarDB(List<imp_ordencompra_ext_x_imp_gastosxImport_Info> lst, ref string mensaje)
        {
            try
            {
              return oData.GuardarDB(lst, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDBLst", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_imp_gastosxImport_Bus) };
            
            }

        }
        public Boolean EliminarDB(int IdEmpresa, int IdSucursa, Decimal IdOrdenCompraExterna,decimal idRegistroGasto, ref string mensaje)
        {
       
            try
            {
                return oData.EliminarDB(IdEmpresa, IdSucursa, IdOrdenCompraExterna, idRegistroGasto ,ref mensaje );
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_imp_gastosxImport_Bus) };
            
            }

        }
        public Boolean AnularXOG(int IdEmpresa,int IdTipoCbte, decimal IdCbteCble, int IdTipoCbte_Anu, decimal IdCbteCble_Anu, string TipoReg = "AGAST")
        {
            try
            {
                return oData.AnularXOG( IdEmpresa,IdTipoCbte, IdCbteCble, IdTipoCbte_Anu, IdCbteCble_Anu,  param.IdUsuario , param.Fecha_Transac );
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_imp_gastosxImport_Bus) };
            
            }
            
        }
    }
}
