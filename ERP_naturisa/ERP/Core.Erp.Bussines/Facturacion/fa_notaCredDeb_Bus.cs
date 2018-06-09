using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;

using Core.Erp.Info.class_sri.NotaCredito;
using Core.Erp.Info.class_sri.NotaDebito;
using Core.Erp.Info.class_sri;
using Core.Erp.Info.class_sri.FacturaV2;

using Core.Erp.Business.Facturacion_CAH;
using Core.Erp.Info.Factuarcion_CAH;
using Core.Erp.Info.Academico;
using Core.Erp.Business.Academico;


using System.Xml.Serialization;
using System.IO;
using Core.Erp.Data.Facturacion_Grafinpren;
using Core.Erp.Business.Facturacion;
using System.Data;

namespace Core.Erp.Business.Facturacion
{
    public class fa_notaCredDeb_Bus
    {
        
        string mensaje="";
        decimal idctctb = 0;
        string msg = "";

      
        string campoAdicional = null;
        string format = "dd/MM/yyyy";

        fa_notaCreDeb_x_fa_factura_NotaDeb_Bus bus_notaCreDeb_x_fa_factura_NotaDeb = new fa_notaCreDeb_x_fa_factura_NotaDeb_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_Cbtecble_Info Info_CbteCble = new ct_Cbtecble_Info();
        fa_notaCreDeb_Data oData_NotaCredDeb = new fa_notaCreDeb_Data();
        ct_Cbtecble_Bus bus_CbteCble = new ct_Cbtecble_Bus();
        tb_sis_Documento_Tipo_Talonario_Info InfoTalonario = new tb_sis_Documento_Tipo_Talonario_Info();
        tb_sis_Documento_Tipo_Talonario_Bus Bus_Talonario = new tb_sis_Documento_Tipo_Talonario_Bus();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();


