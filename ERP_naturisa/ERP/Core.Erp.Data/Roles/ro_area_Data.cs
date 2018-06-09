using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_area_Data
    {
        string mensaje = "";

        public int getId(int IdEmpresa , int IdDivision)
        {
            try
            {
                 int Id;
                    EntitiesRoles OEEmpleado = new EntitiesRoles();
                    var select = from q in OEEmpleado.ro_area
                                 where q.IdEmpresa == IdEmpresa && q.IdDivision == IdDivision
                                 select q;

                    if (select.ToList().Count() == 0)
                    {
                        Id = 1;
                    }
                    else
                    {
                        var select_em = (from q in OEEmpleado.ro_area
                                         where q.IdEmpresa == IdEmpresa && q.IdDivision == IdDivision
                                         select q.IdArea).Max();
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

        public Boolean GuardarDB(ref ro_area_Info Info)
	    {
		    try
		    {
			    List<ro_area_Info> Lst = new List<ro_area_Info>() ;
			    using(EntitiesRoles Context= new EntitiesRoles())
			    {
                    var Address = new ro_area();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdDivision = Info.IdDivision;
                    Info.IdArea = Address.IdArea = getId(Info.IdEmpresa, Info.IdDivision);
                    Address.estado = "A";
                    Address.Descripcion = Info.Descripcion;
                    Address.IdUsuario = Info.IdUsuario;
                    Address.Fecha_Transac = Info.FechaTransac;
                    Address.IdUsuarioUltMod = Info.IdUsuarioUltModi;
                    Address.Fecha_UltMod = Info.FechaUltModi;

                    Context.ro_area.Add(Address);
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

        public List<ro_area_Info> Get_List_area(int IdEmpresa)
	    {
			        List<ro_area_Info> Lst = new List<ro_area_Info>() ;
		    try
		    {
			        EntitiesRoles oEnti= new EntitiesRoles();
			        var Query = from q in oEnti.vwRo_Area_x_Division
                            where q.IdEmpresa == IdEmpresa
				    select q;

			        foreach (var item in Query)
		    	    {
				        ro_area_Info Obj = new ro_area_Info() ;
					    Obj.IdEmpresa= item.IdEmpresa;
					    Obj.IdDivision= item.IdDivision;
					    Obj.IdArea= item.IdArea;
					    Obj.Estado= item.estado;
					    Obj.Descripcion= item.Descripcion;
                        Obj.Descripcion_Division = item.Descripcion_Division;
                        Obj.MotivoAnu = item.MotiAnula
;
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

        public ro_area_Info Get_Info_area(int IdEmpresa, int IdDivision, int IdArea)
	    { 
            ro_area_Info Info = new ro_area_Info() ;
			EntitiesRoles oEnti= new EntitiesRoles();
		    try
		    {				  
                    var Objeto = oEnti.ro_area.First(var => var.IdEmpresa == IdEmpresa && var.IdDivision == IdDivision && var.IdArea == IdArea);
                    Info.IdEmpresa = Objeto.IdEmpresa;
                    Info.IdDivision = Objeto.IdDivision;
                    Info.IdArea = Objeto.IdArea;
                    Info.Estado = Objeto.estado;
                    Info.Descripcion = Objeto.Descripcion;
				    return Info;
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

        public Boolean ModificarDB(ro_area_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_area.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdDivision == info.IdDivision && minfo.IdArea == info.IdArea);
                    if (contact != null)
                    {
                        contact.IdDivision = info.IdDivision;
                        contact.Descripcion = info.Descripcion;
                        contact.estado = info.Estado;
                        contact.Fecha_Transac = info.FechaTransac;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltModi;
                        contact.Fecha_UltMod = info.FechaUltModi;
                        contact.MotiAnula = "";
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
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean AnularDB(ro_area_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_area.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdDivision == info.IdDivision && minfo.IdArea == info.IdArea);
                    contact.estado = "I";
                    contact.Fecha_UltAnu =  info.FechaTransac;
                    contact.IdUsuarioUltAnu = info.IdUsuarioAnu;
                    contact.MotiAnula = info.MotivoAnu;
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

        public List<ro_area_Info> Get_List_area(int IdEmpresa, int IdDivision) 
        {
                List<ro_area_Info> lst = new List<ro_area_Info>();
            try
            {

                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var Consulta = from q in rol.ro_area
                                   where q.IdEmpresa == IdEmpresa &&
                                         q.IdDivision == IdDivision
                                   select q;
                    foreach (var item in Consulta)
                    {
                        ro_area_Info Obj = new ro_area_Info() ;
					    Obj.IdEmpresa= item.IdEmpresa;
					    Obj.IdDivision= item.IdDivision;
					    Obj.IdArea= item.IdArea;
					    Obj.Estado= item.estado;
					    Obj.Descripcion= item.Descripcion;                        
			    	    lst.Add(Obj);
                    }
                }
                return lst;
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
