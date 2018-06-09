using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Importacion
{
    public class imp_ordencompra_ext_x_Condiciones_Pago_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(imp_ordencompra_ext_Info Info) 
        {

            try
            {
                int secuencia = 1;

                foreach (var item in Info.ListCondicionPago)
                {
                    using(EntitiesImportacion Context = new EntitiesImportacion())
                    {
                    
                        var address = new imp_ordencompra_ext_x_Condiciones_Pago();
                        address.IdEmpresa = item.IdEmpresa;
                        address.IdSucusal = item.IdSucursal;
                        address.IdOrdenCompraExt = Info.IdOrdenCompraExt;
                        address.Secuencia = item.Secuencia;
                        
                        address.IdCondicion_Pago = item.IdCondicion_Pago;
                        address.Fecha_Pago = item.Fecha_Pago;
                        address.IdConfirmacion_Pago = item.IdConfirmacion_Pago;
                        address.Por_Pago = item.Por_Pago;
                        address.Valor_Pago = item.Valor_Pago;
                        address.Observacion = (item.Observacion == null) ? "" : item.Observacion;

                        Context.imp_ordencompra_ext_x_Condiciones_Pago.Add(address);
                        secuencia++;
                        Context.Dispose();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<imp_ordencompra_ext_x_Condiciones_Pago_Info> Get_List_ordencompra_ext_x_Condiciones_Pago(imp_ordencompra_ext_Info Info) 
        {
                List<imp_ordencompra_ext_x_Condiciones_Pago_Info> lst = new List<imp_ordencompra_ext_x_Condiciones_Pago_Info>();                
                EntitiesImportacion oen = new EntitiesImportacion();
            try
            {
                var Consu = from q in oen.imp_ordencompra_ext_x_Condiciones_Pago
                            where q.IdEmpresa == Info.IdEmpresa && q.IdOrdenCompraExt == Info.IdOrdenCompraExt && q.IdSucusal == Info.IdSucusal
                            select q;

                foreach (var item in Consu)
                {
                    imp_ordencompra_ext_x_Condiciones_Pago_Info address = new imp_ordencompra_ext_x_Condiciones_Pago_Info();
                    address.IdEmpresa = item.IdEmpresa;
                    address.IdSucursal = item.IdSucusal;
                    address.IdOrdenCompraExt = item.IdOrdenCompraExt;
                    address.Secuencia = item.Secuencia;
                    address.IdCondicion_Pago = item.IdCondicion_Pago;
                    address.Fecha_Pago = item.Fecha_Pago;
                    address.IdConfirmacion_Pago = item.IdConfirmacion_Pago;
                    address.Por_Pago = item.Por_Pago;
                    address.Valor_Pago = item.Valor_Pago;
                    address.Observacion = (item.Observacion == null) ? "" : item.Observacion;

                    lst.Add(address);
                    
                }

                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(imp_ordencompra_ext_Info Info) 
        {
            try
            {
                List<imp_ordencompra_ext_x_Condiciones_Pago_Info> ListCondicionPago = new List<imp_ordencompra_ext_x_Condiciones_Pago_Info>();
                ListCondicionPago =Get_List_ordencompra_ext_x_Condiciones_Pago(Info);
                foreach (var item in ListCondicionPago)
                {
                    using (EntitiesImportacion context = new EntitiesImportacion())
                    {
                        //var contact = context.imp_ordencompra_ext_x_Condiciones_Pago.First(obj => obj.IdEmpresa == item.IdEmpresa && obj.IdSucusal == item.IdSucursal && obj.IdOrdenCompraExt == item.IdOrdenCompraExt && obj.Secuencia == item.Secuencia);
                        var contact = context.Database.ExecuteSqlCommand("delete from	imp_ordencompra_ext_x_Condiciones_Pago where IdOrdenCompraExt =" + item.IdOrdenCompraExt + "and IdEmpresa = " + item.IdEmpresa + " and IdSucusal = " + item.IdSucursal);
                        
                        //context.Remove(contact);
                        //context.SaveChanges();
                        //context.Dispose();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
