using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_ControlProduccionObreroDetalle_Data
    {
        string mensaje = "";
        public List<prd_ControlProduccionObreroDetalle_Info> ObtenerCtrlPrdDetalle(decimal IdControlProduccion, int idempresa, int IdSucursal)
        {
            try
            {
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();

                List<prd_ControlProduccionObreroDetalle_Info> lM = new List<prd_ControlProduccionObreroDetalle_Info>();
                var select = from C in OEProduccion.prd_ControlProduccion_Obrero_Det
                             where C.IdEmpresa == idempresa && C.IdSucursal == IdSucursal && C.IdControlProduccionObrero == IdControlProduccion
                             orderby C.Secuencia ascending
                             select C;

                foreach (var item in select)
                {
                    prd_ControlProduccionObreroDetalle_Info info = new prd_ControlProduccionObreroDetalle_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdControlProduccionObrero = item.IdControlProduccionObrero;
                    info.HoraInicio = item.HoraInicio;
                    //info.HoraControl = item.HoraControl;
                    info.Cantidad = item.Cantidad;
                    info.Secuencia = item.Secuencia;
                    info.CodBarra = item.CodBarra;
                    info.IdProducto = item.IdProducto;
                    info.CodBarraMaestro = item.CodBarraMaestro;
                    //info.IdFecha = item.IdFecha;
                    //info.Cerrado = item.Cerrado;

                    lM.Add(info);
                }
                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<prd_ControlProduccionObreroDetalle_Info> ObtenerCtrlPrdDetallexFecha(decimal  IdControlProduccion, int idempresa, int IdSucursal, DateTime IdFecha)
        {
            try
            {
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();

                List<prd_ControlProduccionObreroDetalle_Info> lM = new List<prd_ControlProduccionObreroDetalle_Info>();
                var select = from C in OEProduccion.prd_ControlProduccion_Obrero_Det
                             //where C.IdEmpresa == idempresa && C.IdSucursal == IdSucursal && 
                             //C.IdControlProduccionObrero == IdControlProduccion
                             //&& C.IdFecha == IdFecha
                             orderby C.Secuencia ascending
                             select C;

                foreach (var item in select)
                {
                    prd_ControlProduccionObreroDetalle_Info info = new prd_ControlProduccionObreroDetalle_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdControlProduccionObrero = item.IdControlProduccionObrero;
                    info.HoraInicio = item.HoraInicio;
                    info.CodBarra = item.CodBarra;
                    info.CodBarraMaestro = item.CodBarraMaestro;
                    //info.HoraControl = item.HoraControl;
                    info.Cantidad = item.Cantidad;
                    info.Secuencia = item.Secuencia;
                    //info.IdFecha = item.IdFecha;
                    //info.Cerrado = item.Cerrado;
                    lM.Add(info);
                }
                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean grabarDB(List<prd_ControlProduccionObreroDetalle_Info> lmDetalleInfo, int idempresa, decimal IdCtrlPrdObrero, ref string msg)
        {
            try
            {
                int c = 1;
               
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    foreach (var item in lmDetalleInfo)
                    {
                       
                        var address = new prd_ControlProduccion_Obrero_Det();

                        address.IdEmpresa = idempresa;
                        address.IdSucursal = item.IdSucursal;
                        address.IdControlProduccionObrero = IdCtrlPrdObrero;
                        address.Secuencia = c; c++;
                        address.HoraInicio = item.HoraInicio;
                        address.CodBarra = item.CodBarra;
                        address.CodBarraMaestro = item.CodBarraMaestro;
                        address.IdProducto = item.IdProducto;
                        
                        
                        address.Cantidad = item.Cantidad;

                        context.prd_ControlProduccion_Obrero_Det.Add(address);
                        context.SaveChanges();
                    }
                    context.Dispose();

                }
                msg = "Guardado con exito";
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean eliminarregistrotabla(List<prd_ControlProduccionObreroDetalle_Info> lmDetalleInfo, int idempresa, decimal IdCtrlPrdObrero, ref string msg)
        {
            try
            {
                var contact = new prd_ControlProduccion_Obrero_Det();
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {

                    foreach (var item in lmDetalleInfo)
                    {
                        var address = context.prd_ControlProduccion_Obrero_Det.FirstOrDefault(A => A.IdEmpresa == idempresa && A.IdSucursal == item.IdSucursal && A.IdControlProduccionObrero == IdCtrlPrdObrero);
                        //&& A.Secuencia == item.Secuencia && A.IdFecha == item.IdFecha);
                        if (address != null)
                        {
                            contact = address;
                            context.prd_ControlProduccion_Obrero_Det.Remove(contact);
                            context.SaveChanges();
                            msg = "Guardado con exito";
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }
    }
}