        public List<fa_notaCreDeb_Info> Get_List_notaCreDeb(int idEmpresa, int idSucursalIni, int idSucursalFin, int idBodegaIni, int idBodegaFin
            , DateTime FechaIni, DateTime FechaFin,string Tipo)
        {
            try
            {
                return oData_NotaCredDeb.Get_List_notaCreDeb(idEmpresa, idSucursalIni, idSucursalFin, idBodegaIni, idBodegaFin, FechaIni, FechaFin, Tipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerLista", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
            }   
        }

        public fa_notaCreDeb_Info Get_Info_notaCreDeb_x_ND(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {
            try
            {
                return oData_NotaCredDeb.Get_Info_notaCreDeb_x_ND(IdEmpresa, IdSucursal, IdBodega, IdNota);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getNotaCreditoDebitoDet", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
            }
        }

        public Boolean AnularDB(fa_notaCreDeb_Info oNota, ref string mensajeError)
        {
            try
            {
                Boolean res = false;

                if (oData_NotaCredDeb.AnularDB(oNota))
                {
                    res = ContabilizarNCDREVERSO(oNota.IdEmpresa, oNota.IdSucursal, oNota.IdBodega, oNota.IdNota);
                    if (res)
                    {
                        fa_notaCreDeb_x_cxc_cobro_Info info_nc_x_cr = new fa_notaCreDeb_x_cxc_cobro_Info();
                        fa_notaCreDeb_x_cxc_cobro_Bus bus_nc_x_cr = new fa_notaCreDeb_x_cxc_cobro_Bus();

                        info_nc_x_cr = bus_nc_x_cr.Get_info_cobro_x_nc(oNota.IdEmpresa, oNota.IdSucursal, oNota.IdBodega, oNota.IdNota);
                        if (info_nc_x_cr.IdEmpresa_cbr != 0)
                        {
                            cxc_cobro_Bus bus_cobro = new cxc_cobro_Bus();
                            cxc_cobro_Info info_cobro = new cxc_cobro_Info();

                            info_cobro = bus_cobro.Get_Info_Cobro(info_nc_x_cr.IdEmpresa_cbr, info_nc_x_cr.IdSucursal_cbr, info_nc_x_cr.IdCobro_cbr);
                            if (info_cobro.IdEmpresa != 0)
                            {
                                res = bus_cobro.AnularDB(info_cobro);
                            }
                        }
                    }
                }

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularNota", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
            }
            
            
        }

        public Boolean GuardarDB(fa_notaCreDeb_Info Info, ref decimal idnota, ref string mensajeDocumentoDupli, ref string mensaje, Boolean SeContabiliza = true)
        {
            try
            {

                if (Validar_Objeto(Info,ref mensaje)==false)
                { return false; }


                cxc_cobro_Bus Bus_Cobro = new cxc_cobro_Bus();
                Boolean res=true;
                Boolean Talonario_usuado = false;
                Boolean res_Conta=true;
                InfoTalonario = new tb_sis_Documento_Tipo_Talonario_Info();
                Bus_Talonario = new tb_sis_Documento_Tipo_Talonario_Bus();
                fa_notaCreDeb_x_cxc_cobro_Info info_NotaCreDeb = new fa_notaCreDeb_x_cxc_cobro_Info();
                fa_notaCreDeb_x_cxc_cobro_Bus Bus_NotaCreDeb = new fa_notaCreDeb_x_cxc_cobro_Bus();

                if (Info.NaturalezaNota == "SRI")
                {
                    InfoTalonario.Establecimiento = Info.Serie1;
                    InfoTalonario.PuntoEmision = Info.Serie2;
                    InfoTalonario.NumDocumento = Info.NumNota_Impresa;
                    InfoTalonario.IdEmpresa = Info.IdEmpresa;
                    InfoTalonario.IdSucursal = Info.IdSucursal;
                    InfoTalonario.CodDocumentoTipo = Info.IdTipoDoc;                    
                    Talonario_usuado = Bus_Talonario.Documento_talonario_esta_Usado(InfoTalonario, ref mensaje, ref mensajeDocumentoDupli);
                }

                Info.Info_sisDocTipoTalo = InfoTalonario;

                if (Talonario_usuado == false)
                {
                    if (oData_NotaCredDeb.GuardarDB(Info,  ref idnota, ref mensaje))
                    {       
                        Info.IdNota = idnota;
                        foreach (var item in Info.lst_docs_relacionados)
                        {
                            item.IdNota_nt = idnota;                           
                        }
                        if (bus_notaCreDeb_x_fa_factura_NotaDeb.GuardarDB(Info.lst_docs_relacionados))
                        {
                            Generar_Cobro_x_NC(Info.IdEmpresa, Info.IdSucursal, Info.IdBodega, Info.IdNota, ref mensaje);

                            if (SeContabiliza == true)
                            {
                                res_Conta = ContabilizarNCD(Info.IdEmpresa, Info.IdSucursal, Info.IdBodega, idnota);
                            }
                            res = res_Conta;
                            if (res_Conta == true)
                            {
                                if (Info.IdEmpresa_fac_doc_mod != null)
                                {
                                    cxc_cobro_Info Info_cobro = new cxc_cobro_Info();
                                    Info_cobro = Info.CobroInfo;


                                    if (Bus_Cobro.GuardarDB(Cl_Enumeradores.PantallaEjecucion.COBROS, ref Info_cobro, ref mensaje))
                                    {
                                        // guardando la relacion del cobro que se genero por la nota de credito
                                        info_NotaCreDeb = Get_faNotaCreDeb_x_Cobro(Info_cobro, Info);
                                        Bus_NotaCreDeb.GuardarDB(info_NotaCreDeb, ref mensaje);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        res = false;                        
                    }
                   
                }else{                   
                res = false;
                }

                    return res;
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
            }    
        }

        public Boolean GuardarDB_ND_x_Saldo_inicial(fa_notaCreDeb_Info Info_ND,ref string mensajeError)
        {
            try
            {
                bool res = false;
                fa_notaCreDeb_x_ct_cbtecble_Info info_ND_x_CbteCble = new fa_notaCreDeb_x_ct_cbtecble_Info();
                fa_notaCreDeb_x_ct_cbtecble_Bus bus_ND_x_CbteCble = new fa_notaCreDeb_x_ct_cbtecble_Bus();

                if (Validar_Objeto(Info_ND, ref mensajeError) == false)
                { return false; }
                
                decimal idnota = 0;

                if (oData_NotaCredDeb.GuardarDB(Info_ND, ref idnota, ref mensajeError))
                {
                    //Contabilizo
                    if (bus_CbteCble.GrabarDB(Info_ND.info_CbteCble, ref idnota, ref mensajeError))
                    {
                        info_ND_x_CbteCble.ct_IdEmpresa = Info_ND.info_CbteCble.IdEmpresa;
                        info_ND_x_CbteCble.ct_IdTipoCbte = Info_ND.info_CbteCble.IdTipoCbte;
                        info_ND_x_CbteCble.ct_IdCbteCble = Info_ND.info_CbteCble.IdCbteCble;
                        info_ND_x_CbteCble.no_IdEmpresa = Info_ND.IdEmpresa;
                        info_ND_x_CbteCble.no_IdSucursal = Info_ND.IdSucursal;
                        info_ND_x_CbteCble.no_IdBodega = Info_ND.IdBodega;
                        info_ND_x_CbteCble.no_IdNota = Info_ND.IdNota;

                        if (bus_ND_x_CbteCble.GuardarDB(info_ND_x_CbteCble))
                        {
                            res = true;
                        }


                        if (Info_ND.Info_notaCredDeb_aca.IdEstudiante != 0)
                        {

                            Info_ND.Info_notaCredDeb_aca.IdEmpresa = Info_ND.info_CbteCble.IdEmpresa;
                            Info_ND.Info_notaCredDeb_aca.IdSucursal = Info_ND.info_CbteCble.IdSucursal;
                            Info_ND.Info_notaCredDeb_aca.IdBodega = Info_ND.IdBodega;
                            Info_ND.Info_notaCredDeb_aca.IdNotaCredDeb = Info_ND.IdNota;
                            //Info_ND.Info_notaCredDeb_aca.IdInstitucion = 0;
                            //Info_ND.Info_notaCredDeb_aca.IdEstudiante = 0;
                            Info_ND.Info_notaCredDeb_aca.estado = true;
                            Info_ND.Info_notaCredDeb_aca.Observaciones = "";

                            fa_notaCredDeb_aca_Bus Bus_ND_Aca = new fa_notaCredDeb_aca_Bus();
                            Bus_ND_Aca.GrabarDB(Info_ND.Info_notaCredDeb_aca, ref mensajeError);

                        }
                    }
                }
                else
                {
                    res = false;
                }
                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
            }
        }

        public List<fa_notaCreDeb_Info> ProcesarDataTable_ND_x_Saldo_inicial(DataTable ds, ref string MensajeError)
        {
            fa_parametro_Bus bus_param = new fa_parametro_Bus();
            fa_parametro_info info_param = new fa_parametro_info();
            info_param = bus_param.Get_Info_parametro(param.IdEmpresa);
            fa_Cliente_Info info_cliente = new fa_Cliente_Info();
            fa_Cliente_Bus bus_cliente = new fa_Cliente_Bus();
            List<fa_notaCreDeb_Info> lista = new List<fa_notaCreDeb_Info>();

            int COLUMNA_ERROR = 0;
            string FILA_ERROR = "";
            lista.Clear();
            try
            {
                //VALIDAR QUE TENGA MAS DE 12 COLUMNAS
                //if (ds.Columns.Count == 5)
                {
                    //RECORRE EL DATATABLE REGISTRO X REGISTRO
                    if (ds.Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Rows)
                        {

                            fa_notaCreDeb_Info info = new fa_notaCreDeb_Info();
                            //RECORRE C/U DE LAS COLUMNAS
                            info.IdEmpresa = param.IdEmpresa;
                            info.IdNota = 0;                            
                            info.CreDeb = "D";
                            info.sc_observacion = "S.I CXC-FAC # ";
                            info.IdTipoNota = 32;//No quemar, eventualmente hacerlo un parametro para tipo de nota por saldo inicial en fa_parametro att: jaroca :*(besito)
                            info.IdUsuario = "SysAdmin";
                            info.CodDocumentoTipo = "NTDB";
                            info.NaturalezaNota = "INT";
                            info.IdVendedor = 1;
                            info.IdCaja = 1;
                            info.IdSucursal = 1;
                            info.IdBodega = 1;

                            for (int col = 0; col < ds.Columns.Count + 1; col++)
                            {
                                COLUMNA_ERROR = col;
                                switch (col)
                                {
                                    case 0://Cod_cliente
                                        info_cliente = bus_cliente.Get_info_cliente_x_codigo_para_saldo_inicial(param.IdEmpresa, Convert.ToString(row[col]), ref mensaje);
                                        info.IdCliente = info_cliente.IdCliente;
                                        info.info_cliente.IdCtaCble_cxc = info_cliente.IdCtaCble_cxc;
                                        info.IdCtaCble_TipoNota = info_cliente.IdCtaCble_cxc;
                                        info.info_cliente.Codigo = info_cliente.Codigo;
                                        info.info_cliente.Persona_Info.pe_nombreCompleto = info_cliente.Persona_Info.pe_nombreCompleto;
                                        info.IdSucursal = param.IdSucursal;
                                        FILA_ERROR = "Código " + Convert.ToString(row[col]);
                                        break;
                                    case 2://# factura
                                        info.CodNota = Convert.ToString(row[col]);
                                        info.sc_observacion += info.CodNota;
                                        FILA_ERROR = "# factura " + Convert.ToString(row[col]);
                                        break;
                                    case 3://Fecha factura
                                        info.no_fecha = Convert.ToDateTime(row[col]).Date;
                                        FILA_ERROR = "Fecha factura " + Convert.ToString(row[col]);
                                        break;
                                    case 4://Fecha vcto factura
                                        info.no_fecha_venc = Convert.ToDateTime(row[col]).Date;
                                        FILA_ERROR = "Fecha vcto factura " + Convert.ToString(row[col]);
                                        break;
                                    case 5://Total
                                        info.sc_observacion += " Total:" + Convert.ToDouble(row[col]);
                                        FILA_ERROR = "Total " + Convert.ToString(row[col]);
                                        break;
                                    case 6://Saldo
                                        info.sc_observacion += " Saldo:" + Convert.ToDouble(row[col]);
                                        info.Total = Convert.ToDouble(row[col]);
                                        FILA_ERROR = "Saldo " + Convert.ToString(row[col]);
                                        break;
                                    case 7://Observación
                                        info.sc_observacion += " " + Convert.ToString(row[col]);
                                        FILA_ERROR = "Observación " + Convert.ToString(row[col]);
                                        break;
                                    default:
                                        break;
                                }
                            }
                            info.Estado = "A";
                            //Armo detalle
                            fa_notaCreDeb_det_Info info_det = new fa_notaCreDeb_det_Info();
                            
                            info_det.IdEmpresa = info.IdEmpresa;
                            info_det.IdSucursal = info.IdSucursal;
                            info_det.IdBodega = info.IdBodega;
                            info_det.Secuencia = 1;
                            info_det.IdProducto = 1;
                            info_det.sc_cantidad = 1;
                            info_det.sc_Precio = info.Total;
                            info_det.sc_precioFinal = info.Total;
                            info_det.sc_subtotal = info.Total;
                            info_det.sc_total = info.Total;
                            info_det.IdCod_Impuesto_Iva = "IVA0";
                            info_det.sc_observacion = info.sc_observacion;
                            info_det.sc_estado = "A";
                            info_det.vt_por_iva = 0;

                            info.ListaDetalles.Add(info_det);
                            
                            lista.Add(info);
                        }
                    }
                    else
                    {
                        MensajeError = "Por favor verifique que el archivo contenga Datos.";
                        lista = new List<fa_notaCreDeb_Info>();
                    }
                }               
                return lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_Info) };
            }

        }


        public List<fa_notaCreDeb_Info> ProcesarDataTable_ND_x_Saldo_inicial_x_Alumno_CAH(DataTable ds, ref string MensajeError)
        {
            fa_parametro_Bus bus_param = new fa_parametro_Bus();
            fa_parametro_info info_param = new fa_parametro_info();
            info_param = bus_param.Get_Info_parametro(param.IdEmpresa);
            fa_Cliente_Info info_cliente = new fa_Cliente_Info();
            
            Aca_Estudiante_Bus Bus_Estudiante = new Aca_Estudiante_Bus();
            Aca_Estudiante_Info Info_Estudiante = new Aca_Estudiante_Info();

            fa_Cliente_Bus bus_cliente = new fa_Cliente_Bus();

            List<fa_notaCreDeb_Info> lista = new List<fa_notaCreDeb_Info>();

            int COLUMNA_ERROR = 0;
            string FILA_ERROR = "";
            lista.Clear();
            try
            {
                //VALIDAR QUE TENGA MAS DE 12 COLUMNAS
                //if (ds.Columns.Count == 5)
                {
                    //RECORRE EL DATATABLE REGISTRO X REGISTRO
                    if (ds.Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Rows)
                        {

                            fa_notaCreDeb_Info info_nota_deb = new fa_notaCreDeb_Info();
                            fa_notaCredDeb_aca_Info Info_ND_Aca = new fa_notaCredDeb_aca_Info();
                            
                            //RECORRE C/U DE LAS COLUMNAS
                            info_nota_deb.IdEmpresa = param.IdEmpresa;
                            info_nota_deb.IdNota = 0;
                            info_nota_deb.CreDeb = "D";
                            info_nota_deb.sc_observacion = "S.I CXC-FAC # ";
                            info_nota_deb.IdTipoNota = 32;//No quemar, eventualmente hacerlo un parametro para tipo de nota por saldo inicial en fa_parametro att: jaroca :*(besito)
                            info_nota_deb.IdUsuario = "SysAdmin";
                            info_nota_deb.CodDocumentoTipo = "NTDB";
                            info_nota_deb.NaturalezaNota = "INT";
                            info_nota_deb.IdVendedor = 1;
                            info_nota_deb.IdCaja = 1;
                            info_nota_deb.IdSucursal = 1;
                            info_nota_deb.IdBodega = 1;

                            
                            info_nota_deb.IdSucursal = param.IdSucursal;


                            Info_ND_Aca.IdEmpresa = info_nota_deb.IdEmpresa;
                            Info_ND_Aca.IdNotaCredDeb = 0;
                            Info_ND_Aca.IdInstitucion = 1;//param.IdInstitucion;

                            
                            Info_ND_Aca.Observaciones = "Saldo Inicial ";
                            Info_ND_Aca.estado = true;


                            for (int col = 0; col < ds.Columns.Count + 1; col++)
                            {
                                COLUMNA_ERROR = col;
                                switch (col)
                                {

                                    case 0://Cod_Estudiante

                                        info_nota_deb.Info_notaCredDeb_aca.Info_Estudiante.cod_estudiante = Convert.ToString(row[col]);

                                        Info_Estudiante = Bus_Estudiante.Get_Info_Estudiante_x_Codigo2
                                            (Convert.ToInt32(Info_ND_Aca.IdInstitucion), info_nota_deb.Info_notaCredDeb_aca.Info_Estudiante.cod_estudiante);

                                        if (Info_Estudiante.IdEstudiante != 0) //exite el estudiante en la base de Aca_estudiante
                                        {


                                            Info_ND_Aca.Info_Estudiante = Info_Estudiante;
                                            Info_ND_Aca.IdEstudiante = Info_Estudiante.IdEstudiante;



                                            if (Info_Estudiante.Info_Familiar_Repre_Econo.IdFamiliar != 0) // el estuiante tiene represn economico q seria el cliente
                                            {

                                               // si tiene cedula el repre econo busco datos del cliente en tabla fa_cliente
                                                if (string.IsNullOrEmpty(Info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_cedulaRuc)==false)
                                                {

                                                    //opteniendo el cliente de representante economico
                                                    info_cliente = bus_cliente.Get_info_cliente_x_cedula_para_saldo_inicial(param.IdEmpresa, Info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_cedulaRuc, ref mensaje);

                                                    if (info_cliente.IdCliente != 0)
                                                    {

                                                        info_nota_deb.IdCliente = info_cliente.IdCliente;
                                                        info_nota_deb.IdCtaCble_TipoNota = info_cliente.IdCtaCble_cxc;

                                                        info_nota_deb.info_cliente = info_cliente;

                                                        
                                                        


                                                    }

                                                    
                                                }
                                            }

                                        }

                                        

                                        FILA_ERROR = "Código " + Convert.ToString(row[col]);
                                        break;
                                    case 2://# factura
                                        info_nota_deb.CodNota = Convert.ToString(row[col]);
                                        info_nota_deb.sc_observacion += info_nota_deb.CodNota;
                                        FILA_ERROR = "# factura " + Convert.ToString(row[col]);
                                        break;
                                    case 3://Fecha factura
                                        info_nota_deb.no_fecha = Convert.ToDateTime(row[col]).Date;
                                        FILA_ERROR = "Fecha factura " + Convert.ToString(row[col]);
                                        break;
                                    case 4://Fecha vcto factura
                                        info_nota_deb.no_fecha_venc = Convert.ToDateTime(row[col]).Date;
                                        FILA_ERROR = "Fecha vcto factura " + Convert.ToString(row[col]);
                                        break;
                                    case 5://Total
                                        
                                        info_nota_deb.sc_observacion += " Total:" + Convert.ToDouble(row[col]);
                                        FILA_ERROR = "Total " + Convert.ToString(row[col]);
                                        break;
                                    case 6://Saldo
                                        info_nota_deb.sc_observacion += " Saldo:" + Convert.ToDouble(row[col]);
                                        info_nota_deb.Total = Convert.ToDouble(row[col]);
                                        FILA_ERROR = "Saldo " + Convert.ToString(row[col]);
                                        break;
                                    case 7://Observación
                                        info_nota_deb.sc_observacion += " " + Convert.ToString(row[col]);
                                        FILA_ERROR = "Observación " + Convert.ToString(row[col]);
                                        break;
                                    default:
                                        break;
                                }
                            }


                            info_nota_deb.Info_notaCredDeb_aca = Info_ND_Aca;
                            info_nota_deb.Estado = "A";

                            //info_nota_deb.Info_notaCredDeb_aca.Info_Estudiante.Info_Persona.pe_nombreCompleto
                            


                            fa_notaCreDeb_det_Info info_det = new fa_notaCreDeb_det_Info();

                            info_det.IdEmpresa = info_nota_deb.IdEmpresa;
                            info_det.IdSucursal = info_nota_deb.IdSucursal;
                            info_det.IdBodega = info_nota_deb.IdBodega;
                            info_det.Secuencia = 1;
                            info_det.IdProducto = 1;
                            info_det.sc_cantidad = 1;
                            info_det.sc_Precio = info_nota_deb.Total;
                            info_det.vt_por_iva = 0;
                            info_det.sc_iva = 0;
                            info_det.sc_precioFinal = info_nota_deb.Total;
                            info_det.sc_subtotal = info_nota_deb.Total;
                            info_det.sc_total = info_nota_deb.Total;

                            info_det.IdCod_Impuesto_Iva = "IVA0";
                            info_det.sc_observacion = info_nota_deb.sc_observacion;
                            info_det.sc_estado = "A";

                            info_nota_deb.ListaDetalles.Add(info_det);
                            lista.Add(info_nota_deb);
                        }
                    }
                    else
                    {
                        MensajeError = "Por favor verifique que el archivo contenga Datos.";
                        lista = new List<fa_notaCreDeb_Info>();
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_Info) };
            }

        }

        public fa_notaCreDeb_x_cxc_cobro_Info Get_faNotaCreDeb_x_Cobro(cxc_cobro_Info info, fa_notaCreDeb_Info Item)
        {
            try
            {
                string mensaje = "";
                fa_notaCreDeb_x_cxc_cobro_Info info_NotaCreDeb = new fa_notaCreDeb_x_cxc_cobro_Info();
                cxc_conciliacion_det_Info conciliaInfo = new cxc_conciliacion_det_Info();
                info_NotaCreDeb.IdEmpresa_cbr = info.IdEmpresa;
                info_NotaCreDeb.IdSucursal_cbr = info.IdSucursal;
                info_NotaCreDeb.IdCobro_cbr = info.IdCobro;                
                info_NotaCreDeb.IdEmpresa_nt = Convert.ToInt32(Item.IdEmpresa);
                info_NotaCreDeb.IdSucursal_nt = Convert.ToInt32(Item.IdSucursal); ;
                info_NotaCreDeb.IdBodega_nt = Convert.ToInt32(Item.IdBodega);
                info_NotaCreDeb.IdNota_nt = Convert.ToInt32(Item.IdNota);

                info_NotaCreDeb.Valor_cobro = info.cr_TotalCobro;

                return info_NotaCreDeb;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_faNotaCreDeb_x_Cobro", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
            }

        }

        public Boolean VerificarCodigo(string Codigo)
        {
            try
            {
                return oData_NotaCredDeb.VerificarCodigo(Codigo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarCodigo", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
            }         
        }

        public Boolean ActualizarDB(fa_notaCreDeb_Info Info, ref string mensajeError, ref string mensajeDocumentoDupli)
        {
            try
            {
                Boolean res = true;


                if (Validar_Objeto(Info, ref mensajeError) == false)
                { return false; }


                InfoTalonario = new tb_sis_Documento_Tipo_Talonario_Info();
                Bus_Talonario = new tb_sis_Documento_Tipo_Talonario_Bus();
                fa_notaCreDeb_x_ct_cbtecble_Bus BusNotCreDeb = new fa_notaCreDeb_x_ct_cbtecble_Bus();
                fa_notaCreDeb_x_ct_cbtecble_Info InfoNotCreDeb = new fa_notaCreDeb_x_ct_cbtecble_Info();
                ct_Cbtecble_Bus bus = new ct_Cbtecble_Bus();
                if (Info.NaturalezaNota == "SRI")
                {
                    InfoTalonario.Establecimiento = Info.Serie1;
                    InfoTalonario.PuntoEmision = Info.Serie2;
                    InfoTalonario.NumDocumento = Info.NumNota_Impresa;
                    InfoTalonario.IdEmpresa = Info.IdEmpresa;
                    InfoTalonario.CodDocumentoTipo = Info.IdTipoDoc;

                }

                if (res)
                {
                    if (oData_NotaCredDeb.ActualizarDB(Info, ref mensajeError))
                    {
                        foreach (var item in Info.lst_docs_relacionados)
                        {
                            item.IdNota_nt = Info.IdNota;
                        }

                        if (bus_notaCreDeb_x_fa_factura_NotaDeb.ModificarDB(Info.lst_docs_relacionados))
                        {
                            Generar_Cobro_x_NC(Info.IdEmpresa, Info.IdSucursal, Info.IdBodega, Info.IdNota, ref mensaje);

                            InfoNotCreDeb = BusNotCreDeb.Get_Info_fa_notaCreDeb_x_ct_cbtecble(Info.IdEmpresa, Info.IdSucursal, Info.IdBodega, Info.IdNota);

                            if (InfoNotCreDeb.ct_IdCbteCble != 0)
                            {
                                Info = oData_NotaCredDeb.Get_Info_notaCreDeb_x_ND(Info.IdEmpresa, Info.IdSucursal, Info.IdBodega, Info.IdNota);
                                get_CbteCbleInfo(Info);
                                Info_CbteCble.IdCbteCble = InfoNotCreDeb.ct_IdCbteCble;
                                Info_CbteCble.IdTipoCbte = InfoNotCreDeb.ct_IdTipoCbte;


                                foreach (var item in Info_CbteCble._cbteCble_det_lista_info)
                                {
                                    item.IdCbteCble = InfoNotCreDeb.ct_IdCbteCble;
                                    item.IdTipoCbte = InfoNotCreDeb.ct_IdTipoCbte;
                                }


                                res = bus.ModificarDB(Info_CbteCble, ref mensajeError);
                            }
                            else// no existe el diario voy a generarlo 
                            {
                                res = ContabilizarNCD(Info.IdEmpresa, Info.IdSucursal, Info.IdBodega, Info.IdNota);
                            }
                        }
                    }
                }
                return res;//oDat.ActualizarDB(Info, ref mensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
            }
          
        }

        public Boolean ContabilizarNCD(int IdEmpresa, int IdSucursal,int IdBodega, decimal IdNotaCD)
        {
            try
            {
                fa_notaCreDeb_Info Info = new fa_notaCreDeb_Info();
                Info=oData_NotaCredDeb.Get_Info_notaCreDeb_x_ND(IdEmpresa, IdSucursal,IdBodega, IdNotaCD);
                GeneraCbteCtbl(Info);
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ContabilizarNCD", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
            }
        }

        public Boolean ContabilizarNCDREVERSO(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNotaCD)
        {
            try
            {
                fa_notaCreDeb_Info Info = new fa_notaCreDeb_Info();
                Info = oData_NotaCredDeb.Get_Info_notaCreDeb_x_ND(IdEmpresa, IdSucursal, IdBodega, IdNotaCD);
                GeneraCbteCtblREVERSO(Info);
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ContabilizarNCDREVERSO", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
            }
        }

        public void GeneraCbteCtbl(fa_notaCreDeb_Info Info)
        {
            try
            {
                fa_notaCreDeb_x_ct_cbtecble_Info InfoFAxCT = new fa_notaCreDeb_x_ct_cbtecble_Info();
                fa_notaCreDeb_x_ct_cbtecble_Data DataFAxCT = new fa_notaCreDeb_x_ct_cbtecble_Data();
                ct_Cbtecble_Bus bus = new ct_Cbtecble_Bus();
                if (DataFAxCT.Get_Info_fa_notaCreDeb_x_ct_cbtecble(param.IdEmpresa, Info.IdSucursal, Info.IdBodega, Info.IdNota).no_IdNota != 0) { return; }


                Info_CbteCble = get_CbteCbleInfo(Info);


                if (bus.GrabarDB(Info_CbteCble, ref idctctb, ref msg)==true)
                {

                    InfoFAxCT.ct_IdEmpresa = Info_CbteCble.IdEmpresa;
                    InfoFAxCT.ct_IdTipoCbte = Info_CbteCble.IdTipoCbte;
                    InfoFAxCT.ct_IdCbteCble = idctctb;
                    InfoFAxCT.no_IdEmpresa = Info.IdEmpresa;
                    InfoFAxCT.no_IdBodega = Info.IdBodega;
                    InfoFAxCT.no_IdSucursal = Info.IdSucursal;
                    InfoFAxCT.no_IdNota = Info.IdNota;
                    DataFAxCT.GuardarDB(InfoFAxCT);
                }


            }
                
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GeneraCbteCtbl", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
            }
        }

        public void GeneraCbteCtblREVERSO(fa_notaCreDeb_Info Info)
        {
            try
            {
                fa_parametro_Data faParam = new fa_parametro_Data();
                fa_parametro_info faParamInfo = new fa_parametro_info();
                fa_notaCreDeb_x_ct_cbtecble_Info Info_Nota_x_cbtecble = new fa_notaCreDeb_x_ct_cbtecble_Info();
                fa_notaCreDeb_x_ct_cbtecble_Data data_Nota_x_cbtecble = new fa_notaCreDeb_x_ct_cbtecble_Data();
                ct_Cbtecble_Bus bus = new ct_Cbtecble_Bus();
                Info_Nota_x_cbtecble = data_Nota_x_cbtecble.Get_Info_fa_notaCreDeb_x_ct_cbtecble(param.IdEmpresa, Info.IdSucursal, Info.IdBodega, Info.IdNota);
                faParamInfo = faParam.Get_Info_parametro(param.IdEmpresa);


                if(Info.CreDeb.TrimEnd()=="D"){
                        bus.ReversoCbteCble(param.IdEmpresa, Info_Nota_x_cbtecble.ct_IdCbteCble, Info_Nota_x_cbtecble.ct_IdTipoCbte, faParamInfo.IdTipoCbteCble_ND_Reverso, ref idctctb, ref msg, param.IdUsuario);
                }
                if (Info.CreDeb.TrimEnd() == "C")
                {
                    bus.ReversoCbteCble(param.IdEmpresa, Info_Nota_x_cbtecble.ct_IdCbteCble, Info_Nota_x_cbtecble.ct_IdTipoCbte, faParamInfo.IdTipoCbteCble_NC_Reverso, ref idctctb, ref msg, param.IdUsuario);
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GeneraCbteCtblREVERSO", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
            }
        }

        public ct_Cbtecble_Info get_CbteCbleInfo(fa_notaCreDeb_Info Info)
        {
            try
            {
                ct_Cbtecble_Bus _Cbtebus = new ct_Cbtecble_Bus();
                ct_Cbtecble_tipo_Bus cbtipobus = new ct_Cbtecble_tipo_Bus();
                ct_Periodo_Bus _PeriodoBus = new ct_Periodo_Bus();
                ct_Periodo_Info _PeriodoInfo = new ct_Periodo_Info();
                fa_parametro_Data faParam = new fa_parametro_Data();


                Info_CbteCble = new ct_Cbtecble_Info();

                string MensajeError = "";
                

                string codigo;
                DateTime Fecha_contable;

                Fecha_contable = (Info.fecha_Ctble == null) ? Convert.ToDateTime( Info.no_fecha) : Convert.ToDateTime(Info.fecha_Ctble);



                _PeriodoInfo = _PeriodoBus.Get_Info_Periodo(Info.IdEmpresa, Fecha_contable, ref MensajeError);

                if (_PeriodoInfo != null && _PeriodoInfo.pe_cerrado != "S")
                {
                    Info_CbteCble.IdEmpresa = Info.IdEmpresa;
                    Info_CbteCble.IdUsuario = param.IdUsuario;

                    

                    Info_CbteCble.IdPeriodo = _PeriodoInfo.IdPeriodo;
                    Info_CbteCble.Anio = _PeriodoInfo.IdanioFiscal;
                    Info_CbteCble.Mes = _PeriodoInfo.pe_mes;
                    if (Info.CreDeb.TrimEnd() == "C") { Info_CbteCble.IdTipoCbte = faParam.Get_Info_parametro(param.IdEmpresa).IdTipoCbteCble_NC; }
                    if(Info.CreDeb.TrimEnd() == "D"){Info_CbteCble.IdTipoCbte = faParam.Get_Info_parametro(param.IdEmpresa).IdTipoCbteCble_ND;}
                    Info_CbteCble.CodCbteCble = "NOTA"+Info.CreDeb.TrimEnd() + Info.IdNota;// (txt_codCbteCble.Text == "") ? codigo + " " + _CbteCbleInfo.IdCbteCble : txt_codCbteCble.Text;
                    Info_CbteCble.cb_Fecha = Convert.ToDateTime(Info.fecha_Ctble);
                    Info_CbteCble.cb_FechaTransac = param.Fecha_Transac;
                    Info_CbteCble.Mayorizado = "N";

                    Info_CbteCble.cb_Observacion = Info.sc_observacion + " - NOTA"+Info.CreDeb+" # " + Info.IdNota.ToString() +" el Cliente "+Info.Cliente+ " por el monto de " + (Info.Total+Info.flete+Info.interes+Info.valor1+Info.valor2).ToString();
                    Info_CbteCble.Secuencia = _Cbtebus.Get_IdSecuencia(ref msg);
                    Info_CbteCble.cb_Valor = Convert.ToDouble(Info.Total + Info.flete + Info.interes + Info.valor1 + Info.valor2);
                    Info_CbteCble.Estado = "A";
                    Info_CbteCble.IdUsuario = param.IdUsuario;

                    Info_CbteCble._cbteCble_det_lista_info = get_CbteCble_det_x_Items (Info);


                    int c = 1;                    
                    foreach (var item in Info_CbteCble._cbteCble_det_lista_info)
                    {
                        item.secuencia = c;
                        c++;
                        item.IdTipoCbte = Info_CbteCble.IdTipoCbte;
                        item.IdEmpresa = Info_CbteCble.IdEmpresa;
                        item.dc_Observacion = Info_CbteCble.cb_Observacion;
                        item.dc_Valor = Math.Round(item.dc_Valor, 2);
                    }
                    
                    return Info_CbteCble;
                }
                else
                {
                    return new ct_Cbtecble_Info();
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCbleInfo", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
            }
        }

        public List<ct_Cbtecble_det_Info> get_CbteCble_det_x_Items(fa_notaCreDeb_Info Info)
        {
            
            List<ct_Cbtecble_det_Info> Listadte = new List<ct_Cbtecble_det_Info>();
            try
            {
                

                fa_notaCreDeb_det_Data BUSdet = new fa_notaCreDeb_det_Data();
                fa_parametro_Data faParam = new fa_parametro_Data();
                fa_parametro_info faInfoParam = new fa_parametro_info();
                string IdCtaCble_IVA = "";

                faInfoParam = faParam.Get_Info_parametro(Info.IdEmpresa);
                IdCtaCble_IVA = faInfoParam.IdCtaCble_IVA;

                List<vwfa_ContabilizarNotaCredDeb_x_Item_Info> DetalleNotaCred = new List<vwfa_ContabilizarNotaCredDeb_x_Item_Info>();
                DetalleNotaCred = BUSdet.Get_List_fa_ContabilizarNotaCredDeb_Items(Info.IdEmpresa, Info.IdSucursal, Info.IdBodega, Info.IdNota);

                string tipoProceso;



                if (Info.CreDeb.TrimEnd() == "C")
                {
                    
                    tipoProceso = "NTCR";
                }
                else
                {
                    
                    tipoProceso = "NTDB";
                }
                int i = 0;

                Listadte.Clear();
                

                string TipPara_CXC = tipoProceso + "_CXC";
                string TipPara_IVA = tipoProceso + "_IVA";
                string TipPara_FLETE = tipoProceso + "_FLETE";
                string TipPara_INTERES = tipoProceso + "_INTERES";
                string TipPara_DESC = tipoProceso + "_DESC";
                string TipPara_SUBTOTAL_0 = tipoProceso + "_SUBTOTAL_0";
                string TipPara_SUBTOTAL_IVA = tipoProceso + "_SUBTOTAL_IVA";




                string IdCtaCble_cxc = "";
                string IdCtaCble_tipo_Nota = "";


                if (string.IsNullOrEmpty(Info.IdCtaCble_TipoNota))
                {
                    IdCtaCble_tipo_Nota = "";
                }
                else
                {
                    IdCtaCble_tipo_Nota = Info.IdCtaCble_TipoNota;
                }

                fa_Cliente_Bus CliBu = new fa_Cliente_Bus();
                fa_Cliente_Info ClienInfo = new fa_Cliente_Info();

                ClienInfo = CliBu.Get_Info_Cliente(Info.IdEmpresa, Info.IdCliente);

                if (string.IsNullOrEmpty(ClienInfo.IdCtaCble_cxc))
                {
                    IdCtaCble_cxc = "";
                }
                else
                {
                    IdCtaCble_cxc = ClienInfo.IdCtaCble_cxc;
                }


                //List<string> Categorias = (from q in DetalleNotaCred group q by q.IdCategoria into w select w.Key).ToList();



                ct_Cbtecble_det_Info dte = new ct_Cbtecble_det_Info();

                //haber 
                dte.IdCtaCble = IdCtaCble_cxc;
                if (Info.CreDeb.TrimEnd() == "C") //NC
                { dte.dc_Valor =Math.Round( -1 * Convert.ToDouble(DetalleNotaCred.Sum(v => v.Total)) ,2,MidpointRounding.AwayFromZero); }
                else { dte.dc_Valor = Math.Round(Convert.ToDouble(DetalleNotaCred.Sum(v => v.Total)), 2, MidpointRounding.AwayFromZero); }

                dte.IdCentroCosto = ClienInfo.IdCentroCosto_CXC;
                dte.IdTipoCbte = Info_CbteCble.IdTipoCbte;
                dte.dc_Observacion = Info_CbteCble.cb_Observacion + " [" + TipPara_CXC + "]/";
                i = i + 1;
                dte.secuencia = i;
                Listadte.Add(dte);

                dte = new ct_Cbtecble_det_Info();
                dte.IdCtaCble = IdCtaCble_IVA;
                if (Info.CreDeb.TrimEnd() == "C") { dte.dc_Valor = Math.Round(Convert.ToDouble(DetalleNotaCred.Sum(v => v.Iva)),2,MidpointRounding.AwayFromZero) ; }
                else { Math.Round(dte.dc_Valor = -1 * Convert.ToDouble(DetalleNotaCred.Sum(v => v.Iva)),2,MidpointRounding.AwayFromZero); }
                dte.dc_Observacion = Info_CbteCble.cb_Observacion + " [" + TipPara_IVA + "]/";
                i = i + 1;
                dte.secuencia = i;
                Listadte.Add(dte);

                var lista_agrupada = from q in DetalleNotaCred
                                     group q by new { q.IdEmpresa, q.IdSucursal, q.IdBodega, q.IdNota, q.IdPunto_cargo_grupo, q.IdPunto_Cargo ,q.IdCentroCosto}
                                         into grouping
                                         select new { grouping.Key, suma = grouping.Sum(q => q.Sub_total) };

                foreach (var item in lista_agrupada)
                {
                    dte = new ct_Cbtecble_det_Info();
                    dte.IdCtaCble = IdCtaCble_tipo_Nota;
                    if (Info.CreDeb.TrimEnd() == "C")
                    {
                        dte.dc_Valor = Math.Round(Convert.ToDouble(item.suma), 2, MidpointRounding.AwayFromZero);
                    }
                    else
                    {
                        dte.dc_Valor = Math.Round(-1 * Convert.ToDouble(item.suma), 2, MidpointRounding.AwayFromZero);
                    }
                    dte.dc_Observacion = Info_CbteCble.cb_Observacion + " [" + TipPara_SUBTOTAL_IVA + " - " + TipPara_SUBTOTAL_0 + "]/";
                    i = i + 1;
                    dte.secuencia = i;
                    dte.IdPunto_cargo_grupo = item.Key.IdPunto_cargo_grupo;
                    dte.IdPunto_cargo = item.Key.IdPunto_Cargo;
                    dte.IdCentroCosto = item.Key.IdCentroCosto;

                    Listadte.Add(dte);    
                }

                Listadte.RemoveAll(v => v.dc_Valor == 0);
                return Listadte;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCble_det_CATEGORIA", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
            }

        }

        public Boolean GenerarXml_notaCreDeb(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota,string CreDeb, string RutaDescarga, ref string msg)
        {
            try
            {
                string sIdCbteNotCreDeb = "";

                List<vwfa_notaCreDeb_sri_Info> lista_NotaCreDeb_sri = new List<vwfa_notaCreDeb_sri_Info>();
                lista_NotaCreDeb_sri = oData_NotaCredDeb.Get_list_NotaCreDeb_Sri(IdEmpresa, IdSucursal, IdBodega, IdNota, CreDeb, ref msg);

                if (lista_NotaCreDeb_sri.Count != 0)
                { 
                   // validar objeto

                    if (!ValidarObjeto_XML_notaCreDeb(lista_NotaCreDeb_sri, ref  msg))
                        return false;

                    if (CreDeb == "C")
                    {
                        List<notaCredito> lista = new List<notaCredito>();
                        lista = Get_List_GenerarXml_NotaCredito(IdEmpresa, IdSucursal, IdBodega, IdNota, CreDeb, ref msg);

                        

                        if (lista.Count != 0)
                        {
                            foreach (var item in lista)
                            {
                                sIdCbteNotCreDeb = item.infoTributaria.razonSocial.Substring(0, 3) + "-" + Cl_Enumeradores.eTipoCodComprobante.NTC + "-" + item.infoTributaria.estab + "-" + item.infoTributaria.ptoEmi + "-" + item.infoTributaria.secuencial;
                                XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                                NamespaceObject.Add("", "");
                                XmlSerializer mySerializer = new XmlSerializer(typeof(notaCredito));
                                StreamWriter myWriter = new StreamWriter(RutaDescarga + sIdCbteNotCreDeb + ".xml");
                                mySerializer.Serialize(myWriter, item, NamespaceObject);
                                myWriter.Close();
                            }
                        }
                    }
                    else
                    {
                        List<notaDebito> lista = new List<notaDebito>();
                        lista = Get_List_GenerarXml_NotaDebito(IdEmpresa, IdSucursal, IdBodega, IdNota, CreDeb, ref msg);

                        if (lista.Count != 0)
                        {
                            foreach (var item in lista)
                            {
                                sIdCbteNotCreDeb = item.infoTributaria.razonSocial.Substring(0, 3) + "-" + Cl_Enumeradores.eTipoCodComprobante.NTD + "-" + item.infoTributaria.estab + "-" + item.infoTributaria.ptoEmi + "-" + item.infoTributaria.secuencial;
                                XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                                NamespaceObject.Add("", "");
                                XmlSerializer mySerializer = new XmlSerializer(typeof(notaDebito));
                                StreamWriter myWriter = new StreamWriter(RutaDescarga + sIdCbteNotCreDeb + ".xml");
                                mySerializer.Serialize(myWriter, item, NamespaceObject);
                                myWriter.Close();
                            }
                        }
                    }
                }


                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GenerarXml_notaCreDeb", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
            }
        }

        public Boolean ValidarObjeto_XML_notaCreDeb(List<vwfa_notaCreDeb_sri_Info> lista, ref string MensajeError)
        {
            try
            {
                Boolean res = true;

                foreach (var item in lista)
                {
                    //Empresa
                    if (String.IsNullOrEmpty(item.RazonSocial))
                    {
                        MensajeError = "Falta Razón Social Empresa. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.NombreComercial))
                    {
                        MensajeError = "Falta Nombre Comercial Empresa. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.em_direccion))
                    {
                        MensajeError = "Falta Dirección Matriz Empresa. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.em_ruc))
                    {
                        MensajeError = "Falta Tipo de Identificación Empresa. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.ContribuyenteEspecial))
                    {
                        MensajeError = "Falta Número de Contribuyente Especial Empresa. Por Favor verifique";
                        res = false;
                    }

                    //Factura
                    if (String.IsNullOrEmpty(item.Serie1))
                    {
                        MensajeError = "Falta serie del Documento. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.Serie2))
                    {
                        MensajeError = "Falta serie del Documento. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.NumNota_Impresa))
                    {
                        MensajeError = "Falta Secuencial del Documento. Por Favor verifique";
                        res = false;
                    }

                    //Cliente
                    if (String.IsNullOrEmpty(item.Su_Direccion))
                    {
                        MensajeError = "Falta Dirección Establecimiento. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.cl_RazonSocial))
                    {
                        MensajeError = "Falta Razón Social Comprador. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.pe_cedulaRuc))
                    {
                        MensajeError = "Falta Identificación del Comprador. Por Favor verifique";
                        res = false;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarObjeto_XML_notaCreDeb", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
            }
        }

        public Boolean Validar_Objeto(fa_notaCreDeb_Info Info,ref string MensajeError)
        {
            try
            {
                Boolean res = true;
                if (Info.CreDeb == "C")
                {
                    if (Info.CodDocumentoTipo == null || Info.CodDocumentoTipo == "")
                    {
                        Info.CodDocumentoTipo = "NTCR";
                    }
                }
                else
                {
                    if (Info.CodDocumentoTipo == null || Info.CodDocumentoTipo == "")
                    {
                        Info.CodDocumentoTipo = "NTDB";
                    }
                }


                if (Info.IdEmpresa==0 || Info.IdSucursal==0 || Info.IdBodega ==0)
                {
                    MensajeError = "Los IdEmpresa o IdSucursal o IdBodega estan en cero son PK no pueden estar en cero";
                    res = false;
                }

                if (Info.IdCliente==0)
                {
                    MensajeError = "El IdCliente no puede ser cero";
                    res = false;
                }

                if (String.IsNullOrEmpty(Info.CreDeb))
                {
                    MensajeError = "El campo [CreDeb] Tipo Credito o Debito esta en blanco o null";
                    res = false;
                }

                if (Info.no_fecha ==null || Info.no_fecha == new DateTime(0001,1,1))
                {
                    MensajeError = "La Fecha no puede ser null o 01/01/0001";
                    res = false;
                }

                if (Info.no_fecha_venc == null || Info.no_fecha_venc == new DateTime(0001, 1, 1))
                {
                    MensajeError = "La Fecha de venc no puede ser null o 01/01/0001";
                    res = false;
                }

                if (Info.IdTipoNota == 0)
                {
                    MensajeError = "El tipo de Nota : IdTipoNota  no puede ser cero";
                    res = false;
                }

                if (Info.IdCaja == 0)
                {
                    MensajeError = "la caja no puede ser cero";
                    res = false;
                }
                if (Info.fecha_Ctble==null)
                {
                    Info.fecha_Ctble = Info.no_fecha;
                }

                if (string.IsNullOrEmpty( Info.IdCtaCble_TipoNota ))
                {
                    fa_TipoNota_x_Empresa_x_Sucursal_Bus BusTipoNota = new fa_TipoNota_x_Empresa_x_Sucursal_Bus();
                    fa_TipoNota_x_Empresa_x_Sucursal_Info InfoTipoN = new fa_TipoNota_x_Empresa_x_Sucursal_Info();
                   InfoTipoN= BusTipoNota.Get_Info_TipoNota_x_Empresa_x_Sucursal_x_TipoNota(Info.IdEmpresa,Info.IdSucursal,Info.IdTipoNota);
                   if (InfoTipoN != null && !string.IsNullOrEmpty(InfoTipoN.IdCtaCble))
                   {
                       Info.IdCtaCble_TipoNota = InfoTipoN.IdCtaCble;
                   }
                   else
                   {
                       MensajeError = "El tipo de nota no tiene una cuenta contable";
                       res = false;
                   }
                }
                return res;
            }
            catch (Exception ex)
            {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarObjeto_XML_notaCreDeb", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
            }
        }

        public Boolean Generar_Cobro_x_NC(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota_Cred, ref string MensajeError)
        {
            try
            {
                bool res = false;

                cxc_cobro_Bus BusCobro = new cxc_cobro_Bus();
                cxc_cobro_Det_Bus BusCobro_Det = new cxc_cobro_Det_Bus();
                cxc_cobro_Info InfoCbro = new cxc_cobro_Info();

                List<cxc_cobro_Det_Info> listDet_cobro = new List<cxc_cobro_Det_Info>();

                fa_notaCreDeb_Info InfoNota_deb = new fa_notaCreDeb_Info();
                List<fa_notaCreDeb_det_Info> listDet_Nota = new List<fa_notaCreDeb_det_Info>();
                fa_notaCreDeb_det_bus BusDet_Nota = new fa_notaCreDeb_det_bus();

                fa_notaCreDeb_x_fa_factura_NotaDeb_Bus BusNota_deb_x_factura = new fa_notaCreDeb_x_fa_factura_NotaDeb_Bus();
                List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info> list_cbts_vtas_x_NC = new List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info>();
                List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info> list_cbts_vtas_x_cobrar = new List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info>();
                
                #region Valida si los documentos de la nota de crédito tengan cobros, en caso de no tenerlos los cobra
                list_cbts_vtas_x_NC = BusNota_deb_x_factura.Get_list_docs_x_NC_x_cobro(IdEmpresa, IdSucursal, IdBodega, IdNota_Cred);
                foreach (var item in list_cbts_vtas_x_NC)
                {
                    if (item.IdCobro_cbr==null)
                    {
                        fa_notaCreDeb_x_fa_factura_NotaDeb_Info info = new fa_notaCreDeb_x_fa_factura_NotaDeb_Info();
                        info = item;
                        list_cbts_vtas_x_cobrar.Add(info);
                    }
                }
                #endregion

                if (list_cbts_vtas_x_cobrar.Count() > 0) 
                {

                    InfoNota_deb = Get_Info_notaCreDeb_x_ND(IdEmpresa, IdSucursal, IdBodega, IdNota_Cred);
                    listDet_Nota = BusDet_Nota.Get_List_notaCreDeb_det(IdEmpresa, IdSucursal, IdBodega, IdNota_Cred);

                    InfoCbro.IdEmpresa = InfoNota_deb.IdEmpresa;
                    InfoCbro.IdSucursal = InfoNota_deb.IdSucursal;
                    InfoCbro.IdCobro = 0;
                    InfoCbro.IdCobro_tipo = InfoNota_deb.CreDeb.Trim() == "D" ? "NTDB" : "NTCR";
                    InfoCbro.IdCliente = InfoNota_deb.IdCliente;
                
                    InfoCbro.cr_fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    InfoCbro.cr_fechaDocu = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    InfoCbro.cr_fechaCobro = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    InfoCbro.cr_observacion = "Cbr x "+InfoNota_deb.CodNota+" x cruze  " + InfoNota_deb.sc_observacion;
                    InfoCbro.cr_Banco = null;
                    InfoCbro.cr_cuenta = null;
                    InfoCbro.cr_NumDocumento = InfoNota_deb.CreDeb.Trim() == "D" ? "ND" : "NC" + "#:" + ((InfoNota_deb.NumNota_Impresa == null) ? InfoNota_deb.IdNota.ToString() : InfoNota_deb.NumNota_Impresa);
                    InfoCbro.cr_Tarjeta = null;
                    InfoCbro.cr_estado = "A";
                    InfoCbro.cr_es_anticipo = "N";
                    InfoCbro.Fecha_Transac = DateTime.Now;
                    InfoCbro.IdUsuario = InfoNota_deb.IdUsuario;
                    InfoCbro.nom_pc = InfoNota_deb.nom_pc;
                    InfoCbro.ip = InfoNota_deb.ip;
                    InfoCbro.IdCaja = InfoNota_deb.IdCaja;
                    InfoCbro.IdTipoNotaCredito = InfoNota_deb.IdTipoNota;

                    InfoCbro.ListaCobro = new List<cxc_cobro_Det_Info>();
                    listDet_cobro = new List<cxc_cobro_Det_Info>();
                    int fila=1;
                    double Total_cobro = 0;

                    foreach (var item in list_cbts_vtas_x_cobrar)
                    {
                        if (item.Valor_Aplicado!=0)
                        {
                            cxc_cobro_Det_Info Infodet = new cxc_cobro_Det_Info();
                            Infodet.IdEmpresa = InfoNota_deb.IdEmpresa;
                            Infodet.IdSucursal = InfoNota_deb.IdSucursal;
                            Infodet.IdCobro = InfoCbro.IdCobro;
                            Infodet.secuencial = fila++;
                            Infodet.dc_TipoDocumento = item.vt_tipoDoc;
                            Infodet.IdBodega_Cbte = item.IdBodega_fac_nd_doc_mod;
                            Infodet.IdCbte_vta_nota = item.IdCbteVta_fac_nd_doc_mod;
                            Infodet.dc_ValorPago = InfoNota_deb.CreDeb.Trim() == "D" ? item.Valor_Aplicado * -1 : item.Valor_Aplicado;

                            Total_cobro = Total_cobro + (InfoNota_deb.CreDeb.Trim() == "D" ? item.Valor_Aplicado * -1 : item.Valor_Aplicado);

                            Infodet.IdUsuario = InfoNota_deb.IdUsuario;
                            Infodet.Fecha_Transac = DateTime.Now;
                            Infodet.estado = "A";

                            listDet_cobro.Add(Infodet);    
                        }
                    }

                    InfoCbro.cr_TotalCobro = Total_cobro;
                    InfoCbro.ListaCobro = listDet_cobro;
                    if (InfoCbro.cr_TotalCobro != 0)
                    {
                        string mensa = "";

                        res = BusCobro.GuardarDB(Cl_Enumeradores.PantallaEjecucion.COBROS, ref InfoCbro, ref mensa);

                        if (res == true)
                        {
                            fa_notaCreDeb_x_cxc_cobro_Bus Bus_nota_x_cobro = new fa_notaCreDeb_x_cxc_cobro_Bus();
                            fa_notaCreDeb_x_cxc_cobro_Info Info_nota_x_cobro = new fa_notaCreDeb_x_cxc_cobro_Info();

                            Info_nota_x_cobro.IdEmpresa_cbr = InfoCbro.IdEmpresa;
                            Info_nota_x_cobro.IdSucursal_cbr = InfoCbro.IdSucursal;
                            Info_nota_x_cobro.IdCobro_cbr = InfoCbro.IdCobro;
                            Info_nota_x_cobro.Valor_cobro = InfoCbro.cr_TotalCobro;
                            Info_nota_x_cobro.IdEmpresa_nt = InfoNota_deb.IdEmpresa;
                            Info_nota_x_cobro.IdSucursal_nt = InfoNota_deb.IdSucursal;
                            Info_nota_x_cobro.IdBodega_nt = InfoNota_deb.IdBodega;
                            Info_nota_x_cobro.IdNota_nt = InfoNota_deb.IdNota;

                            if (Info_nota_x_cobro.IdCobro_cbr > 0 && Info_nota_x_cobro.IdNota_nt > 0)
                            {
                                res = Bus_nota_x_cobro.GuardarDB(Info_nota_x_cobro, ref MensajeError);
                            }
                        }
                    }
                   
                    return res;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
                
            }
        
        }

        public List<notaCredito> Get_List_GenerarXml_NotaCredito(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota, string CreDeb, ref string msg)
        {
            try
            {
                string secuencia_aux = "";
                string secuencia = "";

                List<notaCredito> lista = new List<notaCredito>();

                List<vwfa_notaCreDeb_sri_Info> consulta = new List<vwfa_notaCreDeb_sri_Info>();
                vwfa_notaCreDeb_sri_Bus Bus_notadecred_sri = new vwfa_notaCreDeb_sri_Bus();

                consulta = Bus_notadecred_sri.Get_List_notaCreDeb_sri(IdEmpresa, IdSucursal, IdBodega, IdNota, CreDeb, ref mensaje);


                vwfa_notaCreDeb_sri_Info info_notCredSRI = new vwfa_notaCreDeb_sri_Info();

                if (consulta.ToList().Count != 0)
                {
                    //consultar nota credito det
                    fa_notaCreDeb_det_Data odetNotCred = new fa_notaCreDeb_det_Data();
                    List<fa_notaCreDeb_det_Info> info_notCredet = new List<fa_notaCreDeb_det_Info>();

                    info_notCredet = odetNotCred.Get_List_notaCreDeb_det(IdEmpresa, IdSucursal, IdBodega, IdNota);

                    if (info_notCredet.Count != 0)
                    {
                        info_notCredSRI.lista_DetCreDeb = info_notCredet;

                        foreach (var item in consulta)
                        {

                            notaCredito myObject;
                            myObject = new notaCredito();
                            myObject.id = notaCreditoID.comprobante;
                            myObject.version = "1.1.0";
                            myObject.idSpecified = true;
                            totalConImpuestos imp = new totalConImpuestos();
                            myObject.infoNotaCredito = new notaCreditoInfoNotaCredito();
                            myObject.infoTributaria = new infoTributaria();
                            myObject.detalles = new List<notaCreditoDetalle>();
                            myObject.infoNotaCredito.totalConImpuestos = new List<totalConImpuestosTotalImpuesto>();
                            totalConImpuestosTotalImpuesto impuesto = null;

                            myObject.infoTributaria.ambiente = "1";
                            myObject.infoTributaria.tipoEmision = "1";
                            myObject.infoTributaria.razonSocial = item.RazonSocial.Trim();
                            myObject.infoTributaria.nombreComercial = item.NombreComercial.Trim();
                            myObject.infoTributaria.ruc = item.em_ruc;
                            myObject.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                            myObject.infoTributaria.codDoc = "04";
                            myObject.infoTributaria.estab = item.Serie1;
                            myObject.infoTributaria.ptoEmi = item.Serie2;


                            //validar secuencial nota credito
                            secuencia_aux = "";
                            secuencia = "";

                            if (!String.IsNullOrEmpty(item.NumNota_Impresa))
                            {
                                if (item.NumNota_Impresa.Length < 9)
                                {
                                    int conta = item.NumNota_Impresa.Length;
                                    int diferencia = 9 - conta;

                                    secuencia_aux = secuencia_aux.PadLeft(diferencia, '0');
                                    secuencia = secuencia_aux + item.NumNota_Impresa;

                                    item.NumNota_Impresa = secuencia;
                                }

                            }

                            myObject.infoTributaria.secuencial = item.NumNota_Impresa;
                            myObject.infoTributaria.dirMatriz = item.em_direccion;
                            myObject.infoNotaCredito.fechaEmision = item.no_fecha.ToString(format);
                            myObject.infoNotaCredito.dirEstablecimiento = item.Su_Direccion.Trim();


                            switch (item.IdTipoDocumento)
                            {
                                case "CED":
                                    myObject.infoNotaCredito.tipoIdentificacionComprador = "05";
                                    break;
                                case "PAS":
                                    myObject.infoNotaCredito.tipoIdentificacionComprador = "06";
                                    break;

                                case "RUC":
                                    myObject.infoNotaCredito.tipoIdentificacionComprador = "04";
                                    break;
                                default:
                                    break;
                            }


                            myObject.infoNotaCredito.razonSocialComprador = item.pe_nombreCompleto.Trim();
                            myObject.infoNotaCredito.identificacionComprador = item.pe_cedulaRuc;
                            myObject.infoNotaCredito.contribuyenteEspecial = item.ContribuyenteEspecial.Trim();
                            myObject.infoNotaCredito.obligadoContabilidad = (item.ObligadoAllevarConta == "S" || item.ObligadoAllevarConta == "SI") ? "SI" : "NO";
                            myObject.infoNotaCredito.codDocModificado = item.tipo_doc_aplicado == "FACT" ? "01" : "05"; //01 FACT - 05 NTDB

                            myObject.infoNotaCredito.numDocModificado = item.NumDocModificado;
                            myObject.infoNotaCredito.fechaEmisionDocSustento = Convert.ToString(item.fechaEmisionDocSustento.Value.ToShortDateString());
                            myObject.infoNotaCredito.motivo = item.observacion_Nota;
                            myObject.infoNotaCredito.moneda = "DOLAR";

                            // calculo impuestos detalle nota cerdito
                            double sum_totsinImp = 0;
                            double sum_Total = 0;

                            List<totalConImpuestosTotalImpuesto> lista_Impuesto = new List<totalConImpuestosTotalImpuesto>();

                            foreach (var item2 in info_notCredSRI.lista_DetCreDeb)
                            {
                                double subtotal = 0;
                                double descuento_total = 0;

                                impuesto = new totalConImpuestosTotalImpuesto();
                                impuesto.codigo = "2";

                                impuesto impue = new impuesto();
                                notaCreditoDetalle NCdetalle = new notaCreditoDetalle();

                                subtotal = item2.sc_cantidad * item2.sc_Precio;
                                //subtotal = Math.Round(subtotal,2);
                                if (item2.sc_descUni != 0)
                                {
                                    descuento_total = item2.sc_descUni * item2.sc_cantidad;
                                    subtotal = subtotal - Math.Round(descuento_total, 2);
                                    NCdetalle.descuentoSpecified = true;
                                }
                                sum_totsinImp = sum_totsinImp + subtotal;
                                sum_Total = sum_Total + item2.sc_total;

                                NCdetalle.codigoInterno = Convert.ToString(item2.IdProducto);
                                NCdetalle.codigoAdicional = item2.pr_codigo;
                                NCdetalle.descripcion = item2.pr_descripcion;
                                NCdetalle.cantidad = Convert.ToDecimal(item2.sc_cantidad);
                                NCdetalle.precioUnitario = Convert.ToDecimal(Math.Round(item2.sc_Precio, 6));
                                NCdetalle.descuento = Convert.ToDecimal(item2.sc_descUni);
                                NCdetalle.precioTotalSinImpuesto = Math.Round(Convert.ToDecimal(subtotal), 2);

                                NCdetalle.impuestos = new List<impuesto>();

                                if (item2.sc_iva > 0)
                                {
                                    impue.codigo = "2";
                                    if (item2.vt_por_iva == 12)
                                    {
                                        impuesto.baseImponible = Math.Round(Convert.ToDecimal(subtotal), 2);
                                        impuesto.valor = Math.Round(Convert.ToDecimal(item2.sc_iva), 2);
                                        impuesto.codigoPorcentaje = "2";
                                        lista_Impuesto.Add(impuesto);

                                        impue.codigoPorcentaje = "2";
                                        impue.tarifa = 12;
                                        impue.baseImponible = Convert.ToDecimal(Math.Round(subtotal, 2));
                                        impue.valor = Math.Round(Convert.ToDecimal(item2.sc_iva), 2);
                                    }
                                    else
                                        if (item2.vt_por_iva == 14)
                                        {
                                            impuesto.baseImponible = Math.Round(Convert.ToDecimal(subtotal), 2);
                                            impuesto.valor = Math.Round(Convert.ToDecimal(item2.sc_iva), 2);
                                            impuesto.codigoPorcentaje = "3";
                                            lista_Impuesto.Add(impuesto);

                                            impue.codigoPorcentaje = "3";
                                            impue.tarifa = 14;
                                            impue.baseImponible = Convert.ToDecimal(Math.Round(subtotal, 2));
                                            impue.valor = Math.Round(Convert.ToDecimal(item2.sc_iva), 2);
                                        }
                                }
                                else
                                {
                                    impuesto.codigoPorcentaje = "0";
                                    impuesto.baseImponible = Convert.ToDecimal(Math.Round(subtotal, 6));
                                    impuesto.valor = Convert.ToDecimal(Math.Round(item2.sc_iva, 6));

                                    lista_Impuesto.Add(impuesto);

                                    impue.codigo = "2";
                                    impue.codigoPorcentaje = "0";
                                    impue.tarifa = 0;
                                    impue.baseImponible = Convert.ToDecimal(Math.Round(subtotal, 6));
                                    impue.valor = Convert.ToDecimal(Math.Round(item2.sc_iva, 6));
                                }
                                NCdetalle.impuestos.Add(impue);
                                myObject.detalles.Add(NCdetalle);
                            }

                            myObject.infoNotaCredito.totalSinImpuestos = Convert.ToDecimal(Math.Round(sum_totsinImp, 2));
                            myObject.infoNotaCredito.valorModificacion = Convert.ToDecimal(Math.Round(sum_Total, 2));

                            var resul_Impuesto = from s in lista_Impuesto
                                                 group s by new { s.codigoPorcentaje, s.codigo } into g
                                                 select new { g.Key.codigoPorcentaje, g.Key.codigo, baseImponible = g.Sum(s => s.baseImponible), Valor = g.Sum(x => x.valor) };

                            foreach (var item3 in resul_Impuesto)
                            {
                                impuesto = new totalConImpuestosTotalImpuesto();
                                impuesto.codigo = item3.codigo;
                                impuesto.codigoPorcentaje = item3.codigoPorcentaje;
                                impuesto.baseImponible = item3.baseImponible;
                                impuesto.valor = item3.Valor;

                                myObject.infoNotaCredito.totalConImpuestos.Add(impuesto);
                            }

                            if (!String.IsNullOrEmpty(item.pe_correo))
                            {
                                campoAdicional = item.pe_correo;

                                // campos adicionales 
                                Cl_ValidarEmail_Info datosAdc = new Cl_ValidarEmail_Info();

                                if (datosAdc.email_bien_escrito(campoAdicional) == true)
                                {
                                    notaCreditoCampoAdicional compoadicional = new notaCreditoCampoAdicional();
                                    compoadicional.nombre = "MAIL";
                                    compoadicional.Value = campoAdicional;
                                    myObject.infoAdicional = new List<notaCreditoCampoAdicional>();
                                    myObject.infoAdicional.Add(compoadicional);
                                }
                            }
                            lista.Add(myObject);
                        }
                    }
                }

                msg = "Archivo XML de Nota de Crédito Generado con Exito";
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<notaDebito> Get_List_GenerarXml_NotaDebito(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota, string CreDeb, ref string msg)
        {
            try
            {
                string secuencia_aux = "";
                string secuencia = "";

                


                vwfa_notaCreDeb_sri_Bus Bus_notadecred_sri = new vwfa_notaCreDeb_sri_Bus();

                List<notaDebito> lista = new List<notaDebito>();
                List<vwfa_notaCreDeb_sri_Info> consulta = new List<vwfa_notaCreDeb_sri_Info>();
                
                consulta = Bus_notadecred_sri.Get_List_notaCreDeb_sri(IdEmpresa, IdSucursal, IdBodega, IdNota, CreDeb, ref mensaje);

                vwfa_notaCreDeb_sri_Info info_notCredSRI = new vwfa_notaCreDeb_sri_Info();

                if (consulta.ToList().Count != 0)
                {

                    //consultar nota debito det
                    fa_notaCreDeb_det_Data odetNotCred = new fa_notaCreDeb_det_Data();
                    List<fa_notaCreDeb_det_Info> info_notCredet = new List<fa_notaCreDeb_det_Info>();

                    info_notCredet = odetNotCred.Get_List_notaCreDeb_det(IdEmpresa, IdSucursal, IdBodega, IdNota);

                    if (info_notCredet.Count != 0)
                    {
                        info_notCredSRI.lista_DetCreDeb = info_notCredet;

                        foreach (var item in consulta)
                        {
                            notaDebito myObject = new notaDebito();
                            myObject.infoTributaria = new Info.class_sri.FacturaV2.infoTributaria();
                            myObject.infoNotaDebito = new notaDebitoInfoNotaDebito();
                            myObject.motivos = new notaDebitoMotivos();
                            myObject.motivos.motivo = new List<notaDebitoMotivosMotivo>();

                            // info nota debito
                            myObject.id = notaDebitoID.comprobante;
                            myObject.idSpecified = true;
                            myObject.version = "1.0.0";
                            myObject.infoTributaria.ambiente = "1";
                            myObject.infoTributaria.tipoEmision = "1";
                            myObject.infoTributaria.razonSocial = item.RazonSocial;
                            myObject.infoTributaria.nombreComercial = item.NombreComercial;
                            myObject.infoTributaria.ruc = item.em_ruc;
                            myObject.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                            myObject.infoTributaria.codDoc = "05";
                            myObject.infoTributaria.estab = item.Serie1;
                            myObject.infoTributaria.ptoEmi = item.Serie2;

                            //validar secuencial nota debito
                            secuencia_aux = "";
                            secuencia = "";

                            if (!String.IsNullOrEmpty(item.NumNota_Impresa))
                            {
                                if (item.NumNota_Impresa.Length < 9)
                                {
                                    int conta = item.NumNota_Impresa.Length;
                                    int diferencia = 9 - conta;

                                    secuencia_aux = secuencia_aux.PadLeft(diferencia, '0');
                                    secuencia = secuencia_aux + item.NumNota_Impresa;
                                    item.NumNota_Impresa = secuencia;
                                }
                            }

                            myObject.infoTributaria.secuencial = item.NumNota_Impresa;
                            myObject.infoTributaria.dirMatriz = item.em_direccion;
                            myObject.infoNotaDebito.fechaEmision = item.no_fecha.ToString(format);
                            myObject.infoNotaDebito.dirEstablecimiento = item.Su_Direccion;

                            switch (item.IdTipoDocumento)
                            {
                                case "CED":
                                    myObject.infoNotaDebito.tipoIdentificacionComprador = "05";
                                    break;
                                case "PAS":
                                    myObject.infoNotaDebito.tipoIdentificacionComprador = "06";
                                    break;

                                case "RUC":
                                    myObject.infoNotaDebito.tipoIdentificacionComprador = "04";
                                    break;
                                default:
                                    break;
                            }

                            myObject.infoNotaDebito.razonSocialComprador = item.cl_RazonSocial;
                            myObject.infoNotaDebito.identificacionComprador = item.pe_cedulaRuc;
                            myObject.infoNotaDebito.contribuyenteEspecial = item.ContribuyenteEspecial;
                            myObject.infoNotaDebito.obligadoContabilidad = (item.ObligadoAllevarConta == "S" || item.ObligadoAllevarConta == "SI") ? "SI" : "NO";

                            myObject.infoNotaDebito.codDocModificado = "01";
                            myObject.infoNotaDebito.numDocModificado = item.NumDocModificado;
                            myObject.infoNotaDebito.fechaEmisionDocSustento = Convert.ToString(Convert.ToDateTime(item.fechaEmisionDocSustento).ToShortDateString());

                            // calculo impuestos detalle nota cerdito
                            double sum_totsinImp = 0;
                            double sum_Total = 0;


                            myObject.infoNotaDebito.impuestos = new List<Info.class_sri.FacturaV2.impuesto>();

                            List<notaDebitoMotivosMotivo> lista_motivo = new List<notaDebitoMotivosMotivo>();

                            foreach (var item2 in info_notCredSRI.lista_DetCreDeb)
                            {
                                impuesto impue = new impuesto();

                                notaDebitoMotivosMotivo motivos = new notaDebitoMotivosMotivo();

                                double subtotal = 0;

                                subtotal = item2.sc_cantidad * item2.sc_Precio;
                                sum_totsinImp = sum_totsinImp + subtotal;
                                sum_Total = sum_Total + Math.Round(item2.sc_total, 2, MidpointRounding.AwayFromZero);

                                if (item2.vt_por_iva == 12)
                                {

                                    impue.codigo = "2";
                                    impue.codigoPorcentaje = "2";
                                    impue.tarifa = 12;
                                    impue.baseImponible = Convert.ToDecimal(subtotal);
                                    impue.valor = Math.Round(Convert.ToDecimal(item2.sc_iva), 2, MidpointRounding.AwayFromZero);

                                    myObject.infoNotaDebito.impuestos.Add(impue);


                                    switch (param.IdCliente_Ven_x_Default)
                                    {
                                        case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                                                motivos.razon = item2.pr_descripcion;
                                            break;
                                        case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                                            motivos.razon = item.observacion_Nota;
                                            break;
                                        case Cl_Enumeradores.eCliente_Vzen.FJ:
                                            break;
                                        case Cl_Enumeradores.eCliente_Vzen.TALME:
                                            break;
                                        case Cl_Enumeradores.eCliente_Vzen.CAH:
                                            break;
                                        case Cl_Enumeradores.eCliente_Vzen.GENERAL:
                                            motivos.razon = item.observacion_Nota;
                                            break;
                                        default:
                                            motivos.razon = item.observacion_Nota;
                                            break;
                                    }
                                   


                                    motivos.valor = Convert.ToDecimal(subtotal);

                                    myObject.motivos.motivo.Add(motivos);
                                }

                                if (item2.vt_por_iva == 0)
                                {

                                    impue.codigo = "2";
                                    impue.codigoPorcentaje = "0";
                                    impue.tarifa = 0;
                                    impue.baseImponible = Convert.ToDecimal(subtotal);
                                    impue.valor = Math.Round(Convert.ToDecimal(item2.sc_iva), 2, MidpointRounding.AwayFromZero);

                                    myObject.infoNotaDebito.impuestos.Add(impue);

                                    switch (param.IdCliente_Ven_x_Default)
                                    {
                                        case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                                            motivos.razon = item.observacion_Nota;
                                            break;
                                        case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                                            motivos.razon = item.observacion_Nota;
                                            break;
                                        case Cl_Enumeradores.eCliente_Vzen.FJ:
                                            break;
                                        case Cl_Enumeradores.eCliente_Vzen.TALME:
                                            break;
                                        case Cl_Enumeradores.eCliente_Vzen.CAH:
                                            break;
                                        case Cl_Enumeradores.eCliente_Vzen.GENERAL:
                                            motivos.razon = item.observacion_Nota;
                                            break;
                                        default:
                                            motivos.razon = item.observacion_Nota;
                                            break;
                                    }

                                    motivos.valor = Convert.ToDecimal(subtotal);

                                    myObject.motivos.motivo.Add(motivos);

                                }

                                if (item2.vt_por_iva == 14)
                                {

                                    impue.codigo = "2";
                                    impue.codigoPorcentaje = "3";
                                    impue.tarifa = 14;
                                    impue.baseImponible = Convert.ToDecimal(subtotal);
                                    impue.valor = Math.Round(Convert.ToDecimal(item2.sc_iva), 2, MidpointRounding.AwayFromZero);

                                    myObject.infoNotaDebito.impuestos.Add(impue);


                                    switch (param.IdCliente_Ven_x_Default)
                                    {
                                        case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                                            motivos.razon = item.observacion_Nota;
                                            break;
                                        case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                                            motivos.razon = item.observacion_Nota;
                                            break;
                                        case Cl_Enumeradores.eCliente_Vzen.FJ:
                                            break;
                                        case Cl_Enumeradores.eCliente_Vzen.TALME:
                                            break;
                                        case Cl_Enumeradores.eCliente_Vzen.CAH:
                                            break;
                                        case Cl_Enumeradores.eCliente_Vzen.GENERAL:
                                            motivos.razon = item.observacion_Nota;
                                            break;
                                        default:
                                            motivos.razon = item.observacion_Nota;
                                            break;
                                    }


                                    motivos.valor = Convert.ToDecimal(subtotal);

                                    myObject.motivos.motivo.Add(motivos);

                                }

                            }

                            myObject.infoNotaDebito.totalSinImpuestos = Convert.ToDecimal(sum_totsinImp);
                            myObject.infoNotaDebito.valorTotal = Convert.ToDecimal(sum_Total);


                            if (!String.IsNullOrEmpty(item.pe_correo))
                            {
                                campoAdicional = item.pe_correo;

                                // campos adicionales 
                                Cl_ValidarEmail_Info datosAdc = new Cl_ValidarEmail_Info();

                                if (datosAdc.email_bien_escrito(campoAdicional) == true)
                                {
                                    notaDebitoCampoAdicional compoadicional = new notaDebitoCampoAdicional();
                                    compoadicional.nombre = "MAIL";
                                    compoadicional.Value = campoAdicional;
                                    myObject.infoAdicional = new List<notaDebitoCampoAdicional>();
                                    myObject.infoAdicional.Add(compoadicional);
                                }

                            }

                            lista.Add(myObject);
                        }
                    }

                }

                msg = "Archivo XML de Nota de Débito Generado con Exito";
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

      

    }
}
