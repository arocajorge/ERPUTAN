using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

//using Core.Erp.Data.Academico;

namespace Core.Erp.Data.Academico
{
    public class vwAca_AnioPeriodo_Activo_Data
    {
        public vwAca_AnioPeriodo_Activo_Info Get_List_vwAca_AnioPeriodo_Activo(ref string mensaje)
        {
            try
            {
                vwAca_AnioPeriodo_Activo_Info info = new vwAca_AnioPeriodo_Activo_Info();
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var context = from c in Base.vwAca_AnioPeriodo_Activo
                                  select c;
                    if (context != null)
                    {
                        foreach (var item in context)
                        {
                            vwAca_AnioPeriodo_Activo_Info AnioPeriodo_Activo = new vwAca_AnioPeriodo_Activo_Info();
                            AnioPeriodo_Activo.IdInstitucion = item.IdInstitucion;
                            AnioPeriodo_Activo.IdAnioLectivo = item.IdAnioLectivo;
                            AnioPeriodo_Activo.AnioLectivo = item.AnioLectivo;
                            AnioPeriodo_Activo.IdPeriodo = item.IdPeriodo;
                            AnioPeriodo_Activo.pe_anio = item.pe_anio;
                            AnioPeriodo_Activo.pe_mes = item.pe_mes;
                            AnioPeriodo_Activo.EstadoAnioLectivo = item.EstadoAnioLectivo;
                            AnioPeriodo_Activo.EstadoAperturaPeriodo = item.EstadoAperturaPeriodo;
                            AnioPeriodo_Activo.pe_estado = item.pe_estado;

                            AnioPeriodo_Activo.pe_FechaIni = item.pe_FechaIni;
                            AnioPeriodo_Activo.pe_FechaFin = item.pe_FechaFin;

                            //AnioPeriodo_Activo.UsuarioCreacion = item.UsuarioCreacion;
                            //AnioPeriodo_Activo.FechaCreacion = item.FechaCreacion;

                            AnioPeriodo_Activo.IdUsuarioUltMod = item.IdUsuarioUltMod;

                            AnioPeriodo_Activo.IdUsuarioUltAnu = item.IdUsuarioUltAnu;

                            AnioPeriodo_Activo.Fecha_UltMod = item.Fecha_UltMod;
                            AnioPeriodo_Activo.FechaHoraAnul = item.FechaHoraAnul;
                            AnioPeriodo_Activo.MotivoAnulacion = item.MotivoAnulacion;
                            

                            info = AnioPeriodo_Activo;

                            //lista.Add(AnioPeriodo_Activo);
                        }
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

    }
}
