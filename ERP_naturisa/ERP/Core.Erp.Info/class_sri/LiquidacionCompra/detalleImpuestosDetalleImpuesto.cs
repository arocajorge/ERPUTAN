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
    public partial class detalleImpuestosDetalleImpuesto
    {

        private string codigoField;

        private string codigoPorcentajeField;

        private string tarifaField;

        private decimal baseImponibleReembolsoField;

        private decimal impuestoReembolsoField;

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
        public string tarifa
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
        public decimal baseImponibleReembolso
        {
            get
            {
                return this.baseImponibleReembolsoField;
            }
            set
            {
                this.baseImponibleReembolsoField = value;
            }
        }

        /// <remarks/>
        public decimal impuestoReembolso
        {
            get
            {
                return this.impuestoReembolsoField;
            }
            set
            {
                this.impuestoReembolsoField = value;
            }
        }
    }
}
