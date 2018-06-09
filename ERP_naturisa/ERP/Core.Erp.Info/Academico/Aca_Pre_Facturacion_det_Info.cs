using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
  public  class Aca_Pre_Facturacion_det_Info
    {
        public int IdInstitucion { get; set; }
        public decimal IdPreFacturacion { get; set; }

        public int Secuencia_Proce { get; set; }
        public int secuencia { get; set; }

        public int IdInstitucion_contra { get; set; }
        public decimal IdContrato { get; set; }
        public int IdRubro { get; set; }
        public int IdInstitucion_Per { get; set; }
        public int IdAnioLectivo_Per { get; set; } //SE ACTUALIZO DEBIDO A QUE EN LA TABLA Aca_Anio_Lectivo el id es varchar
        ////public string IdAnioLectivo_Per { get; set; }
        public int IdPeriodo_Per { get; set; }
        public int IdGrupoFE { get; set; }
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

      // vista
        public string Descripcion_paralelo { get; set; }
        public string Descripcion_cur { get; set; }
        public string Descripcion_secc { get; set; }
        public string Descripcion_Jor { get; set; }
        public string nom_GrupoFe { get; set; }
        public string Descripcion_rubro { get; set; }
        public string deb_cred { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string pe_razonSocial { get; set; }
        public string Codigo { get; set; }
        public decimal IdPersona { get; set; }
        public int IdSucursal { get; set; }
        public int IdVendedor { get; set; }
        public int Idtipo_cliente { get; set; }
        public string IdTipoCredito { get; set; }
        public string cl_Cat_crediticia { get; set; }
        public int cl_plazo { get; set; }
        public double cl_porcentaje_descuento { get; set; }
        public string IdCtaCble_cxc { get; set; }
        public string IdCtaCble_Anti { get; set; }

        public Nullable<decimal> IdProducto_inv { get; set; }
        public decimal IdFamiliar { get; set; }
        public string pe_nombreCompleto { get; set; }
        public decimal IdCliente { get; set; }
        public string IdParentesco_cat { get; set; }
        public decimal IdMatricula { get; set; }
        public string IdAnioLectivo { get; set; }
        public decimal IdEstudiante { get; set; }

        public Nullable<int> IdEmpresa_fac { get; set; }
        public Nullable<int> IdSucursal_fac { get; set; }
        public Nullable<int> IdBodega_fac { get; set; }
        public Nullable<decimal> IdCbteVta_fac { get; set; }
        public string idEstablecimiento { get; set; }
        public int idPtoEmision { get; set; }
        public string cod_PuntoVta_fact { get; set; }
        public string Su_CodigoEstablecimiento { get; set; }

        public string Numero_Documento { get; set; }
        public int IdTipoPersona { get; set; }
        public string IdTipoDocumento { get; set; }
        public string Tipo_documento_cat { get; set; }

        public string IdCentroCosto_ct { get; set; }
    }
}
