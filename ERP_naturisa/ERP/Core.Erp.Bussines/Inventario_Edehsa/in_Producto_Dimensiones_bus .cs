using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Inventario;
using Core.Erp.Data.Inventario_Edehsa;

using Core.Erp.Info.Inventario;
using Core.Erp.Info.Inventario_Edehsa;

using Core.Erp.Business.General;
using System.Data;


namespace Core.Erp.Business.Inventario_Edehsa
{
    public class in_Producto_Dimensiones_bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_Producto_data proD = new in_Producto_data();
        in_Producto_Dimensiones_Data proDimen = new in_Producto_Dimensiones_Data();

        public Boolean GrabarDB(in_Producto_Dimensiones_Info prIDim, ref decimal IdProducto, ref string mensaje)
        {

            try
            {
                Boolean res = false;

                if (ValidarObjeto(prIDim, ref mensaje) == true)
                {
                    res = proDimen.GrabarDB(prIDim, ref IdProducto, ref mensaje);
                }

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_Producto_Dimensiones_bus) };


            }
        }
        public Boolean ModificarDB(in_Producto_Dimensiones_Info prIDim, ref string mensaje)
        {

            try
            {
                Boolean res = false;

                if (ValidarObjeto(prIDim, ref mensaje) == true)
                {
                    res = proDimen.ModificarDB(prIDim, ref mensaje);
                }

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_Producto_Dimensiones_bus) };


            }
        }
        public in_Producto_Dimensiones_Info Get_Info_BuscarProducto_Dimensiones(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                return proDimen.Get_Info_BuscarProducto_Dimensiones(IdProducto, IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetProducto", ex.Message), ex) { EntityType = typeof(in_Producto_Dimensiones_bus) };

            }
        }
		

        public Boolean ValidarObjeto(in_Producto_Dimensiones_Info _Info, ref string MensajeError)
        {

            try
            {

                Boolean res = true;


                if (_Info.IdEmpresa == 0)
                {
                    MensajeError = "el objeto esta errado los PK IdEmpresa , IdTipoCbte no pueden estar en cero";
                    return false;
                }

                if (_Info.longitud == 0 || _Info.longitud == null)
                {
                    MensajeError = "El Largo no puede ser 0 o null";
                    return false;
                }
                //if (_Info.alto == 0 || _Info.alto == null)
                //{
                //    MensajeError = "El Alto no puede ser 0 o null";
                //    return false;
                //}
                //if (_Info.espesor == 0 || _Info.espesor == null)
                //{
                //    MensajeError = "El Espesor no puede ser 0 o null";
                //    return false;
                //}
                //if (_Info.espesor == 0 || _Info.espesor == null)
                //{
                //    MensajeError = "El Espesor no puede ser 0 o null";
                //    return false;
                //}

                return res;


            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarObjeto", ex.Message), ex) { EntityType = typeof(in_Producto_Dimensiones_bus) };
            }


        }


    }
}
