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
    public class fa_pre_facturacion_det_Cobro_x_Depreciacion_Data
    {
        public List<fa_pre_facturacion_det_Cobro_x_Depreciacion_Info> Get_List(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                List<fa_pre_facturacion_det_Cobro_x_Depreciacion_Info> Lista = new List<fa_pre_facturacion_det_Cobro_x_Depreciacion_Info>();
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_pre_facturacion_det_Cobro_x_Depreciacion
                              where IdEmpresa == q.IdEmpresa && IdPrefacturacion == q.IdPreFacturacion
                              select q;

                    foreach (var item in lst)
                    {
                        fa_pre_facturacion_det_Cobro_x_Depreciacion_Info info = new fa_pre_facturacion_det_Cobro_x_Depreciacion_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdPreFacturacion = item.IdPreFacturacion;
                        info.secuencia = item.secuencia;
                        info.IdCentro_Costo = item.IdCentro_Costo;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.IdEmpresa_dep = item.IdEmpresa_dep;
                        info.IdDepreciacion_dep = item.IdDepreciacion_dep;
                        info.IdTarifario = item.IdTarifario;
                        info.secuencia_dep = item.secuencia_dep;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.concepto = item.concepto;
                        info.Total_depreciado_x_cobrar = item.Total_depreciado_x_cobrar;
                        info.Costo_unitario = item.Costo_unitario;
                        info.Valor_salvamento = item.Valor_salvamento;
                        info.Facturar = item.Facturar;
                        info.IdTarifario = item.IdTarifario;
                        info.Porc_ganancia = item.Porc_ganancia;

                        info.IdEmpresa_cli = item.IdEmpresa_cli;
                        info.IdCliente_cli = item.IdCliente_cli;
                        info.nom_Cliente = item.nom_Cliente;
                        info.Af_Nombre = item.Af_Nombre;
                        info.nom_punto_cargo = item.nom_punto_cargo;
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

        public Boolean GuardarDB(List<fa_pre_facturacion_det_Cobro_x_Depreciacion_Info> Lista)
        {
            try
            {
                foreach (var item in Lista)
                {
                    using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                    {
                        fa_pre_facturacion_det_Cobro_x_Depreciacion Entity = new fa_pre_facturacion_det_Cobro_x_Depreciacion();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdPreFacturacion = item.IdPreFacturacion;
                        Entity.secuencia = item.secuencia;
                        Entity.IdCentro_Costo = item.IdCentro_Costo;
                        Entity.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Entity.IdPunto_cargo = item.IdPunto_cargo;
                        Entity.IdEmpresa_dep = item.IdEmpresa_dep;
                        Entity.IdDepreciacion_dep = item.IdDepreciacion_dep;
                        Entity.IdTarifario = item.IdTarifario;
                        Entity.secuencia_dep = item.secuencia_dep;
                        Entity.IdActivoFijo = item.IdActivoFijo;
                        Entity.concepto = item.concepto;
                        Entity.Total_depreciado_x_cobrar = item.Total_depreciado_x_cobrar;
                        Entity.Costo_unitario = item.Costo_unitario;
                        Entity.Valor_salvamento = item.Valor_salvamento;
                        Entity.Facturar = item.Facturar;
                        Entity.IdTarifario = item.IdTarifario;
                        Entity.Porc_ganancia = item.Porc_ganancia;
                        Context.fa_pre_facturacion_det_Cobro_x_Depreciacion.Add(Entity);
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
                    Context.Database.ExecuteSqlCommand("delete [Fj_servindustrias].[fa_pre_facturacion_det_Cobro_x_Depreciacion] where IdEmpresa = " + info.IdEmpresa + " and IdPreFacturacion = " + info.IdPreFacturacion);
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
