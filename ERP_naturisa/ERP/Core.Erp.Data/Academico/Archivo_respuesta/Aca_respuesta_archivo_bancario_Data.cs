using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico.Archivo_respuesta;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.IO;

namespace Core.Erp.Data.Academico.Archivo_respuesta
{
    public class Aca_respuesta_archivo_bancario_Data
    {
        public List<Aca_respuesta_archivo_bancario_Info> get_lis_respuesta_aca(string Ruta)
        {
            try
            {
                List<Aca_respuesta_archivo_bancario_Info> Lista = new List<Aca_respuesta_archivo_bancario_Info>();

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

                foreach (var item in parsedData)
                {
                    if (item[0] != "")
                    {
                        char identificador = item[0].Substring(0, 1).FirstOrDefault();
                        if (identificador < '9' && identificador > '0')
                        {                            
                            Aca_respuesta_archivo_bancario_Info info = new Aca_respuesta_archivo_bancario_Info();
                            info.cod_estudiante = item[0];
                            info.nom_estudiante = item[1];
                            info.num_cuenta_tarjeta = item[2];
                            info.fecha_proceso = item[3];
                            info.valor_cobrado = item[4];
                            info.valor_comision = item[5];
                            Lista.Add(info);
                        }
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
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
