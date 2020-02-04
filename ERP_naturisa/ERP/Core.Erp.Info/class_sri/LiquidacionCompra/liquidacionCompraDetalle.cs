using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.class_sri.LiquidacionCompra
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class liquidacionCompraDetalle
    {

        private string codigoPrincipalField;

        private string codigoAuxiliarField;

        private string descripcionField;

        private string unidadMedidaField;

        private decimal cantidadField;

        private decimal precioUnitarioField;

        private decimal precioSinSubsidioField;

        private bool precioSinSubsidioFieldSpecified;

        private decimal descuentoField;

        private decimal precioTotalSinImpuestoField;

        private List<liquidacionCompraDetalleDetAdicional> detallesAdicionalesField;

        private List<impuesto> impuestosField;

        /// <remarks/>
        public string codigoPrincipal
        {
            get
            {
                return this.codigoPrincipalField;
            }
            set
            {
                this.codigoPrincipalField = value;
            }
        }

        /// <remarks/>
        public string codigoAuxiliar
        {
            get
            {
                return this.codigoAuxiliarField;
            }
            set
            {
                this.codigoAuxiliarField = value;
            }
        }

        /// <remarks/>
        public string descripcion
        {
            get
            {
                return this.descripcionField;
            }
            set
            {
                this.descripcionField = value;
            }
        }

        /// <remarks/>
        public string unidadMedida
        {
            get
            {
                return this.unidadMedidaField;
            }
            set
            {
                this.unidadMedidaField = value;
            }
        }

        /// <remarks/>
        public decimal cantidad
        {
            get
            {
                return this.cantidadField;
            }
            set
            {
                this.cantidadField = value;
            }
        }

        /// <remarks/>
        public decimal precioUnitario
        {
            get
            {
                return this.precioUnitarioField;
            }
            set
            {
                this.precioUnitarioField = value;
            }
        }

        /// <remarks/>
        public decimal precioSinSubsidio
        {
            get
            {
                return this.precioSinSubsidioField;
            }
            set
            {
                this.precioSinSubsidioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool precioSinSubsidioSpecified
        {
            get
            {
                return this.precioSinSubsidioFieldSpecified;
            }
            set
            {
                this.precioSinSubsidioFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal descuento
        {
            get
            {
                return this.descuentoField;
            }
            set
            {
                this.descuentoField = value;
            }
        }

        /// <remarks/>
        public decimal precioTotalSinImpuesto
        {
            get
            {
                return this.precioTotalSinImpuestoField;
            }
            set
            {
                this.precioTotalSinImpuestoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("detAdicional", IsNullable = false)]
        public List<liquidacionCompraDetalleDetAdicional> detallesAdicionales
        {
            get
            {
                return this.detallesAdicionalesField;
            }
            set
            {
                this.detallesAdicionalesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<impuesto> impuestos
        {
            get
            {
                return this.impuestosField;
            }
            set
            {
                this.impuestosField = value;
            }
        }
    }

}
