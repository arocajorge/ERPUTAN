using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Bancos
{
    public class ba_Archivo_Transferencia_Det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdArchivo { get; set; }
        public string IdProceso_bancario { get; set; }
        public ebanco_procesos_bancarios_tipo IdProceso { get; set; }
        public int Secuencia { get; set; }
        public string Id_Item { get; set; }
        public Nullable<int> IdEmpresa_OP { get; set; }
        public Nullable<decimal> IdOrdenPago { get; set; }
        public Nullable<int> IdEmpresaNomina { get; set; }
        public Nullable<int> IdNominaTipo { get; set; }
        public Nullable<int> IdNominaTipoLiqui { get; set; }
        public Nullable<int> IdPeriodo { get; set; }
        public Nullable<int> IdEmpleado { get; set; }
        public string IdRubro { get; set; }
        public Nullable<decimal> Secuencial_reg_x_proceso { get; set; }
        public decimal Valor { get; set; }
        public string IdEstadoRegistro_cat { get; set; }
        public string nom_EstadoRegistro { get; set; }
        public bool Estado { get; set; }        
        public Nullable<int> IdInstitucion_Col { get; set; }
        public Boolean Chequeo { get; set; }
        public bool Contabilizado { get; set; }
        //public string IdAnioLectivo_Col { get; set; }
        public int? IdAnioLectivo_Col { get; set; }
        public Nullable<int> IdPeriodo_Col { get; set; }
        public Nullable<int> IdRubro_Col { get; set; }
        public Nullable<decimal> IdEstudiante_Col { get; set; }
        public decimal Valor_cobrado { get; set; }
        public Nullable<int> IdEmpresa_pago { get; set; }
        public Nullable<int> IdTipoCbte_pago { get; set; }
        public Nullable<decimal> IdCbteCble_pago { get; set; }
        //campos pantalla pago proveedores
        public decimal IdPersona { get; set; }
        public string Beneficiario { get; set; }
        public string Observacion_op { get; set; }
        public bool check { get; set; }
        public DateTime fecha_op { get; set; }
        public string Estado_OP { get; set; }
        public Nullable<int> Secuencia_OP { get; set; }
        public string IdTipo_Persona { get; set; }
        public Nullable<decimal> IdEntidad { get; set; }
        public string Estado_Transferencia { get; set; }
        public string Referencia { get; set; }
        //Campos vista
        public Nullable<decimal> Saldo_x_Cobrar { get; set; }
        public decimal Valor_Enviado { get; set; }
        public string IdOrden_Bancaria { get; set; }
        public string IdMotivoArchivo_cat { get; set; }
        public string nom_MotivoArchivo { get; set; }
        public string Nom_Archivo { get; set; }
        public DateTime Fecha { get; set; }
        public string IdTipoCta_acreditacion_cat { get; set; }
        public string IdTipoDocumento { get; set; }
        public string CodigoLegal { get; set; }        
        public string tipo_cbte_pago { get; set; }
        //Campos para respuesta del banco
        public decimal Valor_procesado { get; set; }
        public decimal Saldo { get; set; }
        public Nullable<System.DateTime> Fecha_Proceso { get; set; }
        public Nullable<bool> Genera_anulacion { get; set; }
        public string cb_Estado { get; set; }
        //Campos para grilla actualizacion
        public Boolean Actualizado { get; set; }
        public string Observacion { get; set; }
        //Campos para movimiento bancario
        

        public int ? IdEmpresa_mvba { get; set; }
        public decimal ? IdCbteCble_mvba { get; set; }
        public int ? IdTipocbte_mvba { get; set; }
        //Campos para movimiento de caja
        public int  mcj_IdEmpresa { get; set; }
        public int  mcj_IdTipocbte { get; set; }
        public decimal  mcj_IdCbteCble { get; set; }
        public int  mcj_secuencia { get; set; }
        public string IdCtaCble { get; set; }
        public double dc_Valor { get; set; }

        public DateTime ? cb_Fecha_cheq { get; set; }
        public string num_cheq { get; set; }
        public string Observacion_cheq { get; set; }
        public string giradoA_cheq { get; set; }
        public string IdEstado_Preaviso_ch_cat { get; set; }

        // campo de colecturia
        public int IdInstitucion { get; set; }
        public decimal IdPreFacturacion { get; set; }
        public int Secuencia_Proce { get; set; }        
        public int IdRubro_col { get; set; }
        public int IdInstitucion_contra { get; set; }
        public decimal IdContrato { get; set; }
        public int IdInstitucion_Per { get; set; }
        public int IdAnioLectivo_Per { get; set; }
        public int IdPeriodo_Per { get; set; }
        public int IdGrupoFE { get; set; }
        public decimal Valor_comision { get; set; }
        public string codigo_unico_estudiante { get; set; }
        public int esta_en_archivo { get; set; }
        public string concepto_estado_cuenta { get; set; }
        public Nullable<decimal> IdPreFacturacion_col { get; set; }
        public Nullable<int> Secuencia_Proce_col { get; set; }
        public Nullable<int> secuencia_col { get; set; }
        public Nullable<bool> estado_contrato_pago_garantizado { get; set; }
        //Campos de factura
        public Nullable<int> IdEmpresa_fac { get; set; }
        public Nullable<int> IdSucursal_fac { get; set; }
        public Nullable<int> IdBodega_fac { get; set; }
        public Nullable<decimal> IdCbteVta_fac { get; set; }

        public Nullable<decimal> IdProducto { get; set; }
        public double vt_cantidad { get; set; }
        public double vt_Precio { get; set; }
        public double vt_PorDescUnitario { get; set; }
        public double vt_DescUnitario { get; set; }
        public double vt_PrecioFinal { get; set; }
        public double vt_Subtotal { get; set; }
        public double vt_iva_valor { get; set; }
        public double vt_total { get; set; }
        public string IdCod_Impuesto_Iva { get; set; }
        public string observacion_det { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string num_cta_acreditacion { get; set; }
        public string pe_nombre { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string Descripcion_paralelo { get; set; }
        public string Descripcion_cur { get; set; }
        public string Descripcion_secc { get; set; }
        public string Descripcion_Jor { get; set; }
        public string Numero_Documento { get; set; }
        public string Tipo_documento_cat { get; set; }
        public bool activo { get; set; }
        public string Factura { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public decimal IdCliente { get; set; }
        public string CodigoCliente{ get; set; }
        public string NumCuenta_Respuesta { get; set; }
        public string EstadoRespuesta { get; set; }
        public int IdBanco { get; set; }

    }
}
