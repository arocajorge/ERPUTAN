using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt005_Data
    {

        string mensaje = "";
        tb_Empresa_Bus busEmpresa = new tb_Empresa_Bus();
        tb_Empresa_Info Cbt = new tb_Empresa_Info();

        public List<XACTF_Rpt005_Info> get_RptImporteMensual(int IdEmpresa, int IdTipoDepreciacion, int IdActivoFijo, int IdPeriodoIni, int IdPeiodoFin)
        {
            try
            {
                List<XACTF_Rpt005_Info> lstRpt = new List<XACTF_Rpt005_Info>();

                using (Entities_ActivoFijo_Reportes listado = new Entities_ActivoFijo_Reportes())
                {
                    var select = from q in listado.vwACTF_Rpt005
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdPeriodo >= IdPeriodoIni && q.IdPeriodo <= IdPeiodoFin
                                 select q;

                    if (IdTipoDepreciacion != 0)
                        select = select.Where(q => q.IdTipoDepreciacion == IdTipoDepreciacion);

                    if (IdActivoFijo != 0)
                        select = select.Where(q => q.IdActivoFijo == IdActivoFijo);

                    Cbt = busEmpresa.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XACTF_Rpt005_Info infoRpt = new XACTF_Rpt005_Info();
                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdActivoFijo = item.IdActivoFijo;
                        infoRpt.CodActivoFijo = item.Af_Codigo_Barra;
                        infoRpt.IdTipoDepreciacion = item.IdTipoDepreciacion;
                        infoRpt.cod_tipo_depreciacion = item.cod_tipo_depreciacion;
                        infoRpt.nom_tipo_depreciacion = item.nom_tipo_depreciacion;
                        infoRpt.Af_Nombre = item.Af_Nombre;
                        infoRpt.IdDepartamento = Convert.ToInt32(item.IdDepartamento);
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.Su_Descripcion = item.Su_Descripcion;
                        infoRpt.Af_fecha_compra = item.Af_fecha_compra;
                        infoRpt.Af_costo_compra = item.Af_costo_compra;
                        infoRpt.Estado_Proceso = item.Estado_Proceso;
                        infoRpt.IdDepreciacion = item.IdDepreciacion;
                        infoRpt.Secuencia = item.Secuencia;
                        infoRpt.Ciclo = item.Ciclo;
                        infoRpt.Valor_Compra = item.Valor_Compra;
                        infoRpt.Valor_Salvamento = item.Valor_Salvamento;
                        infoRpt.Vida_Util = item.Vida_Util;
                        infoRpt.Valor_Depreciacion = item.Valor_Depreciacion;
                        infoRpt.Valor_Depre_Acum = item.Valor_Depre_Acum;
                        infoRpt.Valor_Importe = item.Valor_Importe;
                        infoRpt.IdPeriodo = item.IdPeriodo;
                        infoRpt.IdanioFiscal = item.IdanioFiscal;
                        infoRpt.pe_mes = item.pe_mes;
                        infoRpt.smes = item.smes;
                        infoRpt.Nemonico = item.Nemonico;
                        infoRpt.Periodo_Mes = item.smes + "-" + Convert.ToString(item.IdanioFiscal);
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
