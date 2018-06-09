using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;

using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using System.Data;


namespace Core.Erp.Business.CuentasxPagar
{
   public class cp_nota_DebCre_Bus
    {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

       string mensaje = "";
       cp_nota_DebCre_Data data = new cp_nota_DebCre_Data();

       public List<cp_nota_DebCre_Info> Get_List_nota_DebCre(int IdEmpresa)
       {
           try
           {
               return data.Get_List_nota_DebCre(IdEmpresa);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_nota_DebCre", ex.Message), ex) { EntityType = typeof(cp_nota_DebCre_Bus) };
           }
         
       }

       public List<cp_nota_DebCre_Info> Get_List_nota_DebCre(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string DebCre)
       {
           try
           {
                return data.Get_List_nota_DebCre(IdEmpresa,FechaIni, FechaFin, DebCre);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_nota_DebCre", ex.Message), ex) { EntityType = typeof(cp_nota_DebCre_Bus) };
           }            
       }

       public List<cp_nota_DebCre_Info> Get_List_nota_DebCre(int IdEmpresa, int anio, int mes)
       {
           try
           {
               return data.Get_List_nota_DebCre(IdEmpresa, anio, mes);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_nota_DebCre", ex.Message), ex) { EntityType = typeof(cp_nota_DebCre_Bus) };

           }
       }

       public Boolean Existe_NumNotaCredito_Proveedor(int IdEmpresa, decimal IdProveedor, String ptoEmision, String Establecimiento, String secuencial, String Tipo, String IdTipoNota)
       {
           try
           {
               return data.Existe_NumNotaCredito_Proveedor(IdEmpresa,  IdProveedor,  ptoEmision, Establecimiento,  secuencial,  Tipo,  IdTipoNota);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Existe_NumNotaCredito_Proveedor", ex.Message), ex) { EntityType = typeof(cp_nota_DebCre_Bus) };
           }
       
       
       }

