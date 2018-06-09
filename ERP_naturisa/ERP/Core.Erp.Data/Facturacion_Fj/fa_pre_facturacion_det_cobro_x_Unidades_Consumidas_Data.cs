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
    public class fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Data
    {
        public List<fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Info> Get_List(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                List<fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Info> Lista = new List<fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Info>();
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_pre_facturacion_det_cobro_x_Unidades_Consumidas
                              where IdEmpresa == q.IdEmpresa && IdPrefacturacion == q.IdPreFacturacion
                              select q;

                    foreach (var item in lst)
                    {
                        fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Info info = new fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdPreFacturacion = item.IdPreFacturacion;
                        info.secuencia = item.secuencia;
                        info.IdPeriodo = item.IdPeriodo;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.IdPunto_cargo_PC = item.IdPunto_cargo_PC;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.Cantidad = item.Cantidad;
                        info.Costo_Uni = item.Costo_Uni;
                        info.Subtotal = item.Subtotal;
                        info.Aplica_Iva = item.Aplica_Iva;
                        info.Por_Iva = item.Por_Iva;
                        info.Valor_Iva = item.Valor_Iva;
                        info.Total = item.Total;
                        info.Estado = item.Estado;
                        info.IdTarifario = item.IdTarifario;
                        info.Porc_ganancia = item.Porc_ganancia;
                        info.Facturar = item.Facturar;

                        info.Af_Nombre = item.Af_Nombre;
                        info.IdEmpresa_cli = item.IdEmpresa_cli;
                        info.IdCliente_cli = item.IdCliente_cli;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.nom_Cliente = item.nom_Cliente;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.nom_Centro_costo_sub_centro_costo = item.nom_Centro_costo_sub_centro_costo;
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

        public Boolean GuardarDB(List<fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Info> Lista)
        {
            try
            {
                foreach (var item in Lista)
                {
                    using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                    {
                        fa_pre_facturacion_det_cobro_x_Unidades_Consumidas Entity = new fa_pre_facturacion_det_cobro_x_Unidades_Consumidas();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdPreFacturacion = item.IdPreFacturacion;
                        Entity.secuencia = item.secuencia;
                        Entity.IdPeriodo = item.IdPeriodo;
                        Entity.IdCentroCosto = item.IdCentroCosto;
                        Entity.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Entity.IdPunto_cargo_PC = item.IdPunto_cargo_PC;
                        Entity.IdActivoFijo = item.IdActivoFijo;
                        Entity.Cantidad = item.Cantidad;
                        Entity.Costo_Uni = item.Costo_Uni;
                        Entity.Subtotal = item.Subtotal;
                        Entity.Aplica_Iva = item.Aplica_Iva;
                        Entity.Por_Iva = item.Por_Iva;
                        Entity.Valor_Iva = item.Valor_Iva;
                        Entity.Total = item.Total;
                        Entity.Estado = item.Estado;
                        Entity.IdTarifario = item.IdTarifario;
                        Entity.Porc_ganancia = item.Porc_ganancia;
                        Entity.Facturar = item.Facturar;

                        Context.fa_pre_facturacion_det_cobro_x_Unidades_Consumidas.Add(Entity);
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

        public Boolean EliminarDB(fa_pre_facturacion_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete [Fj_servindustrias].[fa_pre_facturacion_det_cobro_x_Unidades_Consumidas] where IdEmpresa = "+ info.IdEmpresa +" and IdPreFacturacion = "+info.IdPreFacturacion);   
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
