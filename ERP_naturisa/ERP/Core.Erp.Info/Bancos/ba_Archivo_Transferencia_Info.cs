using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Bancos
{
    public class ba_Archivo_Transferencia_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdArchivo { get; set; }
        public string cod_archivo { get; set; }
        public int IdBanco { get; set; }
        public string IdOrden_Bancaria { get; set; }
        public string IdProceso_bancario { get; set; }
        public string Origen_Archivo { get; set; }
        public string Cod_Empresa { get; set; }
        public string Nom_Archivo { get; set; }
        public System.DateTime Fecha { get; set; }
        public byte[] Archivo { get; set; }
        public bool Estado { get; set; }
        public string IdEstadoArchivo_cat { get; set; }
        public string IdMotivoArchivo_cat { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string Observacion { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string Nom_pc { get; set; }
        public string Ip { get; set; }
        public string Motivo_anulacion { get; set; }
        public Nullable<System.DateTime> Fecha_Proceso { get; set; }
        public Nullable<bool> Contabilizado { get; set; }

        //Campos de vista
        public string nom_empresa { get; set; }
        public string nom_banco { get; set; }
        public string nom_proceso_bancario { get; set; }
        public string nom_EstadoArchivo { get; set; }
        public string CodigoLegal { get; set; }
        public Nullable<decimal> Valor_Enviado { get; set; }
        public Nullable<decimal> Valor_cobrado { get; set; }
        public Nullable<decimal> Saldo_x_Cobrar { get; set; }
        public string nom_MotivoArchivo { get; set; }

        public List<ba_Archivo_Transferencia_Det_Info> Lst_Archivo_Transferencia_Det { get; set; }
    }

    
}