       public Boolean GrabarDB(cp_nota_DebCre_Info info,ref string mensaje)
       {
           try
           {

               Boolean res_mod_conta = false;
               decimal IdCbteCble = 0;
               ct_Cbtecble_Bus BusCbteCble = new ct_Cbtecble_Bus();
               cp_parametros_Bus BusParam = new cp_parametros_Bus();
               cp_parametros_Info InfoParam = new cp_parametros_Info();
               InfoParam =BusParam.Get_Info_parametros(info.IdEmpresa);
               if (info.DebCre=="D")
               {
                   info.IdTipoCbte_Nota = Convert.ToInt32(InfoParam.pa_TipoCbte_ND);
               }
               else
               {
                   info.IdTipoCbte_Nota = Convert.ToInt32(InfoParam.pa_TipoCbte_NC);
               }

               res_mod_conta = BusCbteCble.GrabarDB(info.Info_CbteCble_X_Nota,ref IdCbteCble, ref mensaje);
               if (res_mod_conta == true)
               {
                   info.IdCbteCble_Nota = IdCbteCble;
                   info.IdTipoCbte_Nota = info.Info_CbteCble_X_Nota.IdTipoCbte;

                   res_mod_conta = data.GrabarDB(info, ref mensaje);
               }

               return res_mod_conta;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_nota_DebCre_Bus) };

           }
       }

       public Boolean ModificarDB(cp_nota_DebCre_Info info)
       {
           try
           {
               Boolean res_mod_conta = false;
               string mensaje="";
               ct_Cbtecble_Bus BusCbteCble = new ct_Cbtecble_Bus();
               res_mod_conta = BusCbteCble.ModificarDB(info.Info_CbteCble_X_Nota, ref mensaje);
               if (res_mod_conta == true)
               { 
                    res_mod_conta =data.ModificarDB(info );
               }

               return res_mod_conta;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_nota_DebCre_Bus) };

           }
       }

       public Boolean AnularDB(cp_nota_DebCre_Info Info_notaCredDeb)
       {
           try
           {
               bool res = false;
               decimal IdCbteCbleRev = 0;
               int IdTipoCbte_Anulacion = 0;

               string msg2 = "";

               IdTipoCbte_Anulacion = Convert.ToInt32(Info_notaCredDeb.IdTipoCbte_Anulacion);



               ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
               res = CbteCble_B.ReversoCbteCble(Info_notaCredDeb.IdEmpresa, Info_notaCredDeb.IdCbteCble_Nota, Info_notaCredDeb.IdTipoCbte_Nota,  IdTipoCbte_Anulacion , ref IdCbteCbleRev, ref msg2, Info_notaCredDeb.IdUsuario);

               //if (res)
               {
                   Info_notaCredDeb.IdCbteCble_Anulacion = IdCbteCbleRev;
                   Info_notaCredDeb.IdTipoCbte_Anulacion = IdTipoCbte_Anulacion;

                   res = data.AnularDB(Info_notaCredDeb);
               }

               return res;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(cp_nota_DebCre_Bus) };
           }
       }

       public Boolean VericarNumDocumento(int IdEmpresa, decimal IdProveedor, string Serie1, string Serie2, string cn_NotaC, decimal IdCbteCble_NotaC, int IdTipoCbte_NotaC, ref string mensaje)
       {
           try
           {
               return data.VericarNumDocumento(IdEmpresa,IdProveedor,Serie1,Serie2, cn_NotaC, IdCbteCble_NotaC, IdTipoCbte_NotaC, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VericarNumDocumento", ex.Message), ex) { EntityType = typeof(cp_nota_DebCre_Bus) };
           }
       }
       
       public cp_nota_DebCre_Info Get_Info_nota_DebCre(int IdEmpresa, decimal IdCbteCble_NotaC, int IdTipoCbte_NotaC)
        {
            try
            {
                return data.Get_Info_nota_DebCre(IdEmpresa, IdCbteCble_NotaC, IdTipoCbte_NotaC);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_nota_DebCre", ex.Message), ex) { EntityType = typeof(cp_nota_DebCre_Bus) };

            }
        }

       public cp_rpt_nota_credito_Info Get_Info_rpt_nota_credito(int IdEmpresa, decimal IdProveedor, decimal IdCbteCble_NotaC, int IdTipoCbte_NotaC)
       {
           try
           {
               return data.Get_Info_rpt_nota_credito(IdEmpresa, IdProveedor, IdCbteCble_NotaC, IdTipoCbte_NotaC);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_rpt_nota_credito", ex.Message), ex) { EntityType = typeof(cp_nota_DebCre_Bus) };
           }
       }

       public bool Modificar_tipo_flujo(cp_nota_DebCre_Info info_nota)
       {
           try
           {
               return data.Modificar_tipo_flujo(info_nota);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar_tipo_flujo", ex.Message), ex) { EntityType = typeof(cp_nota_DebCre_Bus) };
           }
       }

       public List<cp_nota_DebCre_Info> ProcesarDataTable_ND_x_Saldo_inicial(DataTable ds, ref string MensajeError)
       {
           cp_parametros_Bus bus_param = new cp_parametros_Bus();
           cp_parametros_Info info_param = new cp_parametros_Info();
           info_param = bus_param.Get_Info_parametros(param.IdEmpresa);
           cp_proveedor_Info info_proveedor = new cp_proveedor_Info();
           cp_proveedor_Bus bus_proveedor = new cp_proveedor_Bus();          
           List<cp_nota_DebCre_Info> lista = new List<cp_nota_DebCre_Info>();

           int COLUMNA_ERROR = 0;
           string FILA_ERROR = "";
           lista.Clear();
           try
           {
               //VALIDAR QUE TENGA MAS DE 12 COLUMNAS
               //if (ds.Columns.Count == 5)
               {
                   //RECORRE EL DATATABLE REGISTRO X REGISTRO
                   if (ds.Rows.Count > 0)
                   {
                       foreach (DataRow row in ds.Rows)
                       {

                           cp_nota_DebCre_Info info = new cp_nota_DebCre_Info();
                           //RECORRE C/U DE LAS COLUMNAS
                           info.IdEmpresa = param.IdEmpresa;
                           info.IdCbteCble_Nota = 0;
                           info.IdTipoCbte_Nota = Convert.ToInt32(info_param.pa_TipoCbte_ND);
                           info.DebCre = "D";
                           info.IdTipoNota = "T_TIP_NOTA_INT";
                           info.IdUsuario = "SysAdmin";
                           info.PagoLocExt = "LOC";
                           info.ConvenioTributacion = "NA";
                           info.PagoSujetoRetencion = "NA";
                           info.IdTipoFlujo = 1;
                           info.Fecha_Transac = param.Fecha_Transac;
                           info.cn_Por_iva = param.iva.porcentaje;
                           info.IdCtaCble_IVA = info_param.pa_ctacble_iva;

                           for (int col = 0; col < ds.Columns.Count + 1; col++)
                           {
                               COLUMNA_ERROR = col;
                               switch (col)
                               {
                                   case 0://cod_prov
                                       info_proveedor = bus_proveedor.Get_info_proveedor_x_codigo_para_saldo_inicial(param.IdEmpresa, Convert.ToString(row[col]), ref mensaje);
                                       info.IdProveedor = info_proveedor.IdProveedor;
                                       info.InfoProveedor.IdCtaCble_CXP = info_proveedor.IdCtaCble_CXP;
                                       info.InfoProveedor.pr_codigo = Convert.ToString(row[col]).ToString();
                                       info.InfoProveedor.pr_nombre = info_proveedor.pr_nombre;
                                       info.InfoProveedor.IdClaseProveedor = info_proveedor.IdClaseProveedor;
                                       info.IdSucursal = param.IdSucursal;
                                       FILA_ERROR = "Código "+Convert.ToString(row[col]);
                                       break;
                                   case 1://# factura
                                       info.cod_nota = Convert.ToString(row[col]).Trim();
                                       FILA_ERROR = "# factura " + Convert.ToString(row[col]);

                                       //if (info.cod_nota == "000017052") 
                                       //{
                                       //    info.cn_observacion = "S.I. FAC # " + info.cod_nota;
                                       //}
                                       break;
                                   case 2://Fecha factura
                                       info.cn_fecha = Convert.ToDateTime(row[col]).Date;
                                       FILA_ERROR = "Fecha factura " + Convert.ToString(row[col]);
                                       break;
                                   case 3://Fecha vcto factura
                                       info.cn_Fecha_vcto = Convert.ToDateTime(row[col]).Date;
                                       FILA_ERROR = "Fecha vcto factura " + Convert.ToString(row[col]);
                                       break;
                                   case 4://Saldo
                                       info.Saldo = Convert.ToDouble(row[col]);
                                       info.cn_subtotal_siniva = Convert.ToDouble(row[col]);
                                       info.cn_total = Convert.ToDecimal(info.Saldo);
                                       info.cn_baseImponible = info.cn_subtotal_siniva;
                                       FILA_ERROR = "Saldo " + Convert.ToString(row[col]);
                                       break;
                                   case 5://Observacion
                                       info.cn_observacion = Convert.ToString(row[col]).Trim();
                                       FILA_ERROR = "Observacion " + Convert.ToString(row[col]);
                                       break;
                                   default:
                                       break;
                               }
                           }                           
                           info.Estado = "A";
                           lista.Add(info);
                       }
                   }
                   else
                   {
                       MensajeError = "Por favor verifique que el archivo contenga Datos.";
                       lista = new List<cp_nota_DebCre_Info>();
                   }

               }
               /*else
               {
                   MensajeError = "Por favor verifique que el archivo tenga el formato correcto.\r Son 5 columnas.";
                   lista = new List<cp_nota_DebCre_Info>();
               }*/
               return lista;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
           }

       }

       public  cp_nota_DebCre_Bus(){}

    }
}
