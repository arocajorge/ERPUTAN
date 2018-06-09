using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;

namespace Cus.Erp.Reports.FJ.Roles
{
    public class XROLES_Rpt004_Data
    {
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XROLES_Rpt004_Info> Get_list_Horas_Extras(int IdEmpresa, int IdNomina_Tipo, int IdNomina_tipo_Liq, int IdPerido)
        {
            List<XROLES_Rpt004_Info> lista = new List<XROLES_Rpt004_Info>();
            try
            {

                using (Entities_Roles_Fj_Rpt db = new Entities_Roles_Fj_Rpt())
                {
                    var query = from q in db.vwROLES_Rpt004
                                where q.IdEmpresa == IdEmpresa
                                && q.IdNomina_Tipo == IdNomina_Tipo
                                && q.IdNomina_TipoLiqui == IdNomina_tipo_Liq
                                && q.IdPeriodo == IdPerido
                                select q;

                    foreach (var item in query)
                    {
                        XROLES_Rpt004_Info info = new XROLES_Rpt004_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdDepartamento = item.IdDepartamento;
                        info.IdCargo = item.IdCargo;
                        info.IdNomina_Tipo = item.IdNomina_Tipo;
                        info.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                        info.IdPeriodo = item.IdPeriodo;
                        info.pe_apellido = item.pe_apellido;
                        info.pe_nombre = item.pe_nombre;
                        info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.ca_descripcion = item.ca_descripcion;
                        info.de_descripcion = item.de_descripcion;
                        info.hora_extra25 = item.hora_extra25;
                        info.hora_extra50 = item.hora_extra50;
                        info.hora_extra100 = item.hora_extra100;
                        info.TotalHorasExtras = item.TotalHorasExtras;
                        info.hora_trabajada = item.hora_trabajada;
                        info.Dias_Efectivos = item.Dias_Efectivos;
                        info.Sueldo = item.Sueldo;
                        info.Valor_Hora_25 = item.Valor_Hora_25;
                        info.Valor_Hora_250 = item.Valor_Hora_250;
                        info.Valor_Hora_100 = item.Valor_Hora_100;

                        lista.Add(info);
                    }
                }
                return lista;
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
