using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_TablaSectorial_Data
    {
        string mensaje = "";  
        public Boolean GuardarDB(ref ro_TablaSectorial_Info Info)
        {

            try
            {
                List<ro_TablaSectorial_Info> Lst = new List<ro_TablaSectorial_Info>();  
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    var Address = new ro_TablaSectorial();

                    Info.IdCodSectorial = Address.IdCodSectorial = getId(Info.IdCodSectorial);
                    Address.CodigoIESS = Info.CodigoIESS;
                    Address.Actividad = Info.Actividad;
                    Address.EstructuraOcupacional = Info.EstructuraOcupacional;
                    Address.Estado = "A";

                    //contact = Address;
                    //Context.ro_TablaSectorial.Add(contact);
                    Context.ro_TablaSectorial.Add(Address);

                    Context.SaveChanges();
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

        public List<ro_TablaSectorial_Info> Get_List_TablaSectorial()
        {
             List<ro_TablaSectorial_Info> Lst = new List<ro_TablaSectorial_Info>();
            try
            {

                EntitiesRoles oEnti = new EntitiesRoles();
                var Query = from q in oEnti.ro_TablaSectorial

                            select q;

                foreach (var item in Query)
                {
                    ro_TablaSectorial_Info Obj = new ro_TablaSectorial_Info();
                    Obj.IdCodSectorial = item.IdCodSectorial;
                    Obj.CodigoIESS = item.CodigoIESS;
                    Obj.Actividad = item.Actividad;
                    Obj.EstructuraOcupacional = item.EstructuraOcupacional;
                    Obj.Estado = item.Estado; 

                    Lst.Add(Obj);
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

        public ro_TablaSectorial_Info Get_Info_TablaSectorial(int IdCodSectorial)
        {
            EntitiesRoles oEnti = new EntitiesRoles();
             ro_TablaSectorial_Info Info = new ro_TablaSectorial_Info();
            try
            {

                var Objeto = oEnti.ro_TablaSectorial.First(var => var.IdCodSectorial == IdCodSectorial);
                Info.CodigoIESS = Objeto.CodigoIESS;
                Info.Actividad = Objeto.Actividad;
                Info.EstructuraOcupacional = Objeto.EstructuraOcupacional;
                Info.Estado = Objeto.Estado;
                
                return Info;
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

        public Boolean ModificarDB(ro_TablaSectorial_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    var contact = context.ro_TablaSectorial.First(minfo => minfo.IdCodSectorial == info.IdCodSectorial);
                    contact.CodigoIESS = info.CodigoIESS;
                    contact.Actividad = info.Actividad;
                    contact.EstructuraOcupacional = info.EstructuraOcupacional;
                    contact.Estado = info.Estado;

                    context.SaveChanges();


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

        public Boolean AnularDB(ro_TablaSectorial_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    var contact = context.ro_TablaSectorial.First(minfo => minfo.IdCodSectorial == info.IdCodSectorial);
                    contact.Estado = "I";
                    context.SaveChanges();

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

        public int getId(int IdCodSectorial)
        {
            try
            {
                int Id;
                EntitiesRoles OEEmpleado = new EntitiesRoles();
                var select = from q in OEEmpleado.ro_TablaSectorial
                             select q;

                if (select.ToList().Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in OEEmpleado.ro_TablaSectorial
                                     select q.IdCodSectorial).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }
                return Id;
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
