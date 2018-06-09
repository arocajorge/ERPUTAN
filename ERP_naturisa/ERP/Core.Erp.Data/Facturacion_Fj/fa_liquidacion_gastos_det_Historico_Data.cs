using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_liquidacion_gastos_det_Historico_Data
    {
        public List<fa_liquidacion_gastos_det_Info> Get_List_Liquidacion_Gastos_Det_Historico(int IdEmpresa, decimal IdLiquidacion, ref string mensaje)
        {
            try
            {
                List<fa_liquidacion_gastos_det_Info> Lista = new List<fa_liquidacion_gastos_det_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var contact = from q in Context.vwfa_liquidacion_gastos_det_Historico
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdLiquidacion == IdLiquidacion
                                  select q;

                    foreach (var item in contact)
                    {
                        fa_liquidacion_gastos_det_Info Info = new fa_liquidacion_gastos_det_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdLiquidacion = item.IdLiquidacion;
                        Info.secuencia = item.secuencia;
                        Info.IdProducto_Liqui = item.IdProducto_Liqui;
                        Info.detalle_x_producto = item.detalle_x_producto;
                        Info.cantidad = item.cantidad;
                        Info.precio = item.precio;
                        Info.subtotal = item.subtotal;
                        Info.aplica_iva = item.aplica_iva;
                        Info.por_iva = item.por_iva;
                        Info.valor_iva = item.valor_iva;
                        Info.Total_liq = item.Total_liq;
                        Info.nom_producto_Liqui = item.nom_producto_Liqui;
                        Info.IdProducto = item.IdProducto;

                        Lista.Add(Info);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool GuardarDB(fa_liquidacion_gastos_det_Info Info, ref string mensaje)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_liquidacion_gastos_det_Historico contact = new fa_liquidacion_gastos_det_Historico();

                    contact.IdEmpresa = Info.IdEmpresa;
                    contact.IdLiquidacion = Info.IdLiquidacion;
                    contact.secuencia = Info.secuencia;
                    contact.IdProducto_Liqui = Info.IdProducto_Liqui;
                    contact.detalle_x_producto = Info.detalle_x_producto;
                    contact.cantidad = Info.cantidad;
                    contact.precio = Info.precio;
                    contact.subtotal = Info.subtotal;
                    contact.aplica_iva = Info.aplica_iva;
                    contact.por_iva = Info.por_iva;
                    contact.valor_iva = Info.valor_iva;
                    contact.Total_liq = Info.Total_liq;

                    Context.fa_liquidacion_gastos_det_Historico.Add(contact);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool GuardarDB(List<fa_liquidacion_gastos_det_Info> Lst_Info, ref string mensaje)
        {
            try
            {
                int sec = 1;
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    foreach (fa_liquidacion_gastos_det_Info item in Lst_Info)
                    {
                        item.secuencia = sec;

                        GuardarDB(item, ref mensaje);

                        sec++;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool EliminarDB(fa_liquidacion_gastos_Info info, ref string mensaje)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_liquidacion_gastos_det where IdEmpresa = " + info.IdEmpresa + " and IdLiquidacion = " + info.IdLiquidacion + " ");
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
