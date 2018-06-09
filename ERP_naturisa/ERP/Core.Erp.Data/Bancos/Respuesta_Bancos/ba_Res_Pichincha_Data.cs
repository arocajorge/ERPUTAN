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
    public class ba_Res_Pichincha_Data
    {
        string mensaje = "";

        public List<ba_Res_Pichincha_Info> Get_Res_Pichincha(string Ruta, ref string Id_Orden_Bancaria)
        {
            try
            {
                List<ba_Res_Pichincha_Info> Lista = new List<ba_Res_Pichincha_Info>();

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
                    if (item[0]!="")
                    {
                        char identificador = item[0].Substring(0, 1).FirstOrDefault();
                        if (identificador<'9' && identificador > '0')
                        {
                            if (i == 0)
                            {
                                Id_Orden_Bancaria = item[13];
                                i++;
                            }
                            ba_Res_Pichincha_Info info = new ba_Res_Pichincha_Info();
                            info.Id_Item = item[0];
                            info.Pais = item[1];
                            info.Banco = item[2];
                            info.F_Pago = item[3];
                            info.Cuenta = item[4];
                            info.ContraPartida = item[5];
                            info.Referencia = item[6];
                            info.Valor = item[7];
                            info.N_Documento = item[8];
                            info.Moneda = item[9];
                            info.Estado = item[10];
                            info.Descripcion = item[11];
                            info.Referencia_adicional = item[12];
                            info.id_sobre = item[13];

                            Lista.Add(info);        
                        }
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
    }
}
