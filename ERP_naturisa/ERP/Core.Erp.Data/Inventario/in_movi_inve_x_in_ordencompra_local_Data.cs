using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Inventario
{
    public class in_movi_inve_x_in_ordencompra_local_Data
    {
        public Boolean GrabarDB(in_movi_inve_Info prI, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    EntitiesInventario EDB = new EntitiesInventario();

                    var Q = from per in EDB.in_movi_inve_x_in_ordencompra_local
                            where per.IdEmpresa == prI.IdEmpresa
                            && per.IdSucursal == prI.IdSucursal
                            && per.IdBodega == prI.IdBodega
                            && per.IdMovi_inven_tipo == prI.IdMovi_inven_tipo
                            && per.IdNumMovi == prI.IdNumMovi
                            && per.IdEmpresaOC == prI.IdEmpresa
                            && per.IdSucursalOC == prI.IdSucursal
                            && per.IdOrdenCompra == prI.IdOrdenCompra

                            select per;

                    if (Q.ToList().Count == 0)
                    {
                        var address = new in_movi_inve_x_in_ordencompra_local();

                        address.IdEmpresa = prI.IdEmpresa;
                        address.IdSucursal = prI.IdSucursal;
                        address.IdBodega = prI.IdBodega;
                        address.IdMovi_inven_tipo = prI.IdMovi_inven_tipo;
                        address.IdNumMovi = prI.IdNumMovi;
                        address.IdEmpresaOC = prI.IdEmpresa;
                        address.IdSucursalOC = prI.IdSucursal;
                        address.IdOrdenCompra = prI.IdOrdenCompra;
                        context.in_movi_inve_x_in_ordencompra_local.Add(address);
                        context.SaveChanges();
                        mensaje = "Grabacion ok..";
                    }
                    else
                        return false;

                    return true;
                }
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

        public Boolean GrabarDB(List<in_movi_inve_Info> lmcabmovin, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    EntitiesInventario EDB = new EntitiesInventario();

                    foreach (var item in lmcabmovin)
                    {
                        
                        var address = new in_movi_inve_x_in_ordencompra_local();

                        address.IdEmpresa = item.IdEmpresa;
                        address.IdSucursal = item.IdSucursal;
                        address.IdBodega = item.IdBodega;
                        address.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        address.IdNumMovi = item.IdNumMovi;
                        address.IdEmpresaOC = item.IdEmpresa;
                        address.IdSucursalOC = item.IdSucursal;
                        address.IdOrdenCompra = item.IdOrdenCompra;

                        context.in_movi_inve_x_in_ordencompra_local.Add(address);
                        context.SaveChanges();

                        mensaje = "Grabacion ok..";
                    }

                    return true;
                }
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
    }
}
