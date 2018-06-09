using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
//Derek 13/12/2013
namespace Core.Erp.Data.Roles
{
    public class ro_empleado_gastos_perso_x_otros_gast_deduci_Data
    {
        string mensaje = "";
        public List<ro_empleado_gastos_perso_x_otros_gast_deduci_Info> Get_List_empleado_gastos_perso_x_otros_gast_deduci(int IdEmpresa, decimal IdEmpleado, int anio)
        {
            List<ro_empleado_gastos_perso_x_otros_gast_deduci_Info> lst = new List<ro_empleado_gastos_perso_x_otros_gast_deduci_Info>();
            try
            {
               
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var Consulta = from q in rol.ro_empleado_gastos_perso_x_otros_gast_deduci
                                   where q.IdEmpresa == IdEmpresa
                                   && q.IdEmpleado == IdEmpleado
                                   && q.Anio_fiscal == anio
                                   orderby q.IdEmpleado
                                   select q;

                    foreach (var item in Consulta)
                    {
                        ro_empleado_gastos_perso_x_otros_gast_deduci_Info info = new ro_empleado_gastos_perso_x_otros_gast_deduci_Info();
                        info.IdEmpresa = item.IdEmpresa;                        
                        info.IdEmpleado = item.IdEmpleado;
                        info.Anio_fiscal = item.Anio_fiscal;
                        info.secuencia = item.secuencia;
                        info.Valor_Pension_alim = item.Valor_Pension_alim;
                        info.Valor_no_cub_x_aseg = item.Valor_no_cub_x_aseg;

                        lst.Add(info);
                    }
                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GrabarDB(List<ro_empleado_gastos_perso_x_otros_gast_deduci_Info> info)
        {
            try
            {
                //if (EliminarEGPXOGD(info, IncrementaColumnas) == true || EliminarEGPXOGD(info, IncrementaColumnas) == false)
                if (EliminarEGPXOGD(info) == true || EliminarEGPXOGD(info) == false)
                {
                    using (EntitiesRoles rol = new EntitiesRoles())
                    {
                        foreach (var item in info)
                        {
                            ro_empleado_gastos_perso_x_otros_gast_deduci BD = new ro_empleado_gastos_perso_x_otros_gast_deduci();
                            BD.IdEmpresa = item.IdEmpresa;
                            BD.IdEmpleado = item.IdEmpleado;
                            BD.Anio_fiscal = item.Anio_fiscal;
                            BD.secuencia = item.secuencia;
                            BD.Valor_Pension_alim = item.Valor_Pension_alim;
                            BD.Valor_no_cub_x_aseg = item.Valor_no_cub_x_aseg;

                            rol.ro_empleado_gastos_perso_x_otros_gast_deduci.Add(BD);
                            rol.SaveChanges();
                        }
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }


        public int getId(int IdEmpresa, decimal idEmpleado, int anioFiscal)
        {
            int Id = 0;
            try
            {

                EntitiesRoles db = new EntitiesRoles();
                var selecte = db.ro_empleado_gastos_perso_x_otros_gast_deduci.Count(q => q.IdEmpresa == IdEmpresa
                    && q.IdEmpleado == idEmpleado && q.Anio_fiscal == anioFiscal);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in db.ro_empleado_gastos_perso_x_otros_gast_deduci
                                     where q.IdEmpresa == IdEmpresa
                                     && q.IdEmpleado == idEmpleado && q.Anio_fiscal == anioFiscal
                                     select q.secuencia).Max();

                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }





        public Boolean GrabarBD(ro_empleado_gastos_perso_x_otros_gast_deduci_Info info, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    ro_empleado_gastos_perso_x_otros_gast_deduci item = new ro_empleado_gastos_perso_x_otros_gast_deduci();

                    item.IdEmpresa = info.IdEmpresa;
                    item.IdEmpleado = info.IdEmpleado;
                    item.Anio_fiscal = info.Anio_fiscal;
                    item.secuencia = getId(info.IdEmpresa,info.IdEmpleado, info.Anio_fiscal);
                    item.Valor_Pension_alim = info.Valor_Pension_alim;
                    item.Valor_no_cub_x_aseg = info.Valor_no_cub_x_aseg;

                    db.ro_empleado_gastos_perso_x_otros_gast_deduci.Add(item);
                    db.SaveChanges();
                }
                
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }


        public Boolean EliminarBD(int idEmpresa, decimal idEmpleado, int anioFiscal, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_empleado_gastos_perso_x_otros_gast_deduci where IdEmpresa =" + idEmpresa.ToString()
                       + " AND IdEmpleado=" + idEmpleado.ToString()
                       + " AND Anio_fiscal=" + anioFiscal.ToString()
                     //  + " AND secuencia=" + idEmpleado.ToString()
                       );
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = msg = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }

        }






        //public Boolean EliminarEGPXOGD(List<ro_empleado_gastos_perso_x_otros_gast_deduci_Info> info, int IncrementaColumnas)
        public Boolean EliminarEGPXOGD(List<ro_empleado_gastos_perso_x_otros_gast_deduci_Info> info)
        {
            try
            {
                using (EntitiesRoles ro = new EntitiesRoles())
                {
                    //int i = 0;
                    //int Resta = info.Count - IncrementaColumnas;
                    foreach (var item in info)
                    {
                        //i++;
                        //if (i <= Resta)
                        //{
                            ro_empleado_gastos_perso_x_otros_gast_deduci EGPXOGD = ro.ro_empleado_gastos_perso_x_otros_gast_deduci.First(v => v.IdEmpleado == item.IdEmpleado && v.IdEmpresa == item.IdEmpresa && v.Anio_fiscal == item.Anio_fiscal);
                            ro.ro_empleado_gastos_perso_x_otros_gast_deduci.Remove(EGPXOGD);
                            ro.SaveChanges();
                        //}
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean EliminarDB(ro_empleado_gastos_perso_x_otros_gast_deduci_Info info)
        {
            try
            {
                using (EntitiesRoles ro = new EntitiesRoles())
                {                  
                    ro_empleado_gastos_perso_x_otros_gast_deduci EGPXOGD = ro.ro_empleado_gastos_perso_x_otros_gast_deduci.First(v => v.IdEmpleado == info.IdEmpleado && v.IdEmpresa == info.IdEmpresa && v.Anio_fiscal == info.Anio_fiscal);
                        ro.ro_empleado_gastos_perso_x_otros_gast_deduci.Remove(EGPXOGD);
                        ro.SaveChanges();                  
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean consultarAnio(int IdEmpresa, int IdEmpleado, int anio)
        {
            try
            {
                Boolean retorna = false;
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var Consultar = from q in rol.ro_empleado_gastos_perso_x_otros_gast_deduci
                                    where q.IdEmpresa == IdEmpresa && q.IdEmpleado == IdEmpleado
                                    && q.Anio_fiscal == anio
                                    select q;

                    foreach (var item in Consultar)
                    {
                        if (item.Anio_fiscal != null)
                        {
                            retorna = true;
                            break;
                        }
                    }
                }
                return retorna;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        //public int GetSecuencia()
        //{
        //    try
        //    {
        //        EntitiesRoles rol = new EntitiesRoles();
        //        var numero = (from q in rol.ro_empleado_gastos_perso_x_otros_gast_deduci
        //                      select q.secuencia).Max() + 1;

        //        return numero;
        //    }
        //    catch (Exception)
        //    {

        //        return 0;
        //    }
        //}
    }
}
