using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt024_Data
    {
        tb_Empresa_Data dataEmp = new tb_Empresa_Data();
        tb_Empresa_Info infoEmp = new tb_Empresa_Info();
        string MensajeError = "";

        public List<XINV_Rpt024_Info> GetList_Data(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi, string Tipo, DateTime FechaIni, DateTime FechaFin, ref String mensaje)
        {
            try
            {
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                int IdBodegaIni = 0;
                int IdBodegaFin = 0;
                int IdMovi_inven_tipoIni = 0;
                int IdMovi_inven_tipoFin = 0;
                decimal IdNumMoviIni = 0;
                decimal IdNumMoviFin = 0;
                

                IdSucursalIni = (IdSucursal == 0) ? 0 : IdSucursal;
                IdSucursalFin = (IdSucursal == 0) ? 999999 : IdSucursal;
                
                IdBodegaIni = (IdBodega == 0) ? 0 : IdBodega;
                IdBodegaFin = (IdBodega == 0) ? 999999 : IdBodega;

                IdMovi_inven_tipoIni = (IdMovi_inven_tipo == 0) ? 0 : IdMovi_inven_tipo;
                IdMovi_inven_tipoFin = (IdMovi_inven_tipo == 0) ? 999999 : IdMovi_inven_tipo;

                IdNumMoviIni = (IdNumMovi == 0) ? 0 : IdNumMovi;
                IdNumMoviFin = (IdNumMovi == 0) ? 9999999999999999999 : IdNumMovi;

                FechaIni = FechaIni.Date;
                FechaFin = FechaFin.Date;
                
                List<XINV_Rpt024_Info> lista = new List<XINV_Rpt024_Info>();

                using (Entities_Inventario_General Contact = new Entities_Inventario_General())
                {
                    var select = from h in Contact.vwINV_Rpt024
                                 where h.IdEmpresa == IdEmpresa
                                 && h.IdSucursal >= IdSucursalIni
                                 && h.IdSucursal <= IdSucursalFin
                                 && h.IdBodega >= IdBodegaIni
                                 && h.IdBodega <= IdBodegaFin
                                 && h.IdMovi_inven_tipo >= IdMovi_inven_tipoIni
                                 && h.IdMovi_inven_tipo <= IdMovi_inven_tipoFin
                                 && h.IdNumMovi >= IdNumMoviIni
                                 && h.IdNumMovi <= IdNumMoviFin
                                 && h.Tipo.Contains(Tipo)
                                 && h.cm_fecha >= FechaIni
                                 && h.cm_fecha <= FechaFin
                                 select h;

                    infoEmp = dataEmp.Get_Info_Empresa(IdEmpresa);
                    foreach (var item in select)
                    {
                        XINV_Rpt024_Info Info = new XINV_Rpt024_Info();

                        Info.IdEmpresa = item.IdEmpresa;
                        Info.nom_empresa = item.nom_empresa;
                        Info.IdSucursal = item.IdSucursal;
                        Info.nom_sucursal = item.nom_sucursal;
                        Info.IdBodega = item.IdBodega;
                        Info.nom_bodega = item.nom_bodega;
                        Info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        Info.IdNumMovi = item.IdNumMovi;
                        Info.cod_tipo_movi = item.cod_tipo_movi;
                        Info.nom_tipo_movi = item.nom_tipo_movi;
                        Info.Tipo = item.Tipo;
                        Info.cm_fecha = item.cm_fecha;
                        Info.cm_observacion = item.cm_observacion;
                        Info.Estado = item.Estado;
                        Info.Secuencia = item.Secuencia;
                        Info.cod_producto = item.cod_producto;
                        Info.IdProducto = item.IdProducto;
                        Info.nom_producto = item.nom_producto;
                        Info.IdUnidadMedida = item.IdUnidadMedida;
                        Info.nom_UnidadMedida = item.nom_UnidadMedida;
                        Info.cantidad = item.cantidad;
                        Info.costo_uni = item.costo_uni;
                        Info.Costo_Total = item.Costo_Total;
                        Info.dm_observacion = item.dm_observacion;
                        lista.Add(Info);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
