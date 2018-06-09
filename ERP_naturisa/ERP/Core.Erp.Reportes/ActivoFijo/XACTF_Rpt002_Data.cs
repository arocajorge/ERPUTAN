using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt002_Data
    {
        string mensaje = "";
        tb_Empresa_Bus busEmpresa = new tb_Empresa_Bus();
        tb_Empresa_Info Cbt = new tb_Empresa_Info();


        public List<XACTF_Rpt002_Info> get_ReporteActivoFijo(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdTipoDepreciacion, int IdTipoActivo, string IdEstadoProceso, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<XACTF_Rpt002_Info> lstRpt = new List<XACTF_Rpt002_Info>();

                using (Entities_ActivoFijo_Reportes listado = new Entities_ActivoFijo_Reportes())
                {
                    var select = from q in listado.vwACTF_Rpt002
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                 && q.Af_fecha_compra >= FechaIni && q.Af_fecha_compra <= FechaFin
                                 select q;

                    if (IdTipoActivo != 0)
                        select = select.Where(q => q.IdActijoFijoTipo == IdTipoActivo);

                    if (IdTipoDepreciacion != 0)
                        select = select.Where(q => q.IdTipoDepreciacion == IdTipoDepreciacion);

                    if (IdEstadoProceso != "0")
                        select = select.Where(q => q.Estado_Proceso == IdEstadoProceso);

                    Cbt = busEmpresa.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XACTF_Rpt002_Info infoRpt = new XACTF_Rpt002_Info();
                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdActivoFijo = item.IdActivoFijo;
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.IdActijoFijoTipo = item.IdActijoFijoTipo;
                        infoRpt.IdTipoDepreciacion = Convert.ToInt32(item.IdTipoDepreciacion);
                        infoRpt.CodActivoFijo = item.Af_Codigo_Barra;
                        infoRpt.nom_tipo_depreciacion = item.nom_tipo_depreciacion;
                        infoRpt.Af_Descripcion = item.Af_Descripcion;
                        infoRpt.Descripcion = item.Descripcion;
                        infoRpt.Su_Descripcion = item.Su_Descripcion;
                        infoRpt.Af_Nombre = item.Af_Nombre;
                        infoRpt.IdDepartamento = Convert.ToInt32(item.IdDepartamento);
                        infoRpt.Af_Marca = item.Af_Marca;
                        infoRpt.Af_Modelo = item.Af_Modelo;
                        infoRpt.Af_NumSerie = item.Af_NumSerie;
                        infoRpt.Af_Color = item.Af_Color;
                        infoRpt.Af_Ubicacion = item.Af_Ubicacion;
                        infoRpt.Af_fecha_compra = item.Af_fecha_compra;
                        infoRpt.Af_costo_compra = item.Af_costo_compra;
                        infoRpt.Af_Costo_historico = item.Af_Costo_historico;
                        infoRpt.Af_Vida_Util = item.Af_Vida_Util;
                        infoRpt.Af_Meses_depreciar = item.Af_Meses_depreciar;
                        infoRpt.Af_ValorSalvamento = item.Af_ValorSalvamento;
                        infoRpt.Af_ValorResidual = item.Af_ValorResidual;
                        infoRpt.Estado_Proceso = item.Estado_Proceso;
                        infoRpt.Logo = Cbt.em_logo_Image;

                        lstRpt.Add(infoRpt);
                    }

                }
                return lstRpt;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

    }
}
