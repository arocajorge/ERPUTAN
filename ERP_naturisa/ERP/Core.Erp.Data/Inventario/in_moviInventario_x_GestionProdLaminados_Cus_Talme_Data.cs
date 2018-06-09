using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
   public class in_moviInventario_x_GestionProdLaminados_Cus_Talme_Data
   {
       string mensaje = "";
        public Boolean GuardarDB(in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info Info)
        {
            try
            {
                List<in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info> Lst = new List<in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info>();
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    //var contact = in_moviInventario_x_GestionProdLaminados_Cus_Talme.Createin_moviInventario_x_GestionProdLaminados_Cus_Talme(0,0,0,0,0,0,0);
                    //var Address = new in_moviInventario_x_GestionProdLaminados_Cus_Talme();

                    //Address.mov_IdEmpresa = Info.mov_IdEmpresa;
                    //Address.mov_IdSucursal = Info.mov_IdSucursal;
                    //Address.mov_IdBodega = Info.mov_IdBodega;
                    //Address.mov_IdMovi_inven_tipo = Info.mov_IdMovi_inven_tipo;
                    //Address.mov_IdNumMovi = Info.mov_IdNumMovi;
                    //Address.prod_IdEmpresa = Info.prod_IdEmpresa;
                    //Address.prod_IdGestionProductiva = Info.prod_IdGestionProductiva;

                    //contact = Address;
                    //Context.in_moviInventario_x_GestionProdLaminados_Cus_Talme.(contact);
                    //Context.SaveChanges();
                }
                return true;
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

        public in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info Get_Info_moviInventario_x_GestionProdLaminados_Cus_Talme(int IdEmpresa, Decimal IdGestion) 
        {
            try
            {
                in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info Info = new in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info();

                EntitiesInventario Oent = new EntitiesInventario();
                string Query = "select * from in_moviInventario_x_GestionProdLaminados_Cus_Talme where prod_IdEmpresa = "+IdEmpresa+" and prod_IdGestionProductiva = "+IdGestion;
                var Obj = Oent.Database.SqlQuery<in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info>(Query);
                Info = Obj.First();
                

                return Info;
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

        public Boolean Eliminar(in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info Info) 
        {
            try
            {
                //using (EntitiesInventario context = new EntitiesInventario())
                //{
                //    var contact = context.in_moviInventario_x_GestionProdLaminados_Cus_Talme.First(obj => obj.mov_IdEmpresa == Info.mov_IdEmpresa && obj.mov_IdSucursal == Info.mov_IdSucursal && obj.mov_IdBodega == Info.mov_IdBodega && obj.mov_IdMovi_inven_tipo == Info.mov_IdMovi_inven_tipo && obj.mov_IdNumMovi == Info.mov_IdNumMovi);
                //    context.Remove(contact);
                //    context.SaveChanges();
                //    context.Dispose();
                //}
                return false;

               
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

    }
}
