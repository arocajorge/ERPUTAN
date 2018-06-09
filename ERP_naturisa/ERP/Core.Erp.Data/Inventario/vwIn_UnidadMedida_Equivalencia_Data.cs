using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Inventario
{
    public class vwIn_UnidadMedida_Equivalencia_Data
    {
        string mensaje = "";

        public List<vwIn_UnidadMedida_Equivalencia_Info> Get_List_UnidadMedida_Equivalencia(string IdUnidadMedida)
        {
            try
            {
                List<vwIn_UnidadMedida_Equivalencia_Info> lstInfo = new List<vwIn_UnidadMedida_Equivalencia_Info>();
                using (EntitiesInventario listado = new EntitiesInventario())
                {
                    var select = from q in listado.vwin_UnidadMedida_Equivalencia
                                 where q.IdUnidadMedida == IdUnidadMedida
                                 select q;

                    foreach (var item in select)
                    {
                        vwIn_UnidadMedida_Equivalencia_Info Info = new vwIn_UnidadMedida_Equivalencia_Info();
                        Info.IdUnidadMedida = item.IdUnidadMedida;
                        Info.IdUnidadMedida_equiva = item.IdUnidadMedida_equiva;
                        Info.cod_alterno = item.cod_alterno;
                        Info.Descripcion = item.Descripcion;
                        Info.valor_equiv = item.valor_equiv;
                        Info.interpretacion = item.interpretacion;
                        lstInfo.Add(Info);
                    }
                }
                return lstInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<vwIn_UnidadMedida_Equivalencia_Info> Get_List_UnidadMedida_Equivalencia_x_Uni_Consumo(string IdUnidadConsumo)
        {
            try
            {
                List<vwIn_UnidadMedida_Equivalencia_Info> lstInfo = new List<vwIn_UnidadMedida_Equivalencia_Info>();
                using (EntitiesInventario listado = new EntitiesInventario())
                {
                    var select = from q in listado.vwin_UnidadMedida_Equivalencia
                                 where q.IdUnidadMedida_equiva == IdUnidadConsumo
                                 select q;

                    foreach (var item in select)
                    {
                        vwIn_UnidadMedida_Equivalencia_Info Info = new vwIn_UnidadMedida_Equivalencia_Info();                       
                        Info.IdUnidadMedida = item.IdUnidadMedida;
                        Info.IdUnidadMedida_equiva = item.IdUnidadMedida_equiva;
                        Info.cod_alterno = item.cod_alterno_Padre;
                        Info.Descripcion = item.Descripcion_Padre;
                        Info.valor_equiv = item.valor_equiv;
                        Info.interpretacion = item.interpretacion;
                        lstInfo.Add(Info);
                    }
                }
                return lstInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
