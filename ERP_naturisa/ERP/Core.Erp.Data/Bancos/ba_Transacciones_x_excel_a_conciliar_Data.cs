using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Core.Erp.Data.General;



namespace Core.Erp.Data.Bancos
{
   public class ba_Transacciones_x_excel_a_conciliar_Data
    {

       public List<ba_Transacciones_x_excel_a_conciliar_Info> ProcesarDataTable_a_Info(DataTable ds, int idempresa, ref string MensajeError)
       {
           List<ba_Transacciones_x_excel_a_conciliar_Info> lista = new List<ba_Transacciones_x_excel_a_conciliar_Info>();
           try
           {
               string StipoMovimiento = "";
               
                   //RECORRE EL DATATABLE REGISTRO X REGISTRO
                   if (ds.Rows.Count > 0)
                   {
                       foreach (DataRow row in ds.Rows)
                       {
                           ba_Transacciones_x_excel_a_conciliar_Info info = new ba_Transacciones_x_excel_a_conciliar_Info();
                           //RECORRE C/U DE LAS COLUMNAS
                          
                           info.IdEmpresa = idempresa;
                        

                           for (int col = 0; col < ds.Columns.Count + 1; col++)
                           {
                               switch (col)
                               {
                                   case 0:
                                       info.SecuenciaFila = Convert.ToInt32(row[col]);
                                       break;

                                   case 1:
                                       info.Fecha = Convert.ToDateTime(row[col]);
                                       break;

                                   case 2:

                                       StipoMovimiento = Convert.ToString(row[col]);
                                       info.sTipo_Movimiento = StipoMovimiento;

                                       switch (StipoMovimiento)
                                       {
                                           case "CHQ": info.Tipo_Movimiento = ba_Transacciones_x_excel_a_conciliar_Info.eTipo_Movimiento.CHQ; break;
                                           case "N/D": info.Tipo_Movimiento = ba_Transacciones_x_excel_a_conciliar_Info.eTipo_Movimiento.ND; break;
                                           case "N/C": info.Tipo_Movimiento = ba_Transacciones_x_excel_a_conciliar_Info.eTipo_Movimiento.NC; break;
                                           case "DEP": info.Tipo_Movimiento = ba_Transacciones_x_excel_a_conciliar_Info.eTipo_Movimiento.DEP; break;
                                       }

                                       break;
                                   case 3:
                                       info.Documento = Convert.ToString(row[col]);
                                       break;
                                   case 4:
                                       info.Concepto= Convert.ToString(row[col]);
                                       break;
                                   case 5:
                                       info.Agencia= Convert.ToString(row[col]);
                                       break;
                                   case 6:
                                       info.Valor= Convert.ToDecimal(row[col]);
                                       break;
                                   case 7:
                                       info.Referencia= Convert.ToString(row[col]);
                                       break;
                                   

                                   default:
                                       break;
                               }
                           }
                           
                           lista.Add(info);
                       }
                   }
                   else
                   {
                       MensajeError = "Por favor verifique que el archivo contenga Datos.";
                       lista = new List<ba_Transacciones_x_excel_a_conciliar_Info>();
                   }

               
               //else
               //{
               //    MensajeError = "Por favor verifique que el archivo tenga el formato correcto.\r Son 11 columnas.";
               //    lista = new List<ba_Transacciones_x_excel_a_conciliar_Info>();
               //}
                   return lista;
           }
           catch (Exception ex)
           {
               MensajeError = ex.Message;
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }
    }
}
