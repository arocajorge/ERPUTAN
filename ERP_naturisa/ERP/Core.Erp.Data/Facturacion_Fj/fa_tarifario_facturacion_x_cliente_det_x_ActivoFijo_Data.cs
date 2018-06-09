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
    public class fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Data
    {
        string MensajeError = "";

        public List<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info> Get_List_Activo_x_tarifario(int idEmpresa, decimal idTarifario)
        {
            try
            {
                List<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info> Lista = new List<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwaf_fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo
                              where q.IdEmpresa == idEmpresa
                              && q.IdTarifario == idTarifario
                              select q;

                    foreach (var item in lst)
                    {
                        fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info info = new fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTarifario = item.IdTarifario;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.Unidades_minimas = item.Unidades_minimas;
                        info.Valor_x_Unidad = item.Valor_x_Unidad;
                        info.nom_UnidadFact = item.Descripcion;
                        info.Af_Nombre = item.Af_Nombre;
                        info.IdCategoriaAF = item.IdCategoriaAF;
                        info.nom_Categoria = item.Categoria;
                        info.Num_empleado_relacionado =Convert.ToInt32( item.Num_empleado_relacionado);
                        Lista.Add(info);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Validar_Activos_x_tarifario(int idEmpresa, List<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info> Lista, ref string mensaje)
        {
            try
            {
                bool res = true;

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_tarifario_facturacion_x_cliente_det_x_ActivoFijo
                              where idEmpresa == q.IdEmpresa
                              select q;

                    foreach (var item in Lista)
                    {
                        int cont = lst.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdActivoFijo == item.IdActivoFijo && q.IdEstadoVigencia_cat == "0086" && q.IdTarifario != item.IdTarifario).Count();
                        if (cont > 0)
                        {
                            mensaje = "Los equipos seleccionados ya se encuentran en un tarifario activo: \n";
                            mensaje += item.Af_Nombre+" \n";
                            res = false;
                        }
                    }
                }

                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(List<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info> Lista)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    foreach (var item in Lista)
                    {
                        fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo Entity = new fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdActivoFijo = item.IdActivoFijo;
                        Entity.IdTarifario = item.IdTarifario;
                        Entity.Unidades_minimas = item.Unidades_minimas;
                        Entity.Valor_x_Unidad = item.Valor_x_Unidad;
                        Entity.Num_empleado_relacionado = item.Num_empleado_relacionado;
                        Context.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.Add(Entity);
                        Context.SaveChanges();    
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(int idEmpresa, decimal idTarifario)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete from Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo where IdEmpresa= " + idEmpresa + " and IdTarifario = " + idTarifario);
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }




        public int Validar_Activos_x_tarifario(int idEmpresa,int IdActivo_Fijo)
        {
            try
            {
                int res = 0;

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_tarifario_facturacion_x_cliente_det_x_ActivoFijo
                              where idEmpresa == q.IdEmpresa
                              && q.IdActivoFijo==IdActivo_Fijo
                              && q.IdEstadoVigencia_cat == "EST_VIG_VIGENTE"
                              select q;

                    foreach (var item in lst)
                    {
                        if(item.Num_empleado_relacionado!=null)
                        res =Convert.ToInt32( item.Num_empleado_relacionado);
                    }
                }

                return res;
            }
            catch (Exception ex)
            {
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
