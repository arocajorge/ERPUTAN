using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Bancos
{
    public class ba_Inversion_Data
    {
        string mensaje = "";

        public List<ba_Inversion_Info> Get_List_Inversion(int idempresa, ref string msg)
        {
            try
            {
            List<ba_Inversion_Info> listado = new List<ba_Inversion_Info>();
                    try
                    {
                        string query = "Select * from ba_Inversion where IdEmpresa= " +idempresa ;
                        EntitiesBanco oEnt = new EntitiesBanco();
                        listado = oEnt.Database.SqlQuery<ba_Inversion_Info>(query).ToList();

                    }
                    catch (Exception ex)
                    {
                        string arreglo = ToString();
                        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                            "", "", "", "", DateTime.Now);
                        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                        mensaje = ex.InnerException + " " + ex.Message;
                        listado = new List<ba_Inversion_Info>();
                        msg = ex.Message +ex.InnerException;
                    }
                    return listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }  
        
        }

        public decimal GetId(int idempresa)
        {
            try
            {
                 decimal Id;
                EntitiesBanco  OECbtecble = new EntitiesBanco();

                var q = from C in OECbtecble.ba_Inversion
                          where C.IdEmpresa == idempresa ///&& C.IdEmpleado == idEmpleado
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from t in OECbtecble.ba_Inversion 
                                   where t.IdEmpresa == idempresa 
                                   select t.IdInversion).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                    return Id;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GrabarDB(ba_Inversion_Info Info, ref string msg)
        {
            try
            {
                Boolean res = false;
                    try
                    {
                        using (EntitiesBanco context = new EntitiesBanco())
                        {
                            ba_Inversion item = new ba_Inversion();

                            item.Capital = Info.Capital;
                            item.Cod_Inversion = Info.Cod_Inversion;
                            item.Fecha = Info.Fecha;
                            item.Fecha_Transac = Info.Fecha_Transac;
                            item.Fecha_Vct = Info.Fecha_Vct;
                            item.IdBanco = Info.IdBanco;
                            item.IdEmpresa = Info.IdEmpresa;
                            item.IdInversion = Info.IdInversion = GetId(item.IdEmpresa);    
                            item.IdUsuario = Info.IdUsuario;
                            item.ip = Info.ip;
                            item.Monto = Info.Monto;
                            item.nom_pc = Info.nom_pc;
                            item.Observacion = Info.Observacion;
                            item.Otros = Info.Otros;
                            item.Plazo = Info.Plazo;
                            item.Por_Retencion = Convert.ToDouble( Info.Por_Retencion);
                            item.Tasa = Convert.ToDouble (Info.Tasa);
                            item.Tasa_interes = Info.Tasa_interes;
                            item.Total_recibir = Info.Total_recibir;
                            item.Valor_interes = Info.Valor_interes;
                            item.Valor_retencion = Info.Valor_retencion;
                            item.Estado = "A";
                            context.ba_Inversion.Add(item);
                            context.SaveChanges();
                        }
                        res = true;
                        return res;
                    }
                    catch (Exception ex)
                    {
                        string arreglo = ToString();
                        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                            "", "", "", "", DateTime.Now);
                        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                        mensaje = ex.InnerException + " " + ex.Message;
                        msg = ex.Message + ex.InnerException;
                        throw new Exception(ex.InnerException.ToString());
                    }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(ba_Inversion_Info Info, ref string msg)
        {
            Boolean res = false;
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    ba_Inversion item = new ba_Inversion();

                    item = context.ba_Inversion.FirstOrDefault(var => var.IdEmpresa == Info.IdEmpresa && var.IdInversion == Info.IdInversion);
                    if (item != null)
                    {
                        item.Capital = Info.Capital;
                        item.Cod_Inversion = Info.Cod_Inversion;
                        item.Fecha = Info.Fecha;
                        item.Fecha_Transac = Info.Fecha_Transac;
                        item.Fecha_Vct = Info.Fecha_Vct;
                        item.Monto = Info.Monto;
                        item.Observacion = Info.Observacion;
                        item.Otros = Info.Otros;
                        item.Plazo = Info.Plazo;
                        item.Por_Retencion = Convert.ToDouble(Info.Por_Retencion);
                        item.Tasa = Convert.ToDouble(Info.Tasa);
                        item.Tasa_interes = Info.Tasa_interes;
                        item.Total_recibir = Info.Total_recibir;
                        item.Valor_interes = Info.Valor_interes;
                        item.Valor_retencion = Info.Valor_retencion;
                        item.Estado = Info.Estado;
                        context.SaveChanges();
                        res = true;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;

                msg = ex.Message + ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(ba_Inversion_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    ba_Inversion item = new ba_Inversion();
                    item = context.ba_Inversion.FirstOrDefault(var => var.IdEmpresa == Info.IdEmpresa && var.IdInversion == Info.IdInversion);
                    if (item != null)
                    {
                        item.Estado = "I";
                        item.Fecha_UltAnu = Info.Fecha_UltAnu;
                        item.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = ex.Message + ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
