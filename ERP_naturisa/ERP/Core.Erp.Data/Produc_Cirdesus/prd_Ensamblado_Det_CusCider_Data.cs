using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_Ensamblado_Det_CusCider_Data
    {
        public Boolean GuardarDB(List<prd_Ensamblado_Det_CusCider_Info> Detalle, ref string msg)
        {
            try
            {
                int sec = 0;
                List<prd_Ensamblado_Det_CusCider_Info> Lst = new List<prd_Ensamblado_Det_CusCider_Info>();
                using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
                {
                    

                    foreach (var Info in Detalle)
                    {
                        var Address = new prd_Ensamblado_Det_CusCider();
                        Address.IdEmpresa = Info.IdEmpresa;
                        Address.IdSucursal = Info.IdSucursal;
                        Address.IdEnsamblado = Info.IdEnsamblado;
                        Address.Secuencia = ++sec;
                        Address.IdProducto = Info.IdProducto;
                        Address.CodigoBarra = Info.CodigoBarra;
                        if (Info.Observacion.Length > 1000)
                        { Address.Observacion = Info.Observacion.Substring(0, 1000); }
                        else Address.Observacion = Info.Observacion;
                        Address.en_cantidad = Info.en_cantidad;

                        Context.prd_Ensamblado_Det_CusCider.Add(Address);
                        Context.SaveChanges();
                    }
                    Context.Dispose();

                } 
                msg = "Guardado con exito";
                return true;
            }
            catch (Exception ex) 
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString().ToString());
            }
        }

        public List<prd_Ensamblado_Det_CusCider_Info> ConsultaEnsamblado(int Idempresa, int IdSucursal, decimal IdEnsamblado, ref string msg)
        {
            try
            {
                List<prd_Ensamblado_Det_CusCider_Info> Lst = new List<prd_Ensamblado_Det_CusCider_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.prd_Ensamblado_Det_CusCider
                            where q.IdEmpresa == Idempresa 
                            && q.IdSucursal == IdSucursal 
                            && q.IdEnsamblado==IdEnsamblado 
                            select q;
                foreach (var item in Query)
                {
                    prd_Ensamblado_Det_CusCider_Info Obj = new prd_Ensamblado_Det_CusCider_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdEnsamblado = item.IdEnsamblado;
                    Obj.Secuencia = item.Secuencia;
                    Obj.IdProducto = item.IdProducto;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.Observacion = item.Observacion;
                    Obj.en_cantidad = item.en_cantidad;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean eliminaregistrotabla(List<prd_Ensamblado_Det_CusCider_Info> lstDetEns, ref string msg) {
            try
            {
                
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    foreach (var item in lstDetEns )
                    {
                        var address = context.prd_Ensamblado_Det_CusCider.FirstOrDefault(var => var.IdEmpresa == item.IdEmpresa && var.IdSucursal == item.IdSucursal && var.IdEnsamblado == item.IdEnsamblado && var.Secuencia == item.Secuencia);
                        if (address != null)
                        {
                            context.prd_Ensamblado_Det_CusCider.Remove(address);
                            context.SaveChanges();
                            msg = "Guardado con éxito";
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }
    }
}

