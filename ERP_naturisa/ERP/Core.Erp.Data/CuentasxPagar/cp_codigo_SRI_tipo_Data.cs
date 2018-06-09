using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_codigo_SRI_tipo_Data
    {
        string mensaje = "";

        public List<cp_codigo_SRI_tipo_Info> Get_List_codigo_SRI_tipo()
        {
            try
            {
                List<cp_codigo_SRI_tipo_Info> lM = new List<cp_codigo_SRI_tipo_Info>();
                EntitiesCuentasxPagar OEUser = new EntitiesCuentasxPagar();

                var select_ = from TI in OEUser.cp_codigo_SRI_tipo
                                        select TI;


                foreach (var item in select_)
                {
                    cp_codigo_SRI_tipo_Info dat_ = new cp_codigo_SRI_tipo_Info();
                    dat_.IdTipoSRI = item.IdTipoSRI ;
                    dat_.descripcion = item.descripcion;

                    lM.Add(dat_);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(cp_codigo_SRI_tipo_Info info)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    EntitiesCuentasxPagar EDB = new EntitiesCuentasxPagar();
                    var Q = from per in EDB.cp_codigo_SRI_tipo 
                            where per.IdTipoSRI  == info.IdTipoSRI
                            select per;
                    if (Q.ToList().Count == 0)
                    {

                       // id_ = getId();

                        //var contact = cp_codigo_SRI_tipo.Createcp_codigo_SRI_tipo("");
                        var address = new cp_codigo_SRI_tipo();
                        address.IdTipoSRI  = info.IdTipoSRI ;
                        address.descripcion  = info.descripcion;

                        //contact = address;
                        context.cp_codigo_SRI_tipo.Add(address);
                        context.SaveChanges();
                    }
                    else
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(cp_codigo_SRI_tipo_Info info)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_codigo_SRI_tipo.FirstOrDefault(minfo => minfo.IdTipoSRI  == info.IdTipoSRI);
                    if (contact != null)
                    {
                        contact.descripcion = info.descripcion;
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public cp_codigo_SRI_tipo_Data() 
        {
        
        }
    }
}

