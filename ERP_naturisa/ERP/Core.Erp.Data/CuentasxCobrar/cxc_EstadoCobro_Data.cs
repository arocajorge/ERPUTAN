using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxCobrar
{
    public class cxc_EstadoCobro_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(cxc_EstadoCobro_Info Info)
        {
            try
            {

                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                var address = new cxc_EstadoCobro();
                address.IdEstadoCobro = Info.IdEstadoCobro;
                address.posicion = Info.posicion;
                address.Descripcion = Info.Descripcion;
                context.cxc_EstadoCobro.Add(address);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(cxc_EstadoCobro_Info Info)
        {
            try
            {
                Boolean res = false;
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                var address = context.cxc_EstadoCobro.FirstOrDefault(var => var.IdEstadoCobro == Info.IdEstadoCobro);
                if (address != null)
                {
                    address.Descripcion = Info.Descripcion;
                    address.posicion = Info.posicion;
                    context.SaveChanges();
                    res = true;
                }
                return res;
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

        public List<cxc_EstadoCobro_Info> Get_List_EstadoCobro()
        {
            try
            {
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();

                var lista = from q in context.cxc_EstadoCobro
                            select q;

                List<cxc_EstadoCobro_Info> lst = new List<cxc_EstadoCobro_Info>();
                cxc_EstadoCobro_Info Info;

                foreach (var item in lista)
                {
                    Info = new cxc_EstadoCobro_Info();
                    Info.IdEstadoCobro = item.IdEstadoCobro;
                    Info.Descripcion = item.Descripcion;
                    Info.posicion = (int)item.posicion;
                    lst.Add(Info);

                }

                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
