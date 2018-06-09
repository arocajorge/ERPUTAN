using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Core.Erp.Info.class_sri.RDEP
{
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class rdep
    {

        private string numRucField;

        private string anioField;

        private List<rdepRetRelDepDatRetRelDep> retRelDepField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string numRuc
        {
            get
            {
                return this.numRucField;
            }
            set
            {
                this.numRucField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string anio
        {
            get
            {
                return this.anioField;
            }
            set
            {
                this.anioField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("datRetRelDep", typeof(rdepRetRelDepDatRetRelDep), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<rdepRetRelDepDatRetRelDep> retRelDep
        {
            get
            {
                return this.retRelDepField;
            }
            set
            {
                this.retRelDepField = value;
            }
        }
    }






    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rdepRetRelDepDatRetRelDep
    {
        private List<rdepRetRelDepDatRetRelDepEmpleado> empleadoField;

        private string suelSalField;

        private string sobSuelComRemuField;

        private string partUtilField;

        private string intGrabGenField;

        private string impRentEmplField;

        private string decimTerField;

        private string decimCuarField;

        private string fondoReservaField;

        private string salarioDignoField;

        private string otrosIngRenGravField;

        private string ingGravConEsteEmplField;

        private string sisSalNetField;

        private string apoPerIessField;

        private string aporPerIessConOtrosEmplsField;

        private string deducViviendaField;

        private string deducSaludField;

        private string deducEducaField;

        private string deducAliementField;

        private string deducVestimField;

        private string exoDiscapField;

        private string exoTerEdField;

        private string basImpField;

        private string impRentCausField;

        private string valRetAsuOtrosEmplsField;

        private string valImpAsuEsteEmplField;

        private string valRetField;


        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("empleado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<rdepRetRelDepDatRetRelDepEmpleado> empleado
        {
            get
            {
                return this.empleadoField;
            }
            set
            {
                this.empleadoField = value;
            }
        }



   
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string suelSal
        {
            get
            {
                return this.suelSalField;
            }
            set
            {
                this.suelSalField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string sobSuelComRemu
        {
            get
            {
                return this.sobSuelComRemuField;
            }
            set
            {
                this.sobSuelComRemuField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string partUtil
        {
            get
            {
                return this.partUtilField;
            }
            set
            {
                this.partUtilField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string intGrabGen
        {
            get
            {
                return this.intGrabGenField;
            }
            set
            {
                this.intGrabGenField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string impRentEmpl
        {
            get
            {
                return this.impRentEmplField;
            }
            set
            {
                this.impRentEmplField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string decimTer
        {
            get
            {
                return this.decimTerField;
            }
            set
            {
                this.decimTerField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string decimCuar
        {
            get
            {
                return this.decimCuarField;
            }
            set
            {
                this.decimCuarField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fondoReserva
        {
            get
            {
                return this.fondoReservaField;
            }
            set
            {
                this.fondoReservaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string salarioDigno
        {
            get
            {
                return this.salarioDignoField;
            }
            set
            {
                this.salarioDignoField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string otrosIngRenGrav
        {
            get
            {
                return this.otrosIngRenGravField;
            }
            set
            {
                this.otrosIngRenGravField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ingGravConEsteEmpl
        {
            get
            {
                return this.ingGravConEsteEmplField;
            }
            set
            {
                this.ingGravConEsteEmplField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string sisSalNet
        {
            get
            {
                return this.sisSalNetField;
            }
            set
            {
                this.sisSalNetField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string apoPerIess
        {
            get
            {
                return this.apoPerIessField;
            }
            set
            {
                this.apoPerIessField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string aporPerIessConOtrosEmpls
        {
            get
            {
                return this.aporPerIessConOtrosEmplsField;
            }
            set
            {
                this.aporPerIessConOtrosEmplsField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string deducVivienda
        {
            get
            {
                return this.deducViviendaField;
            }
            set
            {
                this.deducViviendaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string deducSalud
        {
            get
            {
                return this.deducSaludField;
            }
            set
            {
                this.deducSaludField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string deducEduca
        {
            get
            {
                return this.deducEducaField;
            }
            set
            {
                this.deducEducaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string deducAliement
        {
            get
            {
                return this.deducAliementField;
            }
            set
            {
                this.deducAliementField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string deducVestim
        {
            get
            {
                return this.deducVestimField;
            }
            set
            {
                this.deducVestimField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string exoDiscap
        {
            get
            {
                return this.exoDiscapField;
            }
            set
            {
                this.exoDiscapField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string exoTerEd
        {
            get
            {
                return this.exoTerEdField;
            }
            set
            {
                this.exoTerEdField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string basImp
        {
            get
            {
                return this.basImpField;
            }
            set
            {
                this.basImpField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string impRentCaus
        {
            get
            {
                return this.impRentCausField;
            }
            set
            {
                this.impRentCausField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string valRetAsuOtrosEmpls
        {
            get
            {
                return this.valRetAsuOtrosEmplsField;
            }
            set
            {
                this.valRetAsuOtrosEmplsField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string valImpAsuEsteEmpl
        {
            get
            {
                return this.valImpAsuEsteEmplField;
            }
            set
            {
                this.valImpAsuEsteEmplField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string valRet
        {
            get
            {
                return this.valRetField;
            }
            set
            {
                this.valRetField = value;
            }
        }

    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rdepRetRelDepDatRetRelDepEmpleado
    {

        private string tipIdRetField;

        private string idRetField;

        private string apellidoTrabField;

        private string nombreTrabField;

        private string estabField;

        private string residenciaTrabField;

        private string paisResidenciaField;

        private string aplicaConvenioField;

        private string tipoTrabajDiscapField;

        private string porcentajeDiscapField;

        private string tipIdDiscapField;

        private string idDiscapField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipIdRet
        {
            get
            {
                return this.tipIdRetField;
            }
            set
            {
                this.tipIdRetField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string idRet
        {
            get
            {
                return this.idRetField;
            }
            set
            {
                this.idRetField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string apellidoTrab
        {
            get
            {
                return this.apellidoTrabField;
            }
            set
            {
                this.apellidoTrabField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombreTrab
        {
            get
            {
                return this.nombreTrabField;
            }
            set
            {
                this.nombreTrabField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string estab
        {
            get
            {
                return this.estabField;
            }
            set
            {
                this.estabField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string residenciaTrab
        {
            get
            {
                return this.residenciaTrabField;
            }
            set
            {
                this.residenciaTrabField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string paisResidencia
        {
            get
            {
                return this.paisResidenciaField;
            }
            set
            {
                this.paisResidenciaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string aplicaConvenio
        {
            get
            {
                return this.aplicaConvenioField;
            }
            set
            {
                this.aplicaConvenioField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipoTrabajDiscap
        {
            get
            {
                return this.tipoTrabajDiscapField;
            }
            set
            {
                this.tipoTrabajDiscapField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string porcentajeDiscap
        {
            get
            {
                return this.porcentajeDiscapField;
            }
            set
            {
                this.porcentajeDiscapField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipIdDiscap
        {
            get
            {
                return this.tipIdDiscapField;
            }
            set
            {
                this.tipIdDiscapField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string idDiscap
        {
            get
            {
                return this.idDiscapField;
            }
            set
            {
                this.idDiscapField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class NewDataSet
    {

        private rdep[] itemsField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("rdep")]
        public rdep[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }



    }
}