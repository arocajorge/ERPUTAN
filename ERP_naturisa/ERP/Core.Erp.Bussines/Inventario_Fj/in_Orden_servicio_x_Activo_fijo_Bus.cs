using Core.Erp.Business.General;
using Core.Erp.Data.Inventario_Fj;
using Core.Erp.Info.Inventario_Fj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Inventario_Fj
{
    public class in_Orden_servicio_x_Activo_fijo_Bus
    {
        #region Atributos y variables
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_Orden_servicio_x_Activo_fijo_Data Data = new in_Orden_servicio_x_Activo_fijo_Data();
        string msg = "";
        #endregion

        public List<in_Orden_servicio_x_Activo_fijo_Info> Get_Lista_Orden_servicio(int idEmpresa) 
        {
            try
            {
                return Data.Get_Lista_Orden_servicio(idEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lista_Orden_servicio", ex.Message), ex) { EntityType = typeof(in_Orden_servicio_x_Activo_fijo_Bus) };
            }
        }

        public List<in_Orden_servicio_x_Activo_fijo_Info> Get_Lista_Orden_servicio_x_Sucursal_y_Bodega(int idEmpresa, int idSucursal, int idBodega)
        {
            try
            {
                return Data.Get_Lista_Orden_servicio_x_Sucursal_y_Bodega(idEmpresa, idSucursal, idBodega);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lista_Orden_servicio_x_Sucursal_y_Bodega", ex.Message), ex) { EntityType = typeof(in_Orden_servicio_x_Activo_fijo_Bus) };
            }
        }

        public Boolean GuardarDB(in_Orden_servicio_x_Activo_fijo_Info info, ref string msg) 
        {
            try
            {
                if (Validar_Objeto(info,ref msg))
                {
                    return Data.GuardarDB(info);
                }
                else
                    return false;
                    
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_Orden_servicio_x_Activo_fijo_Bus) };
            }
        }

        public Boolean ActualizarDB(in_Orden_servicio_x_Activo_fijo_Info info, ref string msg) 
        {
            try
            {
                if (Validar_Objeto(info, ref msg))
                {
                    return Data.ActualizarDB(info);
                }
                else
                    return false;
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(in_Orden_servicio_x_Activo_fijo_Bus) };
            }
        }

        public Boolean AnularDB(in_Orden_servicio_x_Activo_fijo_Info info) 
        {
            try
            {
                return Data.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_Orden_servicio_x_Activo_fijo_Bus) };
            }
        }

        public Boolean Validar_Objeto(in_Orden_servicio_x_Activo_fijo_Info info, ref string mensajeE)
        {
            if (info.IdEmpresa == 0 || info.IdEmpresa == null)
            {
                mensajeE = "Uno de los Pk de la solicitud esta en cero IdEmpresa=" + info.IdEmpresa;
                return false;
            }

            if (info.IdSucursal == 0 || info.IdSucursal == null)
            {
                mensajeE = "Ingrese la Sucursal ";
                return false;
            }
            if (info.IdActivoFijo == 0 || info.IdActivoFijo==null)
            {
                mensajeE = "Seleccione un activo fijo";
                return false;
            }
            if (info.IdBodega == 0 || info.IdBodega==null)
            {
                mensajeE = "Seleccione una bodega";
                return false;
            }
            if (info.IdProveedor == 0 || info.IdProveedor==null)
            {
                mensajeE = "Seleccione un proveedor";
                return false;
            }
            if (info.Num_Documento =="")
            {
                mensajeE = "Ingrese el número de documento";
                return false;
            }
            if (info.Num_Fact == "")
            {
                mensajeE = "Ingrese el número de la factura";
                return false;
            }
            if (info.Observacion == "")
            {
                mensajeE = "Ingrese una observación";
                return false;
            }
            if (info.IdCentroCosto == "" || info.IdCentroCosto == null)
            {
                mensajeE = "Ingrese el centro de costo";
                return false;
            }
            
            
            return true;
        }

        public List<in_Orden_servicio_x_Activo_fijo_Info> Get_Lista_Vista(int idEmpresa, ref string mensaje)
        {
            try
            {
                return Data.Get_Lista_Vista(idEmpresa, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lista_Vista", ex.Message), ex) { EntityType = typeof(in_Orden_servicio_x_Activo_fijo_Bus) };
            }
        }

        public List<in_Orden_servicio_x_Activo_fijo_Info> Get_Lista_Vista_x_sucursal_x_bodega(int idEmpresa, int idSucursal, int idSucursalFin, int idBodega, int idBodegaFin, DateTime fechaIni, DateTime FechaFin, ref string mensaje)
        {
            try
            {
                return Data.Get_Lista_Vista_x_sucursal_x_bodega(idEmpresa,idSucursal,idSucursalFin,  idBodega,idBodegaFin, fechaIni,  FechaFin, ref  mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lista_Vista_x_sucursal_x_bodega", ex.Message), ex) { EntityType = typeof(in_Orden_servicio_x_Activo_fijo_Bus) };
            }
        }
    }
}
