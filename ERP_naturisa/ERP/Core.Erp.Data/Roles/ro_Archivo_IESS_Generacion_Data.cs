
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_Archivo_IESS_Generacion_Data
    {
        string mensaje = "";

        public Boolean GrabarBD(ro_Archivo_IESS_Generacion_Info info, string nombreArchivo, string carSeparador, ref string msg)
        {
            try
            {

                string linea = "";
                
                //CAMPOS BASICOS
                linea += info.Ruc + carSeparador;
                linea += info.CodigoSucursal.PadLeft(4, '0') + carSeparador;
                linea += info.AnioActual + carSeparador;
                linea += info.MesActual.PadLeft(2,'0') + carSeparador;
                linea += info.TipoMovimiento+ carSeparador;
                linea += info.NoCedula + carSeparador;

                switch (info.TipoMovimiento)
                {
                    //1. Archivo para novedades de entrada (Aviso de entrada). 
                    case "ENT":
                        linea += info.FechaIngresoEmpresa.ToString("yyyyMMdd") + carSeparador;
                        linea += info.FechaIngresoIESS.ToString("yyyyMMdd") + carSeparador;
                        linea += info.Jornada + carSeparador;
                        linea += info.CodigoSeguroSocial + carSeparador;
                        linea += info.CodigoTipoEmpleador + carSeparador;
                        linea += info.RelacionTrabajo + carSeparador;
                        linea += info.Cargo + carSeparador;
                        linea += info.CodigoActividaSectorial + carSeparador;
                        linea += info.Sueldo.ToString("F2") + carSeparador;
                        linea += info.OrigenPago;
                        break;

                    //2. Archivo para novedades de salida (Aviso de salida)
                    case "SAL":
                        linea += info.FechaSalida.ToString("yyyyMMdd") + carSeparador;
                        linea += info.Causa + carSeparador;
                        linea += info.FechaFallecimiento;
                        break;

                    //3. Archivo para novedades de modificación de sueldo (Aviso de nuevo sueldo)
                    case "MSU":
                        linea += info.NuevoSueldo.ToString("F2");
                        break;

                    //4. Archivo para Novedades de Variación de Sueldo (Aviso de variación de sueldo por extras)
                    case "INS":
                        linea += info.ValorExtra.ToString("F2") + carSeparador;
                        linea += info.Causa;
                        break;

                    //5. Archivo para Fondos de Reserva (Planilla de fondos de Reserva)
                    case "PFR":
                        linea += info.SueldoTotal.ToString("F2") + carSeparador;
                        linea += info.Periodo + carSeparador;
                        linea += info.NoMesesLaborados;
                        break;

                    //6. Archivo para Fondos de Reserva Mensual (Planilla de Fondos de Reserva Mensual) Nuevo 
                    case "PFM":
                        linea += info.SueldoTotal.ToString("F2") + carSeparador;
                        linea += info.Periodo + carSeparador;
                        linea += info.NoMesesLaborados + carSeparador;
                        linea += info.TipoPeriodo;
                        break;

                    //7. Ajustes de Fondos de Reserva Públicos con fecha de aprobación del presupuesto (MEF)
                    case "PPF":
                        linea += info.SueldoTotal.ToString("F2") + carSeparador;
                        linea += info.Periodo + carSeparador;
                        linea += info.NoMesesLaborados + carSeparador;
                        linea += info.FechaAprobacionMinisterio.ToString("yyyyMMdd") + carSeparador;
                        linea += info.NoOficioAprobado + carSeparador;
                        linea += info.TipoPeriodo;
                            if (info.RucAnterior.Length>0) linea += carSeparador+ info.RucAnterior; //[Opcional en caso de tener cambio de RUC determinado por el MEF]  
                        break;

                    //8. Ajustes de Fondos de Reserva Públicos y Privados Normales Anuales y Mensuales
                    case "PFN":
                        linea += info.SueldoTotal.ToString("F2") + carSeparador;
                        linea += info.Periodo + carSeparador;
                        linea += info.NoMesesLaborados + carSeparador;
                        linea += info.TipoPeriodo;
                        if (info.RucAnterior.Length > 0) linea += carSeparador + info.RucAnterior; //[Opcional en caso de tener cambio de RUC determinado por el MEF]  
                        break;


                    //9. Archivo para novedades de días no laborados (Aviso de días no laborados)
                    case "MND":
                        linea += info.FechaInicioDiasNoLaborados.ToString("yyyyMMdd") + carSeparador;
                        linea += info.DiasNoLaborados;
                        break;

                    //11. Archivo para novedades de Retroactivos y Diferencias
                    case "PRA":
                        linea += info.FechaSuscripcion.ToString("yyyyMMdd") + carSeparador;
                        linea += info.ValorIncremento.ToString("F2");
                        break;

                }



               

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(nombreArchivo, true))
                {
                    file.WriteLine(linea);
                    file.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
