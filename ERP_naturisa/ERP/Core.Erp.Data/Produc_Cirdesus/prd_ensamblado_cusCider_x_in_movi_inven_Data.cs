using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_ensamblado_cusCider_x_in_movi_inven_Data
    {

        public Boolean GuardarDB(prd_ensamblado_cusCider_x_in_movi_inven_Info Info, ref string msg)
        {
            try
            {
                List<prd_ensamblado_cusCider_x_in_movi_inven_Info> Lst = new List<prd_ensamblado_cusCider_x_in_movi_inven_Info>();
                using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
                {
                    
                    var Address = new prd_ensamblado_cusCider_x_in_movi_inven();

                    Address.IdSucursal = Info.IdSucursal;
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdBodega = Info.IdBodega;
                    Address.IdMovi_inven_tipo = Info.IdMovi_inven_tipo;
                    Address.IdNumMovi = Info.IdNumMovi;
                    Address.en_IdEmpresa = Info.en_IdEmpresa;
                    Address.en_IdSucursal = Info.en_IdSucursal;
                    Address.en_IdEnsamblado = Info.en_IdEnsamblado;

                    Context.prd_ensamblado_cusCider_x_in_movi_inven.Add(Address);
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


        public List<prd_ensamblado_cusCider_x_in_movi_inven_Info> ConsultaGeneral(int idempresa, ref string msg)
        {
            try
            {
                List<prd_ensamblado_cusCider_x_in_movi_inven_Info> Lst = new List<prd_ensamblado_cusCider_x_in_movi_inven_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.prd_ensamblado_cusCider_x_in_movi_inven
                            select q;
                foreach (var item in Query)
                {
                    prd_ensamblado_cusCider_x_in_movi_inven_Info Obj = new prd_ensamblado_cusCider_x_in_movi_inven_Info();
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.en_IdEmpresa = item.en_IdEmpresa;
                    Obj.en_IdSucursal = item.en_IdSucursal;
                    Obj.en_IdEnsamblado = item.en_IdEnsamblado;
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

        public List<prd_ensamblado_cusCider_x_in_movi_inven_Info> LstTI_x_Ensamblado(prd_Ensamblado_CusCider_Info Ens, ref string msg)
        {
            try
            {
                List<prd_ensamblado_cusCider_x_in_movi_inven_Info> Lst = new List<prd_ensamblado_cusCider_x_in_movi_inven_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.prd_ensamblado_cusCider_x_in_movi_inven
                            where  q.en_IdEmpresa == Ens.IdEmpresa
                                && q.en_IdSucursal == Ens.IdSucursal
                                && q.en_IdEnsamblado == Ens.IdEnsamblado
                            select q;

                foreach (var item in Query)
                {
                    prd_ensamblado_cusCider_x_in_movi_inven_Info Obj = new prd_ensamblado_cusCider_x_in_movi_inven_Info();
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.en_IdEmpresa = item.en_IdEmpresa;
                    Obj.en_IdSucursal = item.en_IdSucursal;
                    Obj.en_IdEnsamblado = item.en_IdEnsamblado;
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

        public List<prd_ensamblado_cusCider_x_in_movi_inven_Info> LstTI_x_Movimiento(in_movi_inve_Info mov, ref string msg)
        {
            try
            {

                 List<prd_ensamblado_cusCider_x_in_movi_inven_Info> Lst = new List<prd_ensamblado_cusCider_x_in_movi_inven_Info>();
                 EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from var in oEnti.prd_ensamblado_cusCider_x_in_movi_inven
                            where var.IdEmpresa == mov.IdEmpresa
                                && var.IdSucursal == mov.IdSucursal
                                && var.IdBodega == mov.IdBodega
                                && var.IdMovi_inven_tipo == mov.IdMovi_inven_tipo
                                && var.IdNumMovi == mov.IdNumMovi 
                                select var;

                foreach (var item in Query)
                {
                    prd_ensamblado_cusCider_x_in_movi_inven_Info Obj = new prd_ensamblado_cusCider_x_in_movi_inven_Info();
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.en_IdEmpresa = item.en_IdEmpresa;
                    Obj.en_IdSucursal = item.en_IdSucursal;
                    Obj.en_IdEnsamblado = item.en_IdEnsamblado;
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
    }
}
