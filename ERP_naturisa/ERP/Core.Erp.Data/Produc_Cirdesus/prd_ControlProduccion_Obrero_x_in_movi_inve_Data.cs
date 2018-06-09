using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_ControlProduccion_Obrero_x_in_movi_inve_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(prd_ControlProduccion_Obrero_x_in_movi_inve_Info Info)
        {
            try
            {
                List<prd_ControlProduccion_Obrero_x_in_movi_inve_Info> Lst = new List<prd_ControlProduccion_Obrero_x_in_movi_inve_Info>();
                using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
                {
                    var Address = new prd_ControlProduccion_Obrero_x_in_movi_inve();

                    Address.cp_IdEmpresa = Info.cp_IdEmpresa;
                    Address.cp_IdSucursal = Info.cp_IdSucursal;
                    Address.cp_IdControlProduccionObrero = Info.cp_IdControlProduccionObrero;
                    Address.mv_IdEmpresa = Info.mv_IdEmpresa;
                    Address.mv_IdSucursal = Info.mv_IdSucursal;
                    Address.mv_IdBodega = Info.mv_IdBodega;
                    Address.mv_IdMovi_inven_tipo = Info.mv_IdMovi_inven_tipo;
                    Address.mv_IdNumMovi = Info.mv_IdNumMovi;

                    Context.prd_ControlProduccion_Obrero_x_in_movi_inve.Add(Address);
                    Context.SaveChanges();
                }
                return true;
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


        public List<prd_ControlProduccion_Obrero_x_in_movi_inve_Info> Get_List_ControlProduccion_x_Obrero_x_in_movi_inven(int IdEmpresa, Decimal IdControlProduccion, int IdSucursal)
        {
            try
            {
                List<prd_ControlProduccion_Obrero_x_in_movi_inve_Info> Lst = new List<prd_ControlProduccion_Obrero_x_in_movi_inve_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
               
                
                var Query = from q in oEnti.prd_ControlProduccion_Obrero_x_in_movi_inve
                            select q;


                foreach (var item in Query)
                {
                    prd_ControlProduccion_Obrero_x_in_movi_inve_Info Obj = new prd_ControlProduccion_Obrero_x_in_movi_inve_Info();
                    Obj.cp_IdEmpresa = item.cp_IdEmpresa;
                    Obj.cp_IdSucursal = item.cp_IdSucursal;
                    Obj.cp_IdControlProduccionObrero = item.cp_IdControlProduccionObrero;
                    Obj.mv_IdEmpresa = item.mv_IdEmpresa;
                    Obj.mv_IdSucursal = item.mv_IdSucursal;
                    Obj.mv_IdBodega = item.mv_IdBodega;
                    Obj.mv_IdMovi_inven_tipo = item.mv_IdMovi_inven_tipo;
                    Obj.mv_IdNumMovi = item.mv_IdNumMovi;
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
