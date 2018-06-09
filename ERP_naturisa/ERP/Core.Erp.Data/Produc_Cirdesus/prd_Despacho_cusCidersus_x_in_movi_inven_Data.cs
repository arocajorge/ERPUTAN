using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus ;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_Despacho_cusCidersus_x_in_movi_inven_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(prd_Despacho_cusCidersus_x_in_movi_inven_Info Info, ref string msg)
        {
            try
            {
                List<prd_Despacho_cusCidersus_x_in_movi_inven_Info> Lst = new List<prd_Despacho_cusCidersus_x_in_movi_inven_Info>();
                using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
                {
                  
                    var Address = new prd_Despacho_cusCidersus_x_in_movi_inven();

                    Address.IdSucursal = Info.IdSucursal;
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdBodega = Info.IdBodega;
                    Address.IdMovi_inven_tipo = Info.IdMovi_inven_tipo;
                    Address.IdNumMovi = Info.IdNumMovi;
                    Address.dp_IdEmpresa = Info.dp_IdEmpresa;
                    Address.dp_IdSucursal = Info.dp_IdSucursal;
                    Address.dp_IdDespacho = Info.dp_IdDespacho;

                    Context.prd_Despacho_cusCidersus_x_in_movi_inven.Add(Address);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public List<prd_Despacho_cusCidersus_x_in_movi_inven_Info> ConsultaGeneral(int idempresa, ref string msg)
        {
            try
            {
                List<prd_Despacho_cusCidersus_x_in_movi_inven_Info> Lst = new List<prd_Despacho_cusCidersus_x_in_movi_inven_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.prd_Despacho_cusCidersus_x_in_movi_inven 
                            select q;
                foreach (var item in Query)
                {
                    prd_Despacho_cusCidersus_x_in_movi_inven_Info Obj = new prd_Despacho_cusCidersus_x_in_movi_inven_Info();
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.dp_IdEmpresa = item.dp_IdEmpresa;
                    Obj.dp_IdSucursal = item.dp_IdSucursal;
                    Obj.dp_IdDespacho = item.dp_IdDespacho;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }


        public prd_Despacho_cusCidersus_x_in_movi_inven_Info TI_x_Despacho(prd_Despacho_Info  Desp, ref string msg)
        {
            try
            {
                prd_Despacho_cusCidersus_x_in_movi_inven_Info Obj = new prd_Despacho_cusCidersus_x_in_movi_inven_Info();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var item = oEnti.prd_Despacho_cusCidersus_x_in_movi_inven.FirstOrDefault(q => q.dp_IdEmpresa == Desp.IdEmpresa && q.dp_IdSucursal == Desp.IdSucursal && q.dp_IdDespacho == Desp.IdDespacho);
                if (item != null)
                {
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.dp_IdEmpresa = item.dp_IdEmpresa;
                    Obj.dp_IdSucursal = item.dp_IdSucursal;
                    Obj.dp_IdDespacho = item.dp_IdDespacho;
                }
                
                return Obj;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }
    }
}
