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
    public partial class liquidacionCompraDetalleDetAdicional
    {

        private string nombreField;

        private string valorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nombre
        {
            get
            {
                return this.nombreField;
            }
            set
            {
                this.nombreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valor
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
