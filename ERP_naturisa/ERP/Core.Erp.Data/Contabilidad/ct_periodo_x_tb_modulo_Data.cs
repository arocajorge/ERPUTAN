using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Contabilidad
{
   public class ct_periodo_x_tb_modulo_Data
    {

        string mensaje = "";        

        public List<ct_periodo_x_tb_modulo_Info> Get_List_Periodo(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                List<ct_periodo_x_tb_modulo_Info> lM = new List<ct_periodo_x_tb_modulo_Info>();
                EntitiesDBConta OEPeriodo = new EntitiesDBConta();
                var selectPeriodo = from C in OEPeriodo.ct_periodo_x_tb_modulo
                                    where C.IdEmpresa == IdEmpresa
                                    select C;
                foreach (var item in selectPeriodo)
                {
                    ct_periodo_x_tb_modulo_Info Cbt = new ct_periodo_x_tb_modulo_Info();
                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.IdPeriodo = item.IdPeriodo;
                    Cbt.Cerrado = item.Cerrado;
                    Cbt.IdModulo = item.IdModulo;
                    
                    lM.Add(Cbt);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_periodo_x_tb_modulo_Info> Get_List_Periodo(int IdEmpresa,int IdPeriodo, ref string MensajeError)
        {
            try
            {
                List<ct_periodo_x_tb_modulo_Info> lM = new List<ct_periodo_x_tb_modulo_Info>();
                EntitiesDBConta OEPeriodo = new EntitiesDBConta();
                var selectPeriodo = from C in OEPeriodo.ct_periodo_x_tb_modulo
                                    where C.IdEmpresa == IdEmpresa
                                    && C.IdPeriodo == IdPeriodo
                                    select C;
                foreach (var item in selectPeriodo)
                {
                    ct_periodo_x_tb_modulo_Info Cbt = new ct_periodo_x_tb_modulo_Info();
                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.IdPeriodo = item.IdPeriodo;
                    Cbt.Cerrado = item.Cerrado;
                    Cbt.IdModulo = item.IdModulo;

                    lM.Add(Cbt);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool Esta_modulo_cerrado_x_periodo(int IdEmpresa, Cl_Enumeradores.eModulos IdModulo, int IdPeriodo)
        {
            try
            {
                string Modulo =  IdModulo.ToString();

                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    var lst = from q in Context.ct_periodo_x_tb_modulo
                              where IdEmpresa == q.IdEmpresa
                              && Modulo == q.IdModulo
                              && IdPeriodo == q.IdPeriodo
                              && q.Cerrado == true
                              select q;

                    if (lst.Count() == 0)return false; else return true;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public ct_periodo_x_tb_modulo_Info Get_Info_Periodo(int IdEmpresa, int IdPeriodo, ref string MensajeError)
        {
            try
            {

                ct_periodo_x_tb_modulo_Info _PeriodoInfo = new ct_periodo_x_tb_modulo_Info();


                EntitiesDBConta OEPeriodo = new EntitiesDBConta();
                var selectPeriodo = from C in OEPeriodo.ct_periodo_x_tb_modulo
                                    where C.IdEmpresa == IdEmpresa
                                    && C.IdPeriodo == IdPeriodo
                                    select C;
                if (selectPeriodo.ToList().Count > 0)
                {
                    foreach (var item in selectPeriodo)
                    {
                        _PeriodoInfo.IdEmpresa = item.IdEmpresa;
                        _PeriodoInfo.IdPeriodo = item.IdPeriodo;

                        
                    }
                    return _PeriodoInfo;
                }
                else
                    return new ct_periodo_x_tb_modulo_Info();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(List<ct_periodo_x_tb_modulo_Info> Listinfo, ref string MensajeError)
        {
            try
            {
                foreach (var item in Listinfo)
                {
                    ModificarDB(item,ref MensajeError);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(ct_periodo_x_tb_modulo_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_periodo_x_tb_modulo.FirstOrDefault(minfo => minfo.IdPeriodo == info.IdPeriodo 
                        && minfo.IdEmpresa == info.IdEmpresa);
                    if (contact != null)
                    {
                        contact.IdEmpresa = info.IdEmpresa;
                        contact.IdPeriodo = info.IdPeriodo;
                       
                        context.SaveChanges();
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(ct_periodo_x_tb_modulo_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    EntitiesDBConta EDB = new EntitiesDBConta();
                    var Q = from per in EDB.ct_periodo_x_tb_modulo
                            where per.IdPeriodo == info.IdPeriodo 
                            && per.IdEmpresa == info.IdEmpresa
                            && per.IdModulo==info.IdModulo
                            select per;

                    if (Q.ToList().Count == 0)
                    {
                        var address = new ct_periodo_x_tb_modulo();

                        address.IdEmpresa = info.IdEmpresa;
                        address.IdPeriodo = Convert.ToInt32(info.IdPeriodo);
                        address.IdModulo=info.IdModulo;
                        address.Cerrado=info.Cerrado;
                        address.FechaTransac=DateTime.Now;
                        address.IdUsuario=info.IdUsuario;
                       
                        context.ct_periodo_x_tb_modulo.Add(address);
                        context.SaveChanges();
                    }
                    else
                        return false;
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(List<ct_periodo_x_tb_modulo_Info> Listinfo, ref string MensajeError)
        {
            try
            {
                foreach (ct_periodo_x_tb_modulo_Info item in Listinfo)
                {
                    GrabarDB(item, ref MensajeError);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(ct_periodo_x_tb_modulo_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_periodo_x_tb_modulo.FirstOrDefault(dinfo => dinfo.IdPeriodo == info.IdPeriodo && dinfo.IdEmpresa==info.IdEmpresa);

                    if (contact != null)
                    {
                        context.ct_periodo_x_tb_modulo.Remove(contact);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(int IdEmpresa, int IdPeriodo, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    string comando = "delete ct_periodo_x_tb_modulo where IdEmpresa = " + IdEmpresa + " and IdPeriodo = " + IdPeriodo;
                    context.Database.ExecuteSqlCommand(comando);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

       
    }
}
