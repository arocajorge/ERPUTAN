using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Inventario
{
    public class vwIn_Movi_Inven_x_Ing_x_OC_Data
    {

        string mensaje = "";
        public List<vwIn_Movi_Inven_x_Ing_x_OC_Info> Get_List_Movi_Inven_x_Ing_x_OC(int IdEmpresa, int IdSucursal, int IdBodega, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
                List<vwIn_Movi_Inven_x_Ing_x_OC_Info> List = new List<vwIn_Movi_Inven_x_Ing_x_OC_Info>();
                EntitiesInventario oEntities = new EntitiesInventario();
                var select = from q in oEntities.vwin_Movi_Inven_x_Ing_x_OC
                             where q.IdEmpresa == IdEmpresa
                             && q.IdSucursal == IdSucursal
                             && q.IdBodega==IdBodega
                             && q.cm_fecha>= FechaIni && q.cm_fecha<=FechaFin
                             select q;

                foreach (var item in select)
                {
                    vwIn_Movi_Inven_x_Ing_x_OC_Info _Info = new vwIn_Movi_Inven_x_Ing_x_OC_Info();

                    _Info.IdEmpresa=item.IdEmpresa;
                    _Info.Su_Descripcion = item.Su_Descripcion;
                    _Info.bo_Descripcion = item.bo_Descripcion;
                    _Info.Tipo_Movi_Inven = item.Tipo_Movi_Inven;
                    _Info.IdNumMovi = item.IdNumMovi;
                    _Info.cm_observacion = item.cm_observacion;
                    _Info.cm_fecha = item.cm_fecha;
                    _Info.Sucursal_OC = item.Sucursal_OC;
                    _Info.IdOrdenCompra = item.IdOrdenCompra;
                    _Info.oc_fecha = item.oc_fecha;
                    _Info.oc_observacion = item.oc_observacion;
                    _Info.IdSucursal = item.IdSucursal;
                    _Info.IdBodega = item.IdBodega;
                    _Info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    _Info.IdProveedor = item.IdProveedor;
                    _Info.pr_codigo = item.pr_codigo;
                    _Info.pr_nombre = item.pr_nombre;
                    List.Add(_Info);
                }
                return List;
            }
            catch (Exception ex)
            {
                 string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public vwIn_Movi_Inven_x_Ing_x_OC_Data()
        {

        }
    }
}
