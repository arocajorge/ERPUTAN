using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
    public class fa_cotizacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_cotizacion_data oData = new fa_cotizacion_data();

        public List<fa_cotizacion_info> Get_List_cotizacion_para_facturacion(int IdEmpresa, int IdSucursal, int IdBodega, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                return oData.Get_List_cotizacion_para_facturacion(IdEmpresa,  IdSucursal,  IdBodega, fechaIni, fechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerParaFactura", ex.Message), ex) { EntityType = typeof(fa_cotizacion_Bus) };
            }
        }

        public List<fa_cotizacion_info> Get_List_cotizacion(int idEmpresa, int idSucursalIni, int idSucursalFin, int idBodegaIni, int idBodegaFin
            , DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return oData.Get_List_cotizacion(idEmpresa,idSucursalIni,idSucursalFin,idBodegaIni,idBodegaFin,FechaIni,FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaCotizacion", ex.Message), ex) { EntityType = typeof(fa_cotizacion_Bus) };
            }           
        }

        public Boolean ActualizarEstado(int idempresa, fa_cotizacion_info oInfo)
        {
            try
            {
                return oData.ActualizarEstado(idempresa, oInfo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarEstado", ex.Message), ex) { EntityType = typeof(fa_cotizacion_Bus) };
            }

        }

        public Boolean ValidarObjeto(fa_cotizacion_info inf,ref string  mensajeE)
        {
            try
            {
                mensajeE = "";

                if (inf.lista_detalle.Count == 0)
                {
                    mensajeE = "Objeto no valido no tiene detalle";
                    return false;
                }

                if (inf.IdEmpresa ==0 && inf.IdSucursal==0 && inf.IdBodega==0 )
                {
                    mensajeE = "Uno de los PK del objeto estan en cero IdEmpresa=" + inf.IdEmpresa
                         + " IdSucursal=" + inf.IdSucursal + " IdBodega=" + inf.IdBodega;
                    return false;
                }


                if (inf.IdCliente == 0 && inf.IdVendedor == 0 )
                {
                    mensajeE = "Id de cliente o vendedor esta en cero  IdCliente=" + inf.IdCliente
                         + " IdVendedor=" + inf.IdVendedor;
                    return false;
                }


                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarObjeto", ex.Message), ex) { EntityType = typeof(fa_cotizacion_Bus) };             
            }        
        }

        private void ArreglandoObjeto(ref fa_cotizacion_info inf)
        {
            try
            {

                inf.cc_observacion = (inf.cc_observacion == null) ? "" : inf.cc_observacion;
                inf.cc_fecha = Convert.ToDateTime(inf.cc_fecha.ToShortDateString());
                inf.cc_fechaVencimiento = Convert.ToDateTime(inf.cc_fechaVencimiento.ToShortDateString());

                foreach (var item in inf.lista_detalle)
                {
                    item.IdEmpresa = inf.IdEmpresa;
                    item.IdSucursal = inf.IdSucursal;
                    item.IdBodega = inf.IdBodega;
                    item.dc_pagaIva = (item.dc_iva > 0)?"S":"N";
                    item.dc_detallexItems = (item.dc_detallexItems == null) ? "" : item.dc_detallexItems;
                }

                int c = 1;
                foreach (var item in inf.lista_detalle)
                {
                    item.IdEmpresa = inf.IdEmpresa;
                    item.IdSucursal = inf.IdSucursal;
                    item.IdBodega = inf.IdBodega;
                    item.Secuencial = c;
                    c = c + 1;
                }

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ArreglandoObjeto", ex.Message), ex) { EntityType = typeof(fa_cotizacion_Bus) };
                
            }
        }

        public Boolean GrabarDB(fa_cotizacion_info inf, ref decimal IdNumCotizacion, ref string msg)
        {
            try
            {
                Boolean resCab = false;
                Boolean resDet = false;

                ArreglandoObjeto(ref inf);

                if (ValidarObjeto(inf, ref msg)==false)
                {
                    return false;
                }
               resCab= oData.GrabarDB(inf, ref IdNumCotizacion,  ref msg);


               foreach (var item in inf.lista_detalle)
               {
                   item.IdCotizacion = IdNumCotizacion;
               }
               
               //resDet=GuardarDetalle(inf.lista_detalle, ref msg);

                return (resCab && resDet);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(fa_cotizacion_Bus) };
            }
        }

        public Boolean ModificarDB(fa_cotizacion_info inf, ref string msg)
        {
            try
            {
                Boolean resCab = false;
                Boolean resDet = false;

                ArreglandoObjeto(ref inf);

                if (ValidarObjeto(inf, ref msg)==false)
                {
                    return false;
                }



                resCab = oData.ModificarDB(inf, ref msg);
                //resDet = ModificarDetalleDB(inf.lista_detalle, inf, ref msg);

                return (resCab && resDet);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_cotizacion_Bus) };
            }
        }

        public fa_cotizacion_info Get_Info_cotizacio(int IdEmpresa, int idSucursal, int IdBodega, decimal idCotizacion)
        {
            try
            {
                return oData.Get_Info_cotizacion(IdEmpresa,idSucursal,IdBodega,idCotizacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerCabecera", ex.Message), ex) { EntityType = typeof(fa_cotizacion_Bus) };
            }
        }


        public Boolean AnularDB(fa_cotizacion_info inf, ref string mensajeE) 
        {
            try
            {
                return oData.AnularDB(inf, ref mensajeE);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularCotizacionDB", ex.Message), ex) { EntityType = typeof(fa_cotizacion_Bus) };
            }   
        }
    }
}
