using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.CuentasxPagar
{
   public class cp_reembolso_Data
   {
       string mensaje = "";
       public Boolean GuardarDB(cp_reembolso_Info Info)
       {
           try
           {
               List<cp_reembolso_Info> Lst = new List<cp_reembolso_Info>();
               using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
               {

                   var Address = new cp_reembolso();

                   Address.IdEmpresa = Info.IdEmpresa;
                   Address.IdCbteCble_Ogiro = Info.IdCbteCble_Ogiro;
                   Address.IdTipoCbte_Ogiro = Info.IdTipoCbte_Ogiro;
                   Address.IdReembolso = GetId(Info.IdEmpresa);
                   Address.IdProveedor = Info.IdProveedor;
                   Address.TipoIdProveedor = Info.TipoIdProveedor;
                   Address.IdentificacionProveedor = Info.IdentificacionProveedor;
                   Address.TipoDoc_CodSRI = Info.TipoDoc_CodSRI;
                   Address.Establecimiento = Info.Establecimiento;
                   Address.Punto_Emision = Info.Punto_Emision;
                   Address.Secuencial = Info.Secuencial;
                   Address.Autorizacion = Info.Autorizacion;
                   Address.Fecha_Emision = Info.Fecha_Emision;
                   Address.TarifaIVAcero = Info.TarifaIVAcero;
                   Address.TarifaIVADiferentecero = Info.TarifaIVADiferentecero;
                   Address.TarifaNoObjetoIVA = Info.TarifaNoObjetoIVA;
                   Address.MontoICE = Info.MontoICE;
                   Address.MontoIVA = Info.MontoIVA;

                   Address.baseImponible = Info.baseImponible;
                   Address.Total = Info.Total;

                   //contact = Address;
                   Context.cp_reembolso.Add(Address);
                   Context.SaveChanges();
               }
               return true;
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

       public decimal GetId(int IdEmpresa)
       {
           try
           {
               decimal Id;
               using (EntitiesCuentasxPagar enti=new EntitiesCuentasxPagar())
               {
                   var selec=from t in enti.cp_reembolso
                             where t.IdEmpresa==IdEmpresa
                             select t;
                   if (selec.ToList().Count == 0)
                       Id = 1;
                   else
                   {
                       var se = (from t in enti.cp_reembolso
                                 where t.IdEmpresa == IdEmpresa
                                 select t.IdReembolso).Max();
                       Id = se + 1;
                   }
               }

               return Id;
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

       public List<cp_reembolso_Info> Get_List_reembolso(int IdEmpresa)
       {
           try
           {
               List<cp_reembolso_Info> Lst = new List<cp_reembolso_Info>();
               EntitiesCuentasxPagar oEnti = new EntitiesCuentasxPagar();
               var Query = from q in oEnti.cp_reembolso
                           where q.IdEmpresa == IdEmpresa
                           select q;
               foreach (var item in Query)
               {
                   cp_reembolso_Info Obj = new cp_reembolso_Info();
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                   Obj.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                   Obj.IdReembolso = item.IdReembolso;
                   Obj.IdProveedor = item.IdProveedor;
                   Obj.TipoIdProveedor = item.TipoIdProveedor;
                   Obj.IdentificacionProveedor = item.IdentificacionProveedor;
                   Obj.TipoDoc_CodSRI = item.TipoDoc_CodSRI;
                   Obj.Establecimiento = item.Establecimiento;
                   Obj.Punto_Emision = item.Punto_Emision;
                   Obj.Secuencial = item.Secuencial;
                   Obj.Autorizacion = item.Autorizacion;
                   Obj.Fecha_Emision = item.Fecha_Emision;
                   Obj.TarifaIVAcero = item.TarifaIVAcero;
                   Obj.TarifaIVADiferentecero = item.TarifaIVADiferentecero;
                   Obj.TarifaNoObjetoIVA = item.TarifaNoObjetoIVA;
                   Obj.MontoICE = item.MontoICE;
                   Obj.MontoIVA = item.MontoIVA;

                   Obj.baseImponible = item.baseImponible;
                   Obj.Total = item.Total;


                   Lst.Add(Obj);
               }
               return Lst;
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

       public List<cp_reembolso_Info> Get_List_reembolso(int IdEmpresa, int IdTipoCbte_Ogiro, decimal IdCbteCble_Ogiro)
       {
           try
           {
               List<cp_reembolso_Info> Lst = new List<cp_reembolso_Info>();
               EntitiesCuentasxPagar oEnti = new EntitiesCuentasxPagar();
               var Query = from q in oEnti.cp_reembolso
                           where q.IdEmpresa == IdEmpresa && q.IdTipoCbte_Ogiro == IdTipoCbte_Ogiro && q.IdCbteCble_Ogiro == IdCbteCble_Ogiro
                           select q;
               foreach (var item in Query)
               {
                   cp_reembolso_Info Obj = new cp_reembolso_Info();
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                   Obj.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                   Obj.IdReembolso = item.IdReembolso;
                   Obj.IdProveedor = item.IdProveedor;
                   Obj.TipoIdProveedor = item.TipoIdProveedor;
                   Obj.IdentificacionProveedor = item.IdentificacionProveedor;
                   Obj.TipoDoc_CodSRI = item.TipoDoc_CodSRI;
                   Obj.Establecimiento = item.Establecimiento;
                   Obj.Punto_Emision = item.Punto_Emision;
                   Obj.Secuencial = item.Secuencial;
                   Obj.Autorizacion = item.Autorizacion;
                   Obj.Fecha_Emision = item.Fecha_Emision;
                   Obj.TarifaIVAcero = item.TarifaIVAcero;
                   Obj.TarifaIVADiferentecero = item.TarifaIVADiferentecero;
                   Obj.TarifaNoObjetoIVA = item.TarifaNoObjetoIVA;
                   Obj.MontoICE = item.MontoICE;
                   Obj.MontoIVA = item.MontoIVA;

                   Obj.baseImponible = item.baseImponible;
                   Obj.Total = item.Total;

                   Lst.Add(Obj);
               }
               return Lst;
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

       public bool EliminarDB(int IdEmpresa,Decimal IdCbteCble_Ogiro,int IdTipoCbte_Ogiro)
       {
           try
           {
               using (EntitiesCuentasxPagar enti=new EntitiesCuentasxPagar())
               {
                   enti.Database.ExecuteSqlCommand("delete cp_reembolso where IdEmpresa=" + IdEmpresa + " and IdCbteCble_Ogiro =" + IdCbteCble_Ogiro + " and IdTipoCbte_Ogiro="+IdTipoCbte_Ogiro);
               }
               return true;
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

       public cp_reembolso_Data(){}
    }
}
