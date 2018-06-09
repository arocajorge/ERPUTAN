using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_conciliacion_Data
    {
        public List<cp_conciliacion_Info> Get_List_conciliacion(int IdEmpresa, ref string mensaje)
        {
            try
            {
                List<cp_conciliacion_Info> Lst = new List<cp_conciliacion_Info>();
                List<cp_conciliacion_Info> lista = new List<cp_conciliacion_Info>();


                using (EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
                {
                    var Consulta = from q in CxP.cp_conciliacion
                                   where q.IdEmpresa == IdEmpresa                                   
                                   select q;                 

                    foreach (var item in Consulta)
                    {
                        cp_conciliacion_Info info = new cp_conciliacion_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdConciliacion = item.IdConciliacion;
                        info.Fecha = item.Fecha;
                        info.Observacion = item.Observacion;
                        info.Estado = item.Estado;
                        info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        info.Fecha_Transac = Convert.ToDateTime(item.Fecha_Transac).Date;
                        info.Fecha_UltMod = Convert.ToDateTime(item.Fecha_UltMod).Date;
                        info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        info.MotivoAnu = item.MotivoAnu;
                        info.nom_pc = item.nom_pc;
                        info.Fecha_UltAnu = Convert.ToDateTime(item.Fecha_UltAnu).Date;
                        info.ip = item.ip;
                        info.IdCancelacion = Convert.ToDecimal(item.IdCancelacion);
                        info.Tipo_detalle = item.Tipo_detalle;
                        info.Tipo = item.Tipo;
                        
                        info.IdEmpresa_cbtecble = Convert.ToInt32(item.IdEmpresa_cbtecble);
                        info.IdTipoCbte_cbtecble = Convert.ToInt32(item.IdTipoCbte_cbtecble);
                        info.IdCbteCble_cbtecble = Convert.ToDecimal(item.IdCbteCble_cbtecble);

                        Lst.Add(info);
                    }

                    lista = new List<cp_conciliacion_Info>(Lst.OrderByDescending(d => d.IdConciliacion));
                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(ref cp_conciliacion_Info Info, ref string mensaje)
        {
            try
            {
                using (EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
                {
                    cp_conciliacion Data = new cp_conciliacion();
                    Data.IdEmpresa = Info.IdEmpresa;
                    Data.IdConciliacion = GetId(Info.IdEmpresa,ref mensaje);
                    Info.IdConciliacion = Data.IdConciliacion;
                    Data.Fecha = Info.Fecha;
                    Data.Observacion = Info.Observacion;
                    Data.Estado = "A";
                    Data.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                    Data.Fecha_Transac = Info.Fecha_Transac;
                    Data.Fecha_UltMod = Info.Fecha_UltMod;
                    Data.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    Data.MotivoAnu = Info.MotivoAnu;
                    Data.nom_pc = Info.nom_pc;
                    Data.Fecha_UltAnu = Info.Fecha_UltAnu;
                    Data.ip = Info.ip;                
                    Data.IdCancelacion = Info.IdCancelacion;
                    Data.Tipo_detalle = Info.Tipo_detalle;

                    Data.IdEmpresa_cbtecble = Info.IdEmpresa_cbtecble;
                    Data.IdTipoCbte_cbtecble = Info.IdTipoCbte_cbtecble;
                    Data.IdCbteCble_cbtecble = Info.IdCbteCble_cbtecble;

                    CxP.cp_conciliacion.Add(Data);
                    CxP.SaveChanges();


                    int sec = 0;
                    if (Info.lista_Det_Concilia.Count != 0)
                    {
                        foreach (var item in Info.lista_Det_Concilia)
                        {
                            sec = sec + 1;
                            
                            item.IdEmpresa = Info.IdEmpresa;
                            item.IdConciliacion = Info.IdConciliacion;
                            item.Secuencia = sec;
                        }
                                                                      
                        cp_conciliacion_det_Data odata = new cp_conciliacion_det_Data();
                        if (odata.GrabarDB(Info.lista_Det_Concilia))
                        {
                                               
                        }                                                      
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(cp_conciliacion_Info Info, ref string mensaje)
        {
            try
            {
                using (EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
                {
                    var Modificar = CxP.cp_conciliacion.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdConciliacion == Info.IdConciliacion);
                    if (Modificar != null)
                    {
                        Modificar.IdEmpresa_cbtecble = Info.IdEmpresa_cbtecble;
                        Modificar.IdTipoCbte_cbtecble = Info.IdTipoCbte_cbtecble;
                        Modificar.IdCbteCble_cbtecble = Info.IdCbteCble_cbtecble;
                        CxP.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(cp_conciliacion_Info Info, ref string mensaje)
        {
            try
            {
                using (EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
                {
                    var Modificar = CxP.cp_conciliacion.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdConciliacion == Info.IdConciliacion);
                    if (Modificar != null)
                    {
                        Modificar.Estado = "I";
                        Modificar.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        Modificar.MotivoAnu = Info.MotivoAnu;
                        Modificar.Fecha_UltAnu = DateTime.Now;

                        CxP.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public decimal GetId(int IdEmpresa, ref string mensaje)
        {
            try
            {
                decimal Id;
                EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

                var select = ECXP.cp_conciliacion.Count(q => q.IdEmpresa == IdEmpresa);
                if (select == 0)
                {
                    return Id = 1;
                }

                else
                {
                    var select_ = (from t in ECXP.cp_conciliacion
                                   where t.IdEmpresa == IdEmpresa
                                   select t.IdConciliacion).Max();
                    Id = Convert.ToDecimal(select_.ToString()) + 1;
                    return Id;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now );
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
