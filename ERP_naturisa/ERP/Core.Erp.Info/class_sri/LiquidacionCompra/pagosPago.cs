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
    public partial class pagosPago
    {

        private string formaPagoField;

        private decimal totalField;

        private decimal plazoField;

        private bool plazoFieldSpecified;

        private string unidadTiempoField;

        /// <remarks/>
        public string formaPago
        {
            get
            {
                return this.formaPagoField;
            }
            set
            {
                this.formaPagoField = value;
            }
        }

        /// <remarks/>
        public decimal total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        public decimal plazo
        {
            get
            {
                return this.plazoField;
            }
            set
            {
                this.plazoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool plazoSpecified
        {
            get
            {
                return this.plazoFieldSpecified;
            }
            set
            {
                this.plazoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string unidadTiempo
        {
            get
            {
                return this.unidadTiempoField;
            }
            set
            {
                this.unidadTiempoField = value;
            }
        }
    }

}
