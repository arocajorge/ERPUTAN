/*CLASE: ro_Tabla_Impu_Renta_Data
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 08-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
//Tabla Impuestos a la renta
//Derek Mejía Soria
//ultima modificacion : 08/01/2014
namespace Core.Erp.Data.Roles
{
    public class ro_Tabla_Impu_Renta_Data
    {
        string mensaje = "";
        public List<ro_tabla_Impu_Renta_Info> Get_List_tabla_Impu_Renta()
        {
                List<ro_tabla_Impu_Renta_Info> Lst = new List<ro_tabla_Impu_Renta_Info>();
            try
            {

                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var consultar = from q in rol.ro_tabla_Impu_Renta
                                    orderby q.Secuencia
                                    select q;
                    foreach (var item in consultar)
                    {
                        ro_tabla_Impu_Renta_Info info = new ro_tabla_Impu_Renta_Info();
                        info.AnioFiscal = item.AnioFiscal;
                        info.Secuencia = item.Secuencia;
                        info.FraccionBasica = Convert.ToDouble(item.FraccionBasica);
                        info.ExcesoHasta = Convert.ToDouble(item.ExcesoHasta);
                        info.ImpFraccionBasica = Convert.ToDouble(item.ImpFraccionBasica);
                        info.Por_ImpFraccion_Exce = Convert.ToDouble(item.Por_ImpFraccion_Exce);
                        Lst.Add(info);
                    }
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ro_tabla_Impu_Renta_Info> Get_List_tabla_Impu_Renta(int anio)
        {
               List<ro_tabla_Impu_Renta_Info> Lst = new List<ro_tabla_Impu_Renta_Info>();
            try
            {

                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var consultar = from q in rol.ro_tabla_Impu_Renta
                                    where q.AnioFiscal == anio
                                    orderby q.Secuencia
                                    select q;
                    foreach (var item in consultar)
                    {
                        ro_tabla_Impu_Renta_Info info = new ro_tabla_Impu_Renta_Info();
                        info.AnioFiscal = item.AnioFiscal;
                        info.Secuencia = item.Secuencia;
                        info.FraccionBasica = Convert.ToDouble(item.FraccionBasica);
                        info.ExcesoHasta = Convert.ToDouble(item.ExcesoHasta);
                        info.ImpFraccionBasica = Convert.ToDouble(item.ImpFraccionBasica);
                        info.Por_ImpFraccion_Exce = Convert.ToDouble(item.Por_ImpFraccion_Exce);
                        Lst.Add(info);
                    }
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public ro_tabla_Impu_Renta_Info Get_Info_FraccionBasica(int anio, ref string msg)
        {
            ro_tabla_Impu_Renta_Info info = new ro_tabla_Impu_Renta_Info();
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var consultar = from q in db.ro_tabla_Impu_Renta
                                    where q.AnioFiscal == anio && q.FraccionBasica==0 
                                    && q.ImpFraccionBasica==0 && q.Por_ImpFraccion_Exce==0
                                    select q;
                    foreach (var item in consultar)
                    {
                       info.AnioFiscal = item.AnioFiscal;
                        info.Secuencia = item.Secuencia;
                        info.FraccionBasica = Convert.ToDouble(item.FraccionBasica);
                        info.ExcesoHasta = Convert.ToDouble(item.ExcesoHasta);
                        info.ImpFraccionBasica = Convert.ToDouble(item.ImpFraccionBasica);
                        info.Por_ImpFraccion_Exce = Convert.ToDouble(item.Por_ImpFraccion_Exce);
                        
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean EliminarDB(ro_tabla_Impu_Renta_Info info)
        {
            try
            {
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var Quer = (from q in rol.ro_tabla_Impu_Renta
                                where q.Secuencia == info.Secuencia
                                select q);

                    if (Quer.Count() >0)
                    {
                        ro_tabla_Impu_Renta dato = rol.ro_tabla_Impu_Renta.First(v => v.Secuencia == info.Secuencia);
                        rol.ro_tabla_Impu_Renta.Remove(dato);
                        rol.SaveChanges();
                    }

                    
                }
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public Boolean GrabarDB(ro_tabla_Impu_Renta_Info info)
        {
            try
            {
                EliminarDB(info);
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    ro_tabla_Impu_Renta db = new ro_tabla_Impu_Renta();
                    db.AnioFiscal = info.AnioFiscal;
                    db.Secuencia = info.Secuencia;
                    db.FraccionBasica = info.FraccionBasica;
                    db.ExcesoHasta = info.ExcesoHasta;
                    db.ImpFraccionBasica = info.ImpFraccionBasica;
                    db.Por_ImpFraccion_Exce = info.Por_ImpFraccion_Exce;

                    rol.ro_tabla_Impu_Renta.Add(db);
                    rol.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public int GetSecuencia()
        {
            try
            {
                int secuencia = 0;
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                  var  Quer = (from q in rol.ro_tabla_Impu_Renta
                                 select q);

                  if (Quer.Count() == 0)
                  {
                      secuencia = 1;
                  }
                  else
                  {

                      secuencia = (from q in rol.ro_tabla_Impu_Renta
                                   select q.Secuencia).Max()+1;
                  }

                }
                return secuencia ;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


    }
}
