using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Roles
{
    public class ro_CatalogoTipo_Data
    {
        string mensaje = "";
        public int getId()
        {
            try
            {
                int Id;
                EntitiesRoles OEEmpleado = new EntitiesRoles();
                var select = from q in OEEmpleado.ro_catalogoTipo
                             select q;

                if (select.ToList().Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in OEEmpleado.ro_catalogoTipo
                                     //where q.IdTipoCatalogo == IdTipoCatalogo
                                     select q.IdTipoCatalogo).Max();
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

        public Boolean ValidarCodigoExiste(string Cod) 
        {
            try
            {
                EntitiesRoles Ent = new EntitiesRoles();

                var Existe = from q in Ent.ro_catalogoTipo
                             where q.Codigo == Cod
                             select q;
                if (Existe.ToList().Count() > 0)
                {
                    return true;
                }
                else 
                {
                    return false;
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
    	
        public Boolean GuardarDB(ref ro_CatalogoTipo_Info Info)
	{
		try
		{
			List<ro_CatalogoTipo_Info> Lst = new List<ro_CatalogoTipo_Info>() ;
			using(EntitiesRoles Context= new EntitiesRoles())
			{
				var Address = new ro_catalogoTipo();

				Address.IdTipoCatalogo= Info.IdTipoCatalogo = getId();
				Address.Codigo= Info.Codigo;
				Address.tc_Descripcion= Info.tc_Descripcion;

                Context.ro_catalogoTipo.Add(Address);
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

        public List<ro_CatalogoTipo_Info> Get_List_CatalogoTipo(int IdEmpresa)
	    {
			    List<ro_CatalogoTipo_Info> Lst = new List<ro_CatalogoTipo_Info>() ;
		    try
		    {

			    EntitiesRoles oEnti= new EntitiesRoles();
			    var Query = from q in oEnti.ro_catalogoTipo
                            
                            select q;  
			     foreach (var item in Query)
			    {
				    ro_CatalogoTipo_Info Obj = new ro_CatalogoTipo_Info();
					    Obj.IdTipoCatalogo= item.IdTipoCatalogo;
					    Obj.Codigo= item.Codigo;
					    Obj.tc_Descripcion= item.tc_Descripcion;
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

        public ro_CatalogoTipo_Info Get_Info_CatalogoTipo(int IdTipoCatalogo)
	    {
			    EntitiesRoles oEnti= new EntitiesRoles();
		        ro_CatalogoTipo_Info Info = new ro_CatalogoTipo_Info() ;
		        try
		        {

			        var Objeto = oEnti.ro_catalogoTipo.First(var => var.IdTipoCatalogo == IdTipoCatalogo);
					    Info.IdTipoCatalogo= Objeto.IdTipoCatalogo;
					    Info.Codigo= Objeto.Codigo;
					    Info.tc_Descripcion= Objeto.tc_Descripcion;
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

        public Boolean ModificarDB(ro_CatalogoTipo_Info Info, string msj)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    var contact = context.ro_catalogoTipo.First(var => var.IdTipoCatalogo == Info.IdTipoCatalogo);

                    contact.tc_Descripcion = Info.tc_Descripcion;
                    //contact.ca_orden = Info.ca_orden;


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
