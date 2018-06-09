using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Produccion_Edehsa;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produccion_Edehsa
{
    public class vwprd_Guia_Remision_Electronica_Data
    {


        string mensaje = "";
        public List<vwprd_Guia_Remision_Electronica_Info> Get_List_vwprd_Guia_Remision_Electronica(string CodGuiaRemision)
        {
            try
            {
                List<vwprd_Guia_Remision_Electronica_Info> Lst = new List<vwprd_Guia_Remision_Electronica_Info>();
                EntitiesProduccion_Edehsa oEnti = new EntitiesProduccion_Edehsa();

                var Query = from q in oEnti.vwprd_Guia_Remision_Electronica
                            where q.CodGuiaRemision == CodGuiaRemision
                            select q;
                foreach (var item in Query)
                {
                    vwprd_Guia_Remision_Electronica_Info Obj = new vwprd_Guia_Remision_Electronica_Info();

                    Obj.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                    Obj.IdSucursal =  item.IdSucursal;
                    Obj.IdBodega =  item.IdBodega;
                    Obj.IdGuiaRemision = item.IdGuiaRemision;
                    Obj.CodGuiaRemision = item.CodGuiaRemision;
                    Obj.CodDocumentoTipo =  item.CodDocumentoTipo;
                    Obj.Serie1 =  item.Serie1;
                    Obj.Serie2 =  item.Serie2;
                    Obj.NumGuia_Preimpresa =  item.NumGuia_Preimpresa;
                    Obj.NUAutorizacion =  item.NUAutorizacion;
                    Obj.Fecha_Autorizacion =  item.Fecha_Autorizacion;
                    Obj.IdCliente =  item.IdCliente;
                    Obj.IdVendedor =  item.IdVendedor;
                    Obj.gi_fecha =  item.gi_fecha;
                    Obj.gi_fech_venc =  item.gi_fech_venc;
                    Obj.gi_Observacion =  item.gi_Observacion;
                    Obj.gi_TotalKilos = item.gi_TotalKilos;
                    Obj.gi_plazo = item.gi_plazo;
                    Obj.gi_TotalQuintales = item.gi_TotalQuintales;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Obj.Fecha_Transac = item.Fecha_Transac;
                    Obj.Fecha_UltMod = item.Fecha_UltMod;
                    Obj.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Obj.nom_pc = item.nom_pc;
                    Obj.Fecha_UltAnu = item.Fecha_UltAnu;
                    Obj.ip = item.ip;
                    Obj.Estado = item.Estado;
                    Obj.MotiAnula = item.MotiAnula;
                    Obj.Impreso = item.Impreso;
                    Obj.IdPeriodo = item.IdPeriodo;
                    Obj.gi_flete = item.gi_flete;
                    Obj.gi_interes = item.gi_interes;
                    Obj.gi_seguro = item.gi_seguro;
                    Obj.gi_OtroValor1 = item.gi_OtroValor1;
                    Obj.gi_OtroValor2 = item.gi_OtroValor2;
                    Obj.gi_FechaIniTraslado = item.gi_FechaIniTraslado;
                    Obj.placa = item.placa;
                    Obj.gi_FechaFinTraslado = item.gi_FechaFinTraslado;
                    Obj.ruta = item.ruta;
                    Obj.Direccion_Origen = item.Direccion_Origen;
                    Obj.Direccion_Destino = item.Direccion_Destino;
                    Obj.idMotivo_traslado = item.idMotivo_traslado;
                    Obj.IdTransportista = item.IdTransportista;
                    Obj.Cedula_Transportista = item.Cedula_Transportista;
                    Obj.Nombre_Transportista = item.Nombre_Transportista;
                    Obj.IdProducto = item.IdProducto;
                    Obj.gi_cantidad = item.gi_cantidad;
                    Obj.gi_Precio = item.gi_Precio;
                    Obj.gi_PorDescUnitario = item.gi_PorDescUnitario;
                    Obj.gi_DescUnitario = item.gi_DescUnitario;
                    Obj.gi_PrecioFinal = item.gi_PrecioFinal;
                    Obj.gi_Subtotal = item.gi_Subtotal;
                    Obj.gi_iva = item.gi_iva;
                    Obj.gi_total = item.gi_total;
                    Obj.gi_costo = item.gi_costo;
                    Obj.gi_tieneIVA = item.gi_tieneIVA;
                    Obj.gi_detallexItems = item.gi_detallexItems;
                    Obj.gi_peso = item.gi_peso;
                    Obj.pe_cedulaRuc = item.pe_cedulaRuc;
                    Obj.IdTipoPersona = item.IdTipoPersona;
                    Obj.IdTipoDocumento = item.IdTipoDocumento;
                    Obj.pe_razonSocial = item.pe_razonSocial;
                    Obj.pe_nombreCompleto = item.pe_nombreCompleto;
                    Obj.pe_apellido = item.pe_apellido;
                    Obj.pe_nombre = item.pe_nombre;
                    Obj.pe_direccion = item.pe_direccion;
                    Obj.pe_correo = item.pe_correo;
                    Obj.em_nombre = item.em_nombre;
                    Obj.RazonSocial = item.RazonSocial;
                    Obj.NombreComercial = item.NombreComercial;
                    Obj.em_direccion = item.em_direccion;
                    Obj.descripcion_motivo_traslado = item.descripcion_motivo_traslado;
                    Obj.em_ruc = item.em_ruc;
                    Obj.Su_Direccion = item.Su_Direccion;
                    Obj.ObligadoAllevarConta = item.ObligadoAllevarConta;
                    Obj.ContribuyenteEspecial = item.ContribuyenteEspecial;
                    Obj.pr_codigo = item.pr_codigo;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.pr_descripcion_2 = item.pr_descripcion_2;
                    Obj.unidad_medida_consumo = item.unidad_medida_consumo;
                    Obj.CodObra = item.CodObra;
                    Obj.descripcion_obra = item.descripcion_obra;

                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }




    }
}
