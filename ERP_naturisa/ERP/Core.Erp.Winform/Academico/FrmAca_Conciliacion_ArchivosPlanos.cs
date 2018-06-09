using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Info.Academico;
using System.Threading;
using DevExpress.XtraSplashScreen;
using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Business.Academico;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.Caja;
using Core.Erp.Business.Caja;
namespace Core.Erp.Winform.Academico
{
    public partial class FrmAca_Conciliacion_ArchivosPlanos : Form
    {
        public FrmAca_Conciliacion_ArchivosPlanos()
        {
            InitializeComponent();
            ucAca_SedeJornadaSeccionCurso.CargarCombos();
            ucBa_Proceso.cargar_CuentaBanco();
            cargar_combos();
            ucGe_Menu.btnGuardar.Text = "Procesar";
        }

        #region variables
        string MensajeError = "";
        public Cl_Enumeradores.eTipo_action Accion { get; set; }
        BindingList<ba_Archivo_Transferencia_Det_Info> BindingList_Archivo_Detalle = new BindingList<ba_Archivo_Transferencia_Det_Info>();
        ba_Archivo_Transferencia_Det_Bus Archivo_Detalle_Bus = new ba_Archivo_Transferencia_Det_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ba_Catalogo_Info> lista_catalogo = new List<ba_Catalogo_Info>();
        ba_Catalogo_Bus bus_catalogo = new ba_Catalogo_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<caj_Caja_Info> lista_caja = new List<caj_Caja_Info>();
        caj_Caja_Bus bus_caja = new caj_Caja_Bus();
        Aca_Parametros_Info parametro_info = new Aca_Parametros_Info();
        Aca_Parametros_Bus bus_parametro = new Aca_Parametros_Bus();
        //ebanco_procesos_bancarios_tipo IdProceso
        public ebanco_procesos_bancarios_tipo IdProceso { get; set; }
        #endregion

