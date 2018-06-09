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
    public class XACTF_Rpt006_Data
    {
        string mensaje = "";
        tb_Empresa_Bus busEmpresa = new tb_Empresa_Bus();
        tb_Empresa_Info Cbt = new tb_Empresa_Info();

        public List<XACTF_Rpt006_Info> get_MejoraBaja_ActivoFijo(int IdEmpresa, string Id_Tipo, int IdActivoFijo, string Estado, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<XACTF_Rpt006_Info> lstRpt = new List<XACTF_Rpt006_Info>();

                using (Entities_ActivoFijo_Reportes listado = new Entities_ActivoFijo_Reportes())
                {
                    var select = from q in listado.vwACTF_Rpt006
                                 where q.IdEmpresa == IdEmpresa
                                 && q.Estado == Estado
                                 && q.Fecha_Transac >= FechaIni && q.Fecha_Transac <= FechaFin
                                 select q;

                    if (IdActivoFijo != 0)
                        select = select.Where(q => q.IdActivoFijo == IdActivoFijo);

                    if (Id_Tipo != "")
                        select = select.Where(q => q.Id_Tipo == Id_Tipo);

                    Cbt = busEmpresa.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XACTF_Rpt006_Info infoRpt = new XACTF_Rpt006_Info();
                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.Id_Mejora_Baja_Activo = item.Id_Mejora_Baja_Activo;
                        infoRpt.Id_Tipo = item.Id_Tipo;
                        infoRpt.IdActivoFijo = item.IdActivoFijo;
                        infoRpt.Af_Nombre = item.Af_Nombre;
                        infoRpt.Encargado = item.NomCompleto;
                        infoRpt.Af_Marca = item.Af_Marca;
                        infoRpt.Af_Modelo = item.Af_Modelo;
                        infoRpt.Af_NumSerie = item.Af_NumSerie;
                        infoRpt.Af_Color = item.Af_Color;
                        infoRpt.Af_Ubicacion = item.Af_Ubicacion;
                        infoRpt.Af_Vida_Util = item.Af_Vida_Util;
                        infoRpt.Af_Meses_depreciar = item.Af_Meses_depreciar;
                        infoRpt.Af_porcentaje_deprec = item.Af_porcentaje_deprec;
                        infoRpt.IdProveedor = item.IdProveedor;
                        infoRpt.pr_nombre = item.pr_nombre;
                        infoRpt.ValorActivo = Convert.ToDouble(item.ValorActivo);
                        infoRpt.Valor_Mej_Baj_Activo = Convert.ToDouble(item.Valor_Mej_Baj_Activo);
                        infoRpt.Compr_Mej_Baj = item.Compr_Mej_Baj;
                        infoRpt.DescripcionTecnica = item.DescripcionTecnica;
                        infoRpt.Motivo = item.Motivo;
                        infoRpt.Estado = item.Estado;
                        infoRpt.Fecha_Transac = Convert.ToDateTime(item.Fecha_Transac);
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
