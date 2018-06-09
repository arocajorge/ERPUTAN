using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Data.Inventario_Cidersus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Inventario_Cidersus
{
    public class in_movi_inve_detalle_x_Producto_CusCider_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_movi_inve_detalle_x_Producto_CusCider_Data Data = new in_movi_inve_detalle_x_Producto_CusCider_Data();

        public Boolean GuardarDB(List<in_movi_inve_detalle_x_Producto_CusCider_Info> LstInfo, ref string msg)
        {
            try
            {
                return Data.GuardarDB(LstInfo, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
            
            }
        }

        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> ConsultaxMovInvTipo(int idempresa, int idsucursal, int idbodega, decimal idnunmovi, int idinv_movitipo)
        {
            try
            {
                return Data.Get_List_in_movi_inve_detalle_x_Producto_CusCider(idempresa, idsucursal, idbodega, idnunmovi, idinv_movitipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaxMovInvTipo", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
            
            }
        
        
        }

        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> ConsultaxMovInvTipo(int idempresa, int idsucursal, int idbodega, decimal idnunmovi, int idinv_movitipo, decimal IdProducto)
        {
            try
            {
                return Data.Get_List_in_movi_inve_detalle_x_Producto_CusCider(idempresa, idsucursal, idbodega, idnunmovi, idinv_movitipo, IdProducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaxMovInvTipo", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
            
            }


        }

         public List<in_movi_inve_detalle_x_Producto_CusCider_Info> TraeCodBarraxProd(int idempresa, decimal idproducto)
        {
            try
            {
                return Data.Get_List_in_movi_inve_detalle_x_Producto_CusCider(idempresa,  idproducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TraeCodBarraxProd", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
            
            }


        }


        public in_movi_inve_detalle_x_Producto_CusCider_Info TraeProducto(string codbarra, int IdEmpresa)
         {
             try
             {
                 return Data.Get_Info_in_movi_inve_detalle_x_Producto_CusCider (codbarra, IdEmpresa);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TraeProducto", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
            
             }


         }

          public in_movi_inve_detalle_x_Producto_CusCider_Info TraeProductoxCodigoBarra(string codbarra, int IdEmpresa)
        {
            try
            {
                return Data.Get_Info_in_movi_inve_detalle_x_Producto_CusCider(codbarra, IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TraeProductoxCodigoBarra", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
            
            }


        }
           public in_movi_inve_detalle_x_Producto_CusCider_Info TraeProductoxCodigoBarra_UltMov(string codbarra, int IdEmpresa,string TipoMovimiento)
        {
            try
            {
                return Data.Get_Info_in_movi_inve_detalle_x_Producto_CusCider_UltMov(codbarra, IdEmpresa, TipoMovimiento);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TraeProductoxCodigoBarraUltMov", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
            
            }


        }
           public List<in_movi_inve_detalle_x_Producto_CusCider_Info> TraeProductoSobrante(int IdTipoMovimiento)
           {
               try
               {
                   return Data.TraeProductoSobrante(IdTipoMovimiento);
               }
               catch (Exception ex)
               {
                   Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                   throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TraeProductoxCodigoBarraUltMov", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };

               }


           }
       

          public List<in_movi_inve_detalle_Info> ConsultaGeneral(in_movi_inve_Info Info)
         {
             try
             {
                 return Data.Get_List_in_movi_inve_detalle( Info);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                 
             }


         }

        public List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> SaldosxItemsxCodBarra(int idempresa, DateTime Fecha, int IdBodega, int IdSucursal)
        {
            try
            {
                return Data.SaldosxItemsxCodBarra(idempresa, Fecha, IdBodega, IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "SaldosxItemsxCodBarra", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                 
            }


        }
        public List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> SaldosxItemsxCodBarra_x_Obra_x_OT(int idempresa, DateTime Fecha, int IdSucursal, int IdBodega, string Codobra_preasignada, decimal IdOrdenTaller_preasignada)
        {
            try
            {
                return Data.SaldosxItemsxCodBarra_x_Obra_x_OT(idempresa, Fecha, IdSucursal, IdBodega, Codobra_preasignada, IdOrdenTaller_preasignada);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "SaldosxItemsxCodBarra", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };

            }


        }
        public List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> SaldosxItemsxCodBarra_x_Obra(int idempresa, DateTime Fecha, int IdSucursal, int IdBodega, string Codobra_preasignada)
        {
            try
            {
                return Data.SaldosxItemsxCodBarra_x_Obra(idempresa, Fecha, IdSucursal, IdBodega, Codobra_preasignada);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "SaldosxItemsxCodBarra", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };

            }


        }


        public List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> SaldosxItemsxCodBarraxOT(int idempresa, DateTime Fecha, int IdSucursal, int IdBodega, string ot_Codobra, decimal ot_IdOrdenTaller)
        {
            try
            {
                return Data.SaldosxItemsxCodBarraxOT(idempresa, Fecha, IdSucursal, IdBodega,ot_Codobra,ot_IdOrdenTaller);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "SaldosxItemsxCodBarra", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };

            }


        }
         public vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info SaldosxItemsxCodBarra(in_movi_inve_detalle_x_Producto_CusCider_Info Info  )
        {
            try
            {
                return Data.SaldosxItemsxCodBarra(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "SaldosxItemsxCodBarra", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                 
            }


        }

        public List<in_movi_inve_detalle_Info> ValidarProdxCodBarra(List<in_movi_inve_detalle_Info> LstMovDet)
        {
            try
            {
                return Data.ValidarProdxCodBarra(LstMovDet);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarProdxCodBarra", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                 
            }


        }

        public void GenerarRpt(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi,  string IdUsuario, string nom_pc)
        {
            try
            {
                Data.GenerarRpt( IdEmpresa,  IdSucursal,  IdBodega,  IdMovi_inven_tipo,  IdNumMovi,  IdUsuario,  nom_pc);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GenerarRpt", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                                 
            }
        }


         public List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> ObtenerMateriaPrima(int IdEmpresa, int Idsucursal, int Idbodega, int ot_IdSucursal,  decimal ot_IdOrdenTaller, string ot_Codobra, int ot_IdEmpresa)
        {
            try
            {
                return Data.ObtenerMateriaPrima(IdEmpresa, Idsucursal, Idbodega, ot_IdSucursal, ot_IdOrdenTaller, ot_Codobra, ot_IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerMateriaPrima", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                  
            }
            
        
        }

         public Boolean AnularDB(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNumMovi, int IdMovi_inven_tipo, ref  string msg)
         {

             try
             {
                 return Data.AnularDB(IdEmpresa, IdSucursal, IdBodega, IdNumMovi, IdMovi_inven_tipo, ref  msg);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                 
             }
         }


         public List<in_movi_inve_detalle_x_Producto_CusCider_Info> ObtenerProductosxEtapa(in_movi_inve_detalle_x_Producto_CusCider_Info Item)
         {
             try
             {
               return Data.ObtenerProductosxEtapa(Item);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerProductosxEtapa", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                 
             }
  
         }

         public List<vwIn_Movi_Inven_CusCider_Cab_Info> ConsultaMovimientos(int idempresa, int idsucursal, int idbodega, decimal idnumMovi, int idMoviTipo)
         {
             try
             {
                 return Data.ConsultaMovimientos(idempresa, idsucursal, idbodega, idnumMovi, idMoviTipo);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaMovimientos", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                 
             }


         }

         public List<vwIn_Movi_Inven_x_TI_CusCider_Cab_Info> ConsultaMovimienosxEnsamblado(decimal en_IdEnsamblado, int en_idsucursal, int en_IdEmpresa)
         {
             try
             {
                 return Data.ConsultaMovimienosxEnsamblado(en_IdEnsamblado, en_idsucursal, en_IdEmpresa);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaMovimienosxEnsamblado", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                 
             }


         }


         public List<vwIn_Movi_Inven_x_TI_CusCider_Cab_Info> ConsultaMovimienosxCtrlProd(decimal IdControlProd, int IdSucursal, int IdEmpresa, ref string msg)
        {
            try
            {
                return Data.ConsultaMovimienosxCtrlProd(IdControlProd,  IdSucursal,  IdEmpresa,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaMovimienosxCtrlProd", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                 
            }


        } 

        public List<vwIn_Movi_Inven_x_TI_CusCider_Cab_Info> ConsultaMovimienosxConversion(int IdEmpresa, decimal IdConversion, ref string msg)
        {
            try
            {
                return Data.ConsultaMovimienosxConversion(IdEmpresa , IdConversion , ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaMovimienosxConversion", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                 
            }


        } 


        
        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> ConsultaSaldosxCtrlProd(int IdEmpresa, int et_IdEmpresa, int et_IdEtapa, int et_IdProcesoProductivo,
         int ot_IdEmpresa, int ot_IdSucursal, string ot_CodObra, decimal ot_IdOrdenTaller)
        {

            try
            {

                return Data.ConsultaSaldosxCtrlProd( IdEmpresa,  et_IdEmpresa,  et_IdEtapa,  et_IdProcesoProductivo,
                        ot_IdEmpresa,  ot_IdSucursal,  ot_CodObra,  ot_IdOrdenTaller);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaSaldosxCtrlProd", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                 
            }


        }



        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> ConsultaSaldosxDespachoxObra(int IdEmpresa, int IdSucursal, int Idbodega, string IdObra)
        {
            try
            {
                return Data.ConsultaSaldosxDespachoxObra(IdEmpresa, IdSucursal, Idbodega, IdObra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaSaldosxDespachoxObra", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                
            }

        }



        public List<vwprd_Saldos_x_Req_x_OT_x_Consumo_Info> DisponiblesxReqOt(int ot_IdEmpresa, string ot_CodObra, int ot_IdSucursal, decimal ot_IdOrdenTaller,
           ref string msg)
        {
            try
            {
                return Data.DisponiblesxReqOt( ot_IdEmpresa, ot_CodObra,
                     ot_IdSucursal,ot_IdOrdenTaller, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "DisponiblesxReqOt", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                
            }

        }

        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> ReimpresionCodigoBarra(string CodigoBarra, int idempresa)
        {
            try
            {
                return Data.ReimpresionCodigoBarra(CodigoBarra, idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ReimpresionCodigoBarra", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                
            }


        }

        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> ImpresionCBProductoTerminado(int idempresa, int IdSucursal, int IdEmsamblado)
        {
            try
            {
                return Data.ImpresionCBProductoTerminado(idempresa, IdSucursal, IdEmsamblado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ImpresionCBProductoTerminado", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                
            }
        }
        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> GetConsUltaProductoCortados(int idempresa, int IdSucursal, int IdBodega, int IdTipoMov, int IdNumMov)
        {
            try
            {
                return Data.GetConsUltaProductoCortados(idempresa, IdSucursal, IdBodega, IdTipoMov, IdNumMov);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetConsUltaProductoCortados", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                
            }


        }


        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> ReimpresionCodigoBarra( int idempresa, DateTime Finicio, DateTime Ffin, int IdBodega, int IdSucursal, int CodProducto)
        {
            try
            {
                return Data.ReimpresionCodigoBarra(idempresa, Finicio, Ffin, IdBodega, IdSucursal, CodProducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ReimpresionCodigoBarra", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                
            }


        }



        public in_movi_inve_detalle_x_Producto_CusCider_Info Obtener_Saldo_x_Prod_x_Fecha(int idcompany, DateTime Fecha, int IdSucursal
          , int IdBodega, decimal IdPrdoducto, string CodigoBarra, ref string msg) {
              try
              {
                  return Data.Obtener_Saldo_x_Prod_x_Fecha(idcompany, Fecha, IdSucursal, IdBodega, IdPrdoducto, CodigoBarra, ref msg);
              }
              catch (Exception ex)
              {
                  Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                  throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Saldo_x_Prod_x_Fecha", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                
              }
        }


        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> Obtener_Kardex_x_Prod_x_Fecha(int idcompany, DateTime FechaIni, DateTime FechaFin, int IdSucursal
            , int IdBodega, decimal IdProducto, string CodigoBarra, ref string msg) {
                try
                {
                    return Data.Obtener_Kardex_x_Prod_x_Fecha(idcompany,  FechaIni,  FechaFin,  IdSucursal
            ,  IdBodega,  IdProducto,  CodigoBarra, ref  msg);
                }
                catch (Exception ex)
                {
                    Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                    throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Kardex_x_Prod_x_Fecha", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                
                }
        }


        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> Obtener_CodBarrasReimpresion(int idcompany, DateTime FechaIni, DateTime FechaFin, int IdSucursal
           , int IdBodega, decimal IdProducto, int IdMovi_inven_tipo, string CodigoBarra, ref string msg)
        {
            try
            {
                return Data.Obtener_CodBarrasReimpresion(idcompany, FechaIni, FechaFin, IdSucursal
        , IdBodega, IdProducto,  IdMovi_inven_tipo, CodigoBarra, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_CodBarrasReimpresion", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                
            }
        }


        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> Obtener_CodBarrasReimpresion(int idcompany, DateTime FechaIni, DateTime FechaFin, int IdSucursal
           , int IdBodega, decimal IdProducto, int IdMovi_inven_tipo, decimal IdNumMovi, string CodigoBarra, ref string msg)
        {
            try
            {
                return Data.Obtener_CodBarrasReimpresion(idcompany, FechaIni, FechaFin, IdSucursal
        , IdBodega, IdProducto, IdMovi_inven_tipo, IdNumMovi, CodigoBarra, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_CodBarrasReimpresion", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                
            }
        }

        public List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> ObtenerMateriaPrima(int IdEmpresa, int Idsucursal, int Idbodega, int IdObra, int IdOrdenTaller)
        {
            try
            {
                return Data.ObtenerMateriaPrima(IdEmpresa, Idsucursal, Idbodega, IdObra, IdOrdenTaller);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerMateriaPrima", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                
            }
        }
    //nuevo




        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> GetKardexConsultaCidersus(int IdEmpresa, int IdSucursal, int IdBodega, int IdProducto, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return Data.GetKardexConsultaCidersus(IdEmpresa, IdSucursal, IdBodega, IdProducto, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetKardexConsultaCidersus", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
                
            }
        }

        public Boolean ActualizarCodObra_preasignada(in_movi_inve_detalle_x_Producto_CusCider_Info Info, ref string msg)
        {
            try
            {
                return Data.ActualizarCodObra_preasignada(Info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarEstadoAprob", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
            }
        }

        public Boolean LiberarMP_de_Obra_preasignada(in_movi_inve_detalle_x_Producto_CusCider_Info Info)
        {
            try
            {
                return Data.LiberarMP_de_Obra_preasignada(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarEstadoAprob", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_Producto_CusCider_Bus) };
            }
        }

    }
}
