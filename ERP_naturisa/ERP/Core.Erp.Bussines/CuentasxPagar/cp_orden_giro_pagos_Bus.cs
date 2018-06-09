using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_orden_giro_pagos_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cp_orden_giro_pagos_Data data = new cp_orden_giro_pagos_Data();

        public List<cp_orden_giro_pagos_Info> ObtenerList(int IdEmpresa_cbte)
        {
            try
            {
                return new List<cp_orden_giro_pagos_Info>();

            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Obtener Lista .." + ex.Message;
                return new List<cp_orden_giro_pagos_Info>();
            }
        }

        public Boolean GrabarDB(cp_orden_giro_pagos_Info info)
        {
            try
            {
                return false;
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return false;
            }

        }

        public Boolean ActualizarEstado(cp_orden_giro_pagos_Info info)
        {
            try
            {
                return false;
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Actualizar .." + ex.Message;
                return false;
            }
  
        }

        public Boolean ModificarDB(cp_orden_giro_pagos_Info info)
        {
            try
            {
                return false;
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Modificar .." + ex.Message;
                return false;
            }

        }

        public Boolean GrabarLista(List<cp_orden_giro_pagos_Info> lista,int IdEmpresaCbte,ref decimal IdCancelacion)
        {
            try
            {
                return false;

            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return false;
            }
        }

        public Boolean EliminarPagos(int IdEmpresa_cbte, decimal IdCbteCble_cbte, int IdTipocbte_cbte)
        {
            try
            {
                return false;
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Eiminar .." + ex.Message;
                return false;
            }

        }

        public List<cp_orden_giro_pagos_Info> ObtenerListPagosOG(int IdEmpresa, int IdTipocbte, decimal IdCbteCble)
        {
            try
            {
                return new List<cp_orden_giro_pagos_Info>();
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Obtener Lista Pagos .." + ex.Message;
                return new List<cp_orden_giro_pagos_Info>() ;
            }
        }

        public List<vwct_cbtecble_Con_Saldo_Info> ObtenerListPagosOG_X_Cbte(int IdEmpresa_Cbte)
        {
            try
            {
                return new List<vwct_cbtecble_Con_Saldo_Info>();
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Obtener List Pagos .." + ex.Message;
                return new List<vwct_cbtecble_Con_Saldo_Info>();
            }
        }

        public cp_orden_giro_pagos_Bus() { }
    }
}
