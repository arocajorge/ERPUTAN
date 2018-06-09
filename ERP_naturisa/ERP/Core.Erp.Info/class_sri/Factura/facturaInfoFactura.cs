using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.class_sri.Factura
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class facturaInfoFactura
    {

        private string fechaEmisionField;

        private string dirEstablecimientoField;

        private string contribuyenteEspecialField;

        private string obligadoContabilidadField;

        private string tipoIdentificacionCompradorField;

        private string guiaRemisionField;

        private string razonSocialCompradorField;

        private string identificacionCompradorField;

        private decimal totalSinImpuestosField;

        private decimal totalDescuentoField;

        private List< facturaInfoFacturaTotalImpuesto> totalConImpuestosField;

        private decimal propinaField;

        private decimal importeTotalField;

        private string monedaField;

        /// <comentarios/>
        public string fechaEmision
        {
            get
            {
                return this.fechaEmisionField;
            }
            set
            {
                this.fechaEmisionField = value;
            }
        }

        /// <comentarios/>
        public string dirEstablecimiento
        {
            get
            {
                return this.dirEstablecimientoField;
            }
            set
            {
                this.dirEstablecimientoField = value;
            }
        }

        /// <comentarios/>
        public string contribuyenteEspecial
        {
            get
            {
                return this.contribuyenteEspecialField;
            }
            set
            {
                this.contribuyenteEspecialField = value;
            }
        }

        /// <comentarios/>
        public string obligadoContabilidad
        {
            get
            {
                return this.obligadoContabilidadField;
            }
            set
            {
                this.obligadoContabilidadField = value;
            }
        }

        /// <comentarios/>
        public string tipoIdentificacionComprador
        {
            get
            {
                return this.tipoIdentificacionCompradorField;
            }
            set
            {
                this.tipoIdentificacionCompradorField = value;
            }
        }

        /// <comentarios/>
        public string guiaRemision
        {
            get
            {
                return this.guiaRemisionField;
            }
            set
            {
                this.guiaRemisionField = value;
            }
        }

        /// <comentarios/>
        public string razonSocialComprador
        {
            get
            {
                return this.razonSocialCompradorField;
            }
            set
            {
                this.razonSocialCompradorField = value;
            }
        }

        /// <comentarios/>
        public string identificacionComprador
        {
            get
            {
                return this.identificacionCompradorField;
            }
            set
            {
                this.identificacionCompradorField = value;
            }
        }

        /// <comentarios/>
        public decimal totalSinImpuestos
        {
            get
            {
                return this.totalSinImpuestosField;
            }
            set
            {
                this.totalSinImpuestosField = value;
            }
        }

        /// <comentarios/>
        public decimal totalDescuento
        {
            get
            {
                return this.totalDescuentoField;
            }
            set
            {
                this.totalDescuentoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlArrayItemAttribute("totalImpuesto", IsNullable = false)]
        public List< facturaInfoFacturaTotalImpuesto> totalConImpuestos
        {
            get
            {
                return this.totalConImpuestosField;
            }
            set
            {
                this.totalConImpuestosField = value;
            }
        }

        /// <comentarios/>
        public decimal propina
        {
            get
            {
                return this.propinaField;
            }
            set
            {
                this.propinaField = value;
            }
        }

        /// <comentarios/>
        public decimal importeTotal
        {
            get
            {
                return this.importeTotalField;
            }
            set
            {
                this.importeTotalField = value;
            }
        }

        /// <comentarios/>
        public string moneda
        {
            get
            {
                return this.monedaField;
            }
            set
            {
                this.monedaField = value;
            }
        }
    }

}
