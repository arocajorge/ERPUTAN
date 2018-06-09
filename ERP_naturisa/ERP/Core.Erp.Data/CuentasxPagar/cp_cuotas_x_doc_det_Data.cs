using Core.Erp.Data.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_cuotas_x_doc_det_Data
    {
        public List<cp_cuotas_x_doc_det_Info> Get_list_cuotas_x_doc_det(int IdEmpresa, decimal IdCuota)
        {
            try
            {
                List<cp_cuotas_x_doc_det_Info> Lista = new List<cp_cuotas_x_doc_det_Info>();

                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    var lst = from q in Context.cp_cuotas_x_doc_det
                              where q.IdEmpresa == IdEmpresa
                              && q.IdCuota == IdCuota
                              select q;

                    foreach (var item in lst)
                    {
                        cp_cuotas_x_doc_det_Info info = new cp_cuotas_x_doc_det_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCuota = item.IdCuota;
                        info.Secuencia = item.Secuencia;
                        info.Num_cuota = item.Num_cuota;
                        info.Fecha_vcto_cuota = item.Fecha_vcto_cuota;
                        info.Valor_cuota = item.Valor_cuota;
                        info.Observacion = item.Observacion;
                        info.Estado = item.Estado;

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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public bool EliminarDB(int IdEmpresa, decimal IdCuota)
        {
            try
            {
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    string comando = "delete cp_cuotas_x_doc_det where IdEmpresa = "+IdEmpresa+" and IdCuota = "+IdCuota;
                    Context.Database.ExecuteSqlCommand(comando);
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public bool GuardarDB(List<cp_cuotas_x_doc_det_Info> Lista)
        {
            try
            {
                int sec = 1;
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    foreach (var item in Lista)
                    {
                        cp_cuotas_x_doc_det Entity = new cp_cuotas_x_doc_det();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdCuota = item.IdCuota;
                        Entity.Secuencia = sec;
                        Entity.Num_cuota = item.Num_cuota;
                        Entity.Fecha_vcto_cuota = item.Fecha_vcto_cuota;
                        Entity.Valor_cuota = item.Valor_cuota;
                        Entity.Observacion = item.Observacion;
                        Entity.Estado = item.Estado;

                        Context.cp_cuotas_x_doc_det.Add(Entity);
                        Context.SaveChanges();

                        sec++;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public bool ModificarDB_campos_op(cp_cuotas_x_doc_det_Info info)
        {
            try
            {
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    cp_cuotas_x_doc_det Entity = Context.cp_cuotas_x_doc_det.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdCuota == info.IdCuota && q.Secuencia == info.Secuencia);
                    if (Entity != null)
                    {
                        Entity.IdEmpresa_op = info.IdEmpresa_op;
                        Entity.IdOrdenPago = info.IdOrdenPago;
                        Entity.Secuencia_op = info.Secuencia_op;
                        Context.SaveChanges();                            
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
