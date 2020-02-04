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
    public partial class liquidacionCompraInfoLiquidacionCompraTotalImpuesto
    {

        private string codigoField;

        private string codigoPorcentajeField;

        private decimal descuentoAdicionalField;

        private bool descuentoAdicionalFieldSpecified;

        private decimal baseImponibleField;

        private decimal tarifaField;

        private bool tarifaFieldSpecified;

        private decimal valorField;

        /// <remarks/>
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        public string codigoPorcentaje
        {
            get
            {
                return this.codigoPorcentajeField;
            }
            set
            {
                this.codigoPorcentajeField = value;
            }
        }

        /// <remarks/>
        public decimal descuentoAdicional
        {
            get
            {
                return this.descuentoAdicionalField;
            }
            set
            {
                this.descuentoAdicionalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool descuentoAdicionalSpecified
        {
            get
            {
                return this.descuentoAdicionalFieldSpecified;
            }
            set
            {
                this.descuentoAdicionalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal baseImponible
        {
            get
            {
                return this.baseImponibleField;
            }
            set
            {
                this.baseImponibleField = value;
            }
        }

        /// <remarks/>
        public decimal tarifa
        {
            get
            {
                return this.tarifaField;
            }
            set
            {
                this.tarifaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tarifaSpecified
        {
            get
            {
                return this.tarifaFieldSpecified;
            }
            set
            {
                this.tarifaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
            }
        }
    }

}
