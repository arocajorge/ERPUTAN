using Core.Erp.Data.General;
using Core.Erp.Info.Contabilidad_Fj;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Contabilidad_Fj
{
    public class ct_distribucion_gastos_x_periodo_det_gastos_Data
    {
        public List<ct_distribucion_gastos_x_periodo_det_gastos_Info> get_list(int IdEmpresa, decimal IdDistribucion)
        {
            try
            {
                List<ct_distribucion_gastos_x_periodo_det_gastos_Info> Lista = new List<ct_distribucion_gastos_x_periodo_det_gastos_Info>();

                using (EntitiesContabilidad_FJ Context = new EntitiesContabilidad_FJ())
                {
                    var lst = from q in Context.ct_distribucion_gastos_x_periodo_det_gastos
                              where q.IdEmpresa == IdEmpresa && q.IdDistribucion == IdDistribucion
                              select q;

                    foreach (var item in lst)
                    {
                        ct_distribucion_gastos_x_periodo_det_gastos_Info info = new ct_distribucion_gastos_x_periodo_det_gastos_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdDistribucion = item.IdDistribucion;
                        info.Secuencia = item.Secuencia;
                        info.IdCtaCble = item.IdCtaCble;
                        info.Saldo = item.Saldo;
                        info.Checked = item.Checked;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_distribucion_gastos_x_periodo_det_gastos_Info> get_list_para_distribucion(int IdEmpresa, int IdPeriodo)
        {
            try
            {
                List<ct_distribucion_gastos_x_periodo_det_gastos_Info> Lista = new List<ct_distribucion_gastos_x_periodo_det_gastos_Info>();

                using (EntitiesContabilidad_FJ Context = new EntitiesContabilidad_FJ())
                {
                    var lst = from q in Context.vwct_distribucion_gastos_x_periodo_det_gastos_para_distribuir
                              where q.IdEmpresa == IdEmpresa && q.IdPeriodo == IdPeriodo
                              select q;

                    foreach (var item in lst)
                    {
                        ct_distribucion_gastos_x_periodo_det_gastos_Info info = new ct_distribucion_gastos_x_periodo_det_gastos_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCtaCble = item.IdCtaCble;
                        info.pc_Cuenta = item.pc_Cuenta;
                        info.Saldo = item.dc_Valor == null ? 0 : Convert.ToDouble(item.dc_Valor);
                        info.Checked = true;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool GuardarDB(ct_distribucion_gastos_x_periodo_det_gastos_Info info)
        {
            try
            {
                using (EntitiesContabilidad_FJ Context = new EntitiesContabilidad_FJ())
                {
                    ct_distribucion_gastos_x_periodo_det_gastos Entity = new ct_distribucion_gastos_x_periodo_det_gastos();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdDistribucion = info.IdDistribucion;
                    Entity.Secuencia = info.Secuencia;
                    Entity.IdCtaCble = info.IdCtaCble;
                    Entity.Saldo = info.Saldo;
                    Entity.Checked = info.Checked;
                    Context.ct_distribucion_gastos_x_periodo_det_gastos.Add(Entity);
                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool GuardarDB(List<ct_distribucion_gastos_x_periodo_det_gastos_Info> Lista)
        {
            try
            {
                int Secuencia = 1;
                foreach (var item in Lista)
                {
                    item.Secuencia = Secuencia;
                    GuardarDB(item);
                    Secuencia++;
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool EliminarDB(int IdEmpresa, decimal IdDistribucion)
        {
            try
            {
                using (EntitiesContabilidad_FJ Context = new EntitiesContabilidad_FJ())
                {
                    string Comando = "delete Fj_servindustrias.ct_distribucion_gastos_x_periodo_det_gastos where IdEmpresa = " + IdEmpresa.ToString() + " and IdDistribucion = " + IdDistribucion.ToString();
                    Context.Database.ExecuteSqlCommand(Comando);
                }
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
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
