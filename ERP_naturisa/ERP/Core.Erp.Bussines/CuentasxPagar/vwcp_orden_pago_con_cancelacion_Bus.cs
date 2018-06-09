using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;

namespace Core.Erp.Business.CuentasxPagar
{
    public class vwcp_orden_pago_con_cancelacion_Bus
    {

        vwcp_orden_pago_con_cancelacion_Data OPD = new vwcp_orden_pago_con_cancelacion_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";
        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion_Con_Saldo
            (int IdEmpresa, string IdTipoPersona, decimal IdPersona, decimal IdEntidad, string IdEstado_Aprobacion)
        {

            try
            {
                List<vwcp_orden_pago_con_cancelacion_Info> ListD = new List<vwcp_orden_pago_con_cancelacion_Info>();
                ListD = OPD.Get_List_orden_pago_con_cancelacion_Con_Saldo(IdEmpresa, IdTipoPersona, IdPersona, IdEntidad, IdEstado_Aprobacion, param.IdUsuario);

                return ListD;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_con_cancelacion_Con_Saldo", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };


            }

        }

        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion
            (int IdEmpresa, string IdTipoPersona, decimal IdPersona, decimal IdEntidad, string IdEstado_Aprobacion)
        {

            try
            {
                List<vwcp_orden_pago_con_cancelacion_Info> ListD = new List<vwcp_orden_pago_con_cancelacion_Info>();
                ListD = OPD.Get_List_orden_pago_con_cancelacion(IdEmpresa, IdTipoPersona, IdPersona, IdEntidad, IdEstado_Aprobacion, param.IdUsuario);


                return ListD;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_con_cancelacion", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };
            }

        }

        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_para_aprobacion
            (int IdEmpresa, string IdTipoPersona, decimal IdPersona, decimal IdEntidad, string IdEstado_Aprobacion)
        {

            try
            {
                List<vwcp_orden_pago_con_cancelacion_Info> ListD = new List<vwcp_orden_pago_con_cancelacion_Info>();
                ListD = OPD.Get_List_orden_pago_para_aprobacion(IdEmpresa, IdTipoPersona, IdPersona, IdEntidad, IdEstado_Aprobacion);


                return ListD;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_para_aprobacion", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };
            }

        }

        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion_Mayor_a_cero_
            (int IdEmpresa, string IdTipoPersona, decimal IdPersona, decimal IdEntidad, string IdEstado_Aprobacion)
        {

            try
            {
                List<vwcp_orden_pago_con_cancelacion_Info> ListD = new List<vwcp_orden_pago_con_cancelacion_Info>();
                ListD = OPD.Get_List_orden_pago_con_cancelacion_Mayor_a_cero_(IdEmpresa, IdTipoPersona, IdPersona, IdEntidad, param.IdUsuario, IdEstado_Aprobacion);


                return ListD;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_con_cancelacion_Mayor_a_cero_", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };

            }

        }

        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion_Mayor_a_cero_x_OrdenPago
           (int IdEmpresa, string IdTipoPersona, decimal IdPersona, decimal IdEntidad, string IdEstado_Aprobacion)
        {

            try
            {
                List<vwcp_orden_pago_con_cancelacion_Info> ListD = new List<vwcp_orden_pago_con_cancelacion_Info>();
                ListD = OPD.Get_List_orden_pago_con_cancelacion_Mayor_a_cero_x_OrdenPago(IdEmpresa, IdTipoPersona, IdPersona, IdEntidad, param.IdUsuario, IdEstado_Aprobacion);


                return ListD;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_con_cancelacion_Mayor_a_cero_x_OrdenPago", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };
            }

        }



        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion_todos_Mayor_a_cero(int IdEmpresa, string IdEstado_Aprobacion)
        {

            try
            {
                List<vwcp_orden_pago_con_cancelacion_Info> ListD = new List<vwcp_orden_pago_con_cancelacion_Info>();
                ListD = OPD.Get_List_orden_pago_con_cancelacion_todos_Mayor_a_cero(IdEmpresa, IdEstado_Aprobacion, param.IdUsuario);


                return ListD;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_con_cancelacion_todos_Mayor_a_cero", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };

            }


        }
        public List<ba_Archivo_Transferencia_Det_Info> Get_List_orden_pago_con_archivo_Transeferencia(int IdEmpresa, int IdArchivo)
        {
            try
            {

                return OPD.Get_List_orden_pago_con_archivo_Transeferencia(IdEmpresa, IdArchivo);


            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_con_cancelacion_todos_Mayor_a_cero", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };

            }
        }


        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_transferencia(int IdEmpresa, decimal IdArchivo, DateTime fechaInicio, DateTime fechaFin, string IdUsuario)
        {
            try
            {
                return OPD.Get_List_orden_pago_con_transferencia(IdEmpresa, IdArchivo, fechaInicio, fechaFin, IdUsuario);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_con_cancelacion_todos_Mayor_a_cero", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };

            }
        }

        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion_Mayor_a_cero
            (int IdEmpresa, string IdTipoPersona, decimal IdPersona, decimal IdEntidad, string IdEstado_Aprobacion)
        {

            try
            {
                List<vwcp_orden_pago_con_cancelacion_Info> ListD = new List<vwcp_orden_pago_con_cancelacion_Info>();
                ListD = OPD.Get_List_orden_pago_con_cancelacion_Mayor_a_cero(IdEmpresa, IdTipoPersona, IdPersona, IdEntidad, IdEstado_Aprobacion, param.IdUsuario);


                return ListD;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_con_cancelacion_Mayor_a_cero", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };
            }

        }



        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion_Mayor_a_cero
  (int IdEmpresa, string IdTipo_op, decimal IdProveedor, string IdEstado_Aprobacion)
        {
            try
            {
                List<vwcp_orden_pago_con_cancelacion_Info> ListD = new List<vwcp_orden_pago_con_cancelacion_Info>();
                ListD = OPD.Get_List_orden_pago_con_cancelacion_Mayor_a_cero(IdEmpresa, IdTipo_op, IdProveedor, IdEstado_Aprobacion, param.IdUsuario);

                return ListD;
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_con_cancelacion_Mayor_a_cero", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };
            }


        }

        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion_(int IdEmpresa, string IdTipoPersona, decimal IdPersona, decimal IdEntidad, string IdEstado_Aprobacion)
        {

            try
            {
                List<vwcp_orden_pago_con_cancelacion_Info> ListD = new List<vwcp_orden_pago_con_cancelacion_Info>();
                ListD = OPD.Get_List_orden_pago_con_cancelacion_(IdEmpresa, IdTipoPersona, IdPersona, IdEntidad, param.IdUsuario, IdEstado_Aprobacion);


                return ListD;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_con_cancelacion_", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };
            }

        }


        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion(int IdEmpresa, ref string mensaje)
        {
            try
            {
                return OPD.Get_List_orden_pago_con_cancelacion(IdEmpresa, param.IdUsuario, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_con_cancelacion", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };
            }
        }

        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion(int IdEmpresa, decimal IdConciliacion, ref string mensaje)
        {
            try
            {
                return OPD.Get_List_orden_pago_con_cancelacion(IdEmpresa, IdConciliacion, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_con_cancelacion", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };
            }
        }
        /*
        public List<vwcp_orden_pago_con_cancelacion_Info> Get_List_orden_pago_con_cancelacion_todos_Mayor_a_cero(int IdEmpresa, decimal IdOrdenPago, int Secuencia_OP)
        {

            try
            {
                 return OPD.Get_List_orden_pago_con_cancelacion_todos_Mayor_a_cero(IdEmpresa,  IdOrdenPago, Secuencia_OP);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_con_cancelacion_todos_Mayor_a_cero", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };
            }
        
        }*/


        public vwcp_orden_pago_con_cancelacion_Bus() { }



    }





}