        public void Set(ba_Archivo_Transferencia_Info info)
        {
            try
            {
                ucBa_Proceso.cmb_Banco.EditValue = info.IdBanco;
                ucBa_Proceso.cmbProceso.EditValue = info.IdProceso_bancario;
                IdProceso = (ebanco_procesos_bancarios_tipo)Enum.Parse(typeof(ebanco_procesos_bancarios_tipo), info.IdProceso_bancario);
                txtId.EditValue = info.Observacion;
                txtId.EditValue = info.IdArchivo;
                info.Lst_Archivo_Transferencia_Det = Archivo_Detalle_Bus.Get_List_Archivo_transferencia_Det(info.IdEmpresa, param.IdInstitucion, Convert.ToInt32(info.IdArchivo));
                BindingList_Archivo_Detalle = new BindingList<Info.Bancos.ba_Archivo_Transferencia_Det_Info>(info.Lst_Archivo_Transferencia_Det);
                gridControl_pre_fac.DataSource = BindingList_Archivo_Detalle;
                if (info.Lst_Archivo_Transferencia_Det.Count() > 0)
                {
                    cmb_anio_lectivo.EditValue = info.Lst_Archivo_Transferencia_Det.FirstOrDefault().IdAnioLectivo_Col;
                    cmb_periodo.EditValue = info.Lst_Archivo_Transferencia_Det.FirstOrDefault().IdPeriodo_Col;
                    
                }

               

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

     
        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ProcesarDatos();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void FrmAca_Conciliacion_ArchivosPlanos_Load(object sender, EventArgs e)
        {

        }

        private void cargar_combos()
        {
            try
            {
                parametro_info = bus_parametro.Get_info_parametros(param.IdEmpresa, param.IdInstitucion);
                lista_catalogo = bus_catalogo.Get_List_Catalogo("ESTFIL_REG");
                cmb_estado.DataSource = lista_catalogo;
                cmb_estado.ValueMember = "IdCatalogo";
                cmb_estado.DisplayMember = "ca_descripcion";


                lista_caja = bus_caja.Get_list_caja(param.IdEmpresa, ref MensajeError);
                cmb_caja.Properties.DataSource = lista_caja;
                cmb_caja.EditValue = parametro_info.IdCaja_fact;
                    
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void gridView_pre_fac_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                // para pegar en las columnas en el mismo orden 
                if (e.KeyCode == Keys.V && e.Control == true)
                {
                    Pegar_Data();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Pegar_Data()
        {
            try
            {
                string[] data = ClipboardData.Split('\n');
                if (data.Length < 1) return;
                foreach (string row in data)
                {
                    switch (IdProceso)
                    {
                        case ebanco_procesos_bancarios_tipo.PAGO_BANCO_PACIFICO_BPA:
                           
                            break;
                        case ebanco_procesos_bancarios_tipo.PAGO_PROVEEDORES_BOL:
                            break;
                        case ebanco_procesos_bancarios_tipo.PAGO_PROVEEDORES_BP:
                            break;
                        
                        case ebanco_procesos_bancarios_tipo.PREAVISO_CHEQ:
                            break;
                        case ebanco_procesos_bancarios_tipo.ROL_ELECTRONICO_BG:
                            break;
                        case ebanco_procesos_bancarios_tipo.TRANSF_BANCARIA_BP:
                            break;
                       
                        case ebanco_procesos_bancarios_tipo.MASTERCARD_BOLIVARIANO:
                            break;
                        case ebanco_procesos_bancarios_tipo.DINER_PICHINCHA:
                            if (!Agregar_fila_Diner(row))
                                break;
                            break;
                        case ebanco_procesos_bancarios_tipo.BANCO_INTERNACIONAL:
                            break;
                        case ebanco_procesos_bancarios_tipo.PACIFICAR:
                            break;
                        default:
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        string ClipboardData
        {
            get
            {
                IDataObject iData = Clipboard.GetDataObject();
                if (iData == null) return "";

                if (iData.GetDataPresent(DataFormats.Text))
                    return (string)iData.GetData(DataFormats.Text);
                return "";
            }
            set { Clipboard.SetDataObject(value); }
        }


        private Boolean Agregar_fila_Diner(string data)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(data)) return false;
                string[] rowData = data.Split(new char[] { '\r', '\x09' });

                if (rowData.Count() == 5) //return false;          
                {


                    string CodigoCliente = Convert.ToString(rowData[0]);
                    string NumCuenta_Respuesta = Convert.ToString(rowData[1]);
                    string EstadoRespuesta = Convert.ToString(rowData[2]);
                    double Valor_procesado = Convert.ToDouble(rowData[3]);

                    if (string.IsNullOrWhiteSpace(CodigoCliente.ToString()) == false &&
                        string.IsNullOrWhiteSpace(NumCuenta_Respuesta.ToString()) == false &&
                        string.IsNullOrWhiteSpace(EstadoRespuesta.ToString()) == false &&
                        string.IsNullOrWhiteSpace(Valor_procesado.ToString()) == false)
                    {


                        foreach (var item in BindingList_Archivo_Detalle)
                        {
                            if (/*item.CodigoCliente == CodigoCliente &&*/
                                item.Numero_Documento == NumCuenta_Respuesta/* &&
                               item.IdEstadoRegistro_cat==EstadoRespuesta*/)
                            {
                                item.IdEstadoRegistro_cat = EstadoRespuesta;
                                item.Valor_procesado =Convert.ToDecimal( Valor_procesado);
                                item.NumCuenta_Respuesta = NumCuenta_Respuesta;
                                item.CodigoCliente = CodigoCliente;
                                break;
                            }
                            
                        }


                    }
                    

                }
                gridControl_pre_fac.DataSource = BindingList_Archivo_Detalle;
                gridControl_pre_fac.RefreshDataSource();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }
        private Boolean fx_Verificar_Reg_Repetidos(ba_prestamo_detalle_Info Info_det, Boolean eliminar, int tipo)
        {
            try
            {/*
                int cont = 0;



                if (banderaCargaBatch)
                {
                    cont = (from C in BindList_Ing_egr_inve_det
                            where C.cod_producto == Info_det.cod_producto
                            && C.dm_cantidad == Info_det.dm_cantidad
                            && C.mv_costo == Info_det.mv_costo
                            select C).Count();
                }
                else
                {
                    cont = (from C in lista_IngEgrInv
                            where C.cod_producto == Info_det.cod_producto
                            && C.dm_cantidad == Info_det.dm_cantidad
                            && C.mv_costo == Info_det.mv_costo
                            select C).Count();
                }


                if (cont == tipo)
                {
                    return true;
                }
                else
                {
                    if (eliminar == true)
                    {
                        gridViewProductos.DeleteRow(gridViewProductos.FocusedRowHandle);
                        MessageBox.Show("El producto con la misma cantidad y costo  ya se encuentra ingresado, se procederá con su eliminación.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("El producto ya se encuentra ingresado.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    return false;

                }
              * */

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }

        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProcesarDatos()
        {
            try
            {
                foreach (var item in BindingList_Archivo_Detalle)
                {
                    item.IdBanco_cta_Destino_trans = ucBa_Proceso.get_BaCuentaInfo().IdBanco;
                    Archivo_Detalle_Bus.GrabarCobros(item);
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        
    }
}
