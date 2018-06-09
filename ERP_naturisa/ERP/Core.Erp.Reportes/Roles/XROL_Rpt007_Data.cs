
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt007_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XROL_Rpt007_Info> GetListPorIdActa(int idEmpresa, decimal idEmpleado, decimal idActaFiniquito, ref string msg)
        {
            try
            {
                List<XROL_Rpt007_Info> listado = new List<XROL_Rpt007_Info>();

                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt007
                                 where a.IdEmpresa == idEmpresa && a.IdEmpleado==idEmpleado && a.IdActaFiniquito==idActaFiniquito
                                 select a);

                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt007_Info info = new XROL_Rpt007_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdActaFiniquito = item.IdActaFiniquito;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdCausaTerminacion = item.IdCausaTerminacion;
                        info.IdContrato = item.IdContrato;
                        info.FechaIngreso = item.FechaIngreso;
                        info.FechaSalida = item.FechaSalida;
                        info.UltimaRemuneracion = item.UltimaRemuneracion;
                        info.Observacion = item.Observacion;
                        info.EsMujerEmbarazada = item.EsMujerEmbarazada;
                        info.EsDirigenteSindical = item.EsDirigenteSindical;
                        info.EsPorDiscapacidad = item.EsPorDiscapacidad;
                        info.EsPorEnfermedadNoProfesional = item.EsPorEnfermedadNoProfesional;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.NomCompleto = item.NomCompleto;
                        info.IdSecuencia = item.IdSecuencia;
                        info.DescripcionDetalle = item.DescripcionDetalle;
                        info.Signo = item.Signo;
                       // info.Valor = item.Valor;
                        info.IdCargo = item.IdCargo;
                        info.DescripcionCargo = item.DescripcionCargo;

                        info.NumDocumento = item.NumDocumento;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.Centro_costo = item.Centro_costo;
                        info.CodigoEmpleado = item.CodigoEmpleado;

                        if(info.Signo=="+"){
                            info.Ingresos = item.Valor;                        
                        }else{
                            info.Egresos = item.Valor;                       
                        }

                        info.em_logo_Image = Cbt.em_logo_Image;

                        listado.Add(info);
                    }

                }
                return listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                msg = mensaje;
                return new List<XROL_Rpt007_Info>();
            }

        }



    }
}
