using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Contabilidad
{

    public class ct_rpt_Empresas_A_mostrar_Data
    {
        string mensaje = "";

        public Boolean GrabarDB(ct_rpt_Empresas_A_mostrar_Info info)
        {
           try
            {

                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    
                    var address = new ct_rpt_Empresas_A_mostrar();
                        address.IdEmpresa = info.IdEmpresa;
                        address.sEmpresas = info.sEmpresas;
                        context.ct_rpt_Empresas_A_mostrar.Add(address);
                        context.SaveChanges();
        
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

        public Boolean GrabarListDB(List<ct_rpt_Empresas_A_mostrar_Info> listEmpresas )
        {
            try
            {

                    foreach (var item in listEmpresas)
                    {

                        GrabarDB(item);
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

        public Boolean EliminarDB(List<ct_rpt_Empresas_A_mostrar_Info> listEmpresas)
        {
            try
            {
                foreach (var item in listEmpresas)
                {

                    using (EntitiesDBConta context = new EntitiesDBConta())
                    {
                            var contact = context.ct_rpt_Empresas_A_mostrar.FirstOrDefault(dinfo => dinfo.IdEmpresa ==item.IdEmpresa);
                            if (contact != null)
                            {
                                context.ct_rpt_Empresas_A_mostrar.Remove(contact);
                                context.SaveChanges();
                            }
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

        public ct_rpt_Empresas_A_mostrar_Data()
        {
            
        }

    }
}
