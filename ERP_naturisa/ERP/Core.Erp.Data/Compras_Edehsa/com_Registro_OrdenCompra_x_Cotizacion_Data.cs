using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario_Edehsa;
using Core.Erp.Info.Compras_Edehsa;
using Core.Erp.Data.General;
using Core.Erp.Data.Inventario_Edehsa;
using Core.Erp.Data.Compras_Edehsa;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Compras_Edehsa
{
    
    public class com_Registro_OrdenCompra_x_Cotizacion_Data
    {
        string mensaje = "";
        public List<com_Registro_OrdenCompra_x_Cotizacion> Get_List_Registro_OC_x_Cotizacion()
        {
            try
            {
                List<com_Registro_OrdenCompra_x_Cotizacion> lM = new List<com_Registro_OrdenCompra_x_Cotizacion>();
                EntitiesCompras_Edehsa OEUser = new EntitiesCompras_Edehsa();
                //Core.Erp.Data.Inventario_Edehsa.
                var select_ = from TI in OEUser.com_Registro_OrdenCompra_x_Cotizacion
                              select TI;


                foreach (var item in select_)
                {
                    com_Registro_OrdenCompra_x_Cotizacion dat_ = new com_Registro_OrdenCompra_x_Cotizacion();

                    dat_.IdEmpresa = item.IdEmpresa;
                    dat_.IdSucursal = item.IdSucursal;
                    dat_.IdOrdenCompra = item.IdOrdenCompra;
                    dat_.IdCotizacion = item.IdCotizacion;
                    dat_.estado = item.estado;
    
                    lM.Add(dat_);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public com_Registro_OrdenCompra_x_Cotizacion Get_Info_Registro_OC_x_Cotizacion(int IdEmpresa, int IdSucursal, int IdOrdenCompra, int IdCotizacion)
        {
            try
            {
                com_Registro_OrdenCompra_x_Cotizacion reg_oc_x_cot = new com_Registro_OrdenCompra_x_Cotizacion();
                EntitiesCompras_Edehsa OEt = new EntitiesCompras_Edehsa();
                var registr_oc_x_cot = OEt.com_Registro_OrdenCompra_x_Cotizacion.First(var =>
                    var.IdEmpresa == IdEmpresa
                    && var.IdSucursal == IdSucursal
                    && var.IdOrdenCompra == IdOrdenCompra
                    && var.IdCotizacion == IdCotizacion);

                reg_oc_x_cot.IdEmpresa = registr_oc_x_cot.IdEmpresa;
                reg_oc_x_cot.IdSucursal = registr_oc_x_cot.IdSucursal;
                reg_oc_x_cot.IdOrdenCompra = registr_oc_x_cot.IdOrdenCompra;
                reg_oc_x_cot.IdCotizacion = registr_oc_x_cot.IdCotizacion;
                reg_oc_x_cot.estado = registr_oc_x_cot.estado;



                return reg_oc_x_cot;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<com_Registro_OrdenCompra_x_Cotizacion_Info> Get_List_Reg_OC_x_Cotizacion(int idEmpresa, int idSucursal, int idOrdenCompra, int idCotizacion)
        {
            try
            {
                List<com_Registro_OrdenCompra_x_Cotizacion_Info> lM = new List<com_Registro_OrdenCompra_x_Cotizacion_Info>();
                EntitiesCompras_Edehsa OEselectReg_OCxCot_Info = new EntitiesCompras_Edehsa();
                var selectReg_OCxCot = from C in OEselectReg_OCxCot_Info.com_Registro_OrdenCompra_x_Cotizacion
                                                      where C.IdEmpresa == idEmpresa
                                                       && C.IdSucursal == idSucursal
                                                       && C.IdOrdenCompra == idOrdenCompra
                                                       && C.IdCotizacion == idCotizacion
                                                      select C;

                foreach (var item in selectReg_OCxCot)
                {
                    //in_Categoria_x_Formula_Info 
                    com_Registro_OrdenCompra_x_Cotizacion_Info dat_ = new com_Registro_OrdenCompra_x_Cotizacion_Info();

                    dat_.IdEmpresa = item.IdEmpresa;
                    dat_.IdSucursal = item.IdSucursal;
                    dat_.IdOrdenCompra = item.IdOrdenCompra;
                    dat_.IdCotizacion = item.IdCotizacion;
                    dat_.estado = item.estado;
                    lM.Add(dat_);

                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public com_Registro_OrdenCompra_x_Cotizacion_Info Get_Info_BuscarRegistro_OC_x_Cotizacion(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, decimal IdCotizacion)
        {
            try
            {
                com_Registro_OrdenCompra_x_Cotizacion_Info regOCxCot = new com_Registro_OrdenCompra_x_Cotizacion_Info();
                EntitiesCompras_Edehsa OEOCxCot = new EntitiesCompras_Edehsa();
                var selectOCxCot = from C in OEOCxCot.com_Registro_OrdenCompra_x_Cotizacion
                                     where C.IdEmpresa == IdEmpresa
                                     && C.IdSucursal == IdSucursal
                                     && C.IdOrdenCompra == IdOrdenCompra
                                     && C.IdCotizacion == IdCotizacion
                                     select C;

                foreach (var item in selectOCxCot)
                {
                    regOCxCot.IdEmpresa = item.IdEmpresa;
                    regOCxCot.IdSucursal = item.IdSucursal;
                    regOCxCot.IdOrdenCompra = item.IdCotizacion;
                    regOCxCot.IdCotizacion = item.IdCotizacion;
                    regOCxCot.estado = item.estado;
                    
                    

                }
                return (regOCxCot);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }



        public Boolean GrabarDB(List<com_Registro_OrdenCompra_x_Cotizacion_Info> lista, ref string mensaje)
        {
            try
            {
                int sec = 0;
                foreach (var item in lista)
                {
                    using (EntitiesCompras_Edehsa context = new EntitiesCompras_Edehsa())
                    {
                        var address = new com_Registro_OrdenCompra_x_Cotizacion();
                        //int idpv = GetSecuencia(info.IdEmpresa,);
                        // id = idpv;
                        address.IdEmpresa = item.IdEmpresa;
                        //address.Secuencia = GetSecuencia(info.IdEmpresa,1);

                        address.IdSucursal = item.IdSucursal;
                        address.IdOrdenCompra = item.IdOrdenCompra;
                        address.IdCotizacion = item.IdCotizacion;
                        address.SecuenciaDetalleCotizacion = item.SecuenciaDetalleCotizacion;
                        address.IdListadoMateriales = item.IdListadoMateriales;

                        address.estado = item.estado;

                        context.com_Registro_OrdenCompra_x_Cotizacion.Add(address);
                        context.SaveChanges();
                    }
                }
                mensaje = "Se ha procedido a grabar el registro de Ordenes de Compra por Cotizacion"
                    //+ info.tp_descripcion 
                           + " exitosamente.";
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                mensaje = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(mensaje);
            }
        }

    }
}
