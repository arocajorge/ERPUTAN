using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;

namespace Core.Erp.Data.General
{
    public class vwtb_Bodega_x_Sucursal_TreeList_Data
    {
        string mensaje = "";
        public List<vwtb_Bodega_x_Sucursal_TreeList_Info> Get_List_Bodega_x_Sucursal(int IdEmpresa)
        {
            try
            {
                List<vwtb_Bodega_x_Sucursal_TreeList_Info> lstInfo = new List<vwtb_Bodega_x_Sucursal_TreeList_Info>();
                using (EntitiesGeneral listado = new EntitiesGeneral())
                {
                    var select = from q in listado.vwtb_Bodega_x_Sucursal_TreeList
                                 where q.IdEmpresa == IdEmpresa
                                 select q;

                    foreach (var item in select)
                    {
                        vwtb_Bodega_x_Sucursal_TreeList_Info Info = new vwtb_Bodega_x_Sucursal_TreeList_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.ID = item.Id;
                        Info.IdPadre = item.IdPadre;
                        Info.Nombre = item.Nombre;
                        Info.Estado = item.Estado;
                        Info.Nivel = item.Nivel;
                        Info.IdSucursal = item.IdSucursal;
                        Info.IdBodega = Convert.ToInt32(item.IdBodega);
                        Info.Checked = true;

                        lstInfo.Add(Info);
                    }
                }

                return lstInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
