using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produccion_Talme
{

	public class prod_GestionProductivaLaminado_CusTalme_Info
	{


		public int IdEmpresa{ get; set; } 
		public decimal IdGestionProductiva{ get; set; } 
		public int IdTurno{ get; set; } 
		public decimal IdEmpleado_JefeTurno{ get; set; } 
		public decimal IdProducto_MateriaPrima{ get; set; } 
		public string Id_Bobina{ get; set; } 
		public string Num_Orden{ get; set; } 
		public double kg_Cargados{ get; set; } 
		public double kg_producidos{ get; set; } 
		public decimal IdProducto_Producido1{ get; set; } 
		public double unidades_prd_1{ get; set; } 
		public double pesokg_prd_1{ get; set; } 
		public decimal IdProducto_Producido2{ get; set; } 
		public double unidades_prd_2{ get; set; } 
		public double pesokg_prd_2{ get; set; } 
		public double kg_retazo_porcen{ get; set; } 
		public double kg_retazo_valor{ get; set; } 
		public double kg_chatarra_porcen{ get; set; } 
		public double kg_chatarra_valor{ get; set; } 
		public double kg_oxidacion_porcen{ get; set; } 
		public double kg_oxidacion_valor{ get; set; } 
		public double rendi_metal_historico{ get; set; } 
		public double rendi_metal_real{ get; set; } 
		public double rendi_metal_Diferencia{ get; set; } 
		public double consumo_kilowatios{ get; set; } 
		public double consumo_galones{ get; set; } 
		public double cambio_prue_programado{ get; set; } 
		public double cambio_prue_real{ get; set; } 
		public double cambio_prue_porcentaje{ get; set; } 
		public TimeSpan hora_turno_ini{ get; set; } 
		public TimeSpan hora_turno_fin{ get; set; } 
		public double hora_jornada{ get; set; } 
		public double hora_productiva{ get; set; } 
		public double hora_Paros{ get; set; } 
		public double hora_Neta{ get; set; } 
		public double hora_Hrs_Maquina{ get; set; } 
		public double Ton_Programada{ get; set; } 
		public double Ton_real{ get; set; } 
		public double Ton_Eficiencia{ get; set; } 
		public double Ton_TnHrNeta{ get; set; } 
		public double Ton_kwTon{ get; set; } 
		public double Ton_GlsTon{ get; set; } 
		public double EficienciaProduccion{ get; set; } 
		public string Estado{ get; set; } 
		public DateTime Fecha{ get; set; }
        public string Nombre_JefeTurno{ get; set; }
        public string Descripcion { get; set; }

        public List<prod_GestionProductivaLaminado_x_paradas_CusTalme_Info> ListDetalle { get; set; }

	    public prod_GestionProductivaLaminado_CusTalme_Info()
        {
            ListDetalle = new List<prod_GestionProductivaLaminado_x_paradas_CusTalme_Info>();
        }



	}
}
