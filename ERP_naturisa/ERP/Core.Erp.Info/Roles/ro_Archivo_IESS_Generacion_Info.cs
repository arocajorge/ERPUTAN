/*CLASE: ro_Archivo_IESS_Generacion_Info
 *CREADA POR: ALBERTO MENA
 *FECHA: 23-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
   public  class ro_Archivo_IESS_Generacion_Info
    {
        //1. Archivo para novedades de entrada (Aviso de entrada). También sirve para trabajo por horas.
       public string Ruc { get; set; }
       public string CodigoSucursal { get; set; }
       public string AnioActual { get; set; }
       public string MesActual { get; set; }
       public string TipoMovimiento { get; set; }
       public string NoCedula { get; set; }
       public DateTime FechaIngresoEmpresa { get; set; }   
       public DateTime FechaIngresoIESS { get; set; }      
       public string Jornada { get; set; }
       public string CodigoSeguroSocial { get; set; }
       public string CodigoTipoEmpleador { get; set; }
       public string RelacionTrabajo { get; set; }
       public string Cargo { get; set; }
       public string CodigoActividaSectorial { get; set; }
       public double Sueldo { get; set; }
       public string OrigenPago { get; set; }

       //2. Archivo para novedades de salida (Aviso de salida)
       public DateTime FechaSalida { get; set; }       
       public string Causa { get; set; }
       public string FechaFallecimiento { get; set; }      

       //3. Archivo para novedades de modificación de sueldo (Aviso de nuevo sueldo)
       public double NuevoSueldo { get; set; }


       //4. Archivo para Novedades de Variación de Sueldo (Aviso de variación de sueldo por extras)
       public double ValorExtra { get; set; }

       //5. Archivo para Fondos de Reserva (Planilla de fondos de Reserva)
       public double SueldoTotal { get; set; }
       public string Periodo { get; set; }
       public string NoMesesLaborados { get; set; }


       //6. Archivo para Fondos de Reserva Mensual (Planilla de Fondos de Reserva Mensual) Nuevo 
       public string TipoPeriodo { get; set; }

       //7. Ajustes de Fondos de Reserva Públicos con fecha de aprobación del presupuesto (MEF)
       public DateTime FechaAprobacionMinisterio { get; set; }
       public string NoOficioAprobado { get; set; }
       public string RucAnterior { get; set; }
 

       //9. Archivo para novedades de días no laborados (Aviso de días no laborados)
       public DateTime FechaInicioDiasNoLaborados { get; set; }       
       public int DiasNoLaborados { get; set; }       

       //11. Archivo para novedades de Retroactivos y Diferencias
       public DateTime FechaSuscripcion { get; set; }
       public double ValorIncremento { get; set; }
       public string nombre { get; set; }
       public string nomina { get; set; }
       public string departamento { get; set; }

       public ro_Archivo_IESS_Generacion_Info() { }
    }
}
