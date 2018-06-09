using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;


namespace Core.Erp.Info.Inventario
{
    public class in_Parametro_Info
    {
        public int IdEmpresa { get; set; }

        public string IdCentroCosto_Padre_a_cargar { get; set; }
        public string LabelCentroCosto { get; set; }

        public int ? IdMovi_inven_tipo_egresoBodegaOrigen { get; set; }
        public int ? IdMovi_inven_tipo_ingresoBodegaDestino { get; set; }

        public string Maneja_Stock_Negativo { get; set; }

        public string Usuario_Escoge_Motivo { get; set; }

        public int ?IdMovi_inven_tipo_egresoAjuste { get; set; }
        public int ?IdMovi_inven_tipo_ingresoAjuste { get; set; }

        public string Mostrar_CentroCosto_en_transacciones { get; set; }
        public int Rango_Busqueda_Transacciones { get; set; }


        

        public string ApruebaAjusteFisicoAuto { get; set; }
        public string pa_EstadoInicial_Pedido { get; set; }

        public string IdCentro_Costo_Inventario { get; set; }
        public string IdCentro_Costo_Costo { get; set; }
        public int? IdTipoCbte_CostoInven_Reverso { get; set; }

        public int? IdMovi_Inven_tipo_x_anu_Ing { get; set; }
        public int? IdMovi_Inven_tipo_x_anu_Egr { get; set; }

        public string IdCtaCble_Inven { get; set; }
        public string IdCtaCble_CostoInven { get; set; }
        public int? IdTipoCbte_CostoInven { get; set; }
        
        public int IdBodegaSuministro { get; set; }
        public int IdSucursalSuministro { get; set; }

        public int ? IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa { get; set; }
        public int ? IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa { get; set; }

        public string IdEstadoAproba_x_Ing { get; set; }
        public string IdEstadoAproba_x_Egr { get; set; }

        public int ? IdMovi_Inven_tipo_x_Dev_Inv_x_Ing { get; set; }
        public int ? IdMovi_Inven_tipo_x_Dev_Inv_x_Erg { get; set; }

        public Boolean ? P_Grabar_Items_x_Cada_Movi_Inven { get; set; }
        public string P_Fecha_para_contabilizacion_ingr_egr { get; set; }
        public Nullable<bool> P_se_valida_parametrizacion_x_producto { get; set; }

        public string P_IdCtaCble_transitoria_transf_inven { get; set; }

        public in_Parametro_Info() { }

    }
}
