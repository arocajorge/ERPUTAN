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
    public class cp_cuotas_x_doc_Data
    {
        public List<cp_cuotas_x_doc_Info> Get_list_cuotas_x_doc(int IdEmpresa)
        {
            try
            {
                List<cp_cuotas_x_doc_Info> Lista = new List<cp_cuotas_x_doc_Info>();

                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    var lst = from q in Context.cp_cuotas_x_doc
                              where IdEmpresa == q.IdEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        cp_cuotas_x_doc_Info info = new cp_cuotas_x_doc_Info();
                        
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCuota = item.IdCuota;
                        info.Observacion = item.Observacion;
                        info.Estado = item.Estado;
                        info.Fecha_inicio = item.Fecha_inicio;
                        info.Dias_plazo = item.Dias_plazo;
                        info.Num_cuotas = item.Num_cuotas;
                        info.Total_a_pagar = item.Total_a_pagar;
                        info.IdCbteCble = item.IdCbteCble;
                        info.IdTipoCbte = item.IdTipoCbte;
                        info.IdEmpresa_ct = item.IdEmpresa_ct;
                        
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

        public cp_cuotas_x_doc_Info Get_info_cuotas_x_doc(int IdEmpresa, decimal IdCuota)
        {
            try
            {
                cp_cuotas_x_doc_Info info = new cp_cuotas_x_doc_Info();

                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    var lst = from q in Context.cp_cuotas_x_doc
                              where IdEmpresa == q.IdEmpresa
                              && q.IdCuota == IdCuota
                              select q;

                    foreach (var item in lst)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCuota = item.IdCuota;
                        info.Observacion = item.Observacion;
                        info.Estado = item.Estado;
                        info.Fecha_inicio = item.Fecha_inicio;
                        info.Dias_plazo = item.Dias_plazo;
                        info.Num_cuotas = item.Num_cuotas;
                        info.Total_a_pagar = item.Total_a_pagar;
                        info.IdCbteCble = item.IdCbteCble;
                        info.IdTipoCbte = item.IdTipoCbte;
                        info.IdEmpresa_ct = item.IdEmpresa_ct;
                        
                    }
                }

                return info;
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

        public cp_cuotas_x_doc_Info Get_info_cuotas_x_doc(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                cp_cuotas_x_doc_Info info = new cp_cuotas_x_doc_Info();

                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    var lst = from q in Context.cp_cuotas_x_doc
                              where IdEmpresa == q.IdEmpresa
                              && IdTipoCbte == q.IdTipoCbte
                              && IdCbteCble == q.IdCbteCble
                              select q;

                    foreach (var item in lst)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCuota = item.IdCuota;
                        info.Observacion = item.Observacion;
                        info.Estado = item.Estado;
                        info.Fecha_inicio = item.Fecha_inicio;
                        info.Dias_plazo = item.Dias_plazo;
                        info.Num_cuotas = item.Num_cuotas;
                        info.Total_a_pagar = item.Total_a_pagar;
                        info.IdCbteCble = item.IdCbteCble;
                        info.IdTipoCbte = item.IdTipoCbte;
                        info.IdEmpresa_ct = item.IdEmpresa_ct;

                    }
                }

                return info;
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

        public decimal Get_id(int IdEmpresa)
        {
            try
            {
                decimal ID = 0;

                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    var lst = from q in Context.cp_cuotas_x_doc
                              where q.IdEmpresa == IdEmpresa
                              select q;

                    if (lst.Count() == 0)
                    {
                        ID = 1;
                    }
                    else
                    {
                        ID = lst.Max(q => q.IdCuota) + 1;
                    }
                }

                return ID;
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

        public Boolean GuardarDB(cp_cuotas_x_doc_Info info)
        {
            try
            {
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    var lst = from q in Context.cp_cuotas_x_doc
                              where q.IdEmpresa == info.IdEmpresa
                              && q.IdCuota == info.IdCuota
                              select q;
                    if (lst.Count() == 0)
                    {
                        cp_cuotas_x_doc Entity = new cp_cuotas_x_doc();
                        Entity.IdEmpresa = info.IdEmpresa;
                        Entity.IdCuota = info.IdCuota = Get_id(info.IdEmpresa);
                        Entity.Observacion = info.Observacion;
                        Entity.Estado = true;
                        Entity.Fecha_inicio = info.Fecha_inicio.Date;
                        Entity.Dias_plazo = info.Dias_plazo;
                        Entity.Num_cuotas = info.Num_cuotas;
                        Entity.Total_a_pagar = info.Total_a_pagar;
                        Entity.IdCbteCble = info.IdCbteCble;
                        Entity.IdTipoCbte = info.IdTipoCbte;
                        Entity.IdEmpresa_ct = info.IdEmpresa_ct;
                        Context.cp_cuotas_x_doc.Add(Entity);
                        Context.SaveChanges();

                        cp_cuotas_x_doc_det_Data oData_det = new cp_cuotas_x_doc_det_Data();
                        foreach (var item in info.lst_cuotas_det)
                        {
                            item.IdCuota = info.IdCuota;
                        }
                        oData_det.GuardarDB(info.lst_cuotas_det);
                    }
                    else
                    {
                        ModificarDB(info);
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

        public Boolean ModificarDB(cp_cuotas_x_doc_Info info)
        {
            try
            {
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    cp_cuotas_x_doc Entity = Context.cp_cuotas_x_doc.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdCuota == info.IdCuota);
                    if (Entity != null)
                    {
                        Entity.Observacion = info.Observacion;
                        Entity.Fecha_inicio = info.Fecha_inicio;
                        Entity.Dias_plazo = info.Dias_plazo;
                        Entity.Num_cuotas = info.Num_cuotas;
                        Entity.Total_a_pagar = info.Total_a_pagar;
                        Context.SaveChanges();

                        var lst = from q in Context.cp_cuotas_x_doc_det
                                  where q.IdEmpresa == info.IdEmpresa
                                  && q.IdCuota == info.IdCuota
                                  && q.Estado == true
                                  select q;
                        cp_cuotas_x_doc_det_Data oData = new cp_cuotas_x_doc_det_Data();
                        if (lst.Count() == 0)
                        {                            
                            oData.EliminarDB(info.IdEmpresa, info.IdCuota);
                            foreach (var item in info.lst_cuotas_det)
                            {
                                item.IdCuota = info.IdCuota;
                            }
                            oData.GuardarDB(info.lst_cuotas_det);
                        }
                        else
                        {
                            foreach (var item in info.lst_cuotas_det)
                            {
                                oData.ModificarDB_campos_op(item);
                            }
                        }
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

        public Boolean AnularDB(int IdEmpresa, decimal IdCuota)
        {
            try
            {
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    cp_cuotas_x_doc Entity = Context.cp_cuotas_x_doc.FirstOrDefault(q => q.IdEmpresa == IdEmpresa && q.IdCuota == IdCuota);
                    if (Entity != null)
                    {
                        Entity.Estado = false;
                        Entity.IdEmpresa_ct = null;
                        Entity.IdTipoCbte = null;
                        Entity.IdCbteCble = null;
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
