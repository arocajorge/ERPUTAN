using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;




namespace Core.Erp.Data.Inventario
{
  public  class in_movi_inve_detalle_x_ct_cbtecble_det_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(in_movi_inve_detalle_x_ct_cbtecble_det_Info Info)
        {
            try
            {
                using (EntitiesInventario entity = new EntitiesInventario())
                {
                    in_movi_inve_detalle_x_ct_cbtecble_det item = new in_movi_inve_detalle_x_ct_cbtecble_det();

                    item.IdEmpresa_inv= Info.IdEmpresa_inv;
                    item.IdSucursal_inv= Info.IdSucursal_inv;
                    item.IdBodega_inv= Info.IdBodega_inv;
                    item.IdMovi_inven_tipo_inv= Info.IdMovi_inven_tipo_inv;
                    item.IdNumMovi_inv= Info.IdNumMovi_inv;
                    item.Secuencia_inv= Info.Secuencia_inv;
                    item.IdEmpresa_ct= Info.IdEmpresa_ct;
                    item.IdTipoCbte_ct= Info.IdTipoCbte_ct;
                    item.IdCbteCble_ct= Info.IdCbteCble_ct;
                    item.secuencia_ct= Info.secuencia_ct;
                    item.Secuencial_reg = GetId(Info.IdEmpresa_inv, Info.IdSucursal_inv, Info.IdBodega_inv, Info.IdMovi_inven_tipo_inv);
                    item.observacion = Info.observacion;

                    entity.in_movi_inve_detalle_x_ct_cbtecble_det.Add(item);
                    entity.SaveChanges();
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
                return false;
            }
        }


        public decimal GetId(int IdEmpresa, int IdSucursal,int IdBodega, int IdMovi_inven_tipo)
        {
            decimal Id = 0;
            try
            {
                EntitiesInventario contex = new EntitiesInventario();
                var selecte = contex.in_movi_inve_detalle_x_ct_cbtecble_det.Count(q => q.IdEmpresa_inv == IdEmpresa
                    && q.IdSucursal_inv == IdSucursal && q.IdMovi_inven_tipo_inv == IdMovi_inven_tipo && q.IdBodega_inv == IdBodega);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in contex.in_movi_inve_detalle_x_ct_cbtecble_det
                                     where q.IdEmpresa_inv == IdEmpresa
                                     && q.IdSucursal_inv == IdSucursal
                                     && q.IdMovi_inven_tipo_inv == IdMovi_inven_tipo
                                     && q.IdBodega_inv == IdBodega
                                     select q.Secuencial_reg).Max();
                    Id = Convert.ToDecimal(select_em.ToString()) + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }



        public List<in_movi_inve_detalle_x_ct_cbtecble_det_Info> Get_List_Info_x_Movi_Inven(int IdEmpresa, int idsucursal, int idbodega, int idmovi_inven_tipo, decimal idNum_Movi)
        {

            try
            {
                List<in_movi_inve_detalle_x_ct_cbtecble_det_Info> lista = new List<in_movi_inve_detalle_x_ct_cbtecble_det_Info>();


                EntitiesInventario entity = new EntitiesInventario();

                

                var Select = from q in entity.in_movi_inve_detalle_x_ct_cbtecble_det
                             where q.IdEmpresa_ct == IdEmpresa && q.IdSucursal_inv == idsucursal
                             && q.IdBodega_inv == idbodega && q.IdMovi_inven_tipo_inv == idmovi_inven_tipo
                             && q.IdNumMovi_inv == idNum_Movi
                             select q;

                foreach (var item in Select)
                {
                    in_movi_inve_detalle_x_ct_cbtecble_det_Info Info_Movi = new in_movi_inve_detalle_x_ct_cbtecble_det_Info();

                    Info_Movi.IdEmpresa_inv = item.IdEmpresa_inv;
                    Info_Movi.IdSucursal_inv = item.IdSucursal_inv;
                    Info_Movi.IdBodega_inv = item.IdBodega_inv;
                    Info_Movi.IdMovi_inven_tipo_inv = item.IdMovi_inven_tipo_inv;
                    Info_Movi.IdNumMovi_inv = item.IdNumMovi_inv;
                    Info_Movi.Secuencia_inv = item.Secuencia_inv;
                    Info_Movi.IdEmpresa_ct = item.IdEmpresa_ct;
                    Info_Movi.IdTipoCbte_ct = item.IdTipoCbte_ct;
                    Info_Movi.IdCbteCble_ct = item.IdCbteCble_ct;
                    Info_Movi.secuencia_ct = item.secuencia_ct;
                    Info_Movi.Secuencial_reg =Convert.ToInt32( item.Secuencial_reg);
                    Info_Movi.observacion = item.observacion;

                            lista.Add(Info_Movi);
                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString().ToString());
            }
        }
    }
}
