using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_factura_TerminoPago_Distribucion_Data
    {
        string mensaje = "";

        public List<fa_factura_TerminoPago_Distribucion_Info> obtenerLista(string IdTipoFormaPago)
        {
            try
            {
                List<fa_factura_TerminoPago_Distribucion_Info> lst = new List<fa_factura_TerminoPago_Distribucion_Info>();
                EntitiesFacturacion context = new EntitiesFacturacion();

                var select = from q in context.fa_factura_TerminoPago_Distribucion
                             where q.IdTipoFormaPago == IdTipoFormaPago
                             select q;

                fa_factura_TerminoPago_Distribucion_Info _Info;

                foreach (var item in select)
                {
                    _Info = new fa_factura_TerminoPago_Distribucion_Info();
                    _Info.IdTipoFormaPago = item.IdTipoFormaPago;
                    _Info.Secuencia = item.Secuencia;
                    _Info.Por_distribucion = item.Por_distribucion;
                    _Info.Num_Dias_Vcto = item.Num_Dias_Vcto;
                    lst.Add(_Info);
                }

                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);    
                return new List<fa_factura_TerminoPago_Distribucion_Info>();
            }
        }

        public Boolean Guardar(List<fa_factura_TerminoPago_Distribucion_Info> lst)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();
                foreach (var item in lst)
                {
                    var address = new fa_factura_TerminoPago_Distribucion();

                    address.IdTipoFormaPago = item.IdTipoFormaPago;
                    address.Secuencia = item.Secuencia;
                    address.Por_distribucion = item.Por_distribucion;
                    address.Num_Dias_Vcto = item.Num_Dias_Vcto;
                    context.AddTofa_factura_TerminoPago_Distribucion(address);
                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);    
                return false;
            }
        }

         public Boolean eliminar(string IdTipoFormaPago, int count)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();


                for (int i = 0; i < count; i++)
                {
                    var select = context.fa_factura_TerminoPago_Distribucion.First(var => var.IdTipoFormaPago == IdTipoFormaPago);
                    context.DeleteObject((select));
                    context.SaveChanges();
                }
                return true; 
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);    
                return false;
            }
        }

        

        public Boolean Modificar(List<fa_factura_TerminoPago_Distribucion_Info> lst)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();
                foreach (var item in lst)
                {
                    var address = new fa_factura_TerminoPago_Distribucion();

                    address.IdTipoFormaPago = item.IdTipoFormaPago;
                    address.Secuencia = item.Secuencia;
                    address.Por_distribucion = item.Por_distribucion;
                    address.Num_Dias_Vcto = item.Num_Dias_Vcto;
                    context.AddTofa_factura_TerminoPago_Distribucion(address);
                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);    
                return false;
            }
        }

    }
}
