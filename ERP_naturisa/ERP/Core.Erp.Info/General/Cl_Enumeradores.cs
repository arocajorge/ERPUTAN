using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{

    public class Cl_Enumeradores
    {

        public enum eMotivo_Diario_x_Vta
        {
            X_FACT,
            X_INV
        }



        public enum eTipoPersona
        {
            CLIENTE,
            EMPLEA,
            PERSONA,
            PROVEE,
            TODOS
        }


        public enum eEstado_Busqueda_OC
        {
            SIN_ORDEN_C,
            CON_ORDEN_C,
            TODOS
        }


        public enum eTipo_Estado_Cierre_Periodo
        {
            ABIERTO,
            CERRADO
            
        }

        public enum eTipo_Motivos_Conciliacion_CXP
        { 
             ANTPROV
            ,NCPPROV
            ,DIARIO
        }

       public  enum eTipo_Fecha_buscar_cobro
        {
            PorFechaEdicion = 1,
            PorFechaCobro = 2

        }



       public enum eTipo_action
        {
            grabar = 1,
            actualizar = 2,
            Anular=3,
            consultar=4,
            duplicar=5,
            actualizar_proceso_cerrado = 7
        }

    
        
       public enum ePeriocidad_Pago
       {
           mensual = 30,
           quincenal = 15,
           semanal = 7
           
       }  


       public enum eTipoTabla
       { 
        AnioFical=1,
        Periodo=2,
        CbteCble=3,
        CbteCble_tipo=4,
        PlanCta=5,
        CentroCosto=6,
        PlanCta_Nivel=7,
        CentroCosto_nivel=8,
        Empresa=9
      }


       public enum eTipoFiltro
       { 
         todos=0,
         Normal=1
       }

       public enum eTipoDocumento
       {
           COTI=1,
           DEV=2,
           FACT=3,
           NOTA=4,
           PEDI=5
       }

       public enum FaTipoCat
       { 
           E_FAB_PED = 1,
           CAU_MOD_ANU = 2,
           TIP_CONT_FACT = 3,
           TIPCLI = 4,
           ACT_ECO = 5
       
       }

       public enum TipoCatalogo
       {
           SEXO = 1,
           ESTCIVIL = 2,
           TIPODOC = 3,
           ESTGEN = 4,
           TIPONATPER = 5,
           TIPOSERVPR = 6,
           TIPOGAST = 7,
           UNDMED = 8,
           TIPOCLI = 9,
           ACTCOMCL = 10,
           TIPOPREPRO = 11,
           TIPODOCSRI = 12,
           TIPOPAGO = 13,
           CLASEEMP = 14,
           CARGO = 15,
           ESTUDIO = 16,
           TITULO = 17,
           TIPOSANG = 18,
           TIPOCTA = 19,
           TIPOFAMIL=20,
           ANEX_SRI=21,
           TRAN_SRI=22
       }

       public enum DiasSemana { 
       
           LUNES = 1,
           MARTES= 2,
           MIÉRCOLES = 3,
           JUEVES = 4,
           VIERNES = 5,
           SÁBADO = 6,
           DOMINGO = 7
       
       }


       public enum PantallaEjecucion { 
           ANTICIPOS = 1,
           COBROS = 2,
           TARJETA = 3

       }

       public enum TipoConciliacion
       {
           ANT_CLI = 1,
           CBR = 2,
           NT_CR_DB =3,
           VTA = 4
       }



       public enum eTipoDocumento_Talonario
       {
           FACT,
           RETEN,
           NTCR,
           NTDB,
           GUIA,
           NTVTA
       }

       public enum eTipoCargaSubCentroCosto
       {
           CON_CENTRO_COSTO,
           SIN_CENTRO_COSTO
          
       }

       public enum eTipoActivoFijo
       { 
            Mejo_Acti,
            Baja_Acti,
            Venta_Acti,
            Retiro_Acti
       }

       public enum eEstadoActivoFijo
       { 
            TIP_ESTADO_AF_ACTIVO,
            TIP_ESTADO_AF_RETIRO,
            TIP_ESTADO_AF_VENTA
       }

       public enum eTipoCodComprobante
       {
           FAC,
           NTC,
           NTD,
           GUI,
           RET,
           FACR
       }


       public enum eTipoDepreciacion
       { 
           DEP_LIN ,
           DEP_UNI_PRO ,
           DEP_SUM_DIG_ANU 
       }


       public enum eTipo_Cbte_Activos_Fijos
       {
           CTA_ACTIVO,
           CTA_DEPRE_ACUM,
           CTA_GASTOS_DEPRE
       }


       public enum eForma_Contabilizar
       { 
            Por_Activo,
            Por_Tipo_CtaCble,
            Por_CtaCble
       }

       public enum eTipoCatalogo_AF
       { 
           TIP_COLOR,
           TIP_DISEÑO,
           TIP_ESTADO_AF,
           TIP_MARCA,
           TIP_TRAN_AFEC_AF,
           TIP_UBICACION,
           TIP_UNIDADES
       }


       public enum eTipoNaturalezaProducto
       { 
           PRD_X_ACFIJ,
           PRD_X_COMPRA,
           PRD_X_TODO,
           PRD_X_VENT
       }

       public enum eTipoCreditoCliente
       {
           CRE,
           AMB,
           CON
       }

       public enum eTipoVencimiento_x_OG
       { 
        VENCIDO,
           X_VENCER,
           VENCE_HOY
       }

       public enum eTipo_Ing_Egr
       { 
           INGRESOS,
           EGRESOS
       }

       public enum eCodigo_SRI_Tipo
       {         
            COD_101,
            COD_ICE,
            COD_IDCREDITO,
            COD_RET_FUE,
            COD_RET_IVA,
            COD_IMPT_IVA
       }

       public enum eEstadoAprobacion_Ing_Egr
       { 
            APRO,
            PEND,
            REPRO
       }


       public enum eTipoNotaBanco
       {

           NCBA,
           NDBA
       }

       public enum eTipoUbicacion_Geo
       { 
           Pais,
           Provincia,
           Ciudad,
           Parroquia
       }


        


       public enum eCliente_Vzen
       {
           GRAFINPRENT,
           NATURISA,
           FJ,
           TALME,
           //COLEGIO ALEMAN
           CAH,
           GENERAL,
           TRANSGANDIA,
           EDEHSA
       }



        /// <summary>
        /// ACA	Academico
        /// ACTF	Activo Fijo
        /// BAN	Bancos
        /// CAJ	Caja
        /// COMP	Compras
        /// CONTA	Contabilidad
        /// CXC	Cuentas x Cobrar
        /// CXP	Cuentas por Pagar
        /// FAC	Facturacion
        /// IMP	Importaciones
        /// INV	Inventario
        /// ROL	Roles
        /// </summary>
       public enum eModulos
       {    
            ACTF,
            BAN,
            CAJ,
            COMP,
            CONTA,
            CXC,
            CXP,
            FAC,
            IMP,
            INV,
            ROL
       }


       public enum eTipoComprobante
       {
           Factura,
           NotaCred,
           NotaDeb,
           Guia,
           Retencion,
           FacturaRembolso
       }


      


    }

    

}
