using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Contabilidad
{
   public  class ct_GrupoEmpresarial_plancta_Data
    {
       string mensaje = "";

    public Boolean GrabarDB(ct_GrupoEmpresarial_plancta_Info Info)
    {
        try
        {
            List<ct_GrupoEmpresarial_plancta_Info> Lst = new List<ct_GrupoEmpresarial_plancta_Info>();
            using (EntitiesDBConta Context = new EntitiesDBConta())
            {
                var Address = new ct_GrupoEmpresarial_plancta();

                Address.IdCuenta_gr = Info.IdCuenta_gr;
                Address.pc_Cuenta_gr = Info.pc_Cuenta_gr;
                Address.IdCuentaPadre_gr = Info.IdCuentaPadre_gr;
                Address.pc_Naturaleza = Info.pc_Naturaleza;
                Address.IdNivelCta_gr = Info.IdNivelCta_gr;
                Address.IdGrupoCble_gr = Info.IdGrupoCble_gr;
                Address.pc_EsMovimiento = Info.pc_EsMovimiento;
                Address.pc_Estado = Info.pc_Estado;

                Context.ct_GrupoEmpresarial_plancta.Add(Address);
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

    public List<ct_GrupoEmpresarial_plancta_Info> Get_list_GrupoEmpresarial_plancta()
    { 
    try
    {
	    List<ct_GrupoEmpresarial_plancta_Info> Lst = new List<ct_GrupoEmpresarial_plancta_Info>() ;
	    EntitiesDBConta oEnti= new EntitiesDBConta();
	    var Query = from q in oEnti.ct_GrupoEmpresarial_plancta
		    select q;
		    foreach (var item in Query)
	    {
		    ct_GrupoEmpresarial_plancta_Info Obj = new ct_GrupoEmpresarial_plancta_Info() ;
			    Obj.IdCuenta_gr= item.IdCuenta_gr;
			    Obj.pc_Cuenta_gr= item.pc_Cuenta_gr;
			    Obj.IdCuentaPadre_gr= item.IdCuentaPadre_gr;
			    Obj.pc_Naturaleza= item.pc_Naturaleza;
			    Obj.IdNivelCta_gr= item.IdNivelCta_gr;
			    Obj.IdGrupoCble_gr= item.IdGrupoCble_gr;
			    Obj.pc_EsMovimiento= item.pc_EsMovimiento;
			    Obj.pc_Estado= item.pc_Estado;
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

    public ct_GrupoEmpresarial_plancta_Info Get_Info_GrupoEmpresarial_plancta(string IdCuenta_gr)
	{
			EntitiesDBConta oEnti= new EntitiesDBConta();
		try
		{
				ct_GrupoEmpresarial_plancta_Info Info = new ct_GrupoEmpresarial_plancta_Info() ;
                var Objeto = oEnti.ct_GrupoEmpresarial_plancta.First(var => var.IdCuenta_gr == IdCuenta_gr);
					Info.IdCuenta_gr= Objeto.IdCuenta_gr;
					Info.pc_Cuenta_gr= Objeto.pc_Cuenta_gr;
					Info.IdCuentaPadre_gr= Objeto.IdCuentaPadre_gr;
					Info.pc_Naturaleza= Objeto.pc_Naturaleza;
					Info.IdNivelCta_gr= Objeto.IdNivelCta_gr;
					Info.IdGrupoCble_gr= Objeto.IdGrupoCble_gr;
					Info.pc_EsMovimiento= Objeto.pc_EsMovimiento;
					Info.pc_Estado= Objeto.pc_Estado;
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

    public Boolean ModificarDB(ct_GrupoEmpresarial_plancta_Info info)
    {
        try
        {
            using (EntitiesDBConta context = new EntitiesDBConta())
            {
                var contact = context.ct_GrupoEmpresarial_plancta.FirstOrDefault(minfo => minfo.IdCuenta_gr == info.IdCuenta_gr );

                if (contact != null)
                {

                    contact.pc_Cuenta_gr = info.pc_Cuenta_gr.Trim();
                    contact.IdCuentaPadre_gr = (info.IdCuentaPadre_gr.Trim() == "") ? null : info.IdCuentaPadre_gr;
                    contact.pc_Naturaleza = info.pc_Naturaleza;
                    contact.IdNivelCta_gr = Convert.ToByte(info.IdNivelCta_gr);
                    contact.IdGrupoCble_gr = info.IdGrupoCble_gr;
                    contact.pc_Estado = info.pc_Estado;
                    contact.pc_EsMovimiento = info.pc_EsMovimiento;

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

    public Boolean EliminarDB(ct_GrupoEmpresarial_plancta_Info info)
    {
        try
        {
            Boolean res = false;

            using (EntitiesDBConta context = new EntitiesDBConta())
            {
                var contact = context.ct_GrupoEmpresarial_plancta.FirstOrDefault(minfo => minfo.IdCuenta_gr == info.IdCuenta_gr);

                if (contact != null)
                {

                    var padre = (from C in context.ct_GrupoEmpresarial_plancta
                                 where C.IdCuentaPadre_gr == info.IdCuenta_gr
                                 select C.IdCuenta_gr).Count();
                    if (padre == 0)
                    {
                        contact.pc_Estado = "I";
                        context.SaveChanges();
                        res= true;
                    }
                    else
                    {
                        res= false;
                    }
                }
            }
            return res;
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

    public ct_GrupoEmpresarial_plancta_Data()
    {
       
    }
    }
}
