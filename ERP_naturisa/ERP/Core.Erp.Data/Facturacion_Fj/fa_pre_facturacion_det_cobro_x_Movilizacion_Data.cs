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
    public class fa_pre_facturacion_det_cobro_x_Movilizacion_Data
    {
        public List<fa_pre_facturacion_det_cobro_x_Movilizacion_Info> Get_List(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                List<fa_pre_facturacion_det_cobro_x_Movilizacion_Info> Lista = new List<fa_pre_facturacion_det_cobro_x_Movilizacion_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_pre_facturacion_det_cobro_x_Movilizacion
                              where IdEmpresa == q.IdEmpresa && IdPrefacturacion == q.IdPrefacturacion
                              select q;
                    foreach (var item in lst)
                    {
                        fa_pre_facturacion_det_cobro_x_Movilizacion_Info info = new fa_pre_facturacion_det_cobro_x_Movilizacion_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdPrefacturacion = item.IdPrefacturacion;
                        info.secuencia = item.secuencia;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.IdCentro_Costo = item.IdCentro_Costo;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.Movilizacion = item.Movilizacion;
                        info.Facturar = item.Facturar;
                        info.IdTarifario = item.IdTarifario;
                        info.Porc_ganancia = item.Porc_ganancia;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.nom_Centro_costo_sub_centro_costo = item.nom_Centro_costo_sub_centro_costo;
                        info.nom_Cliente = item.nom_Cliente;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.IdEmpresa_cli = item.IdEmpresa_cli;
                        info.IdCliente_cli = item.IdCliente_cli;
                        info.Af_Nombre = item.Af_Nombre;
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

        public Boolean GuardarDB(List<fa_pre_facturacion_det_cobro_x_Movilizacion_Info> Lista)
        {
            try
            {
                foreach (var item in Lista)
                {
                    using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                    {
                        fa_pre_facturacion_det_cobro_x_Movilizacion Entity = new fa_pre_facturacion_det_cobro_x_Movilizacion();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdPrefacturacion = item.IdPrefacturacion;
                        Entity.secuencia = item.secuencia;
                        Entity.IdActivoFijo = item.IdActivoFijo;
                        Entity.IdCentro_Costo = item.IdCentro_Costo;
                        Entity.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Entity.IdPunto_cargo = item.IdPunto_cargo;
                        Entity.Movilizacion = item.Movilizacion;
                        Entity.Facturar = item.Facturar;
                        Entity.IdTarifario = item.IdTarifario;
                        Entity.Porc_ganancia = item.Porc_ganancia;
                        Context.fa_pre_facturacion_det_cobro_x_Movilizacion.Add(Entity);
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
                    Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Movilizacion where IdEmpresa = " + info.IdEmpresa + " and IdPreFacturacion = " + info.IdPreFacturacion);
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
