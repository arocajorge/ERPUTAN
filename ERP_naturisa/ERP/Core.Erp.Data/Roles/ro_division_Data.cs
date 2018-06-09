using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_division_Data
    {


    string mensaje = "";

    public int getId(int IdEmpresa)
        {
            try
            {
               int Id;
               EntitiesRoles OEEmpleado = new EntitiesRoles();
               var select = from q in OEEmpleado.ro_Division
                            where q.IdEmpresa == IdEmpresa
                            select q;

               if (select.Count()==0)
               {
                   Id = 1;
               }
               else
               {
                   var select_em = (from q in OEEmpleado.ro_Division
                                    where q.IdEmpresa == IdEmpresa
                                    select q.IdDivision).Max();
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

	public Boolean GuardarDB(ref ro_division_Info Info ,ref string msg)
	{
		try
		{
			List<ro_division_Info> Lst = new List<ro_division_Info>() ;
            using(EntitiesRoles Context= new EntitiesRoles())
            {
                //var contact = ro_division.Createro_division(0,0,"","");
                var Address = new ro_Division();
                   

                Address.IdEmpresa= Info.IdEmpresa;
                Info.IdDivision = Address.IdDivision = getId(Info.IdEmpresa);
                Address.Descripcion= Info.Descripcion;
                Address.estado= "A";

                
                Context.ro_Division.Add(Address);
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


    public List<ro_division_Info> ConsultaGeneral(int IdEmpresa)
    {
         List<ro_division_Info> Lst = new List<ro_division_Info>();
        try
        {
 
            EntitiesRoles oEnti = new EntitiesRoles();
            var Query = from q in oEnti.ro_Division
                        where q.IdEmpresa == IdEmpresa
                        select q;
            foreach (var item in Query)
            {
                ro_division_Info Obj = new ro_division_Info();
                Obj.IdEmpresa = IdEmpresa;
                Obj.IdDivision = item.IdDivision;
                Obj.Descripcion = item.Descripcion;
                Obj.estado = item.estado;
                Obj.MotivoAnulacion = item.MotiAnula;
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


	public ro_division_Info ObtenerObjeto(int IdEmpresa,int IdDivision)
	{
			EntitiesRoles oEnti= new EntitiesRoles();
		    ro_division_Info Info = new ro_division_Info() ;
		    try
		    {

                var Objeto = oEnti.ro_Division.First(var => var.IdEmpresa == IdEmpresa && var.IdDivision == IdDivision);
                Info.Descripcion = Objeto.Descripcion;
                Info.estado = Objeto.estado;
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


    public Boolean ModificarDB(ro_division_Info info, ref string msg )
    {
        try
        {
            using (EntitiesRoles context = new EntitiesRoles())
            {
                var contact = context.ro_Division.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdDivision == info.IdDivision);
                contact.Descripcion = info.Descripcion;
                contact.estado = info.estado;
                contact.MotiAnula = "";
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


    public Boolean Anular(ro_division_Info info, ref string msg)
    {
        try
        {
            using (EntitiesRoles context = new EntitiesRoles())
            {
                var contact = context.ro_Division.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdDivision == info.IdDivision);
                contact.estado = "I";
                contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                contact.Fecha_UltAnu = info.Fecha_UltAnu;
                contact.MotiAnula = info.MotivoAnulacion;
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
    }
}
