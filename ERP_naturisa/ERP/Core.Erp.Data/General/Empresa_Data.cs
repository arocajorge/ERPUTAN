using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.General
{
    public class Empresa_Data
    {

        string mensaje = "";
        public List<tb_Empresa_Info> ObtenerEmpresa(int idcompany)
        {
            try
            {

                List<tb_Empresa_Info> lM = new List<tb_Empresa_Info>();
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
                
                var selectEmpresa = from C in OEselecEmpresa.tb_empresa
                                          where C.IdEmpresa == idcompany
                                          select C;

                foreach (var item in selectEmpresa)
                {

                    tb_Empresa_Info Cbt = new tb_Empresa_Info();
                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.em_nombre = item.em_nombre;
                    Cbt.em_gerente = item.em_gerente;
                    Cbt.em_ruc = item.em_ruc;
                    Cbt.em_telefonos = item.em_telefonos;
                    Cbt.em_fax = item.em_fax;
                    Cbt.em_notificacion = Convert.ToInt32(item.em_notificacion);
                    Cbt.em_direccion = item.em_direccion;
                    
                    Cbt.em_tel_int = item.em_tel_int;
                    Cbt.em_logo = item.em_logo;
                    Cbt.em_fondo = item.em_fondo;
                    Cbt.codigo = item.codigo;
                    Cbt.Estado = item.Estado;
                
                    lM.Add(Cbt);
                }

                return (lM);
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Empresa_Data() { }
    }
}
