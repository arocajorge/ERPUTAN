using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_parametro_info
    {//vbersion
        public int pa_compania { get; set; }
        public int IdMovi_inven_tipo_Factura { get; set; }
        public double pa_porc_max_total_item_x_despa_Guia { get; set; }
        public int IdMovi_inven_tipo_Dev_Vta { get; set; }
        public int IdMovi_inven_tipo_Factura_Anulacion { get; set; }
        public int IdMovi_inven_tipo_Dev_Vta_Anulacion { get; set; }
        public int Tipo_NC_x_DevVta { get; set; }
        public int IdDepartamento_x_DevVta { get; set; }
        public int IdTipoCbteCble_Factura { get; set; }
        public int IdTipoCbteCble_Factura_Reverso { get; set; } 
        public int IdTipoCbteCble_Factura_Costo_VTA { get; set; }
        public int IdTipoCbteCble_Factura_Costo_VTA_Reverso { get; set; }

        public int IdTipoCbteCble_NC { get; set; }
        public int IdTipoCbteCble_NC_Reverso { get; set; }
        public int IdTipoCbteCble_ND { get; set; }
        public int IdTipoCbteCble_ND_Reverso { get; set; }

        public int ? IdCaja_Default_Factura { get; set; }
        public string IdCtaCble_x_anticipo_cliente { get; set; }

        public int pa_IdTipoNota_NC_x_Anulacion { get; set; }

        public string pa_ruta_descarga_xml_fac_elct { get; set; }

        public fa_parametro_info()
        {                    }


       
        public string SeImprimiGuiaRemiAuto { get; set; }

        public int? NumeroDeItemFact { get; set; }

        public string TipoCobroDafaultFactu { get; set; }
        public string IdEstadoAprobacion { get; set; }

        public string IdCtaCble_IVA { get; set; }
        public string IdCtaCble_SubTotal_Vtas_x_Default { get; set; }
        public string IdCtaCble_CXC_Vtas_x_Default { get; set; }


        public byte[] File_Reporte_FacturaDiseño { get; set; }

        public byte[] File_Reporte_Nota_CRED_DEB { get; set; }

        public bool ? pa_X_Defecto_la_factura_es_cbte_elect { get; set; }
        public bool ? pa_X_Defecto_la_guia_es_cbte_elect { get; set; }
        public bool ? pa_X_Defecto_la_ND_es_cbte_elect { get; set; }
        public bool ? pa_X_Defecto_la_NC_es_cbte_elect { get; set; }




    }
}
