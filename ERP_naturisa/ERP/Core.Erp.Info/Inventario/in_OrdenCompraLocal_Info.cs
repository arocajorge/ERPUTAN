using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_OrdenCompraLocal_Info
    {
        public	int	IdEmpresa	{ get; set; }
        public	int	IdSucursal	{ get; set; }
        public	decimal	IdOrdenCompra	{ get; set; }
        public	string	Tipo	{ get; set; }
        public	int	oc_plazo	{ get; set; }
        public	DateTime	oc_fecha	{ get; set; }
        public	double	oc_subtotal	{ get; set; }
        public	double	oc_iva	{ get; set; }
        public	double	oc_descuento	{ get; set; }
        public	int	oc_pordesc	{ get; set; }
        public	double	oc_flete	{ get; set; }
        public	double	oc_total	{ get; set; }
        public	double	oc_Base_conIva	{ get; set; }
        public	double	oc_Base_sinIva	{ get; set; }
        public	string	oc_observacion	{ get; set; }
        public	DateTime	Fechreg	{ get; set; }
        public	string	Estado	{ get; set; }
        public	string oc_NumDocumento { get; set; }
        public	string	IdEstadoAprobacion	{ get; set; }
        public	DateTime? co_fecha_aprobacion	{ get; set; }
        public	int? IdTerminoPago	{ get; set; }
        public	DateTime?	co_FechaFactProv	{ get; set; }
        public	int?	co_DiasFecFacProv	{ get; set; }
        public	DateTime?	co_fecha_salida	{ get; set; }
        public	DateTime?	co_fecha_llegada	{ get; set; }
        public	string	IdUsuario_Aprueba	{ get; set; }
        public	string	IdUsuario_Reprue	{ get; set; }
        public	DateTime?	co_fechaReproba	{ get; set; }
        public	DateTime?	Fecha_Transac	{ get; set; }
        public	DateTime?	Fecha_UltMod	{ get; set; }
        public	string	IdUsuarioUltMod	{ get; set; }
        public	DateTime?	FechaHoraAnul	{ get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public double? oc_PesoTotal { get; set; }
        public DateTime? oc_fecha_emision { get; set; }
        public string IdUsuarioSolicitante { get; set; }
        public string IdUsuario_Emicion { get; set; }
        public string EstadoRecepcion { get; set; }

        public string NomSucursal { get; set; }
        public string NomProveedor { get; set; }
        public string NomTermPago { get; set; }
        public string CodCentroCosto { get; set; }
        public string NomCentroCosto { get; set; }

        public string Referencia { get; set; }
        public string ReferenciaOC { get; set; }

        public in_OrdenCompraLocal_Info() { }
    }
}
