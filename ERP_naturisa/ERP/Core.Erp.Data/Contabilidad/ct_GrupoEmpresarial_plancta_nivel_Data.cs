using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_GrupoEmpresarial_plancta_nivel_Data
    {
        string mensaje = "";

        public Boolean GrabarDB(ct_GrupoEmpresarial_plancta_nivel_Info Info,ref int ID)
        {
            try
            {
                List<ct_GrupoEmpresarial_plancta_nivel_Info> Lst = new List<ct_GrupoEmpresarial_plancta_nivel_Info>();
                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    var Address = new ct_GrupoEmpresarial_plancta_nivel();
                    ID = Get_Id();
                    Address.IdNivelCta_gr = ID;
                    Address.nv_NumDigitos_gr = Info.nv_NumDigitos_gr;
                    Address.nv_Descripcion_gr = Info.nv_Descripcion_gr;
                    Context.ct_GrupoEmpresarial_plancta_nivel.Add(Address);
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

        public int Get_Id()
        {
            try
            {
                 int Id;
                EntitiesDBConta base_ = new EntitiesDBConta();

                var q = from C in base_.ct_GrupoEmpresarial_plancta_nivel
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from CbtCble in base_.ct_GrupoEmpresarial_plancta_nivel
                                   select CbtCble.IdNivelCta_gr).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                   
                }
                return Id;
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

        public List<ct_GrupoEmpresarial_plancta_nivel_Info> Get_list_GrupoEmpresarial_plancta_nivel()
	    {
		    try
		    {
			    List<ct_GrupoEmpresarial_plancta_nivel_Info> Lst = new List<ct_GrupoEmpresarial_plancta_nivel_Info>() ;
			    EntitiesDBConta oEnti= new EntitiesDBConta();
			    var Query = from q in oEnti.ct_GrupoEmpresarial_plancta_nivel
				    select q;
			     foreach (var item in Query)
			    {
				    ct_GrupoEmpresarial_plancta_nivel_Info Obj = new ct_GrupoEmpresarial_plancta_nivel_Info() ;
					    Obj.IdNivelCta_gr= item.IdNivelCta_gr;
					    Obj.nv_NumDigitos_gr= item.nv_NumDigitos_gr;
					    Obj.nv_Descripcion_gr= item.nv_Descripcion_gr;
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

        public Boolean ModificarDB(ct_GrupoEmpresarial_plancta_nivel_Info info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_GrupoEmpresarial_plancta_nivel.FirstOrDefault(minfo => minfo.IdNivelCta_gr == info.IdNivelCta_gr);
                    if (contact != null)
                    {
                        contact.nv_Descripcion_gr = info.nv_Descripcion_gr;
                        contact.nv_NumDigitos_gr = info.nv_NumDigitos_gr;
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

        public ct_GrupoEmpresarial_plancta_nivel_Info Get_Info_GrupoEmpresarial_plancta_nivel(int IdNivelCta_gr)
	        {
			        EntitiesDBConta oEnti= new EntitiesDBConta();
		        try
		        {
				        ct_GrupoEmpresarial_plancta_nivel_Info Info = new ct_GrupoEmpresarial_plancta_nivel_Info() ;
                        var Objeto = oEnti.ct_GrupoEmpresarial_plancta_nivel.First(var => var.IdNivelCta_gr == IdNivelCta_gr);
					        Info.IdNivelCta_gr= Objeto.IdNivelCta_gr;
					        Info.nv_NumDigitos_gr= Objeto.nv_NumDigitos_gr;
					        Info.nv_Descripcion_gr= Objeto.nv_Descripcion_gr;
				        return Info;
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

        public ct_GrupoEmpresarial_plancta_nivel_Data()
            {
               
            }
    }
}
