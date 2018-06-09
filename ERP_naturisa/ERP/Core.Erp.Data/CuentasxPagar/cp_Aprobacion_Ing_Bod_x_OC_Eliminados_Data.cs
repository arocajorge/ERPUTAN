using Core.Erp.Data.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Erp.Data.CuentasxPagar
{

   public  class cp_Aprobacion_Ing_Bod_x_OC_Eliminados_Data
    {

        string mensaje = "";
        public Boolean GuardarDB(cp_Aprobacion_Ing_Bod_x_OC_Eliminados_Info Info, ref string msg)
        {
            try
            {
                try
                {
                    using (EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
                {
                    cp_Aprobacion_Ing_Bod_x_OC_Eliminados Address = new cp_Aprobacion_Ing_Bod_x_OC_Eliminados();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdAprobacion = Info.IdAprobacion;
                    Address.Fecha_Factura = Convert.ToDateTime(Info.Fecha_Factura.ToShortDateString());
                    Address.Fecha_aprobacion = Convert.ToDateTime(Info.Fecha_Factura.ToShortDateString());
                    Address.IdEmpresa_Ogiro = Info.IdEmpresa_Ogiro;
                    Address.IdCbteCble_Ogiro = Info.IdCbteCble_Ogiro;
                    Address.IdTipoCbte_Ogiro = Info.IdTipoCbte_Ogiro;
                    Address.IdOrden_giro_Tipo = Info.IdOrden_giro_Tipo;
                    Address.IdIden_credito = Info.IdIden_credito;
                    Address.IdProveedor = Info.IdProveedor;
                    Address.Observacion = Info.Observacion;
                    Address.Serie = Info.Serie;
                    Address.Serie2 = Info.Serie2;
                    Address.num_documento = Info.num_documento;
                    Address.num_auto_Proveedor = Info.num_auto_Proveedor;
                    Address.num_auto_Imprenta = Info.num_auto_Imprenta;
                    Address.co_subtotal_iva = Info.co_subtotal_iva;
                    Address.co_subtotal_siniva = Info.co_subtotal_siniva;
                    Address.Descuento = Info.Descuento;
                    Address.co_baseImponible = Info.co_baseImponible;
                    Address.co_Por_iva = Info.co_Por_iva;
                    Address.co_valoriva = Info.co_valoriva;
                    Address.co_total = Info.co_total;
                    Address.co_plazo = Info.co_plazo;
                    Address.IdUsuario_Anu = Info.IdUsuario_Anu;
                    Address.Fecha_Anulacion = Info.Fecha_Anulacion;
                    Address.Motivo_Anu = Info.Motivo_Anu;
                    CxP.cp_Aprobacion_Ing_Bod_x_OC_Eliminados.Add(Address);
                    CxP.SaveChanges();
                    //grabar detalle

                    foreach (var item in Info.listDetalle)
                    {
                        item.IdEmpresa = Info.IdEmpresa;
                        item.IdAprobacion = Address.IdAprobacion;
                    }
                    // detalle
                    cp_Aprobacion_Ing_Bod_x_OC_det_Eliminados_Data data_Det = new cp_Aprobacion_Ing_Bod_x_OC_det_Eliminados_Data();
                    data_Det.GuardarDB(Info.listDetalle, ref msg);
                }
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.ToString() + " " + ex.Message;
                    mensaje = "Error al Grabar" + ex.Message;
                    throw new Exception(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                msg = mensaje;
                throw new Exception(ex.InnerException.ToString());
            }
        }
       
    }
}
