using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt001_Data
    {
        string mensajeError = "";

        public List<XFAC_FJ_Rpt001_Info> Get_Orden_Trabajo(int idEmpresa, decimal idOrdenTrabajo)
        {
            try
            {
                List<XFAC_FJ_Rpt001_Info> Lista = new List<XFAC_FJ_Rpt001_Info>();

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {
                    var lst = from q in Context.vwFAC_FJ_Rpt001
                              where q.IdEmpresa == idEmpresa
                              && q.IdOrdenTrabajo_Pla == idOrdenTrabajo
                              select q;

                    foreach (var item in lst)
                    {
                        XFAC_FJ_Rpt001_Info info = new XFAC_FJ_Rpt001_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdOrdenTrabajo_Pla = item.IdOrdenTrabajo_Pla;
                        info.codOrdenTrabajo_Pla = item.codOrdenTrabajo_Pla;
                        info.IdCliente = item.IdCliente;
                        info.Descripcion = item.Descripcion;
                        info.Equipo = item.Equipo;
                        info.serie = item.serie;
                        info.km_salida = item.km_salida;
                        info.km_llegada = item.km_llegada;
                        info.con_atencion_a = item.con_atencion_a;
                        info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        info.Fecha_UltMod = item.Fecha_UltMod;
                        info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        info.Fecha_UltAnu = item.Fecha_UltAnu;
                        info.MotiAnula = item.MotiAnula;
                        info.nom_pc = item.nom_pc;
                        info.ip = item.ip;
                        info.Estado = item.Estado;
                        info.nom_Cliente = item.nom_Cliente;
                        info.Fecha = item.Fecha;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.pe_direccion = item.pe_direccion;
                        info.secuencia = item.secuencia;
                        info.descrip_equipo_movi = item.descrip_equipo_movi;
                        info.punto_partida = item.punto_partida;
                        info.punto_llegada = item.punto_llegada;
                        info.hora_ini = item.hora_ini;
                        info.hora_fin = item.hora_fin;
                        info.Valor = item.Valor;

                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
    }
}
