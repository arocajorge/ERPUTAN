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
    public class XACTF_Rpt009_Data
    {
        string mensaje = "";
        tb_Empresa_Bus busEmpresa = new tb_Empresa_Bus();
        tb_Empresa_Info Cbt = new tb_Empresa_Info();

        public List<XACTF_Rpt009_Info> get_CodigoBarra(int IdEmpresa, int IdActivoFijo)
        {
            try
            {
                List<XACTF_Rpt009_Info> lstRpt = new List<XACTF_Rpt009_Info>();

                using (Entities_ActivoFijo_Reportes listado = new Entities_ActivoFijo_Reportes())
                {
                    var select = from q in listado.vwACTF_Rpt009
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdActivoFijo == IdActivoFijo
                                 select q;

                    Cbt = busEmpresa.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XACTF_Rpt009_Info infoRpt = new XACTF_Rpt009_Info();
                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdActivoFijo = item.IdActivoFijo;
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.Su_Descripcion = item.Su_Descripcion;
                        infoRpt.CodActivoFijo = item.CodActivoFijo;
                        infoRpt.Af_Codigo_Barra = item.Af_Codigo_Barra;
                        infoRpt.Af_Nombre = item.Af_Nombre;
                        infoRpt.Af_fecha_compra = item.Af_fecha_compra;
                        infoRpt.Descripcion = item.Descripcion;               
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
