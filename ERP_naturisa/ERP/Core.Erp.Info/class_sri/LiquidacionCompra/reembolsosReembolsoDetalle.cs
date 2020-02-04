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
    public partial class reembolsosReembolsoDetalle
    {

        private string tipoIdentificacionProveedorReembolsoField;

        private string identificacionProveedorReembolsoField;

        private string codPaisPagoProveedorReembolsoField;

        private string tipoProveedorReembolsoField;

        private string codDocReembolsoField;

        private string estabDocReembolsoField;

        private string ptoEmiDocReembolsoField;

        private string secuencialDocReembolsoField;

        private string fechaEmisionDocReembolsoField;

        private string numeroautorizacionDocReembField;

        private detalleImpuestosDetalleImpuesto[] detalleImpuestosField;

        /// <remarks/>
        public string tipoIdentificacionProveedorReembolso
        {
            get
            {
                return this.tipoIdentificacionProveedorReembolsoField;
            }
            set
            {
                this.tipoIdentificacionProveedorReembolsoField = value;
            }
        }

        /// <remarks/>
        public string identificacionProveedorReembolso
        {
            get
            {
                return this.identificacionProveedorReembolsoField;
            }
            set
            {
                this.identificacionProveedorReembolsoField = value;
            }
        }

        /// <remarks/>
        public string codPaisPagoProveedorReembolso
        {
            get
            {
                return this.codPaisPagoProveedorReembolsoField;
            }
            set
            {
                this.codPaisPagoProveedorReembolsoField = value;
            }
        }

        /// <remarks/>
        public string tipoProveedorReembolso
        {
            get
            {
                return this.tipoProveedorReembolsoField;
            }
            set
            {
                this.tipoProveedorReembolsoField = value;
            }
        }

        /// <remarks/>
        public string codDocReembolso
        {
            get
            {
                return this.codDocReembolsoField;
            }
            set
            {
                this.codDocReembolsoField = value;
            }
        }

        /// <remarks/>
        public string estabDocReembolso
        {
            get
            {
                return this.estabDocReembolsoField;
            }
            set
            {
                this.estabDocReembolsoField = value;
            }
        }

        /// <remarks/>
        public string ptoEmiDocReembolso
        {
            get
            {
                return this.ptoEmiDocReembolsoField;
            }
            set
            {
                this.ptoEmiDocReembolsoField = value;
            }
        }

        /// <remarks/>
        public string secuencialDocReembolso
        {
            get
            {
                return this.secuencialDocReembolsoField;
            }
            set
            {
                this.secuencialDocReembolsoField = value;
            }
        }

        /// <remarks/>
        public string fechaEmisionDocReembolso
        {
            get
            {
                return this.fechaEmisionDocReembolsoField;
            }
            set
            {
                this.fechaEmisionDocReembolsoField = value;
            }
        }

        /// <remarks/>
        public string numeroautorizacionDocReemb
        {
            get
            {
                return this.numeroautorizacionDocReembField;
            }
            set
            {
                this.numeroautorizacionDocReembField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("detalleImpuesto", IsNullable = false)]
        public detalleImpuestosDetalleImpuesto[] detalleImpuestos
        {
            get
            {
                return this.detalleImpuestosField;
            }
            set
            {
                this.detalleImpuestosField = value;
            }
        }
    }

}
