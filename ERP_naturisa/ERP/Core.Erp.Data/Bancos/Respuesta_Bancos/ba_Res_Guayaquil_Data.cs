using Core.Erp.Data.General;
using Core.Erp.Info.Bancos.Respuesta_Bancos;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Bancos.Respuesta_Bancos
{
    public class ba_Res_Guayaquil_Data
    {
        string mensaje = "";

        public List<ba_Res_Guayaquil_Info> Get_Res_Guayaquil(string Ruta, ref string Id_Orden_Bancaria)
        {
            try
            {
                List<ba_Res_Guayaquil_Info> Lista = new List<ba_Res_Guayaquil_Info>();

                List<string[]> parsedData = new List<string[]>();
                using (StreamReader readFile = new StreamReader(Ruta))
                {
                    string line;
                    string[] fila;

                    while ((line = readFile.ReadLine()) != null)
                    {
                        fila = line.Split('\t');
                        parsedData.Add(fila);
                    }
                }
                int i = 0;
                foreach (var item in parsedData)
                {
                    if (i == 5)
                        Id_Orden_Bancaria = Convert.ToString(item[0]);

                    if (item[0]!="")
                    {
                        char identificador = item[0].Substring(0, 1).ToCharArray().FirstOrDefault();

                        if (identificador < '9' && identificador > '0')
                        {
                            ba_Res_Guayaquil_Info info = new ba_Res_Guayaquil_Info();

                            info.Id_Item = item[1];
                            info.Fecha_Proceso = item[12];
                            info.Cuenta = item[7];
                            info.Num_Identificacion = item[7];
                            info.Referencia = item[8];
                            info.Valor_Procesado = item[9];
                            info.Valor_Enviado = item[10];    
                            info.Estado = item[13];
                            Lista.Add(info);
                        }
                    }
                    
                    i++;
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

        private string Obtener_IdOrden(string cadena)
        {
            try
            {
                
                string remover_cadena = "Resumen de la orden ";
                return cadena.Substring(remover_cadena.Length);
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
