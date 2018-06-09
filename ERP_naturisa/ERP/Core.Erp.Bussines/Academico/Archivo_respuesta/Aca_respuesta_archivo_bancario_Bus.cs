using Core.Erp.Business.Bancos;
using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico.Archivo_respuesta;
using Core.Erp.Data.Academico.Archivo_respuesta;

namespace Core.Erp.Business.Academico.Archivo_respuesta
{
    public class Aca_respuesta_archivo_bancario_Bus
    {
        public List<ba_Archivo_Transferencia_Det_Info> get_lis_respuesta_aca(string Ruta)
        {
            try
            {
                List<ba_Archivo_Transferencia_Det_Info> Lista = new List<ba_Archivo_Transferencia_Det_Info>();
                List<Aca_respuesta_archivo_bancario_Info> lst_res = new List<Aca_respuesta_archivo_bancario_Info>();
                Aca_respuesta_archivo_bancario_Data oData_res = new Aca_respuesta_archivo_bancario_Data();
                lst_res = oData_res.get_lis_respuesta_aca(Ruta);
                foreach (var item in lst_res)
                {
                    ba_Archivo_Transferencia_Det_Info info = new ba_Archivo_Transferencia_Det_Info();

                    info.Id_Item = item.cod_estudiante;
                    info.pe_cedulaRuc = item.num_cuenta_tarjeta;
                    info.pe_nombreCompleto = item.nom_estudiante;
                    info.Fecha_Proceso = Convert.ToDateTime(item.fecha_proceso);
                    string ctvs = item.valor_cobrado.Substring(item.valor_cobrado.Length - 2);
                    string usd = item.valor_cobrado.Substring(0, item.valor_cobrado.Length - 2);
                    info.Valor_cobrado = Convert.ToDecimal(usd) + Convert.ToDecimal(ctvs) / 100;

                    ctvs = item.valor_comision.Substring(item.valor_comision.Length - 2);
                    usd = item.valor_comision.Substring(0, item.valor_comision.Length - 2);
                    info.Valor_comision = Convert.ToDouble(Math.Round(Convert.ToDecimal(usd) + Convert.ToDecimal(ctvs) / 100, 2, MidpointRounding.AwayFromZero));

                    Lista.Add(info);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_lis_respuesta_aca", ex.Message), ex) { EntityType = typeof(Aca_respuesta_archivo_bancario_Bus) };
            }
        }
    }
}
