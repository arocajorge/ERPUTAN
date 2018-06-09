using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Inventario
{
   public  class in_UnidadMedida_Equiv_conversion_Data
    {
        string mensaje = "";
        public List<in_UnidadMedida_Equiv_conversion_Info> Get_List_in_UnidadMedida_Equiv_conversion(string IdUnidadMedida)
        {
            try
            {
                List<in_UnidadMedida_Equiv_conversion_Info> lM = new List<in_UnidadMedida_Equiv_conversion_Info>();
                EntitiesInventario OEUser = new EntitiesInventario();

                var select_ = from TI in OEUser.in_UnidadMedida_Equiv_conversion
                              where TI.IdUnidadMedida == IdUnidadMedida
                              select TI;

                foreach (var item in select_)
                {
                    in_UnidadMedida_Equiv_conversion_Info dat_ = new in_UnidadMedida_Equiv_conversion_Info();
                    dat_.IdUnidadMedida = item.IdUnidadMedida;
                    dat_.IdUnidadMedida_equiva = item.IdUnidadMedida_equiva;
                    dat_.valor_equiv = item.valor_equiv;
                    dat_.interpretacion = item.interpretacion;
                    lM.Add(dat_);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public Boolean GrabarDB(in_UnidadMedida_Equiv_conversion_Info prI, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    EntitiesInventario EDB = new EntitiesInventario();
                    
                    var Q = from per in EDB.in_UnidadMedida_Equiv_conversion
                            where per.IdUnidadMedida == prI.IdUnidadMedida
                            && per.IdUnidadMedida_equiva == prI.IdUnidadMedida_equiva
                            select per;

                    if (Q.ToList().Count == 0)
                    {
                        var address = new in_UnidadMedida_Equiv_conversion();
                        address.IdUnidadMedida = prI.IdUnidadMedida;
                        address.IdUnidadMedida_equiva = prI.IdUnidadMedida_equiva;
                        address.valor_equiv = prI.valor_equiv;
                        address.interpretacion = prI.interpretacion;
                        context.in_UnidadMedida_Equiv_conversion.Add(address);
                        context.SaveChanges();
                        mensaje = "Grabacion ok..";
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }




        }

        public Boolean ModificarDB(in_UnidadMedida_Equiv_conversion_Info prI, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_UnidadMedida_Equiv_conversion.FirstOrDefault(VProdu => VProdu.IdUnidadMedida == prI.IdUnidadMedida && VProdu.IdUnidadMedida_equiva == prI.IdUnidadMedida_equiva);
                    if (contact != null)
                    {
                        contact.valor_equiv = prI.valor_equiv;
                        contact.interpretacion = prI.interpretacion;
                        context.SaveChanges();
                        mensaje = "Grabacion ok...";
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
                throw new Exception(mensaje);
            }
        }

        public Boolean GuardarListDB(List<in_UnidadMedida_Equiv_conversion_Info> Lista,ref string mensaje)
        {
            try
            {
                foreach (var item in Lista)
                {
                    GrabarDB(item, ref mensaje);
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
                throw new Exception(mensaje);
            }
        }

        public Boolean EliminarDB(string IdUnidadMedida,ref string mensaje)
        {
            try
            {
                using (EntitiesInventario Entity = new EntitiesInventario())
                {
                    int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete in_UnidadMedida_Equiv_conversion where IdUnidadMedida='" + IdUnidadMedida + "'");
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
                throw new Exception(mensaje);
            }
        }

        public in_UnidadMedida_Equiv_conversion_Info Get_Info_in_UnidadMedida_Equiv_conversion(string IdUnidadMedida, string IdUnidadMedida_equiva)
        {
            try
            {
                in_UnidadMedida_Equiv_conversion_Info Info = new in_UnidadMedida_Equiv_conversion_Info();
                using (EntitiesInventario listado = new EntitiesInventario())
                {
                    IQueryable<in_UnidadMedida_Equiv_conversion> select;

                    select = from q in listado.in_UnidadMedida_Equiv_conversion
                                 where q.IdUnidadMedida == IdUnidadMedida
                                 && q.IdUnidadMedida_equiva == IdUnidadMedida_equiva
                                 select q;

                    foreach (var item in select)
                    {
                        Info.IdUnidadMedida = item.IdUnidadMedida;
                        Info.IdUnidadMedida_equiva = item.IdUnidadMedida_equiva;
                        Info.valor_equiv = item.valor_equiv;
                        Info.interpretacion = item.interpretacion;
                    }
                    
                    //Si no existe una equivalencia, busco por la misma equivalencia al revez
                    if (select.Count() == 0)
                    {
                        select = from q in listado.in_UnidadMedida_Equiv_conversion
                                 where q.IdUnidadMedida == IdUnidadMedida_equiva
                                 && q.IdUnidadMedida_equiva == IdUnidadMedida
                                 select q;

                        foreach (var item in select)
                        {
                            //Si existe la equivalencia la grabo en la base
                            Info.IdUnidadMedida = item.IdUnidadMedida_equiva;
                            Info.IdUnidadMedida_equiva = item.IdUnidadMedida;
                            Info.valor_equiv = 1 / item.valor_equiv;
                            Info.interpretacion = "1 "+Info.IdUnidadMedida+" equivale a "+Info.valor_equiv.ToString()+" "+Info.IdUnidadMedida_equiva;

                            GrabarDB(Info, ref mensaje);
                        }
                    }
                    
                }
                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                return new in_UnidadMedida_Equiv_conversion_Info();
            }
        }

       public in_UnidadMedida_Equiv_conversion_Data()
       {

       }

      
   }
}
