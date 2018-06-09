using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_cbtecble_Reversado_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(ct_cbtecble_Reversado_Info Info)
        {
            try
            {
                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    
                    var Address = new ct_cbtecble_Reversado();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdTipoCbte = Info.IdTipoCbte;
                    Address.IdCbteCble = Info.IdCbteCble;
                    Address.IdEmpresa_Anu = Info.IdEmpresa_Anu;
                    Address.IdTipoCbte_Anu = Info.IdTipoCbte_Anu;
                    Address.IdCbteCble_Anu = Info.IdCbteCble_Anu;
                    Context.ct_cbtecble_Reversado.Add(Address);
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

        public ct_cbtecble_Reversado_Info Get_CbteCble_Reversado_Info(int IdEmpresa, int IdTipoCbte,decimal IdCbteCble)
	    {
			EntitiesDBConta oEnti= new EntitiesDBConta();
		    try
		    {
				    ct_cbtecble_Reversado_Info Info = new ct_cbtecble_Reversado_Info() ;
			        var Objeto = oEnti.ct_cbtecble_Reversado.FirstOrDefault(var => var.IdEmpresa == IdEmpresa && var.IdTipoCbte == IdTipoCbte && var.IdCbteCble == IdCbteCble);

                    if (Objeto != null)
                    {

                        Info.IdEmpresa = Objeto.IdEmpresa;
                        Info.IdTipoCbte = Objeto.IdTipoCbte;
                        Info.IdCbteCble = Objeto.IdCbteCble;
                        Info.IdEmpresa_Anu = Objeto.IdEmpresa_Anu;
                        Info.IdTipoCbte_Anu = Objeto.IdTipoCbte_Anu;
                        Info.IdCbteCble_Anu = Objeto.IdCbteCble_Anu;
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
    	}


    }
}
