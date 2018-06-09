using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
    public class fa_orden_Desp_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_orden_Desp_Data oDat = new fa_orden_Desp_Data();

        public List<fa_orden_Desp_Info> Get_List_orden_Desp(int idEmpresa, int idSucursalIni, int idSucursalFin, int idBodegaIni, int idBodegaFin
            , DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return oDat.Get_List_orden_Desp(idEmpresa, idSucursalIni, idSucursalFin, idBodegaIni, idBodegaFin, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getlist_OrdenDespachi", ex.Message), ex) { EntityType = typeof(fa_orden_Desp_Bus) };
           
            }
            
        }


        public Boolean ActualizarEstado(int idempresa, fa_orden_Desp_Info oDes)
        {
            try
            {
                  return oDat.ActualizarEstado(idempresa, oDes);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarEstado", ex.Message), ex) { EntityType = typeof(fa_orden_Desp_Bus) };
            }

        }


        public fa_rpt_orden_Desp_Info rpt_orde_Despacho(int idEmpresa, int idSucursalIni, int idSucursalFin, int idBodegaIni, int idBodegaFin
            , DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return oDat.Get_Info_rpt_orde_Despacho(idEmpresa, idSucursalIni, idSucursalFin, idBodegaIni, idBodegaFin, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "rpt_orde_Despacho", ex.Message), ex) { EntityType = typeof(fa_orden_Desp_Bus) };
            }
            
        }


        public Boolean GuardarDB(fa_orden_Desp_Info info, ref decimal IdOrdenDespacho)
        {
            try
            {
                 return oDat.GuardarDB(info,ref IdOrdenDespacho);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_orden_Desp_Bus) };
            }

        }
      
        public Boolean VerificarCodigo(string Codigo, int idempresa)
        {
            try
            {
               return oDat.VerificarCodigo(Codigo,idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarCodigo", ex.Message), ex) { EntityType = typeof(fa_orden_Desp_Bus) };
            }

        }

        public List<fa_orden_Desp_Info> CargarOrdenDespachoPorCliente(int idEmpresa, int idSucursal, int idBodega, decimal Idcliente)
        {
            try
            {
              return oDat.Get_List_Orden_Desp_x_Cliente(idEmpresa, idSucursal, idBodega, Idcliente);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "CargarOrdenDespachoPorCliente", ex.Message), ex) { EntityType = typeof(fa_orden_Desp_Bus) };
            }

        }
    
        public Boolean ModificarDB(int idempresa, fa_orden_Desp_Info info,ref string msg)
        {
            try
            {
                if (Validar_Cantidad_Detalle_Despacho_en_Guia(ref info, ref  msg))
                {              
                    return oDat.ModificarDB(idempresa, info);
                }

                return false;                              
             
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_orden_Desp_Bus) };
            }

        }


        private Boolean Validar_Cantidad_Detalle_Despacho_en_Guia(ref fa_orden_Desp_Info Despacho_info, ref string msg)
        {
            try
            {
                #region 'Validaciones'
               
                if (Despacho_info.ListaGuiaRemision.Count() != 0)
                {
                var ListaDespacho = Despacho_info.ListaDetalle.GroupBy(v => v.IdProducto).Select(g => new
                    {
                        Key = g.Key,
                        od_cantidad = g.Sum(s => s.od_cantidad),
                        IdProducto = g.First().IdProducto,
                        IdPedido = g.First().IdPedido,
                        pr_descripcion = g.First().pr_descripcion
                    });

                var ListaGuiaRemision = Despacho_info.ListaGuiaRemision.GroupBy(v => v.gi_IdProducto).Select(g => new
                    {
                        Key = g.Key,
                        gi_cantidad = g.Sum(s => s.gi_cantidad),
                        gi_IdProducto = g.First().gi_IdProducto,
                        gi_IdGuiaRemision = g.First().gi_IdGuiaRemision,
                        od_IdOrdenDespacho = g.First().od_IdOrdenDespacho

                    });

                    foreach (var itemLD in ListaDespacho)
                    {
                        foreach (var itemLGR in ListaGuiaRemision)
                        {
                            if (itemLD.IdProducto == itemLGR.gi_IdProducto)
                            {

                                if (itemLD.od_cantidad >= itemLGR.gi_cantidad)
                                { }
                                else
                                {
                  msg="La cantidad a modificar del producto : [" + itemLD.IdProducto + "] - " + itemLD.pr_descripcion + ", del despacho # : " + itemLGR.od_IdOrdenDespacho + "  y pedido #: " + itemLD.IdPedido + " , no se puede modificar ya que es menor a la cantidad de los items despachados en la guia #: " + itemLGR.gi_IdGuiaRemision + "";
                                  
                                    return false;
                                }

                            }
                        }
                    }
                }
                         
                #endregion

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_Cantidad_Detalle_Despacho_en_Guia", ex.Message), ex) { EntityType = typeof(fa_orden_Desp_Bus) };

            }
        }
    }
}
