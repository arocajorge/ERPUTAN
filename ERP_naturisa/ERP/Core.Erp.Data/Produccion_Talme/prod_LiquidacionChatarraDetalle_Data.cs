using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_LiquidacionChatarraDetalle_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(List<prod_LiquidacionChatarraDetalle_Info> Lst)
        {
            try
            {
                int sec = 1;
                foreach (var Info  in Lst)
                {
                   
                    using (EntitiesProduccion Context = new EntitiesProduccion())
                    {
                        var Address = new prod_LiquidacionChatarraDetalle();

                        Address.IdEmpresa = Info.IdEmpresa;
                        Address.IdLiquidacion = Info.IdLiquidacion;
                        Address.Secuencia = sec;
                        Address.LLeno = Info.LLeno;
                        Address.Vacio = Info.Vacio;
                        Address.Merma = Info.Merma;
                        Address.Neta = Info.Neta;
                        Address.fecha_pesaje_lleno = Info.fecha_pesaje_lleno;
                        Address.fecha_pesaje_vacion = Info.fecha_pesaje_vacion;
                        Address.Placa = Info.Placa;
                        sec++;
                        Context.prod_LiquidacionChatarraDetalle.Add(Address);
                        Context.SaveChanges();
                    }
                }
                return true;
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


        public List<prod_LiquidacionChatarraDetalle_Info> Get_List_LiquidacionChatarraDetalle()
        {
                List<prod_LiquidacionChatarraDetalle_Info> Lst = new List<prod_LiquidacionChatarraDetalle_Info>();
                EntitiesProduccion oEnti = new EntitiesProduccion();
            try
            {
                var Query = from q in oEnti.prod_LiquidacionChatarraDetalle
                            select q;
                foreach (var item in Query)
                {
                    prod_LiquidacionChatarraDetalle_Info Obj = new prod_LiquidacionChatarraDetalle_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdLiquidacion = item.IdLiquidacion;
                    Obj.Secuencia = item.Secuencia;
                    Obj.LLeno = item.LLeno;
                    Obj.Vacio = item.Vacio;
                    Obj.Merma = item.Merma;
                    Obj.Neta = item.Neta;
                    Obj.fecha_pesaje_lleno = item.fecha_pesaje_lleno;
                    Obj.fecha_pesaje_vacion = item.fecha_pesaje_vacion;
                    Obj.Placa = item.Placa;
                    Lst.Add(Obj);
                }
                return Lst;
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
