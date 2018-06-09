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
    public class XACTF_Rpt014_Data
    {
        public List<XACTF_Rpt014_Info> Consultar_Data(int IdEmpresa, int IdSucursal, int IdActijoFijoTipo, int IdCategoria,DateTime Fecha_corte,string IdUsuario, ref string mensaje)
        {
            try
            {
                int IdActijoFijoTipo_Ini, IdActijoFijoTipo_Fin, IdCategoriaIni;
                int IdCategoriaFin = 0, IdSucursalIni = 0, IdSucursalFin = 0;

                Fecha_corte = Fecha_corte.Date;

                IdActijoFijoTipo_Ini = (IdActijoFijoTipo == 0) ? 1 : IdActijoFijoTipo;
                IdActijoFijoTipo_Fin = (IdActijoFijoTipo == 0) ? 999999 : IdActijoFijoTipo;

                if (IdActijoFijoTipo != 0)
                {
                    IdCategoriaIni = (IdCategoria == 0) ? 1 : IdCategoria;
                    IdCategoriaFin = (IdCategoria == 0) ? 999999 : IdCategoria;
                }
                else
                {
                    IdCategoriaIni = 1;
                    IdCategoriaFin = 999999;
                }

                IdSucursalIni = (IdSucursal == 0) ? 1 : IdSucursal;
                IdSucursalFin = (IdSucursal == 0) ? 999999 : IdSucursal;

                List<XACTF_Rpt014_Info> lstRpt = new List<XACTF_Rpt014_Info>();
                using (Entities_ActivoFijo_Reportes listado = new Entities_ActivoFijo_Reportes())
                {
                    var select = from q in listado.spACTF_Rpt014(IdEmpresa,Fecha_corte,IdUsuario)
                                 where q.IdActivoFijoTipo >= IdActijoFijoTipo_Ini
                                 && q.IdActivoFijoTipo <= IdActijoFijoTipo_Fin                                  
                                 select q;

                    foreach (var item in select)
                    {
                        XACTF_Rpt014_Info info = new XACTF_Rpt014_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdActijoFijoTipo = item.IdActivoFijoTipo;
                        info.Af_Descripcion = item.Af_Descripcion;
                        info.Af_costo_compra = item.Af_costo_compra;
                        info.Valor_Depreciacion = item.Valor_Depreciacion;
                        info.Valor_ult_depreciacion = item.Valor_ult_depreciacion;
                        info.Costo_neto = item.Costo_neto;
                        
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
