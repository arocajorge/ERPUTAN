using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.General
{
    public class Cl_Enumeradores_Mensajes_sys
    {
        public enum_Mensajes_sys Get_msg(string IdMensaje)
        {
            try
            {
                enum_Mensajes_sys Emensaje = (enum_Mensajes_sys)Enum.Parse(typeof(enum_Mensajes_sys), IdMensaje);
                return Emensaje;
                
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

    public enum enum_Mensajes_sys
    {
             Anulada_corectamente=1
            ,Debe_escojer=2
            ,Debido_q_ya_se_encuentra_anulado=3
            ,El_beneficiario_no_tiene_Orden_Pago_pendi
            ,El_registro_se_encuentra_anulado
            ,El_rubro_ya_se_encuentra_seleccionado_Se_procedera_a_eliminar
            ,Error_comunicarse_con_sistemas
            ,Error_encontrado
            ,Esta_caja_ya_se_encuentra_anulada
            ,Esta_realmente_seguro_eliminar
            ,Esta_seguro_de_anular_el_tipo_movimiento_de_caja
            ,Esta_seguro_Eliminar
            ,Esta_seguro_que_desea_anular_el
            ,Esta_seguro_que_desea_anular
            ,Está_seguro_que_desea_anular_la
            ,Este_movimiento_de_caja_ya_esta_anulado
            ,Fecha_final_debe_ser_mayor_que_fecha_inicial
            ,Form_ya_esta_abierta
            ,Grabado_satisfactoriamente
            ,Ingrese_CI_Ruc_Pasaporte
            ,Ingrese_el
            ,Ingrese_la
            ,No_se_encontro_formulario
            ,No_se_guardaron_los_datos
            ,No_se_pudo_anular_la_caja_numero
            ,No_se_pudo_reservar_el_comprobante
            ,No_se_puede_anular
            ,No_se_puede_anular_el_tipo_movimiento_de_caja_numero
            ,No_se_puede_anular_registro
            ,No_se_puede_modif_regis_Inac
            ,Nombre_sistema
            ,Por_Favor_
            ,Por_Favor_genere_el
            ,Por_Favor_genere_la
            ,Por_Favor_ingrese_el
            ,Por_Favor_ingrese_la
            ,Por_favor_seleccione_item_a_anular
            ,Por_favor_seleccione_item_a_consul
            ,Por_favor_seleccione_item_a_modi
            ,Por_favor_seleccione_proveedor
            ,Por_favor_seleccione_sucursal
            ,Porcentaje_de_depreciacion_mayor_a_100
            ,Se_guardaron_los_datos_correctamente
            ,Se_guardo_correctamente
            ,Seleccione_el
            ,Seleccione_la
            ,Seleccione_un_registro
            ,Tipo_documento_no_valido
            ,Tipo_movimiento_de_caja_numero
            ,Titulo_de_formularios
            ,Ya_se_encuentra_anulado
            ,Desea_Imprimir
            ,Se_modifico_corrrectamente
            ,No_se_modificaron_los_datos
            ,Se_Anulo_Correctamente,
            Ya_se_encuentra_anulada
    }  
}
