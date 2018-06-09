using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_MovPteGrua_Det_Data
    {

        //esta funcion no hace nada, hay que revisarla o borrarla
        public Boolean GuardarDB(List<prd_MovPteGrua_Det_Info> LstInfo,ref string msg)
        {
            try
            {
                List<prd_MovPteGrua_Det_Info> Lst = new List<prd_MovPteGrua_Det_Info>();
                
                    using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
                    {
                       //// var contact = prd_MovPteGrua_Det.Createprd_MovPteGrua_Det(0, 0, 0, 0,0,"",  0,TimeSpan.MinValue);
                       // int sec = 0;  
                       // foreach (var Info in LstInfo)
                       // {
                       //     var Address = new prd_MovPteGrua_Det();

                       //     Address.IdEmpresa = Info.IdEmpresa;
                       //     Address.IdSucursal = Info.IdSucursal;
                       //     Address.IdMovPteGrua = Info.IdMovPteGrua;
                       //     Address.Secuencia = ++sec;
                       //     Address.CodigoBarra = Info.CodigoBarra;
                       //     Address.IdProducto = Info.IdProducto;
                       //     Address.CodigoBarraMaestro = Info.CodigoBarraMaestro;
                       //     Address.Hora = Info.Hora;
                       //     Address.Cantidad = Info.Cantidad;

                       //     contact = Address;
                       //     Context.prd_MovPteGrua_Det.AddObject(contact);
                       //     Context.SaveChanges();
                        //}
                        //Context.Dispose();
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
                throw new Exception(ex.ToString());
            }
        }

        public List<prd_MovPteGrua_Det_Info> MovPteGruaDetalle(int IdEmpresa, int IdSucursal, decimal IdMovPteGrua, ref string msg)
        {
            try
            {
                List<prd_MovPteGrua_Det_Info> Lst = new List<prd_MovPteGrua_Det_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                //var Query = from q in oEnti.prd_MovPteGrua_Det
                //            where q.IdEmpresa == IdEmpresa
                //            && q.IdSucursal == IdSucursal
                //            && q.IdMovPteGrua == IdMovPteGrua 
                //            select q;
                //foreach (var item in Query)
                //{
                //    prd_MovPteGrua_Det_Info Obj = new prd_MovPteGrua_Det_Info();
                //    Obj.IdEmpresa = item.IdEmpresa;
                //    Obj.IdSucursal = item.IdSucursal;
                //    Obj.IdMovPteGrua = item.IdMovPteGrua;
                //    Obj.Secuencia = item.Secuencia;
                //    Obj.CodigoBarra = item.CodigoBarra;
                //    Obj.IdProducto = item.IdProducto;
                //    Obj.CodigoBarraMaestro = item.CodigoBarraMaestro;
                //    Obj.Hora = item.Hora;
                //    Lst.Add(Obj);
              //  }
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

    }
}
