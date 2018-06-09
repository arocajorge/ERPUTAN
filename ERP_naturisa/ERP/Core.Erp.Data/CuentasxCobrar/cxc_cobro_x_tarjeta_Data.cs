using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxCobrar
{
    public class cxc_cobro_x_tarjeta_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(cxc_cobro_x_tarjeta_Info Info) {
            try
            {
                using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
                {
                    var Address = new cxc_cobro_x_tarjeta();
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdSucursal = Info.IdSucursal;
                    Address.IdCobro = Info.IdCobro;
                    Address.IdCobro_tipo = Info.IdCobro_tipo;
                    Address.IdCobro_Aplicado = Info.IdCobro_Aplicado;
                    Address.IdCobro_tipo_Aplicado = Info.IdCobro_tipo_Aplicado;
                    Address.IdCbte_vta_aplicado = Info.IdCbte_vta_aplicado;
                    cxc.cxc_cobro_x_tarjeta.Add(Address);
                    cxc.SaveChanges();
                }
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

        public cxc_cobro_x_tarjeta_Data()
        {

        }
    }
}
