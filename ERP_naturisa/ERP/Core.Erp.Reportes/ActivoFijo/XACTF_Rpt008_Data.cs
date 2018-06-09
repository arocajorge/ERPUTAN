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
    public class XACTF_Rpt008_Data
    {
        string mensaje = "";
        tb_Empresa_Bus busEmpresa = new tb_Empresa_Bus();
        tb_Empresa_Info Cbt = new tb_Empresa_Info();

        public List<XACTF_Rpt008_Info> get_RptRetiro_AF(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<XACTF_Rpt008_Info> lstRpt = new List<XACTF_Rpt008_Info>();

                using (Entities_ActivoFijo_Reportes listado = new Entities_ActivoFijo_Reportes())
                {
                    var select = from q in listado.vwACTF_Rpt008
                                 where q.IdEmpresa == IdEmpresa
                                 && q.Fecha_Retiro >= FechaIni && q.Fecha_Retiro <= FechaFin
                                 select q;

                    Cbt = busEmpresa.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XACTF_Rpt008_Info infoRpt = new XACTF_Rpt008_Info();
                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdRetiroActivo = item.IdRetiroActivo;
                        infoRpt.Cod_Ret_Activo = item.Cod_Ret_Activo;
                        infoRpt.IdActivoFijo = item.IdActivoFijo;
                        infoRpt.Af_Nombre = item.Af_Nombre;
                        infoRpt.Encargado = item.NomCompleto;
                        infoRpt.ValorActivo = item.ValorActivo;
                        infoRpt.Valor_Tot_Bajas = item.Valor_Tot_Bajas;
                        infoRpt.Valor_Tot_Mejora = Convert.ToDouble(item.Valor_Tot_Mejora);
                        infoRpt.Valor_Depre_Acu = item.Valor_Depre_Acu;
                        infoRpt.Valor_Neto = item.Valor_Neto;
                        infoRpt.NumComprobante = item.NumComprobante;
                        infoRpt.Concepto_Retiro = item.Concepto_Retiro;
                        infoRpt.Estado = (item.Estado == "A")? "Activo" : "Inactivo" ;
                        infoRpt.Fecha_Retiro = item.Fecha_Retiro;
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
