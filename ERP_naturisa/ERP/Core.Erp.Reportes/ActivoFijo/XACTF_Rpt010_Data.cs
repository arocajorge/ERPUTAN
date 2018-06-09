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
    public class XACTF_Rpt010_Data
    {
        string mensaje = "";
        tb_Empresa_Bus busEmpresa = new tb_Empresa_Bus();
        tb_Empresa_Info Cbt = new tb_Empresa_Info();

        public List<XACTF_Rpt010_Info> get_CambioUbica_AF(int IdEmpresa, int IdActivoFijo, int IdActivoFijoTipo, DateTime FechaIni, DateTime FechaHasta)
        {
            try
            {
                List<XACTF_Rpt010_Info> lstRpt = new List<XACTF_Rpt010_Info>();

                using (Entities_ActivoFijo_Reportes listado = new Entities_ActivoFijo_Reportes())
                {
                    var select = from q in listado.vwACTF_Rpt010
                                 where q.IdEmpresa == IdEmpresa
                                 && q.FechaCambio >= FechaIni && q.FechaCambio <= FechaHasta
                                 select q;

                    if (IdActivoFijo != 0)
                       select = select.Where(q => q.IdActivoFijo == IdActivoFijo);

                    if (IdActivoFijoTipo != 0)
                        select = select.Where(q => q.IdActijoFijoTipo == IdActivoFijoTipo);

                    Cbt = busEmpresa.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XACTF_Rpt010_Info infoRpt = new XACTF_Rpt010_Info();
                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdCambioUbicacion = item.IdCambioUbicacion;
                        infoRpt.IdActivoFijo = item.IdActivoFijo;
                        infoRpt.Af_Nombre = item.Af_Nombre;
                        infoRpt.IdActijoFijoTipo = item.IdActijoFijoTipo;
                        infoRpt.Af_Descripcion = item.Af_Descripcion;
                        infoRpt.IdSucursal_Actu = item.IdSucursal_Actu;
                        infoRpt.SucActual = item.SucActual;
                        infoRpt.IdSucursal_Ant = item.IdSucursal_Ant;
                        infoRpt.SucAnterior = item.SucAnterior;
                        infoRpt.IdDepartamento_Actu = item.IdDepartamento_Actu;
                        infoRpt.DepActual = item.DepActual;
                        infoRpt.IdDepartamento_Ant = item.IdDepartamento_Ant;
                        infoRpt.DepAnterior = item.DepAnterior;
                        infoRpt.IdTipoCatalogo_Ubicacion_Actu = item.IdTipoCatalogo_Ubicacion_Actu;
                        infoRpt.UbiActual = item.UbiActual;
                        infoRpt.IdTipoCatalogo_Ubicacion_Ant = item.IdTipoCatalogo_Ubicacion_Ant;
                        infoRpt.UbiAnterior = item.UbiAnterior;
                        infoRpt.MotivoCambio = item.MotivoCambio;
                        infoRpt.FechaCambio = item.FechaCambio;
                        infoRpt.IdUsuario = item.IdUsuario;
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
