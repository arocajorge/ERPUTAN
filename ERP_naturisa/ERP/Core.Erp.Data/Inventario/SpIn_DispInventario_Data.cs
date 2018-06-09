using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Inventario
{
    public class SpIn_DispInventario_Data
    {
        string mensaje = "";
        public List<SpIn_DispInventario_Info> Get_List_In_DispInventario(Nullable<DateTime> Fecha, Nullable<int> IdSucursal, Nullable<int> IdBodega, int IdEmpresa, string Categorias, string IdUsuario) 
        {
            try
            {
                using (EntitiesInventario entity= new EntitiesInventario())
                {
                    ObjectResult<spIn_DisponibilidadDEInventario_Result> Consulta = entity.spIn_DisponibilidadDEInventario(Fecha, IdEmpresa, IdSucursal, IdBodega, Categorias, IdUsuario);
                    IEnumerable<SpIn_DispInventario_Info> resul = from q in Consulta
                                                                  select new SpIn_DispInventario_Info
                                                                  {
                                                                      bo_Descripcion = q.bo_Descripcion,
                                                                      ca_Categoria = q.ca_Categoria,
                                                                      EmpresaSi = q.EmpresaSi,
                                                                      IdBodegaSi = q.IdBodegaSi,
                                                                      IdCategoria = q.IdCategoria,
                                                                      IdProductoSi = q.IdProductoSi,
                                                                      IdSucursalSi = q.IdSucursalSi,
                                                                      IdUsuario = q.IdUsuario,
                                                                      pr_descripcion = q.pr_descripcion,
                                                                      pr_Pedidos = q.pr_Pedidos,
                                                                      stock = q.stock == null ? 0 : q.stock,
                                                                      Su_Descripcion = q.Su_Descripcion,
                                                                      pr_codigo = q.pr_codigo,
                                                                      Disponibles = Convert.ToDouble(q.stock) - q.pr_Pedidos
                                                                  };
                    
                    return resul.ToList();
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }
    }
}
