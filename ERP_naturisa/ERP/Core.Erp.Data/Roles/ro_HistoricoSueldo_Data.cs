using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Roles
{
    public class ro_HistoricoSueldo_Data
    {
        string mensaje = "";
        List<ro_HistoricoSueldo_Info> lista = new List<ro_HistoricoSueldo_Info>();

        public Boolean GrabarDB(ro_HistoricoSueldo_Info ro_info, ref string mensaje)
        {
            try
            {
                int idSecuencia;
                using (EntitiesRoles context = new EntitiesRoles())
                {

                   
                    EntitiesRoles EDB = new EntitiesRoles();

                    idSecuencia = getSecuenciaHistorico(ro_info.IdEmpresa, ro_info.IdEmpleado);

                    ro_info.Secuencia = idSecuencia;

                    var Q = from per in EDB.ro_empleado_historial_Sueldo
                            where per.Secuencia == ro_info.Secuencia && per.IdEmpresa == ro_info.IdEmpresa && per.IdEmpleado==ro_info.IdEmpleado
                            select per;

                    if (Q.ToList().Count == 0)
                    {


                        var address = new ro_empleado_historial_Sueldo();

                        address.IdEmpresa = ro_info.IdEmpresa;
                        address.IdEmpleado = ro_info.IdEmpleado;
                        address.Secuencia = getSecuenciaHistorico(ro_info.IdEmpresa, ro_info.IdEmpleado);
                        address.SueldoAnterior = ro_info.SueldoAnterior;
                        address.SueldoActual = ro_info.SueldoActual;
                        address.PorIncrementoSueldo = ro_info.PorIncrementoSueldo;
                        address.ValorIncrementoSueldo = ro_info.ValorIncrementoSueldo;
                        address.Motivo = ro_info.Motivo;
                        address.Fecha = ro_info.Fecha;
                        address.idUsuario = ro_info.idUsuario;
                        address.Fecha_Transac = ro_info.Fecha_Transac;
                        address.IdUsuarioUltModi = ro_info.IdUsuarioUltModi;
                        address.Fecha_UltMod = ro_info.Fecha_UltMod;
                        address.nom_pc = ro_info.nom_pc;
                        address.ip = ro_info.ip;
                        address.de_descripcion = ro_info.de_descripcion;
                        address.ca_descripcion = ro_info.ca_descripcion;

                        context.ro_empleado_historial_Sueldo.Add(address);
                        context.SaveChanges();


                        mensaje = "Se ha procedido a guardar la información exitosamente...";

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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public int getSecuenciaHistorico(int idempresa, decimal idempleado)
        {

            try
            {

                int Secuencia;

                EntitiesRoles OECbtecble = new EntitiesRoles();

                var q = from C in OECbtecble.ro_empleado_historial_Sueldo
                        where C.IdEmpresa == idempresa && C.IdEmpleado==idempleado
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from t in OECbtecble.ro_empleado_historial_Sueldo
                                   where t.IdEmpresa == idempresa && t.IdEmpleado==idempleado
                                   select t.Secuencia).Max();
                    Secuencia = Convert.ToInt32(select_.ToString()) + 1;
                    return Secuencia;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ro_HistoricoSueldo_Info> Get_List_HistoricoSueldo(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {
                lista = new List<ro_HistoricoSueldo_Info>();

                EntitiesRoles ORol = new EntitiesRoles();

                var sresult = from A in ORol.vwro_historicoSueldovsEmpl
                              where A.IdEmpresa == IdEmpresa && A.IdEmpleado==IdEmpleado
                              orderby A.Fecha descending
                              select A;

                foreach (var item in sresult)
                {
                    ro_HistoricoSueldo_Info Reg = new ro_HistoricoSueldo_Info();

                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdEmpleado = item.IdEmpleado;
                    Reg.Secuencia = item.Secuencia;
                    Reg.SueldoAnterior = item.SueldoAnterior;
                    Reg.SueldoActual = item.SueldoActual;
                    Reg.PorIncrementoSueldo = item.PorIncrementoSueldo;
                    Reg.ValorIncrementoSueldo = item.ValorIncrementoSueldo;
                    Reg.Motivo = item.Motivo;
                    Reg.Fecha = item.Fecha;
                    Reg.ca_descripcion = item.ca_descripcion;
                    Reg.de_descripcion = item.de_descripcion;
                    
                    lista.Add(Reg);
                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public List<ro_HistoricoSueldo_Info> Get_List_HistoricoSueldo(int IdEmpresa, decimal IdEmpleado, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                lista = new List<ro_HistoricoSueldo_Info>();

                EntitiesRoles ORol = new EntitiesRoles();

                var sresult = from a in ORol.vwro_historicoSueldovsEmpl
                              where a.IdEmpresa == IdEmpresa && a.IdEmpleado == IdEmpleado
                              && (a.Fecha>=fechaIni && a.Fecha<=fechaFin)
                              orderby a.Fecha descending
                              select a;

                foreach (var item in sresult)
                {
                    ro_HistoricoSueldo_Info Reg = new ro_HistoricoSueldo_Info();

                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdEmpleado = item.IdEmpleado;
                    Reg.Secuencia = item.Secuencia;
                    Reg.SueldoAnterior = item.SueldoAnterior;
                    Reg.SueldoActual = item.SueldoActual;
                    Reg.PorIncrementoSueldo = item.PorIncrementoSueldo;
                    Reg.ValorIncrementoSueldo = item.ValorIncrementoSueldo;
                    Reg.Motivo = item.Motivo;
                    Reg.Fecha = item.Fecha;
                    Reg.ca_descripcion = item.ca_descripcion;
                    Reg.de_descripcion = item.de_descripcion;

                    lista.Add(Reg);
                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }



    
        public Boolean EliminarBD(int idEmpresa, decimal idEmpleado, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_empleado_historial_Sueldo where IdEmpresa =" + idEmpresa.ToString()                     
                       + " AND IdEmpleado=" + idEmpleado.ToString()
                       );
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }

        }




        public double Get_sueldo_actual(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {

                EntitiesRoles ORol = new EntitiesRoles();

                var sresult = from A in ORol.vwro_historicoSueldovsEmpl
                              where A.IdEmpresa == IdEmpresa && A.IdEmpleado == IdEmpleado
                              orderby A.Fecha descending
                              select A;

                if (sresult.Count() > 0)
                    return sresult.FirstOrDefault().SueldoActual;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

    }
}
