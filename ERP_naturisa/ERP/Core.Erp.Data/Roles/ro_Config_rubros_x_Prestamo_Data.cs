using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_Config_rubros_x_Prestamo_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(ro_Config_rubros_x_Prestamo_Info Info)
        {
            try
            {
                List<ro_Config_rubros_x_Prestamo_Info> Lst = new List<ro_Config_rubros_x_Prestamo_Info>();
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                   
                    ro_Config_rubros_x_Prestamo Data = new ro_Config_rubros_x_Prestamo();

                    Data.IdEmpresa = Info.IdEmpresa;
                    Data.IdRubro = Info.IdRubro;
                    Data.orden = getId(Info.IdEmpresa);

                    Context.ro_Config_rubros_x_Prestamo.Add(Data);
                    Context.SaveChanges();

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


        public int getId(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesRoles OEEmpleado = new EntitiesRoles();
                var select = from q in OEEmpleado.ro_Config_rubros_x_Prestamo
                             where q.IdEmpresa == IdEmpresa
                             select q;

                if (select.ToList().Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in OEEmpleado.ro_Config_rubros_x_Prestamo
                                     where q.IdEmpresa == IdEmpresa
                                     select q.orden).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }
                return Id;
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


        public Boolean ModificarDB(ro_Config_rubros_x_Prestamo_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_Config_rubros_x_Prestamo.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdRubro == info.IdRubro);
                    contact.orden= info.orden;
                   

                    context.SaveChanges();

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


        public Boolean Borrar(ro_Config_rubros_x_Prestamo_Info Info)
        {
            try
            {

                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_Config_rubros_x_Prestamo.First(minfo => minfo.IdEmpresa == Info.IdEmpresa && minfo.IdRubro == Info.IdRubro);

                    context.ro_Config_rubros_x_Prestamo.Remove(contact);
                    context.SaveChanges();
                    context.Dispose();

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


        public List<ro_Config_rubros_x_Prestamo_Info> ConsultaGeneral(int IdEmpresa)
        {
                List<ro_Config_rubros_x_Prestamo_Info> Lst = new List<ro_Config_rubros_x_Prestamo_Info>();
                EntitiesRoles oEnti = new EntitiesRoles();
            try
            {

                var Query = from q in oEnti.ro_Config_rubros_x_Prestamo
                            where q.IdEmpresa == IdEmpresa
                            select q;

                foreach (var item in Query)
                {
                    ro_Config_rubros_x_Prestamo_Info Obj = new ro_Config_rubros_x_Prestamo_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdRubro = item.IdRubro;
                    Obj.orden = Convert.ToInt32(item.orden);
                    

                    Lst.Add(Obj);
                }
                return Lst;
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
