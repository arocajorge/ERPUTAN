using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_ControlInventarioProd_Data
    {
        string mensaje = "";
        public prd_ControlInventarioProd_Info Get_Info_TraerSaldo(int idempresa, int idsucursal, string CodObra, int idOT, int idET)
        {

            try
            {


                prd_ControlInventarioProd_Info info = new prd_ControlInventarioProd_Info();
                EntitiesProduccion_Cidersus InvProd = new EntitiesProduccion_Cidersus();

                
                var item = InvProd.prd_ControlInventarioProd.LastOrDefault(q => q.IdEmpresa == idempresa && q.IdSucursal == idsucursal && q.CodObra == CodObra && q.IdOrdenTrabajo == idOT && q.IdEtapa == idET);
                if (item != null)
                {
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.CodObra = item.CodObra;
                    info.IdRegistro = item.IdRegistro;
                    info.IdEtapa = item.IdEtapa;
                    info.IdOrdenTrabajo = item.IdOrdenTrabajo;
                    info.FechaRegistro = item.FechaRegistro;
                    info.TipoMov = item.TipoMov;
                    info.Kilos = item.Kilos;
                    info.Unidades = item.Unidades;
                    info.Observacion = item.Observacion;
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;                
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
