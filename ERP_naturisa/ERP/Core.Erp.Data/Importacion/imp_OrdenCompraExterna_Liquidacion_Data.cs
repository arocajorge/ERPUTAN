using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Importacion
{
    public class imp_OrdenCompraExterna_Liquidacion_Data
    {
        string mensaje = "";
        public List<vwImp_LiquidacionImportacion_Info> Get_List_LiquidacionImportacion(int IdEmpresa, int IdSucursal, decimal IdOrdenCompraExterna)
        {
                List<vwImp_LiquidacionImportacion_Info> Lst = new List<vwImp_LiquidacionImportacion_Info>();
                EntitiesImportacion oEnti = new EntitiesImportacion();
            try
            {                
                var Query = from q in oEnti.vwImp_LiquidacionImportacion
                            where q.IdEmpresa == IdEmpresa && q.IdSucusal == IdSucursal && q.IdOrdenCompraExt == IdOrdenCompraExterna
                            select q;
                foreach (var item in Query)
                {
                    vwImp_LiquidacionImportacion_Info Obj = new vwImp_LiquidacionImportacion_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdRegistroGasto = item.IdRegistroGasto;
                    Obj.IdSucusal = item.IdSucusal;
                    Obj.IdOrdenCompraExt = item.IdOrdenCompraExt;
                    Obj.ga_decripcion = item.ga_decripcion;
                    Obj.pr_nombre = (item.pr_nombre == null) ? "" : item.pr_nombre;
                    Obj.IdTipoCbte = Convert.ToInt16((item.IdTipoCbte== null)?0:item.IdTipoCbte);
                    Obj.IdCbteCble = Convert.ToDecimal((item.IdCbteCble == null) ? 0 : item.IdCbteCble);
                    Obj.Valor = Convert.ToDouble((item.Valor == null) ? 0 : item.Valor);
                    Obj.CodCbteCble = item.CodCbteCble;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
