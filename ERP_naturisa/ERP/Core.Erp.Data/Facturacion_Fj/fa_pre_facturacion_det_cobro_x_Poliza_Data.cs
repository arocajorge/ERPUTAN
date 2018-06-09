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
    public class fa_pre_facturacion_det_cobro_x_Poliza_Data
    {
        public List<fa_pre_facturacion_det_cobro_x_Poliza_Info> Get_List(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                List<fa_pre_facturacion_det_cobro_x_Poliza_Info> Lista = new List<fa_pre_facturacion_det_cobro_x_Poliza_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_pre_facturacion_det_cobro_x_Poliza
                              where IdEmpresa == q.IdEmpresa && q.IdPreFacturacion == IdPrefacturacion
                              select q;

                    foreach (var item in lst)
                    {
                        fa_pre_facturacion_det_cobro_x_Poliza_Info info = new fa_pre_facturacion_det_cobro_x_Poliza_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdPreFacturacion = item.IdPreFacturacion;
                        info.secuencia = item.secuencia;
                        info.Af_Nombre = item.Af_Nombre;
                        info.IdCentro_Costo = item.IdCentro_Costo;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.nom_Centro_costo_sub_centro_costo = item.nom_Centro_costo_sub_centro_costo;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.nom_EstadoFacturacion_cat = item.nom_EstadoFacturacion_cat;
                        info.Tipo_Cobro_Poliza_X = item.Tipo_Cobro_Poliza_X;
                        info.IdEmpresa_pol_det = item.IdEmpresa_pol_det;
                        info.IdPoliza_pol_det = item.IdPoliza_pol_det;
                        info.IdActivoFijo_pol_det = item.IdActivoFijo_pol_det;
                        info.secuencia_pol_det = item.secuencia_pol_det;
                        info.IdEmpresa_pol_cuota = item.IdEmpresa_pol_cuota;
                        info.IdPoliza_pol_cuota = item.IdPoliza_pol_cuota;
                        info.cod_cuota_pol_cuota = item.cod_cuota_pol_cuota;
                        info.Cantidad = item.Cantidad;
                        info.Costo_Uni = item.Costo_Uni;
                        info.Subtotal = item.Subtotal;
                        info.Aplica_Iva = item.Aplica_Iva;
                        info.Por_Iva = item.Por_Iva;
                        info.Valor_Iva = item.Valor_Iva;
                        info.Total = item.Total;
                        info.IdCliente = item.IdCliente;
                        info.nom_Cliente = item.nom_Cliente;
                        info.Facturar = item.Facturar;
                        info.IdTarifario = item.IdTarifario;
                        info.Porc_ganancia = item.Porc_ganancia;
                        Lista.Add(info);
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

        public Boolean GuardarDB(List<fa_pre_facturacion_det_cobro_x_Poliza_Info> Lista)
        {
            try
            {
                int sec = 0;
                foreach (var item in Lista)
                {
                    sec++;
                    using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                    {
                        fa_pre_facturacion_det_cobro_x_Poliza Entity = new fa_pre_facturacion_det_cobro_x_Poliza();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdPreFacturacion = item.IdPreFacturacion;
                        Entity.secuencia = sec;
                        Entity.IdCentro_Costo = item.IdCentro_Costo;
                        Entity.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Entity.IdPunto_cargo = item.IdPunto_cargo;
                        Entity.Tipo_Cobro_Poliza_X = item.Tipo_Cobro_Poliza_X;
                        Entity.IdEmpresa_pol_det = item.IdEmpresa_pol_det;
                        Entity.IdPoliza_pol_det = item.IdPoliza_pol_det;
                        Entity.IdActivoFijo_pol_det = item.IdActivoFijo_pol_det;
                        Entity.secuencia_pol_det = item.secuencia_pol_det;
                        Entity.IdEmpresa_pol_cuota = item.IdEmpresa_pol_cuota;
                        Entity.IdPoliza_pol_cuota = item.IdPoliza_pol_cuota;
                        Entity.cod_cuota_pol_cuota = item.cod_cuota_pol_cuota;
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
                        Context.fa_pre_facturacion_det_cobro_x_Poliza.Add(Entity);
                        Context.SaveChanges();
                    }
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

        public Boolean EliminarDB(fa_pre_facturacion_Info Info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza where IdEmpresa = "+Info.IdEmpresa+" and IdPrefacturacion = "+Info.IdPreFacturacion);
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
