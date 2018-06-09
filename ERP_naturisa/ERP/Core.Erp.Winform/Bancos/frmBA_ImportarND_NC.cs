using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Contabilidad;
using System.Data.OleDb;
using System.IO;
using Core.Erp.Info.General;
namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_ImportarND_NC : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string MensajeError = "";
        ct_Centro_costo_Bus busCentroCosto = new ct_Centro_costo_Bus();
        public FrmBA_ImportarND_NC()
        {
            try
            {
                InitializeComponent();
                GetList_NotadasDeb_Cred += frmBA_ImportarND_NC_GetList_NotadasDeb_Cred;
                cmbPlancta.DataSource = b_PlanCta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                ListaCombo =Bustiponota.Get_List_tipo_nota(param.IdEmpresa);
                cmbTipoNota.DataSource = ListaCombo;
                cmbCentroCosto.DataSource = busCentroCosto.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);
                cmbDinamico.SelectedValueChanged += cmbDinamico_SelectedValueChanged;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        public string IdCtaCbleBanco { get; set; }
        public int IdBanco { get; set; }
        void cmbDinamico_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var item = ListaCombo.First(c => c.Descripcion == ((DevExpress.XtraEditors.ComboBoxEdit)(sender)).EditValue.ToString());

                gridViewExcel.SetFocusedRowCellValue(gridColumn1, item.IdCtaCble);
                gridViewExcel.SetFocusedRowCellValue(IdTipoNota, item.IdTipoNota);
                gridViewExcel.SetFocusedRowCellValue(IdCentroCosto, item.IdCentroCosto);
                gridViewExcel.SetFocusedRowCellValue(gridColumn2, true);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        List<ba_tipo_nota_Info> ListaCombo = new List<ba_tipo_nota_Info>();
        ba_tipo_nota_Bus Bustiponota = new ba_tipo_nota_Bus();
        void frmBA_ImportarND_NC_GetList_NotadasDeb_Cred(List<vwba_TransaccionesAConciliar_Info> Sistema)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_Plancta_Bus b_PlanCta = new ct_Plancta_Bus();

        ba_Cbte_Ban_Bus BUSCOMPROBANTEBANCARIO = new ba_Cbte_Ban_Bus();

        List<ba_Cbte_Ban_Info> List_Ids;
        public FrmBA_ImportarND_NC(List<vwba_TransaccionesAConciliar_Info> Sistema):this()
        {
            try
            {
                if (Sistema.Count != 0)
                {
                    ListExcel = new BindingList<vwba_TransaccionesAConciliar_Info>(Sistema);

                    DateTime FechaMax = Sistema.Max(v => v.cb_Fecha);
                    DateTime FechaMin = Sistema.Min(v => v.cb_Fecha);

                    List_Ids = BUSCOMPROBANTEBANCARIO.Get_List_Cbte_Ban(param.IdEmpresa, Convert.ToDateTime(FechaMin.ToShortDateString()), Convert.ToDateTime(FechaMax.ToShortDateString()),ref MensajeError);



                    gridControlExcel.DataSource = ListExcel;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());               
            }
        }


        public delegate void Retornar_list(List<vwba_TransaccionesAConciliar_Info> Sistema);
        public event Retornar_list GetList_NotadasDeb_Cred;
        private void frmBA_ImportarND_NC_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            try
            {
                GetList_NotadasDeb_Cred(new List<vwba_TransaccionesAConciliar_Info>());
                Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        public string fileName { get; set; }
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus _BusCbtBanXCtbtCble = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();
        ct_Cbtecble_Bus BUS_CONTABILIDAD = new ct_Cbtecble_Bus();
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var ITEMS = ListExcel.ToList().FindAll(v => v.chk == true);


                if (!Validar())
                {
                    return;
                }


                ct_Periodo_Bus BusPeriodo = new ct_Periodo_Bus();
                ba_Cbte_Ban_Bus BUSBANCOSCOMPROBANTE = new ba_Cbte_Ban_Bus();
                List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> _Parametros_ = _BusCbtBanXCtbtCble.Get_List_Cbte_Ban_tipo_x_ct_CbteCble_tipo(param.IdEmpresa);

                foreach (var item in ITEMS)
                {
                    var prm = _Parametros_.First(v => v.CodTipoCbteBan == item.CodTipoCbteBan.Trim());
                    ct_Cbtecble_Info CabeceraCbte = new ct_Cbtecble_Info();
                    CabeceraCbte.IdEmpresa = param.IdEmpresa;
                    CabeceraCbte.IdTipoCbte = prm.IdTipoCbteCble;
                    CabeceraCbte.IdPeriodo = BusPeriodo.Get_Info_Periodo(param.IdEmpresa, item.cb_Fecha,ref MensajeError).IdPeriodo;
                    CabeceraCbte.IdUsuario = param.IdUsuario;
                    CabeceraCbte.IdUsuarioUltModi = param.IdUsuario;
                    CabeceraCbte.Mayorizado = "N";
                    CabeceraCbte.cb_Fecha = item.cb_Fecha;
                    CabeceraCbte.cb_Observacion = item.cb_Observacion;
                    CabeceraCbte.cb_Valor = item.dc_Valor;
                    CabeceraCbte.Estado = "A";
                    CabeceraCbte.cb_FechaTransac = param.Fecha_Transac;
                    CabeceraCbte.cb_FechaUltModi = CabeceraCbte.cb_FechaTransac;


                    ct_Cbtecble_det_Info DetalleInfo = new ct_Cbtecble_det_Info();
                    DetalleInfo.IdEmpresa = param.IdEmpresa;
                    DetalleInfo.IdTipoCbte = CabeceraCbte.IdEmpresa;
                    DetalleInfo.secuencia = 1;
                    DetalleInfo.IdCtaCble = IdCtaCbleBanco;
                    DetalleInfo.IdCentroCosto = item.IdCentroCosto;
                    if (item.CodTipoCbteBan == "NCBA")
                        DetalleInfo.dc_Valor = item.dc_Valor * -1;
                    if (item.CodTipoCbteBan == "NDBA")
                        DetalleInfo.dc_Valor = item.dc_Valor;
                    DetalleInfo.dc_Observacion = item.cb_Observacion;
                    CabeceraCbte._cbteCble_det_lista_info.Add(DetalleInfo);

                    DetalleInfo = new ct_Cbtecble_det_Info();
                    DetalleInfo.IdEmpresa = param.IdEmpresa;
                    DetalleInfo.IdTipoCbte = CabeceraCbte.IdEmpresa;
                    DetalleInfo.secuencia = 2;
                    DetalleInfo.IdCtaCble = item.IdCtaCble;
                    DetalleInfo.IdCentroCosto = item.IdCentroCosto;
                    if (item.CodTipoCbteBan == "NCBA")
                        DetalleInfo.dc_Valor = item.dc_Valor;
                    if (item.CodTipoCbteBan == "NDBA")
                        DetalleInfo.dc_Valor = item.dc_Valor * -1;
                    DetalleInfo.dc_Observacion = item.cb_Observacion;
                    CabeceraCbte._cbteCble_det_lista_info.Add(DetalleInfo);


                    decimal IdCbte = 0;
                    string Mensaje = "";
                    string Codigo = "";



                    BUS_CONTABILIDAD.GrabarDB(CabeceraCbte, ref IdCbte, ref Mensaje);

                    item.IdHASH = string.Format("{0}-MOVI_BAN$-s{1}-{2}-{3}-d{4}-{5}-{6}", fileName, item.SecuenciaRelacionado, item.cb_Fecha, item.CodTipoCbteBan, item.cb_Cheque, item.cb_Observacion, item.dc_Valor);
                    ba_Cbte_Ban_Info COMPROBANTEBANCARIO = new ba_Cbte_Ban_Info();
                    COMPROBANTEBANCARIO.IdEmpresa = param.IdEmpresa;
                    COMPROBANTEBANCARIO.IdCbteCble = IdCbte;
                    COMPROBANTEBANCARIO.IdTipocbte = CabeceraCbte.IdTipoCbte;
                    COMPROBANTEBANCARIO.Cod_Cbtecble = Codigo;
                    COMPROBANTEBANCARIO.IdPeriodo = CabeceraCbte.IdPeriodo;
                    COMPROBANTEBANCARIO.IdBanco = IdBanco;
                    COMPROBANTEBANCARIO.cb_Fecha = item.cb_Fecha;
                    COMPROBANTEBANCARIO.cb_Observacion = item.cb_Observacion;
                    COMPROBANTEBANCARIO.cb_Valor = item.dc_Valor;
                    COMPROBANTEBANCARIO.cb_ChequeImpreso = "N";
                    COMPROBANTEBANCARIO.IdUsuario = param.IdUsuario;
                    COMPROBANTEBANCARIO.IdUsuarioUltMod = param.IdUsuario;
                    COMPROBANTEBANCARIO.ip = param.ip;
                    COMPROBANTEBANCARIO.nom_pc = param.nom_pc;
                    COMPROBANTEBANCARIO.Fecha_Transac = param.Fecha_Transac;
                    COMPROBANTEBANCARIO.Fecha_UltMod = COMPROBANTEBANCARIO.Fecha_Transac;
                    //COMPROBANTEBANCARIO.IdTipoNota = null;
                    COMPROBANTEBANCARIO.IdTransaccion = item.IdHASH;
                    BUSBANCOSCOMPROBANTE.GrabarDB(COMPROBANTEBANCARIO,ref MensajeError);
                    item.IdCbteCble = IdCbte;
                    item.IdTipocbte = CabeceraCbte.IdTipoCbte;

                }

                GetList_NotadasDeb_Cred(ITEMS);
                Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        Boolean Validar()
        {
            try
            {
                var ITEMS = ListExcel.ToList().FindAll(v => v.chk == true);
                foreach (var item in ITEMS)
                {
                    if (string.IsNullOrEmpty(item.IdCtaCble))
                    {
                        MessageBox.Show("Existen elmentos que no tienen Cta. Contable");
                        return false;
                    }
                    if (item.dc_Valor <= 0)
                    {
                        MessageBox.Show("Existen montos en cero ");
                        return false;
                    }
                }
                return true;
            }   
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }


        private void gridViewExcel_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
              vwba_TransaccionesAConciliar_Info Item = gridViewExcel.GetFocusedRow() as vwba_TransaccionesAConciliar_Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }     
        }


        ba_Cbte_Ban_Bus BusCompro = new ba_Cbte_Ban_Bus();
        private void gridViewExcel_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            try
            {
                
                vwba_TransaccionesAConciliar_Info Item = gridViewExcel.GetFocusedRow() as vwba_TransaccionesAConciliar_Info;
              
                bool existe = BusCompro.VerificarExisteRegistroImportacion(Item.IdHASH,ref MensajeError);
                if (existe)
                {

                    gridViewExcel.OptionsBehavior.Editable = false;
                    MessageBox.Show("El item seleccionado ya se encuentra registrado en la base de datos");
                }
                else
                {
                    gridViewExcel.OptionsBehavior.Editable = true;
                }


                cmbDinamico.Items.Clear();
                if (gridViewExcel.GetFocusedRowCellValue(codigo_).ToString() == "NCBA")
                {
                    foreach (var item in ListaCombo.FindAll(c => c.Tipo == "NCBA"))
                    {
                        cmbDinamico.Items.Add(item.Descripcion);
                    }
                }
                if (gridViewExcel.GetFocusedRowCellValue(codigo_).ToString() == "NDBA")
                {
                    foreach (var item in ListaCombo.FindAll(c => c.Tipo == "NDBA"))
                    {
                        cmbDinamico.Items.Add(item.Descripcion);
                    }
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewExcel_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        } 


        //string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";
        Boolean CANCEL;
        void ObtenerRuta()
        {
            try
            {
                         //Te Declaras un Objeto de Tipo OpenFileDialog
                        OpenFileDialog dialogo = new OpenFileDialog();

                        dialogo.Filter = "All files (*.*)|*.*";
                        dialogo.InitialDirectory = @"C:\";
                        //para mostrar el cuadro de seleccion de archivo hacemos asi:

                        if (dialogo.ShowDialog() == DialogResult.OK)
                        {
                            fileName = System.IO.Path.GetFileName(dialogo.FileName);

                            path = Path.GetDirectoryName(dialogo.FileName);
                            tipofile = System.IO.Path.GetExtension(dialogo.FileName);

                            ruta = path + "\\" + fileName;
                            CANCEL = false;
                        }
                        else
                        {
                            CANCEL = true;
                        }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        DataTable ds = new DataTable();

        void CargarArchivoExcelADataTable()
        {
            try
            {

                String strconn = "";
                strconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=Excel 12.0;";
                OleDbConnection mconn = new OleDbConnection(strconn);
                //
                //El nombre de la hoja del archivo de marcaciones tiene que llamarse Marcaciones
                OleDbDataAdapter ad = new OleDbDataAdapter("Select * from [MOVI_BAN$]", mconn);

                //abre una conexion de tipo oledb
                mconn.Open();
                //Lo agrega a mi datatable
                ad.Fill(ds);
                //cierra una conexion de tipo oledb
                mconn.Close();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                ds = new DataTable();

            }
        }
        BindingList<vwba_TransaccionesAConciliar_Info> ListExcel = new BindingList<vwba_TransaccionesAConciliar_Info>();
        private void btnBuscarexcel_Click(object sender, EventArgs e)
        {
            try
            {
                 FrmBA_Bancos ofr = new FrmBA_Bancos();

                    ofr.ShowDialog();
                    int IdBancoTipo = ofr.IdBanco;
                    ObtenerRuta();
                    if (CANCEL)
                    {

                    }
                    else
                    {
                        ds = new DataTable();
                        ListExcel.Clear();
                        gridControlExcel.DataSource = ListExcel;

                        CargarArchivoExcelADataTable();
                        ListExcel.Clear();
                        ListExcel = new BindingList<vwba_TransaccionesAConciliar_Info>(ProcesarDataTableAInfo(ds));

                        foreach (var item in ListExcel)
                        {
                            item.IdHASH = string.Format("{0}-MOVI_BAN$-s{1}-{2}-{3}-d{4}-{5}-{6}", fileName, item.SecuenciaRelacionado, item.cb_Fecha, item.CodTipoCbteBan, item.cb_Cheque, item.cb_Observacion, item.dc_Valor);
                        }
                        if (ListExcel.Count == 0)
                        {
                            MessageBox.Show("El excel no cumple con el formato por favor consulte con sistemas", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ListExcel = new BindingList<vwba_TransaccionesAConciliar_Info>();
                            gridControlExcel.DataSource = ListExcel;
                            return;
                        }

                        gridControlExcel.DataSource = ListExcel;

                        //btn_cargarMovimientos_Click(sender, e);
                    }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


         ba_Cbte_Ban_tipo_x_CodBancoExterno_Bus bus_CodBcoExt = new ba_Cbte_Ban_tipo_x_CodBancoExterno_Bus();
        List<ba_Cbte_Ban_tipo_x_CodBancoExterno_Info > lst_ba_Info = new List<ba_Cbte_Ban_tipo_x_CodBancoExterno_Info>();
                public List<vwba_TransaccionesAConciliar_Info> ProcesarDataTableAInfo(DataTable ds)
                {
                    try
                    {
                        List<vwba_TransaccionesAConciliar_Info> lista = new List<vwba_TransaccionesAConciliar_Info>();
                            try{
                                lst_ba_Info = bus_CodBcoExt.Get_List_Cbte_Ban_tipo_x_CodBancoExterno();
                                //ro_Empleado_Data dataEmp = new ro_Empleado_Data();
                                if (ds.Columns.Count > 5)
                                {
                                    foreach (DataRow row in ds.Rows)
                                    {
                                        vwba_TransaccionesAConciliar_Info info = new vwba_TransaccionesAConciliar_Info();
                                        Boolean grabar = true;
                                        for (int col = 0; col < ds.Columns.Count + 1; col++)
                                        {
                                            switch (col)
                                            {
                                                case 0:
                                                    string SecuencialPropio = Convert.ToString(row[col]);
                                                    //int fe = Convert.ToInt32(fechaTrans);
                                                    int sec = 0;
                                                    if (Int32.TryParse(SecuencialPropio, out sec))
                                                    {
                                                        info.SecuenciaConciliacion = Convert.ToInt32(SecuencialPropio);
                                                    }
                                                    else {
                                                        col = ds.Columns.Count + 1; grabar = false;
                                                        //MessageBox.Show("El formato del excel no es el correcto por favor confirmar con sisetmas");
                                        
                                                        break;
                                        
                                                    }

                                                    break;

                                                case 1:
                                                    string fechaTrans = Convert.ToString(row[col]);
                                                    //int fe = Convert.ToInt32(fechaTrans);
                                                    DateTime dt;
                                                    if (DateTime.TryParse(fechaTrans, out dt))
                                                    {
                                                        info.cb_Fecha = Convert.ToDateTime(fechaTrans);
                                                    }
                                                    else { col = ds.Columns.Count + 1; grabar = false;
                                                        //MessageBox.Show("El formato del excel no es el correcto por favor confirmar con sisetmas"); 
                                                        break; }

                                                    break;
                                                case 2:

                                                    string Tipo = Convert.ToString(row[col]);
                                                    try
                                                    {
                                                        var a = lst_ba_Info.First(var => var.CodBanco == Tipo.Trim());
                                                        if (a != null)
                                                        {
                                                            info.CodTipoCbteBan = a.CodTipoCbteBan;
                                                            info.CodTipoCbte = Tipo.Trim();

                                                        }
                                                    }
                                                    catch (Exception)
                                                    {

                                                       col = ds.Columns.Count + 1; grabar = false; 
                                                        MessageBox.Show ("El Codigo del tipo de comprobante '"+Tipo+
                                                            "' no esta configurado...\rComuniquese con Sistemas.","Sistemas",
                                                            MessageBoxButtons.OK,MessageBoxIcon.Error );
                                                        break;
                                                    }
                                  
                                                    break;
                                                case 3:
                                                    string NumDoc = Convert.ToString(row[col]);
                                                    if (!String.IsNullOrWhiteSpace(NumDoc))
                                                        info.cb_Cheque = NumDoc;
                                                    break;
                                                case 4:
                                                    string Concepto = Convert.ToString(row[col]);
                                                    if (!String.IsNullOrWhiteSpace(Concepto))
                                                        info.cb_Observacion = Concepto;
                                                    break;
                                                case 5:
                                                    String Valor = Convert.ToString(row[col]);
                                                    string ab = Valor.Substring(0, 1);
                                                    if (ab == "$")
                                                        Valor = Valor.Substring(1);
                                    
                                                     Valor =   Valor.Replace('.', ',');
                                                     int q = 0;
                                                    int index =0;
                                                     for (int i = 0; i < Valor.Length; i++)
                                                     {
                                                         if (Valor[i] == ',') 
                                                         {
                                                             q++;
                                                             index = i;
                                                         }
                                                    }
                                                    if(q!=0)
                                                    {
                                                        Valor.Remove(index);
                                                    }
                                    
                                                    Double val = 0;
                                                    if (Double.TryParse(Valor, out val))
                                                    {
                                                        info.dc_Valor = Convert.ToDouble(Valor);
                                                    }
                                                    else { col = ds.Columns.Count + 1; grabar = false;
                                                        //MessageBox.Show("El formato del excel no es el correcto por favor confirmar con sisetmas");
                                                        break; }
                                                    break;
                                                case 6:
                                                    string Ref = Convert.ToString(row[col]);
                                                    if (!String.IsNullOrWhiteSpace(Ref))
                                                        info.cb_Observacion = info.cb_Observacion + " Ref:" + Ref;
                                                    break;
                                                default:
                                                    //grabar = false;
                                                    break;
                                            }
                                        }
                                        if (grabar != false)
                                            lista.Add(info);
                                        //else { return new List<vwba_TransaccionesAConciliar_Info>(); }
                                    }
                    
                    
                                }
                                else
                                {
                                    MensajeError = "Por favor verifique que el archivo tenga el formato correcto.\r Son 6  columnas.";
                                    lista = new List<vwba_TransaccionesAConciliar_Info>();
                                }
                                int k = 0;lista.ForEach(var => var.SecuenciaConciliacion = ++k);
                            }
                            catch (Exception ex)
                            {
                                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());           
                                lista = new List<vwba_TransaccionesAConciliar_Info>();
                            }
                            return lista;
                    }
                    catch (Exception ex)
                    {
                        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                        return new List<vwba_TransaccionesAConciliar_Info>();
                    }
           
                }
                
        }
    }

