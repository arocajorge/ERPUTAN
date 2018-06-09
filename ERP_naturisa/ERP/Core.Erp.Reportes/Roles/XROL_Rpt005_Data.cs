/*CLASE: XROL_Rpt004_Data
 *CREADA POR: ALBERTO MENA
 *FECHA: 13-05-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Roles
{
   public  class XROL_Rpt005_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();


        public List<XROL_Rpt005_Info> GetListConsultaPorPrestamo(int idEmpresa, decimal idPrestamo, ref string msg)
        {
            try
            {
                List<XROL_Rpt005_Info> listado = new List<XROL_Rpt005_Info>();
                
                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt005
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdPrestamo==idPrestamo
                                 select a);

                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt005_Info info = new XROL_Rpt005_Info();

                        info.IdEmpleado = item.IdEmpleado;
                        info.CedulaRuc = item.CedulaRuc;
                        info.NombreCompleto = item.CedulaRuc.Trim() + " - " + item.NombreCompleto.Trim();

                        info.IdPrestamo = item.IdPrestamo;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdNomina_Tipo = item.IdNomina_Tipo;
                        info.NominaDescripcion = item.NominaDescripcion;
                        info.EstadoPrestamo = item.EstadoPrestamo;
                        info.Fecha = item.Fecha;
                        info.MontoSol = item.MontoSol;
                        info.TasaInteres = item.TasaInteres;
                        info.TotalPrestamo = item.TotalPrestamo;
                        info.NumCuotas = item.NumCuotas;
                        info.Observacion = item.Observacion;
                        info.NumCuota = item.NumCuota;
                        info.SaldoInicial = item.SaldoInicial;
                        info.Interes = item.Interes;
                        info.AbonoCapital = item.AbonoCapital;
                        info.TotalCuota = item.TotalCuota;
                        info.Saldo = item.Saldo;
                        info.FechaPago = item.FechaPago;
                        info.EstadoPago = item.EstadoPago;
                        info.ObservacionCuota = item.ObservacionCuota;
                        info.RubroDescripcion = item.RubroDescripcion;
                        info.CodigoEmpleado = item.CodigoEmpleado;
                        info.tp_Descripcion = item.RubroDescripcion;
                     
                        info.Logo = Cbt.em_logo_Image;

                        listado.Add(info);
                    }

                }
                 
                return listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                msg = mensaje;
                return new List<XROL_Rpt005_Info>();
            }

        }





    }
}
