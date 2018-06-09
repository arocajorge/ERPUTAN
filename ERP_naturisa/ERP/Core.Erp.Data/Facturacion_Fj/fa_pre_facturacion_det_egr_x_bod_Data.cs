using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion_Fj
{
   public class fa_pre_facturacion_det_egr_x_bod_Data
    {
        public List<fa_pre_facturacion_det_egr_x_bod_Info> Get_List(fa_pre_facturacion_Info info)
        {
            try
            {
                List<fa_pre_facturacion_det_egr_x_bod_Info> Lista = new List<fa_pre_facturacion_det_egr_x_bod_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_pre_facturacion_det_egr_x_bod
                              where q.IdEmpresa == info.IdEmpresa &&
                              q.IdPreFacturacion == info.IdPreFacturacion
                              select q;

                    foreach (var item in lst)
                    {
                        fa_pre_facturacion_det_egr_x_bod_Info info_det = new fa_pre_facturacion_det_egr_x_bod_Info();
                        info_det.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                        info_det.IdPreFacturacion = Convert.ToDecimal(item.IdPreFacturacion);
                        info_det.nom_Producto = item.nom_Producto;
                        info_det.nom_Proveedor = item.nom_Proveedor;
                        info_det.IdCentro_Costo = item.IdCentro_Costo;
                        info_det.nom_Centro_costo = item.nom_Centro_costo;
                        info_det.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info_det.nom_Centro_costo_sub_centro_costo = item.nom_Centro_costo_sub_centro_costo;
                        info_det.IdPunto_cargo = item.IdPunto_cargo;
                        info_det.nom_punto_cargo = item.nom_punto_cargo;
                        info_det.num_Factura = item.oc_NumDocumento;
                        info_det.IdCliente = item.IdCliente_cli;
                        info_det.nom_Cliente = item.nom_Cliente;
                        info_det.cm_fecha =  item.cm_fecha;
                        //Campos de tabla de prefact x egreso
                        info_det.IdEmpresa_mov_inv = item.IdEmpresa;
                        info_det.IdSucursal_mov_inv = item.IdSucursal_mov_inv;
                        info_det.IdBodega_mov_inv = item.IdBodega_mov_inv;
                        info_det.IdMovi_inven_tipo_mov_inv = item.IdMovi_inven_tipo_mov_inv;
                        info_det.IdNumMovi_mov_inv = item.IdNumMovi_mov_inv;
                        info_det.Secuencia_det = (int)item.Secuencia_det;
                        info_det.observacion_det = item.observacion_det;
                        //Campos de valores
                        info_det.Cantidad =  item.Cantidad;
                        info_det.Costo_Uni = item.Costo_Uni;
                        info_det.Subtotal = info_det.Cantidad * info_det.Costo_Uni;
                        info_det.Aplica_Iva = item.Aplica_Iva;
                        info_det.Por_Iva = item.Por_Iva;
                        info_det.Valor_Iva = item.Valor_Iva;
                        info_det.Total = item.Total;
                        info_det.Facturar = item.Facturar;
                        info_det.IdTarifario = item.IdTarifario;
                        info_det.Porc_ganancia = item.Porc_ganancia;
                        Lista.Add(info_det);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
       
        public Boolean Guardar(List<fa_pre_facturacion_det_egr_x_bod_Info> lst_Info)
        {
            try
            {
                int sec = 1;
                foreach (var item in lst_Info)
                {
                    using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                    {
                        fa_pre_facturacion_det_egr_x_bod Entity = new fa_pre_facturacion_det_egr_x_bod();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdPreFacturacion = item.IdPreFacturacion;
                        Entity.secuencia = sec;
                        Entity.IdCentro_Costo = item.IdCentro_Costo;
                        Entity.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Entity.IdPunto_cargo = item.IdPunto_cargo;
                        Entity.IdEmpresa_mov_inv = item.IdEmpresa_mov_inv;
                        Entity.IdSucursal_mov_inv = item.IdSucursal_mov_inv;
                        Entity.IdBodega_mov_inv = item.IdBodega_mov_inv;
                        Entity.IdMovi_inven_tipo_mov_inv = item.IdMovi_inven_tipo_mov_inv;
                        Entity.IdNumMovi_mov_inv = item.IdNumMovi_mov_inv;
                        Entity.Secuencia_det = item.Secuencia_det;
                        Entity.observacion_det = item.observacion_det;
                        Entity.Cantidad = item.Cantidad;
                        Entity.Costo_Uni = item.Costo_Uni;
                        Entity.Subtotal = item.Subtotal;
                        Entity.Aplica_Iva = item.Aplica_Iva;
                        Entity.Por_Iva = item.Por_Iva;
                        Entity.Valor_Iva = item.Valor_Iva;
                        Entity.Total = item.Total;
                        Entity.Facturar = item.Facturar;
                        Entity.IdTarifario = item.IdTarifario;
                        Entity.Porc_ganancia = item.Porc_ganancia;
                        Context.fa_pre_facturacion_det_egr_x_bod.Add(Entity);
                        Context.SaveChanges();
                    }
                    sec++;
                }
                return true;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(fa_pre_facturacion_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_pre_facturacion_det_egr_x_bod where IdEmpresa = "+info.IdEmpresa + " and IdPreFacturacion = "+ info.IdPreFacturacion);
                }
                return true;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Procesar_egresos(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.spFa_pre_facturacion_det_egr_x_bod(IdEmpresa, IdPrefacturacion);
                }
                return true;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
