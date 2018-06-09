using Core.Erp.Business.Bancos;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_DebitoCredito_Masivo : Form
    {

        #region variables declaradas
        List<ba_Cbte_Ban_Info> LstEmp = new List<ba_Cbte_Ban_Info>();
        ba_Banco_Cuenta_Bus banco_B = new ba_Banco_Cuenta_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> listParaBan = new List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info paramBa_I = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus paramBa_B = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();
        BindingList<ba_Cbte_Ban_Info> LstBin_CbteBan = new BindingList<ba_Cbte_Ban_Info>();

        ba_Banco_Cuenta_Info banco_I = new ba_Banco_Cuenta_Info();
        ct_Periodo_Info Per_I = new ct_Periodo_Info();
        ct_Periodo_Bus Per_B = new ct_Periodo_Bus();
        ba_Cbte_Ban_Info CbteBan_I = new ba_Cbte_Ban_Info();
        ct_Cbtecble_Info cbtInfo = new ct_Cbtecble_Info();
        ba_Cbte_Ban_Bus CbteBan_B = new ba_Cbte_Ban_Bus();
        string esConsu = "N";
        ba_tipo_nota_Bus busTipoNota = new ba_tipo_nota_Bus();
        List<ba_tipo_nota_Info> ListTipoNota = new List<ba_tipo_nota_Info>();
        ba_tipo_nota_Info tinfo = new ba_tipo_nota_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string ctaCble_acreedora;
        int IdTipoCbte;
        List<ba_notasDebCre_masivo_Info> listNotaMasiva = new List<ba_notasDebCre_masivo_Info>();
        ba_notasDebCre_masivo_Bus NotaMasi_B = new ba_notasDebCre_masivo_Bus();
        string cod_CbteCble;
        ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
        decimal IdCbteCble;
        decimal secuencial = 1;
        int error = 0;
        string MensajeError = "";
        public delegate void delegate_FrmBA_DebitoCredito_Masivo_FormClosing();
        public event delegate_FrmBA_DebitoCredito_Masivo_FormClosing event_FrmBA_DebitoCredito_Masivo_FormClosing;


        #endregion

        public FrmBA_DebitoCredito_Masivo()
        {
            InitializeComponent();
            try
            {
                event_FrmBA_DebitoCredito_Masivo_FormClosing += FrmBA_DebitoCredito_Masivo_event_FrmBA_DebitoCredito_Masivo_FormClosing;
                this.ultraCmbCtaBanco.Properties.DataSource = banco_B.Get_list_Banco_Cuenta(param.IdEmpresa);
                this.ultraCmbCtaBanco.Properties.DisplayMember = "ba_descripcion";
                this.ultraCmbCtaBanco.Properties.ValueMember = "IdBanco";
                if (!ValidaParametros("NDBA"))
                {
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;
                }

                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return;
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LstBin_CbteBan = new BindingList<ba_Cbte_Ban_Info>();
                gridControl_CbteBan.DataSource = LstBin_CbteBan;
                secuencial = 1;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                    this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void FrmBA_DebitoCredito_Masivo_event_FrmBA_DebitoCredito_Masivo_FormClosing()
        {

        }
        
        public Boolean ValidaParametros(string TipoCbtBan)
        {
            try
            {

                listParaBan = paramBa_B.Get_List_Banco_Parametros(param.IdEmpresa);
                paramBa_I = listParaBan.Find(delegate(ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info P) { return P.CodTipoCbteBan == TipoCbtBan; });

                if (paramBa_I == null)
                {
                    MessageBox.Show("No puede continuar porque no han ingresado los parámetros de banco..\n Ingréselos desde la pantalla de parámetros de banco o, comuníquese  con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ucGe_Menu.Visible_btnGuardar = false;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    return false;

                }
                else
                {
                    if ( paramBa_I.IdTipoCbteCble == null || paramBa_I.IdTipoCbteCble < 1 || paramBa_I.IdTipoCbteCble_Anu == null || paramBa_I.IdTipoCbteCble_Anu < 1)
                    {
                        MessageBox.Show("No puede continuar porque están incompletos los parámetros de banco.. \n Ingréselos desde la pantalla de parámetros de banco o, comuníquese  con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        return false;
                    }
                    else
                    {
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        
                    }
                }


                
                IdTipoCbte = paramBa_I.IdTipoCbteCble;
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

        private void FrmBA_DebitoCredito_Masivo_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl_CbteBan.DataSource = LstBin_CbteBan;
                ListTipoNota = busTipoNota.Get_List_tipo_nota(param.IdEmpresa);
                if (rB_Credito.Checked == true)
                    cmbTipoNota.DataSource = ListTipoNota.FindAll(q => q.Tipo == "NCBA");
                else
                    cmbTipoNota.DataSource = ListTipoNota.FindAll(q => q.Tipo == "NDBA");


                if (esConsu == "S")
                {
                    gridView_CbteBan.OptionsBehavior.ReadOnly = true;
                  //  colbtnCons.Visible = true;
//                    colIdCbteCble.Visible = true;
                    ultraCmbCtaBanco.EditValue = true;
                    ultraCmbCtaBanco.Properties.Appearance.BackColor = Color.White;
                    groupBox3.Enabled = false;
                    ucGe_Menu.Visible_btnGuardar = false;
                    ucGe_Menu.Enabled_bntLimpiar = false;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    
                    List<ba_Cbte_Ban_Info> lstCbt = new List<ba_Cbte_Ban_Info>();
                    lstCbt = CbteBan_B.Get_List_X_NotasMasivas(listNotaMasiva,ref MensajeError);
                    secuencial = 1;
                    lstCbt.ForEach(q => {q.cb_secuencia = secuencial++;q.btnCons = (Bitmap)imageList1.Images[0];});
                    gridControl_CbteBan.DataSource = lstCbt;

                   
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ultraCmbCtaBanco_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                banco_I = (ba_Banco_Cuenta_Info)ultraCmbCtaBanco.EditValue;    //.SelectedItem.ListObject;
                if (banco_I != null)
                    if (banco_I.IdCtaCble == null)
                    {
                        MessageBox.Show("La Cuenta Bancaria seleccionada no esta relacionada a una cuenta Contable", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ultraCmbCtaBanco.EditValue = "";
                    }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void rB_Debito_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rB_Debito.Checked == true)
                    if (!ValidaParametros("NDBA"))
                    {
                        this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        this.ucGe_Menu.Visible_btnGuardar = false;
                    }
                    else 
                    {
                        cmbTipoNota.DataSource = ListTipoNota.FindAll(q => q.Tipo == "NDBA");
                        this.ucGe_Menu_event_btnlimpiar_Click(sender,e);
                    }
            }
            catch (Exception ex)
            {
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        private void rB_Credito_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rB_Credito.Checked == true)
                    if (!ValidaParametros("NCBA"))
                    {
                        this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        this.ucGe_Menu.Visible_btnGuardar = false;
                    }
                    else
                    {
                        cmbTipoNota.DataSource = ListTipoNota.FindAll(q => q.Tipo == "NCBA");
                        this.ucGe_Menu_event_btnlimpiar_Click(sender,e);
                    }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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

        void cargadata()
        {
            try
            {
              //  LstBin_CbteBan = new BindingList<ba_Cbte_Ban_Info>();
                string[] data = ClipboardData.Split('\n');
                if (data.Length < 1) return;
                foreach (string row in data)
                {
                    if (!AddRow(row))
                        break;
                }

                //                if (error > 0) { MessageBox.Show("Hay registros sin motivos validos. Por favor corrija, no podrá grabarlos..."); error = 0; }

                gridControl_CbteBan.DataSource = LstBin_CbteBan;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
           
        }

        private void gridView_CbteBan_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == colIdTipoNota)
                {
                    ba_tipo_nota_Info tipo = new ba_tipo_nota_Info();
                    ba_Cbte_Ban_Info row = (ba_Cbte_Ban_Info)gridView_CbteBan.GetFocusedRow();
                    int IdTipoNota;
                    IdTipoNota = Convert.ToInt32(e.Value);
                    try
                    {
                        if (row != null)
                        {
                            if (rB_Debito.Checked == true)
                                tipo = ListTipoNota.FirstOrDefault(q => q.IdTipoNota == IdTipoNota && q.Tipo == "NDBA");
                            else if (rB_Credito.Checked == true)
                                tipo = ListTipoNota.FirstOrDefault(q => q.IdTipoNota == IdTipoNota && q.Tipo == "NCBA");

                            if (tipo == null || tipo.IdCtaCble == null)
                            {
                                MessageBox.Show("El motivo seleccionado no tiene asignada una Cta Cble...");
                                LstBin_CbteBan.ToList().Find(q => q.cb_secuencia == row.cb_secuencia).IdTipoNota = null;
                                gridView_CbteBan.SetFocusedRowCellValue(colError, "S");
                            }else
                                gridView_CbteBan.SetFocusedRowCellValue(colError, "N");
                        }
                    }
                    catch (Exception ex)
                    {
                        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                        gridView_CbteBan.SetFocusedRowCellValue(colError, "S");
                        LstBin_CbteBan.ToList().Find(q => q.cb_secuencia == row.cb_secuencia).IdTipoNota = null;

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
        
        private Boolean AddRow(string data)
        {
           
            try
            {
                if (string.IsNullOrWhiteSpace(data)) return false;
                string[] rowData = data.Split(new char[] { '\r', '\x09' });
                ba_Cbte_Ban_Info newRow = new ba_Cbte_Ban_Info();

                if (rowData.Count() >= 4)
                {
                    newRow.cb_Observacion = rowData[3];
                    string TipoNota = "";
                    TipoNota = Convert.ToString(rowData[1]);
                    try
                    {
                        if (rB_Debito.Checked == true)
                        {
                            ba_tipo_nota_Info tipo = ListTipoNota.FirstOrDefault(q => q.Descripcion == TipoNota &&
                            q.Tipo == "NDBA");
                            newRow.IdTipoNota = tipo.IdTipoNota;
                            if (String.IsNullOrEmpty(tipo.IdCtaCble))
                            {
                                newRow._Error = "S";
                            }
                        }
                        else if (rB_Credito.Checked == true)
                        {
                            ba_tipo_nota_Info tipo = ListTipoNota.FirstOrDefault(q => q.Descripcion == TipoNota &&
                                                     q.Tipo == "NCBA");
                            newRow.IdTipoNota = tipo.IdTipoNota;
                            if (String.IsNullOrEmpty(tipo.IdCtaCble))
                            {
                                newRow._Error = "S";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                        newRow._Error = "S"; error++;

                    }
                    DateTime dt;
                    if (DateTime.TryParse(rowData[0], out dt))
                    {
                        newRow.cb_Fecha = Convert.ToDateTime(rowData[0]);
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese una fecha válida. \n Formato fecha: 30/12/2000");
                        return false;
                    }

                    double sad;
                    if (double.TryParse(rowData[2], out sad))
                    {
                        //newRow.FechaPago = Convert.ToDateTime(rowData[1]);
                        newRow.cb_Valor = Convert.ToDouble(rowData[2]);
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese un valor válido. \n Formato númerico");
                        return false;
                    }

                    
                    newRow.cb_secuencia = secuencial++;
                    LstBin_CbteBan.Add(newRow);
                    return true;
                }
                else
                {
                    MessageBox.Show("No hay las columnas necesarias para insertar al registros");
                    return false;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
           
        }

        private void evento_cargardata(object sender, EventArgs e)
        {
            try
            {
                cargadata();
                gridControl_CbteBan.RefreshDataSource();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        
        private void ultraCmbCtaBanco_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.ultraCmbCtaBanco.EditValue == null)
                { ultraCmbCtaBanco.EditValue = ""; }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
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

        private bool valida()
        {
            try
            {
                Boolean estado = true;
                string MensajeError = "";
                ba_tipo_nota_Info tipo2 = new ba_tipo_nota_Info();
                Per_I = Per_B.Get_Info_Periodo(param.IdEmpresa, dt_fechaCbte.Value, ref MensajeError);
                
                if (Per_I.pe_estado == "I")
                {
                    MessageBox.Show("No se procedio a Grabar porque el Periodo se encuentra cerrado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }

                CbteCble_B.Get_list_Cbtecble(param.IdEmpresa, ref MensajeError);

                if (banco_I == null)
                {
                    MessageBox.Show("Seleccione La Cuenta Bancaria", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
                }
                if (tipo2.IdCtaCble == null)
                { 
                    
                    MessageBox.Show("La Cuenta Bancaria seleccionada no esta relacionada a una cuenta Contable", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ultraCmbCtaBanco.EditValue = "";
                    //return false;
                }
                string TipoNota = (rB_Debito.Checked == true) ? "NDBA" : "NCBA";
                foreach (ba_Cbte_Ban_Info row in LstBin_CbteBan )
                {
                    #region verifica motivos con sus ctas cbles
                    ba_tipo_nota_Info tipo = new ba_tipo_nota_Info(); 
                    try
                    {
                        if (row.IdTipoNota != null)
                        {
                              tipo = ListTipoNota.FirstOrDefault(q => q.IdTipoNota == row.IdTipoNota && q.Tipo == TipoNota);
                          
                            if (tipo == null || tipo.IdCtaCble == null)
                            {
                                MessageBox.Show("No podrá grabar, hay motivos que no tienen asignado la cta cble...");
                                row._Error = "S";
                                return false;
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("Todos las Notas (Débito/Crédito) deben tener un motivo.");
                            row._Error = "S";
                            return false;
                        }


                    }
                    catch (Exception ex)
                    {
                        Log_Error_bus.Log_Error(ex.ToString());
                        MessageBox.Show("No podrá grabar, hay motivos que no tienen asignado la cta cble..."+
                            "\r Por favor verifique los registros de color rojo.");
                        row._Error = "S";
                    }
                    #endregion


                    #region valida fecha y valor
                    if (row.cb_Valor <= 0 || row.cb_Valor == null ) 
                    {
                        MessageBox.Show("Todos las Notas (Débito/Crédito) deben tener un valor mayor a cero.");
                        return false;
                    }

                    if (row.cb_Fecha == new DateTime()|| row.cb_Fecha == null)
                    {
                        MessageBox.Show("Asigne valores validos para la fecha.");
                        return false;
                    }
                    #endregion

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

        public ct_Cbtecble_Info get_CbteCble(double valor, string obser, int IdTipoNota, DateTime fecha)
        {
            try
            {
                ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();

                string ctaCble = "", dc = "";
                int a = 0;
                List<ct_Cbtecble_det_Info> listaDetCbte = new List<ct_Cbtecble_det_Info>();
                ct_Cbtecble_det_Info DetCbte = new ct_Cbtecble_det_Info();
                ctaCble = ctaCble_acreedora;
                if (rB_Debito.Checked == true)
                {
                    a = 1;
                    dc = "Debito Masivo ";
                }
                else
                {
                    a = 2;
                    dc = "Credito Masivo ";
                }
                DetCbte.IdTipoCbte = IdTipoCbte;
                DetCbte.IdEmpresa = param.IdEmpresa;
                DetCbte.IdCtaCble = (this.ultraCmbCtaBanco.EditValue == null) ? "" : (banco_I.IdCtaCble == null) ? "" : banco_I.IdCtaCble.Trim();
                DetCbte.dc_Valor = (a == 1) ? valor * -1 : valor;
                //                DetCbte.dc_Valor = valor; 
                DetCbte.dc_Observacion = obser+ dc;
                DetCbte.secuencia = 1;
                listaDetCbte.Add(DetCbte);

                ct_Cbtecble_det_Info DetCbte2 = new ct_Cbtecble_det_Info();
                DetCbte2.IdTipoCbte = IdTipoCbte;
                DetCbte2.IdEmpresa = param.IdEmpresa;
                ctaCble = ListTipoNota.First(q => q.IdTipoNota == IdTipoNota).IdCtaCble;
                if (ctaCble == null)
                    return new ct_Cbtecble_Info();
                DetCbte2.IdCtaCble =  ctaCble.Trim();
                DetCbte2.dc_Valor = (a == 1) ? valor : valor * -1; //haber = txt_monto.Value;
                //                DetCbte2.dc_Valor =valor * -1;
                DetCbte2.dc_Observacion = obser + dc;
                DetCbte2.secuencia = 2;
                listaDetCbte.Add(DetCbte2);

                CbteCble_I.IdEmpresa = param.IdEmpresa;
                CbteCble_I.IdTipoCbte = IdTipoCbte;
                //CbteCble_I.CodCbteCble = "";
                CbteCble_I.IdPeriodo = Per_I.IdPeriodo;
                CbteCble_I.cb_Fecha = DateTime.Now;//Convert.ToDateTime(fecha.ToShortDateString());
                CbteCble_I.cb_Valor = valor;
                CbteCble_I.cb_Observacion = obser + dc; ;
                CbteCble_I.Secuencia = 0;
                CbteCble_I.Estado = "A";
                CbteCble_I.Anio = CbteCble_I.cb_Fecha.Year;
                CbteCble_I.Mes = CbteCble_I.cb_Fecha.Month;
                CbteCble_I.IdUsuario = param.IdUsuario;
                CbteCble_I.IdUsuarioUltModi = param.IdUsuario;
                CbteCble_I.cb_FechaTransac = param.Fecha_Transac;
                CbteCble_I.cb_FechaUltModi = param.Fecha_Transac;
                CbteCble_I.Mayorizado = "N";
                //  CbteCble_I.IdCbteCble = IdCbteCble;
                CbteCble_I._cbteCble_det_lista_info = listaDetCbte;
                return CbteCble_I;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ct_Cbtecble_Info();
            }
        }

        public ba_Cbte_Ban_Info get_CbteBan(double valor, string obs, int idTipoNota, DateTime fecha)
        {
            try
            {
                CbteBan_I.IdEmpresa = param.IdEmpresa;
                CbteBan_I.IdTipocbte = IdTipoCbte;
                CbteBan_I.IdCbteCble = IdCbteCble;
                CbteBan_I.Cod_Cbtecble = cod_CbteCble;
                CbteBan_I.IdPeriodo = Per_I.IdPeriodo;
                CbteBan_I.IdBanco = (CbteBan_I.IdBanco == null || CbteBan_I.IdBanco < 1) ? banco_I.IdBanco : CbteBan_I.IdBanco;
                CbteBan_I.cb_Fecha = DateTime.Now; //Convert.ToDateTime( fecha.ToShortDateString());
                CbteBan_I.cb_Observacion = obs;
                CbteBan_I.cb_secuencia =  0;
                CbteBan_I.IdTipoNota = idTipoNota;
                CbteBan_I.cb_Valor = valor;
                CbteBan_I.Estado = "A";
                CbteBan_I.IdUsuario = param.IdUsuario;
                CbteBan_I.IdUsuario_Anu = param.IdUsuario;
                CbteBan_I.FechaAnulacion = param.Fecha_Transac;
                CbteBan_I.Fecha_Transac = param.Fecha_Transac;
                CbteBan_I.Fecha_UltMod = param.Fecha_Transac;
                CbteBan_I.IdUsuarioUltMod = param.IdUsuario;
                CbteBan_I.ip = param.ip;
                CbteBan_I.nom_pc = param.nom_pc;

                return CbteBan_I;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ba_Cbte_Ban_Info();
            }
        }

        public void set(ba_notasDebCre_masivo_Info info, Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                switch (_Accion)
                {
                  
                    case Cl_Enumeradores.eTipo_action.consultar:
                       ucGe_Menu.Visible_btnGuardar = false;
                       ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        listNotaMasiva.Clear();
                        txt_Memo.Text = info.Observacion;
                        txt_idTransaccion.Text = Convert .ToString( info.IdTransaccion);
                        listNotaMasiva = NotaMasi_B.Get_List_notasDebCre_masivo_(info.IdEmpresa, info.IdTransaccion);
                            List<vwba_notasDebCre_masivo_Info> listado = new List<vwba_notasDebCre_masivo_Info>();
                            listado = NotaMasi_B.Get_List_notasDebCre_masivo(info.IdEmpresa, info.IdTransaccion);
                            
                            if (listado != null && listado.Count > 0)
                            {
                                var reg = listado.First();
                                //var c = listNotaMasiva.First();
                                if (info.Deb_Cred == "D")
                                    rB_Debito.Checked = true;
                                else if (info.Deb_Cred == "C")
                                    rB_Credito.Checked = true;
                                dt_fechaCbte.Value = info.fecha;
                                ultraCmbCtaBanco.EditValue = reg.tm_IdBanco;

                                esConsu = "S";
                            }
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public Boolean  Grabar()
        {
            try
            {
                 Boolean  res = false;
                        try
                        {
                            txt_Memo.Focus();
                            string msg = "";
                            ba_Cbte_Ban_Info info = new ba_Cbte_Ban_Info();
                            
                             
                            if (valida())
                            {
                                for (int i = 0; i < gridView_CbteBan.RowCount; i++)
                                {
                                    if (info != null)
                                    {
                                        if (CbteCble_B.GrabarDB(get_CbteCble(info.cb_Valor, info.cb_Observacion,Convert.ToInt32(info.IdTipoNota), info.cb_Fecha), ref IdCbteCble, ref msg))
                                        {
                                            if (CbteBan_B.GrabarDB(get_CbteBan(info.cb_Valor, info.cb_Observacion, Convert.ToInt32(info.IdTipoNota), info.cb_Fecha ),ref MensajeError))
                                            {
                                                ba_notasDebCre_masivo_Info infoNota = new ba_notasDebCre_masivo_Info();

                                                infoNota.IdEmpresa = param.IdEmpresa;
                                                infoNota.IdCbteCble_cb = IdCbteCble;
                                                infoNota.IdEmpresa_cb = param.IdEmpresa;
                                                infoNota.IdTipocbte_cb = IdTipoCbte;
                                                infoNota.Observacion = txt_Memo.Text.Trim();
                                                infoNota.fecha = Convert.ToDateTime( dt_fechaCbte.Value.ToShortDateString());
                                                infoNota.Fecha_Transac = param.Fecha_Transac;
                                                infoNota.Deb_Cred = rB_Credito.Checked == true ? "C" : "D";
                                                infoNota.IdUsuario = param.IdUsuario;
                                                infoNota.ip = param.ip;
                                                infoNota.nom_pc = param.nom_pc;

                                                listNotaMasiva.Add(infoNota);
                                            }
                                            else { MessageBox.Show(msg); return false; }
                                        }
                                        else return false;
                                    }
                                }
                                decimal IdTransaccion = 0;
                                if (NotaMasi_B.GuardarDB(listNotaMasiva, ref IdTransaccion, param.IdEmpresa))
                                {
                                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Transacción de Notas Masivas ", IdTransaccion);
                                    MessageBox.Show(smensaje, param.Nombre_sistema); 
                                    //MessageBox.Show("Se Guardo correctamente Transacción de Notas Masivas #" + IdTransaccion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ucGe_Menu.Visible_btnGuardar = false;
                                    ucGe_Menu.Enabled_bntLimpiar = false;
                                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                                    secuencial = 1;
                                    LstBin_CbteBan.ToList().ForEach(q => q.cb_secuencia = secuencial++);
                                    gridControl_CbteBan.DataSource = LstBin_CbteBan;

                        
                                }
                                else
                                {
                                    MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }

                                txt_idTransaccion.Text = IdTransaccion.ToString();
                            }

                            res = true;
                        }
                        catch (Exception ex)
                        {
                            Log_Error_bus.Log_Error(ex.ToString());
                        }
                        return res;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }
       
        private void FrmBA_DebitoCredito_Masivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              event_FrmBA_DebitoCredito_Masivo_FormClosing();
            }
            catch (Exception ex)
            {
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void gridView_CbteBan_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                #region pegar
                if (e.KeyCode == Keys.V && e.Control == true)
                {
                    cargadata();
                }
                #endregion
                #region delete
                if (e.KeyCode.ToString() == "Delete"|| esConsu != "S")
                {
                    gridView_CbteBan.DeleteSelectedRows();
                    secuencial = 1;
                    LstBin_CbteBan.ToList().ForEach(q => q.cb_secuencia = secuencial++);
                    gridControl_CbteBan.DataSource = LstBin_CbteBan;
                }

                #endregion
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
      
        private void gridView_CbteBan_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                ba_Cbte_Ban_Info info = gridView_CbteBan.GetRow(e.RowHandle) as ba_Cbte_Ban_Info;
                if (info == null)
                    return;
                if (info._Error == "S")
                { e.Appearance.ForeColor = Color.Red; lbl_error.Visible = true; }
                else e.Appearance.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void gridView_CbteBan_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
              try
            {
                if (esConsu == "S")
                {
               
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_event_FrmBA_DebitoCredito_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FrmBA_DebitoCredito_Masivo_Load(sender, e);
            }
            catch (Exception ex)
            {
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        
    }
}
