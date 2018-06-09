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
    public class XACTF_Rpt012_Data
    {
        public List<XACTF_Rpt012_Info> Consultar_Data(int IdEmpresa, int IdActivoFijo, int IdCategoria, int IdSucursal, int IdDepartamento, DateTime FechaCorte,string IdUsuario, ref string mensaje)
        {
            try
            {
                int IdActivoFijoIni ;
                int IdActivoFijoFin ;
                int IdCategoriaIni ;
                int IdCategoriaFin = 0;
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                int IdDepartamentoIni = 0;
                int IdDepartamentoFin = 0;

                FechaCorte = FechaCorte.Date;

                IdActivoFijoIni = (IdActivoFijo == 0) ? 0 : IdActivoFijo;
                IdActivoFijoFin = (IdActivoFijo == 0) ? 999999 : IdActivoFijo;

                IdCategoriaIni = (IdCategoria == 0) ? 0 : IdCategoria;
                IdCategoriaFin = (IdCategoria == 0) ? 999999 : IdCategoria;

                IdSucursalIni = (IdSucursal == 0) ? 0 : IdSucursal;
                IdSucursalFin = (IdSucursal == 0) ? 999999 : IdSucursal;

                IdDepartamentoIni = (IdDepartamento == 0) ? 0 : IdDepartamento;
                IdDepartamentoFin = (IdDepartamento == 0) ? 999999 : IdDepartamento;

                List<XACTF_Rpt012_Info> lstRpt = new List<XACTF_Rpt012_Info>();
                using (Entities_ActivoFijo_Reportes listado = new Entities_ActivoFijo_Reportes())
                {
                    var select = from q in listado.spACTF_Rpt012(IdEmpresa, FechaCorte,IdUsuario) 
                                 where q.IdActivoFijoTipo >= IdActivoFijoIni && q.IdActivoFijoTipo <=IdActivoFijoFin
                                 && q.IdCategoria_Af>=IdCategoriaIni && q.IdCategoria_Af<=IdCategoriaFin
                                 && q.IdSucursal>= IdSucursalIni && q.IdSucursal<=IdSucursalFin                                 
                                 select q;

                    foreach (var item in select)
                    {
                        XACTF_Rpt012_Info info = new XACTF_Rpt012_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.IdSucursal = item.IdSucursal;
                        info.Su_Descripcion = item.Su_Descripcion;
                        info.CodActivoFijo = item.CodActivoFijo;
                        info.IdActijoFijoTipo = item.IdActivoFijoTipo;
                        info.Af_Nombre = item.Af_Nombre; 
                        info.tipo_AF = item.tipo_AF;
                        info.IdCategoriaAF = item.IdCategoria_Af;
                        info.Categoria_AF = item.Categoria_AF;
                        info.Af_costo_compra = item.Af_costo_compra;
                        info.Af_Depreciacion_acum = item.Af_Depreciacion_acum;
                        info.Costo_actual = item.Costo_actual;
                        info.valor_ult_depreciacion = item.valor_ult_depreciacion;
                        info.Af_fecha_compra = item.Af_fecha_compra;
                        lstRpt.Add(info);
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
