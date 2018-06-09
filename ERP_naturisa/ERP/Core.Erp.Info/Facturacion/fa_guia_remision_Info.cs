using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion_Grafinpren;

namespace Core.Erp.Info.Facturacion
{
    public class fa_guia_remision_Info 
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdGuiaRemision { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public decimal IdTransportista { get; set; }
        public DateTime gi_fecha { get; set; }
        public decimal? gi_plazo { get; set; }
        public DateTime? gi_fech_venc { get; set; }
        public string gi_Observacion { get; set; }
        public Nullable<double> gi_TotalKilos { get; set; }
        public Nullable<double> gi_TotalQuintales { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string CodGuiaRemision { get; set; }
        public string NumGuia_Preimpresa { get; set; }
        public string CodDocumentoTipo { get; set; }
        public string NumAutorizacion { get; set; }
        //public string CodDocumentoTipo { get; set; }
        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public string MotiAnula { get; set; }
        public List<fa_guia_remision_det_Info> ListaDetalle { get; set; }
        public string Impreso { get; set; }
        public string Cliente { get; set; }
        public string Sucursal { get; set; }
        public string Bodega { get; set; }
        public string Vendedor { get; set; }
        public decimal Subtotal { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
        public double Precio { get; set; }
        public double Precio_Final { get; set; }
        public string MotivoAnu { get; set; }

        public int IdPeriodo { get; set; }
        public double  gi_flete { get; set; }
        public double gi_interes{ get; set; }
        public double gi_seguro { get; set; }
        public double gi_OtroValor1 { get; set; }
        public double gi_OtroValor2 { get; set; }


        public DateTime gi_FecIniTraslado { get; set; }
        public DateTime gi_FecFinTraslado { get; set; }
        public string placa { get; set; }
        public string ruta { get; set; }
        public string Direccion_Origen { get; set; }
        public string Direccion_Destino { get; set; }
        public string em_nombre { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string ContribuyenteEspecial { get; set; }
        public string ObligadoAllevarConta { get; set; }
        public string em_ruc { get; set; }
        public string Cedula { get; set; }
        public string nom_Transportista { get; set; }

        public string IdTipoDocumento { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_direccion { get; set; }
        public string pe_telefonoCasa { get; set; }
        public string pe_telefonoOfic { get; set; }
        public string pe_celular { get; set; }
        public string pe_correo { get; set; }
        public string pe_Naturaleza { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public int IdTipoPersona { get; set; }

        //MOTIVO TRASLADO
        public Nullable<int> idMotivo_traslado { get; set; }
       
        public Core.Erp.Info.Facturacion_Grafinpren.fa_guia_remision_graf_Info  Info_Guia_Remision_x_Grafinpren { get; set; }
     
        public fa_guia_remision_Info() {
            ListaDetalle = new List<fa_guia_remision_det_Info>();
            Info_Guia_Remision_x_Grafinpren = new Facturacion_Grafinpren.fa_guia_remision_graf_Info();

            
        }
    }
}
