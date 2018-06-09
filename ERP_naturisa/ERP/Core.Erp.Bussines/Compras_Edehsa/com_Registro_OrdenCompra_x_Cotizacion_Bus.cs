using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Inventario;
using Core.Erp.Data.Inventario_Edehsa;
using Core.Erp.Data.Compras_Edehsa;

using Core.Erp.Info.Inventario;
using Core.Erp.Info.Inventario_Edehsa;
using Core.Erp.Info.Compras_Edehsa;

using Core.Erp.Business.General;
using System.Data;

namespace Core.Erp.Business.Compras_Edehsa
{
    public class com_Registro_OrdenCompra_x_Cotizacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        com_Registro_OrdenCompra_x_Cotizacion_Data regOCxCot = new com_Registro_OrdenCompra_x_Cotizacion_Data();
        //in_Producto_Dimensiones_Data proDimen = new in_Producto_Dimensiones_Data();

        public Boolean GrabarDB(List<com_Registro_OrdenCompra_x_Cotizacion_Info> lista, ref string mensaje)
        {
            try
            {
                Boolean res = false;

                //if (ValidarObjeto(lista, ref mensaje) == true)
                //{
                    res = regOCxCot.GrabarDB(lista, ref mensaje);
                //}

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(com_Registro_OrdenCompra_x_Cotizacion_Bus) };
            }
        }


        public com_Registro_OrdenCompra_x_Cotizacion_Info Get_Info_BuscarRegistro_OC_x_Cot(int IdEmpresa, int IdSucursal,decimal IdOrdenCompra, decimal IdCotizacion)
        {
            try
            {
                return regOCxCot.Get_Info_BuscarRegistro_OC_x_Cotizacion(IdEmpresa, IdSucursal, IdOrdenCompra, IdCotizacion);
               
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetProducto", ex.Message), ex) { EntityType = typeof(com_Registro_OrdenCompra_x_Cotizacion_Bus) };

            }
        }

        public Boolean ValidarObjeto(com_Registro_OrdenCompra_x_Cotizacion_Info _Info, ref string MensajeError)
        {
            try
            {
                Boolean res = true;

                if (_Info.IdEmpresa == 0)
                {
                    MensajeError = "el objeto esta errado los PK IdEmpresa no pueden estar en cero";
                    return false;
                }
                if (_Info.IdSucursal == 0)
                {
                    MensajeError = "el objeto esta errado los PK IdSucursal no pueden estar en cero";
                    return false;
                }
                if (_Info.IdOrdenCompra == 0)
                {
                    MensajeError = "el objeto esta errado los PK IdOrdenCompra no pueden estar en cero";
                    return false;
                }
                if (_Info.IdCotizacion == 0)
                {
                    MensajeError = "el objeto esta errado los PK IdCotizacion no pueden estar en cero";
                    return false;
                }

                return res;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarObjeto", ex.Message), ex) { EntityType = typeof(com_Registro_OrdenCompra_x_Cotizacion_Bus) };
            }


        }



    }
}
