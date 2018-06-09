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
    public partial class facturaDetalle
    {

        private string codigoPrincipalField;

        private string codigoAuxiliarField;

        private string descripcionField;

        private decimal cantidadField;

        private decimal precioUnitarioField;

        private decimal descuentoField;

        private decimal precioTotalSinImpuestoField;

        private List< facturaDetalleDetAdicional> detallesAdicionalesField;

        private List< impuesto> impuestosField;

        /// <comentarios/>
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

        /// <comentarios/>
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

        /// <comentarios/>
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

        /// <comentarios/>
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

        /// <comentarios/>
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

        /// <comentarios/>
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

        /// <comentarios/>
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

        /// <comentarios/>
        [System.Xml.Serialization.XmlArrayItemAttribute("detAdicional", IsNullable = false)]
        public List< facturaDetalleDetAdicional> detallesAdicionales
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

        /// <comentarios/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List< impuesto> impuestos
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
