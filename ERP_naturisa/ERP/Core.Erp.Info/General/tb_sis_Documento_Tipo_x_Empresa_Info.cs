using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class tb_sis_Documento_Tipo_x_Empresa_Info
    {
        public int IdEmpresa{ get; set;}
        public string codDocumentoTipo{ get; set;}
        public string ApareceComboFac_TipoFact{ get; set;}
        public string ApareceComboFac_Import{ get; set;}
        public string ApareceTalonario{ get; set;}
        public string Descripcion{ get; set;}
        public int Posicion{ get; set;}
        public string ApareceCombo_FileReporte { get; set; }

        public tb_sis_Documento_Tipo_x_Empresa_Info(){ }

    }
}
