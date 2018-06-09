using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
//PARAMETROS GENERALES
//Derek Mejía Soria
//ultima modificacion : 08/01/2014

namespace Core.Erp.Data.Roles
{
    public class ro_Config_Rubros_ParametrosGenerales_Data
    {
        string mensaje = "";


        public List<ro_Config_Rubros_ParametrosGenerales_Info> Get_List_Config_Rubros_ParametrosGenerales()
        {
               List<ro_Config_Rubros_ParametrosGenerales_Info> param = new List<ro_Config_Rubros_ParametrosGenerales_Info>();
            try
            {

                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var Consulta = from q in rol.ro_Config_Rubros_ParametrosGenerales
                                   orderby q.Orden
                                   select q;
                    foreach (var item in Consulta)
                    {
                        ro_Config_Rubros_ParametrosGenerales_Info par = new ro_Config_Rubros_ParametrosGenerales_Info();
                        par.IdTipoParametro = item.IdTipoParametro;
                        par.Descripcion = item.Descripcion;
                        par.IdRubro = item.IdRubro;
                        par.IdMesPago = Convert.ToInt32(item.IdMesPago);
                        par.Formula = item.Formula;
                        par.Porcentaje = Convert.ToDouble(item.Porcentaje);
                        par.Orden = Convert.ToInt32(item.Orden);
                        par.File = item.File;

                        param.Add(par);
                    }
                }
                return param;
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


        public List<ro_Config_Rubros_ParametrosGenerales_Info> Config_Rubros_ParametrosGenerales_Decimo()
        {
              List<ro_Config_Rubros_ParametrosGenerales_Info> param = new List<ro_Config_Rubros_ParametrosGenerales_Info>();
            try
            {

                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var Consulta = from q in rol.ro_Config_Rubros_ParametrosGenerales
                                   orderby q.Orden
                                   select q;
                    foreach (var item in Consulta)
                    {
                        ro_Config_Rubros_ParametrosGenerales_Info par = new ro_Config_Rubros_ParametrosGenerales_Info();
                        par.IdTipoParametro = item.IdTipoParametro;
                        par.Descripcion = item.Descripcion;
                        par.IdRubro = item.IdRubro;
                        par.IdMesPago = Convert.ToInt32(item.IdMesPago);
                        par.Formula = item.Formula;
                        par.Porcentaje = Convert.ToDouble(item.Porcentaje);
                        par.Orden = Convert.ToInt32(item.Orden);
                        par.File = item.File;

                        par.FechaIni = Convert.ToDateTime(item.FechaIni);
                        par.FechaFin = Convert.ToDateTime(item.FechaFin);

                        param.Add(par);
                    }
                }
                return param;
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

        public Boolean GrabarDB(List<ro_Config_Rubros_ParametrosGenerales_Info> Info, int IncrementaColumnas)
        {
            try
            {
                if (EliminarDB(Info, IncrementaColumnas) == true)
                {
                    using (EntitiesRoles ro = new EntitiesRoles())
                    {
                        foreach (var item in Info)
                        {
                            ro_Config_Rubros_ParametrosGenerales paramGene = new ro_Config_Rubros_ParametrosGenerales();
                            paramGene.IdTipoParametro = item.IdTipoParametro;
                            paramGene.Descripcion = item.Descripcion;
                            paramGene.IdRubro = item.IdRubro;
                            paramGene.IdMesPago = item.IdMesPago;
                            paramGene.Formula = item.Formula;
                            paramGene.Porcentaje = item.Porcentaje;
                            paramGene.Orden = (item.Orden == 0) ? GetOrden() + 1 : item.Orden;

                            ro.ro_Config_Rubros_ParametrosGenerales.Add(paramGene);
                            ro.SaveChanges();
                        }
                    }
                }
                else
                {
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

        public Boolean EliminarDB(List<ro_Config_Rubros_ParametrosGenerales_Info> Info, int IncrementaColumnas)
        {
            try
            {
                using (EntitiesRoles ro = new EntitiesRoles())
                {
                    int i = 0;
                    int Resta = Info.Count - IncrementaColumnas;
                    foreach (var item in Info)
                    {
                        i++;
                        if (i <= Resta)
                        {
                            ro_Config_Rubros_ParametrosGenerales paramGene = ro.ro_Config_Rubros_ParametrosGenerales.First(v => v.IdTipoParametro == item.IdTipoParametro);
                            ro.ro_Config_Rubros_ParametrosGenerales.Remove(paramGene);
                            ro.SaveChanges();
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
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public int GetOrden()
        {
            try
            {

                EntitiesRoles rol = new EntitiesRoles();

                var Id = (from q in rol.ro_Config_Rubros_ParametrosGenerales
                          select q.Orden).Max();

                return Convert.ToInt32(Id);
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

        public void Guardarxsd(byte[] xsd)
        {
            try
            {
                //using (EntitiesRoles rol = new EntitiesRoles())
                //{
                //    string query = "update ro_Config_Rubros_ParametrosGenerales set [File]=" + xsd + "where Orden=" + 99;
                //    rol.Database.ExecuteSqlCommand(query);
                //    //return true;
                //}
                using (EntitiesRoles ro = new EntitiesRoles())
                {
                    //foreach (var item in Info)
                    //{
                    ro_Config_Rubros_ParametrosGenerales paramGene = new ro_Config_Rubros_ParametrosGenerales();
                    paramGene.IdTipoParametro = "FILEXSD107";
                    paramGene.Descripcion = "File XSD para formulario 107";
                    paramGene.IdRubro = null;
                    paramGene.IdMesPago = null;
                    paramGene.Formula = "";
                    paramGene.Porcentaje = 0;
                    paramGene.Orden = 99;
                    paramGene.File = xsd;

                    ro.ro_Config_Rubros_ParametrosGenerales.Add(paramGene);
                    ro.SaveChanges();
                    //}
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
    }
}
