using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_GrupoEmpresarial_Data
    {
    string mensaje = "";

    public Boolean GrabarDB(ct_GrupoEmpresarial_Info Info)
	{
		try
		{
			List<ct_GrupoEmpresarial_Info> Lst = new List<ct_GrupoEmpresarial_Info>() ;
			using(EntitiesDBConta Context= new EntitiesDBConta())
			{
				
				var Address = new ct_GrupoEmpresarial();

				Address.IdGrupoEmpresarial= Info.IdGrupoEmpresarial;
				Address.GrupoEmpresarial= Info.GrupoEmpresarial;
				Address.Estado= Info.Estado;


                Context.ct_GrupoEmpresarial.Add(Address);
				Context.SaveChanges();
			}
		return true;
		}
		catch (Exception ex)
        {
            string arreglo = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                "", "", "", "", DateTime.Now);
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            mensaje = ex.ToString();
            throw new Exception(ex.ToString());
        }
	}

    public List<ct_GrupoEmpresarial_Info> Get_list_GrupoEmpresarial()
	                {
		                try
		                {
			                List<ct_GrupoEmpresarial_Info> Lst = new List<ct_GrupoEmpresarial_Info>() ;
			                EntitiesDBConta oEnti= new EntitiesDBConta();
			                var Query = from q in oEnti.ct_GrupoEmpresarial
				                select q;
			                foreach (var item in Query)
			                {
				                ct_GrupoEmpresarial_Info Obj = new ct_GrupoEmpresarial_Info() ;
					                Obj.IdGrupoEmpresarial= item.IdGrupoEmpresarial;
					                Obj.GrupoEmpresarial= item.GrupoEmpresarial;
					                Obj.Estado= item.Estado;
				                Lst.Add(Obj);
		                    }
			                return Lst;
			                }
		                catch (Exception ex)
                        {
                            string arreglo = ToString();
                            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                                "", "", "", "", DateTime.Now);
                            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                            mensaje = ex.ToString();
                            throw new Exception(ex.ToString());
                        }
			}

    public Boolean ModificarDB(ct_GrupoEmpresarial_Info info)
    {
        try
        {
            using (EntitiesDBConta context = new EntitiesDBConta())
            {
                var contact = context.ct_GrupoEmpresarial.FirstOrDefault(minfo => minfo.IdGrupoEmpresarial == info.IdGrupoEmpresarial);
                if (contact != null)
                {
                    contact.GrupoEmpresarial = info.GrupoEmpresarial;
                    contact.Estado = info.Estado;
                    context.SaveChanges();
                }

            }
            return true;
        }
        catch (Exception ex)
        {
            string arreglo = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                "", "", "", "", DateTime.Now);
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            mensaje = ex.ToString();
            throw new Exception(ex.ToString());
        }
    }

    public Boolean AnularDB(ct_GrupoEmpresarial_Info info)
    {
        try
        {
            using (EntitiesDBConta context = new EntitiesDBConta())
            {
                var contact = context.ct_GrupoEmpresarial.FirstOrDefault(minfo => minfo.IdGrupoEmpresarial == info.IdGrupoEmpresarial);
                if (contact != null)
                {
                    contact.Estado = "I";
                    context.SaveChanges();
                }
            }
            return true;
        }
        catch (Exception ex)
        {
            string arreglo = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                "", "", "", "", DateTime.Now);
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            mensaje = ex.ToString();
            throw new Exception(ex.ToString());
        }
    }

    public ct_GrupoEmpresarial_Data()
            {
               
            }
    }
}
