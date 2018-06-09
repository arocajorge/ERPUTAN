using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.CuentasxCobrar
{
   public class cxc_cobro_Det_Data
    {

       string mensaje = "";

       public Boolean GuardarDB(List<cxc_cobro_Det_Info> lista)
       {
           try
           {
               if (lista != null)
               {

                   using (EntitiesCuentas_x_Cobrar Contex = new EntitiesCuentas_x_Cobrar())
                   {
                       int secuencia = 0;
                       foreach (var item in lista)
                       {

                           var address = new cxc_cobro_det();
                           secuencia = secuencia + 1;

                           address.IdEmpresa = item.IdEmpresa;
                           address.IdSucursal = item.IdSucursal;
                           address.IdCobro = item.IdCobro;
                           address.secuencial = secuencia;
                           address.dc_TipoDocumento = item.dc_TipoDocumento;
                           address.IdBodega_Cbte = item.IdBodega_Cbte;
                           address.IdCbte_vta_nota = item.IdCbte_vta_nota;
                           address.dc_ValorPago = item.dc_ValorPago;
                           address.IdUsuario = item.IdUsuario;
                           address.Fecha_Transac = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                           address.nom_pc = item.nom_pc;
                           address.ip = item.ip;
                           //Contac = address;
                           Contex.cxc_cobro_det.Add(address);
                       }
                       Contex.SaveChanges();
                   }
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
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public List<cxc_cobro_Det_Info> Get_List_cobro_x_documento(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteCble)
       {
           try
           {
               List<cxc_cobro_Det_Info> Lista = new List<cxc_cobro_Det_Info>();

               using (EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
               {
                   var lst = from q in Context.cxc_cobro_det
                             join c in Context.cxc_cobro
                             on new { q.IdEmpresa, q.IdSucursal, q.IdCobro } equals new { c.IdEmpresa, c.IdSucursal, c.IdCobro }
                             where IdEmpresa == q.IdEmpresa
                             && IdSucursal == q.IdSucursal
                             && IdBodega == q.IdBodega_Cbte
                             && IdCbteCble == q.IdCbte_vta_nota
                             && c.cr_estado == "A"
                             group q by new { q.IdEmpresa, q.IdSucursal, q.IdBodega_Cbte, q.IdCbte_vta_nota }
                                 into grouping
                                 select new
                                 {
                                     grouping.Key.IdEmpresa,
                                     grouping.Key.IdSucursal,
                                     grouping.Key.IdBodega_Cbte,
                                     grouping.Key.IdCbte_vta_nota
                                 };
                   foreach (var item in lst)
                   {
                       cxc_cobro_Det_Info info = new cxc_cobro_Det_Info();
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdSucursal = item.IdSucursal;
                       info.IdBodega_Cbte = item.IdBodega_Cbte == null ? 0 : (int)item.IdBodega_Cbte;
                       info.IdCbte_vta_nota = item.IdCbte_vta_nota;
                       Lista.Add(info);
                   }
               }

               return Lista;
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

       public Boolean EliminarDetalleCobro(int IdEmpresa, int IdSucursal, decimal IdCobro)
       {
           try
           {
               Boolean res = false;
               List<cxc_cobro_Det_Info> listaAux = new List<cxc_cobro_Det_Info>();
               listaAux = Get_List_Cobro_detalle(IdEmpresa, IdSucursal, IdCobro);

               using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
               {
                   foreach (var item in listaAux)
                   {
                       var contact = context.cxc_cobro_det.FirstOrDefault(cot => cot.IdEmpresa == item.IdEmpresa && cot.IdSucursal == item.IdSucursal && cot.IdCobro == item.IdCobro);
                       if (contact != null)
                       {
                           context.cxc_cobro_det.Remove(contact);
                           context.SaveChanges();
                           res = true;
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
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean ModificarDetalleCobro(List<cxc_cobro_Det_Info> lista)
       {
           try
           {
               try
               {
                   List<cxc_cobro_Det_Info> listaAux = new List<cxc_cobro_Det_Info>();
                   cxc_cobro_Det_Info i = new cxc_cobro_Det_Info();
                   i = lista.First();
                   listaAux = Get_List_Cobro_detalle(i.IdEmpresa, i.IdSucursal, i.IdCobro);

                   using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                   {
                       foreach (var item in listaAux)
                       {
                           var contact = context.cxc_cobro_det.First(cot => cot.IdEmpresa == item.IdEmpresa && cot.IdSucursal == item.IdSucursal && cot.IdCobro == item.IdCobro);
                           context.cxc_cobro_det.Remove(contact);
                           context.SaveChanges();
                       }
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
               }
               using (EntitiesCuentas_x_Cobrar Contex = new EntitiesCuentas_x_Cobrar())
               {
                   int secuencia = 0;
                   foreach (var item in lista)
                   {
                       //var Contac = cxc_cobro_det.Createcxc_cobro_det(0, 0, 0, 0, 0, 0);
                       var address = new cxc_cobro_det();
                       secuencia = secuencia + 1;
                       address.IdEmpresa = item.IdEmpresa;
                       address.IdSucursal = item.IdSucursal;
                       address.IdCobro = item.IdCobro;
                       address.secuencial = secuencia;
                       address.dc_TipoDocumento = item.dc_TipoDocumento;
                       address.IdBodega_Cbte = item.IdBodega_Cbte;
                       address.IdCbte_vta_nota = item.IdCbte_vta_nota;
                       address.dc_ValorPago = item.dc_ValorPago;
                       address.IdUsuario = item.IdUsuario;
                       address.Fecha_Transac = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                       //Contac = address;
                       Contex.cxc_cobro_det.Add(address);
                       Contex.SaveChanges();
                   }
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
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public List<cxc_cobro_Det_Info> Get_List_Cobro_detalle(int IdEmpresa, int idsucursal, decimal idcobro)
       {
           try
           {
               List<cxc_cobro_Det_Info> lM = new List<cxc_cobro_Det_Info>();
               EntitiesCuentas_x_Cobrar CXC = new EntitiesCuentas_x_Cobrar();
               var select_det_cobro = from A in CXC.vwcxc_cobro_det
                                      where A.IdEmpresa == IdEmpresa
                                      && A.IdSucursal == idsucursal
                                      && A.IdCobro == idcobro
                                      select A
                                     ;
               foreach (var item in select_det_cobro)
               {
                   cxc_cobro_Det_Info dat = new cxc_cobro_Det_Info();
                   dat.IdEmpresa = item.IdEmpresa;
                   dat.IdSucursal = item.IdSucursal;
                   dat.IdCobro = item.IdCobro;
                   dat.dc_TipoDocumento = item.dc_TipoDocumento_Cobrado;
                   dat.dc_ValorPago = item.dc_ValorPago;
                   dat.estado = item.cr_estado;
                   dat.Documento_Cobrado = item.Documento_Cobrado;
                   dat.IdCobro_tipo = item.IdCobro_tipo;
                   dat.IdCbte_vta_nota = item.IdCbte_vta_nota;
                   dat.secuencial = item.secuencial;

                   lM.Add(dat);
               }
               return (lM);

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
