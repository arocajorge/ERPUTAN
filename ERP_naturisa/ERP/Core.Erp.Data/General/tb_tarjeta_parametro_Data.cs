using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.General
{
    public class tb_tarjeta_parametro_Data
    {
        string mensaje = "";
        public List<tb_tarjeta_parametro_Info> Get_List_tarjeta_parametro()
        {
            try
            {
                List<tb_tarjeta_parametro_Info> lst = new List<tb_tarjeta_parametro_Info>();

                EntitiesGeneral oEnti = new EntitiesGeneral();



                var tarjetas = from q in oEnti.tb_tarjeta_parametro
                               select q;

                foreach (var item in tarjetas)
                {

                    tb_tarjeta_parametro_Info info = new tb_tarjeta_parametro_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdTarjeta = item.IdTarjeta;
                    info.IdCtaCble_Tarj = item.IdCtaCble_Tarj;
                    info.IdCobro_tipo_x_RetFu = item.IdCobro_tipo_x_RetFu;
                    info.IdCobro_tipo_x_RetIva = item.IdCobro_tipo_x_RetIva;
                    info.IdCtaCble_Comision = item.IdCtaCble_Comision;
                    info.Porcetaje_Comision = Convert.ToDouble(item.Porcetaje_Comision);
                    lst.Add(info);
                }


                return lst;
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

        public List<vwGe_tb_Tarjeta_tb_Parametro_Info> Get_list_tarjeta_parametro(int IdEmpresa)
        {
            try
            {
                List<vwGe_tb_Tarjeta_tb_Parametro_Info> lst = new List<vwGe_tb_Tarjeta_tb_Parametro_Info>();

                EntitiesGeneral oEnti = new EntitiesGeneral();
                var tarjetas = from q in oEnti.vwGe_tb_Tarjeta_tb_Parametro
                               where q.IdEmpresa == IdEmpresa
                               select q;
                vwGe_tb_Tarjeta_tb_Parametro_Info info;
                foreach (var item in tarjetas)
                {
                    info = new vwGe_tb_Tarjeta_tb_Parametro_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdTarjeta = item.IdTarjeta;
                    info.tr_Descripcion = item.tr_Descripcion;
                    info.Estado = item.Estado;
                    info.IdBanco = item.IdBanco;
                    info.IdCtaCble_Tarj = item.IdCtaCble_Tarj;
                    info.IdCobro_tipo_x_Tarj = item.IdCobro_tipo_x_Tarj;
                    info.IdCobro_tipo_x_RetFu = item.IdCobro_tipo_x_RetFu;
                    info.IdCobro_tipo_x_RetIva = item.IdCobro_tipo_x_RetIva;
                    info.IdCtaCble_Comision = item.IdCtaCble_Comision;
                    info.Porcetaje_Comision = Convert.ToDouble(item.Porcetaje_Comision);
                    lst.Add(info);
                }
                return lst;
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

        public Boolean GuardarDB(tb_tarjeta_parametro_Info Info)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();
                var tarjeta = new tb_tarjeta_parametro();

                tarjeta.IdTarjeta = Info.IdTarjeta;
                tarjeta.IdEmpresa = Info.IdEmpresa;
                tarjeta.IdTarjeta = Info.IdTarjeta;
                tarjeta.IdCtaCble_Tarj = Info.IdCtaCble_Tarj;
                tarjeta.IdCobro_tipo_x_Tarj = Info.IdCobro_tipo_x_Tarj;
                tarjeta.IdCobro_tipo_x_RetFu = Info.IdCobro_tipo_x_RetFu;
                tarjeta.IdCobro_tipo_x_RetIva = Info.IdCobro_tipo_x_RetIva;
                tarjeta.IdCtaCble_Comision = Info.IdCtaCble_Comision;
                tarjeta.Porcetaje_Comision = Info.Porcetaje_Comision;
                context.tb_tarjeta_parametro.Add(tarjeta);
                context.SaveChanges();

                return true;
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

        public Boolean ModificarDB(tb_tarjeta_parametro_Info Info)
        {
            try
            {

                EntitiesGeneral context = new EntitiesGeneral();
                var tarjeta = context.tb_tarjeta_parametro.FirstOrDefault(var => var.IdTarjeta == Info.IdTarjeta && var.IdEmpresa == Info.IdEmpresa);
                if (tarjeta != null)
                {
                    tarjeta.IdTarjeta = Info.IdTarjeta;
                    tarjeta.IdCobro_tipo_x_Tarj = Info.IdCobro_tipo_x_Tarj;
                    tarjeta.IdCtaCble_Tarj = Info.IdCtaCble_Tarj;
                    tarjeta.IdCobro_tipo_x_RetFu = Info.IdCobro_tipo_x_RetFu;
                    tarjeta.IdCobro_tipo_x_RetIva = Info.IdCobro_tipo_x_RetIva;
                    tarjeta.IdCtaCble_Comision = Info.IdCtaCble_Comision;
                    tarjeta.Porcetaje_Comision = Info.Porcetaje_Comision;
                    context.SaveChanges();
                }
                return true;
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

        public tb_tarjeta_parametro_Info Get_Info_tarjeta_parametro(int IdTarjeta, int IdEmpresa)
        {
            try
            {

                EntitiesGeneral context = new EntitiesGeneral();
                tb_tarjeta_parametro_Info info = new tb_tarjeta_parametro_Info();
                var tarjeta = context.tb_tarjeta_parametro.FirstOrDefault(var => var.IdTarjeta == IdTarjeta && var.IdEmpresa == IdEmpresa);
                if (tarjeta != null)
                {
                    info.IdEmpresa = tarjeta.IdEmpresa;
                    info.IdTarjeta = tarjeta.IdTarjeta;
                    info.IdCtaCble_Tarj = tarjeta.IdCtaCble_Tarj;
                    info.IdCobro_tipo_x_Tarj = tarjeta.IdCobro_tipo_x_Tarj;
                    info.IdCobro_tipo_x_RetFu = tarjeta.IdCobro_tipo_x_RetFu;
                    info.IdCobro_tipo_x_RetIva = tarjeta.IdCobro_tipo_x_RetIva;
                    info.IdCtaCble_Comision = tarjeta.IdCtaCble_Comision;
                    info.Porcetaje_Comision = Convert.ToDouble(tarjeta.Porcetaje_Comision);
                }
                return info;
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
