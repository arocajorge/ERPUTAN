using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_ModeloProduccion_CusTalme_Data
    {
        string mensaje = "";
        public List<prod_ModeloProduccion_CusTalme_Info> Get_List_ModeloProduccion_CusTalme()
        {   
            List<prod_ModeloProduccion_CusTalme_Info> Lst = new List<prod_ModeloProduccion_CusTalme_Info>();
                EntitiesProduccion oEnti = new EntitiesProduccion();
            try
            {

                var Query = from q in oEnti.prod_ModeloProduccion_CusTalme
                            select q;
                foreach (var item in Query)
                {
                    prod_ModeloProduccion_CusTalme_Info Obj = new prod_ModeloProduccion_CusTalme_Info();
                    Obj.IdModeloProd = item.IdModeloProd;
                    Obj.Descripcion = item.Descripcion;
                    Obj.Estado = item.Estado;
                    Obj.Tipo = item.Tipo.Trim();

                    Obj.IdSucursal_IngxProduc = item.IdSucursal_IngxProduc;
                    Obj.IdBodega_IngxProduc = item.IdBodega_IngxProduc;
                    Obj.IdMovi_inven_tipo_x_IngxProduc_ProdTermi = item.IdMovi_inven_tipo_x_IngxProduc_ProdTermi;
                    Obj.IdMovi_inven_tipo_x_EgrxProduc_MatPri = item.IdMovi_inven_tipo_x_EgrxProduc_MatPri;
                    Obj.IdCargo_JefeTurno = item.IdCargo_JefeTurno;
                    Obj.IdSucursal_EgrxMateriaPrima = item.IdSucursal_EgrxMateriaPrima;
                    Obj.IdBodega_EgrxMateriaPrima = item.IdBodega_EgrxMateriaPrima;



                    Lst.Add(Obj);
                }
                return Lst;
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
