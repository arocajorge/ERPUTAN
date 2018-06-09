using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt026_Data
    {
        string MensajeError = "";

        public List<XINV_Rpt026_Info> Get_list_reporte(int IdEmpresa, int IdSucursal, int IdBodega, string IdCategoria, int IdLinea, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 99999 : IdSucursal;

                int IdBodega_ini = IdBodega;
                int IdBodega_fin = IdBodega == 0 ? 99999 : IdBodega;

                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                List<XINV_Rpt026_Info> Lista = new List<XINV_Rpt026_Info>();

                using (Entities_Inventario_General Context = new Entities_Inventario_General())
                {
                    var lst = from q in Context.spINV_Rpt026(IdEmpresa, IdSucursal_ini, IdSucursal_fin, IdBodega_ini, IdBodega_fin, Fecha_ini, Fecha_fin)
                              select q;

                    if (IdCategoria!="")
                    {
                        lst = lst.Where(q => q.IdCategoria == IdCategoria);
                    }
                    if (IdLinea!=0)
                    {
                        lst = lst.Where(q => q.IdLinea == IdLinea);
                    }

                    foreach (var item in lst)
                    {
                        XINV_Rpt026_Info info = new XINV_Rpt026_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdProducto = item.IdProducto;
                        info.Fecha_ini = item.Fecha_ini;
                        info.Fecha_fin = item.Fecha_fin;
                        info.pr_codigo = item.pr_codigo;
                        info.nom_producto = item.nom_producto;
                        info.IdCategoria = item.IdCategoria;
                        info.nom_categoria = item.nom_categoria;
                        info.IdLinea = item.IdLinea;
                        info.nom_linea = item.nom_linea;
                        info.Saldo_inicial = item.Saldo_inicial;
                        info.Ingresos = item.Ingresos;
                        info.Egresos = item.Egresos;
                        info.Saldo_final = item.Saldo_final;
                        info.IdUnidadMedida = item.IdUnidadMedida;
                        info.nom_unidad_medida = item.nom_unidad_medida;
                        info.nom_Sucursal = item.nom_Sucursal;
                        info.nom_Bodega = item.nom_Bodega;

                        info.costo_egresos = item.costo_egresos;
                        info.costo_final = item.costo_final;
                        info.costo_ingresos = item.costo_ingresos;
                        info.costo_inicial = item.costo_inicial;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
