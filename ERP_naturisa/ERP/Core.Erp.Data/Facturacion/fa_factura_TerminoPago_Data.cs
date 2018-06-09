using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_factura_TerminoPago_Data
    {
        string mensaje = "";
        #region CJimenez

        public List<fa_factura_TerminoPago_Info> obtenerList()
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();
                List<fa_factura_TerminoPago_Info> lst = new List<fa_factura_TerminoPago_Info>();

                var select = from q in context.fa_factura_TerminoPago
                             select q;

                fa_factura_TerminoPago_Info _Info;

                foreach(var item in select )
                {
                    _Info = new fa_factura_TerminoPago_Info();
                    _Info.IdTipoFormaPago = item.IdTipoFormaPago;
                    _Info.Descripcion = item.Descripcion;
                    _Info.Dias_Vct = item.Dias_Vct;
                    _Info.Num_Cuotas = item.Num_Coutas;

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
                return new List<fa_factura_TerminoPago_Info>();
            }
        }

        public Boolean Guardar(fa_factura_TerminoPago_Info _Info)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();
                var address = new fa_factura_TerminoPago();
                    
                address.IdTipoFormaPago = _Info.IdTipoFormaPago;
                address.Descripcion = _Info.Descripcion;
                address.Dias_Vct = _Info.Dias_Vct;
                address.Num_Coutas = _Info.Num_Cuotas;

                context.AddTofa_factura_TerminoPago(address);
                context.SaveChanges();

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

        public Boolean Modificacion(fa_factura_TerminoPago_Info _Info)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();
                var address = context.fa_factura_TerminoPago.First(var => var.IdTipoFormaPago == _Info.IdTipoFormaPago);
                address.Descripcion = _Info.Descripcion;
                address.Dias_Vct = _Info.Dias_Vct;
                address.Num_Coutas = _Info.Num_Cuotas;

                context.SaveChanges();

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
        #endregion

    }
}
