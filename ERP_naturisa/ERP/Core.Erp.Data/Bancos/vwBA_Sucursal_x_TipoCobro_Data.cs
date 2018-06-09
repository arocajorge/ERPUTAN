using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Bancos
{
    public class vwBA_Sucursal_x_TipoCobro_Data
    {
        string mensaje = "";
        public List<vwBA_Sucursal_x_TipoCobro_Info> Get_List_vwBA_Sucursal_x_TipoCobro(int IdEmpresa)
        {
            try
            {
                 List<vwBA_Sucursal_x_TipoCobro_Info> res = new List<vwBA_Sucursal_x_TipoCobro_Info>();
                    try
                    {
                        using (EntitiesBanco oEnt = new EntitiesBanco())
                        {
                            string query = "select tb.IdEmpresa,vw.IdSucursal,"
                            +" tb.IdCtaCble_Credito, tb.IdCtaCble_Deudora,"
                            + " vw.Su_Descripcion,vw.tc_descripcion,vw.IdCobro_tipo  "
                            + " from dbo.cxc_cobro_tipo_Param_conta_x_sucursal tb right join "
                            +" vwBA_Sucursal_x_TipoCobro vw on"
                            +" tb.IdEmpresa = vw.IdEmpresa and"
                            +" tb.IdCobro_tipo = vw.IdCobro_tipo and "
                            +" tb.IdSucursal = vw.IdSucursal "
                            +" where vw.IdEmpresa = " + IdEmpresa;
                            var con = oEnt.Database.SqlQuery<vwBA_Sucursal_x_TipoCobro_Info>(query);
                            if (con == null)
                            {
                                if (con.ToList().Count() > 0)
                                {
                                    res = con.ToList();
                                }
                            }
                        }
                        return res;
                    }
                    catch (Exception ex)
                    {
                        string arreglo = ToString();
                        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                            "", "", "", "", DateTime.Now);
                        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                        mensaje = ex.InnerException + " " + ex.Message;
                        throw new Exception(ex.InnerException.ToString());
                    }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
        
    }
}
