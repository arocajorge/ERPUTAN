using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;

namespace Core.Erp.Winform.Facturacion
{ //version 1.0
    public partial class frmFa_Secuencia_Documento_Talonario_Mant : Form
    {
       // #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        UCIn_Sucursal_Bodega UCSucursal = new UCIn_Sucursal_Bodega();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_Secuencia_Documento_Talonario_Bus busTipoDoc = new fa_Secuencia_Documento_Talonario_Bus();
        public fa_Secuencia_Documento_Talonario_Info info;
        public List<fa_Secuencia_Documento_Talonario_Info> listaDocTalo = new List<fa_Secuencia_Documento_Talonario_Info>();
        List<fa_Documento_Tipo_info> lmTipoDoc = new List<fa_Documento_Tipo_info>();
        DataTable tablaTipoDoc = new DataTable();
        private Cl_Enumeradores.eTipo_action _Accion;
        public delegate void Delegate_frmFa_Secuencia_Documento_Talonario_Mant_FormClosing();
        public event Delegate_frmFa_Secuencia_Documento_Talonario_Mant_FormClosing event_frmFa_Secuencia_Documento_Talonario_Mant_FormClosing;


    //    #endregion

        public frmFa_Secuencia_Documento_Talonario_Mant()
        {
            try
            {
              InitializeComponent();
              //ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
              //ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
              //ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
              //ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

    //    void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
    //    {
    //        try
    //        {
    //            this.Close();
    //        }
    //        catch (Exception ex)
    //        {
    //            Log_Error_bus.Log_Error(ex.ToString());
    //        }

    //    }

    //    void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
    //    {
           
    //    }

    //    void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
    //    {
    //        try
    //        {
    //            get();
    //            txtFoco.Focus();
    //            if (validar()) { return; }
    //            //if (btnGuardarYsalir.Text == "Actualizar y Salir") 
    //           // if (_Accion != Cl_Enumeradores.eTipo_action.actualizar)
    //            //{
    //                if (busTipoDoc.ModificarDB(info))
    //                {
    //                    MessageBox.Show("Actualizado con Exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    //                } this.Close();
    //                return;
    //           // }
    //            if (busTipoDoc.GuardarDB(info)) { MessageBox.Show("Guardado con Exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
    //            this.Close();
    //        }
    //        catch (Exception ex)
    //        {
    //            Log_Error_bus.Log_Error(ex.ToString());
    //        }
    //    }

    //    void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
    //    {
    //        try
    //        {
    //            get();
    //            txtFoco.Focus();
    //            if (validar()) { return; }
    //            if (_Accion != Cl_Enumeradores.eTipo_action.actualizar)
    //            {
    //                if (busTipoDoc.ModificarDB(info))
    //                {
    //                    MessageBox.Show("Actualizado con Exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    //                }
    //                return;
    //            }
    //            if (busTipoDoc.GuardarDB(info))
    //            {
    //                MessageBox.Show("Guardado con Exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    //                bloquear();
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Log_Error_bus.Log_Error(ex.ToString());
    //        }
    //    }

        private void frmFA_Secuencia_Documento_Talonario_Load(object sender, EventArgs e)
        {
            try
            {
                //UCSucursal.Dock = DockStyle.Fill;
                //UCSucursal.TipoCarga = Info.General.Cl_Enumeradores.eTipoFiltro.Normal;

                //panel1.Controls.Add(UCSucursal);
                //setUltaCmb();
                //set();
                //switch (_Accion)
                //{
                //    case Cl_Enumeradores.eTipo_action.grabar:
                //        ucGe_Menu.Visible_btnGuardar = true;
                //        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                //        break;
                //    case Cl_Enumeradores.eTipo_action.actualizar:

                //        ucGe_Menu.Visible_btnGuardar = true;
                //        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                //        ultraCmbE_TipoDoc.Enabled = false;
                //        break;
                //    case Cl_Enumeradores.eTipo_action.Anular:
                //        ucGe_Menu.Visible_btnGuardar = false;
                //        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                //        ucGe_Menu.Enabled_bntAnular = true;

                //        break;
                //    case Cl_Enumeradores.eTipo_action.consultar:
                //        ucGe_Menu.Visible_btnGuardar = false;
                //        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                //        ucGe_Menu.Enabled_bntLimpiar = false;

                //        break;
                //}


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


    //    public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
    //    {
    //        try
    //        {
    //            _Accion = iAccion;
    //        }
    //        catch (Exception ex)
    //        {
    //            Log_Error_bus.Log_Error(ex.ToString());
    //        }

    //    }

    //    public void get() 
    //    {
    //        try
    //        {
                
    //            //int secuencia= 0;
    //            //try
    //            //{
    //            //    secuencia = info.Secuencia;
                    
    //            //}
    //            //catch (Exception ex)
    //            //{
    //            //    Log_Error_bus.Log_Error(ex.ToString());
    //            //} 
    //            info = new fa_Secuencia_Documento_Talonario_Info();
    //            info.Secuencia = Convert.ToInt32(txtsecuencia.Text);
    //            info.CodDocumentoTipo = ultraCmbE_TipoDoc.EditValue.ToString();
    //            info.IdEmpresa = param.IdEmpresa;
    //            info.IdSucursal = Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue);
    //            info.IdBodega = Convert.ToInt32(UCSucursal.cmb_bodega.EditValue);
    //            info.Serie1 = txtSerie1.Text;
    //            info.Serie2 = txtSerie2.Text;
    //            info.DocInicial = txtDocIni.Text;
    //            info.DocFinal = txtDocFin.Text;
    //            info.DocActual = txtDocAct.Text;
    //            info.NAutorizacion = txtAut.Text;
    //            info.FechaCaducidad = Convert.ToDateTime(dtFechaCad.Text);
    //            //info.Secuencia = secuencia;
    //            info.Estado = (chkEstado.Checked==true)?"A":"I";
    //        }
    //        catch (Exception ex)
    //        {
    //            Log_Error_bus.Log_Error(ex.ToString());
    //        }
    //    }

    //    public void set()
    //    {
    //        try
    //        {
    //            //info = new fa_Secuencia_Documento_Talonario_Info();
                 
                
    //             ultraCmbE_TipoDoc.EditValue = info.CodDocumentoTipo;
    //             UCSucursal.cmb_sucursal.EditValue = info.IdSucursal;
    //             UCSucursal.cmb_bodega.EditValue = info.IdBodega;
    //             txtsecuencia.EditValue = info.Secuencia;
    //             txtSerie1.Text=info.Serie1;
    //             txtSerie2.Text=info.Serie2;
    //             txtDocIni.Text=info.DocInicial;
    //             txtDocFin.Text=info.DocFinal;
    //             txtDocAct.Text=info.DocActual;
    //             txtAut.Text=info.NAutorizacion;
    //             dtFechaCad.Text=Convert.ToString(info.FechaCaducidad);
    //             chkEstado.Checked =(info.Estado=="A")?true:false;
    //        }
    //        catch (Exception ex) 
    //        {
    //            Log_Error_bus.Log_Error(ex.ToString());
    //            ultraCmbE_TipoDoc.EditValue = "FAC";
    //        }
    //    }

    //    private void creaTabla(List<fa_Documento_Tipo_info> Lista, DataTable tablaNCombo)
    //    {
    //        try
    //        {
    //            tablaNCombo.Columns.Add("Descripcion                                 _");
    //            tablaNCombo.Columns.Add("Codigo");
    //            foreach (var item in Lista)
    //            {
    //                DataRow filas;
    //                filas = tablaNCombo.NewRow();
    //                filas[0] = "[ "+item.codDocumentoTipo+" ] " + item.descripcion;
    //                filas[1] = item.codDocumentoTipo;
    //                tablaNCombo.Rows.Add(filas);
    //                tablaNCombo.AcceptChanges();
    //            }
    //        }
    //        catch (Exception ex)
    //        { Log_Error_bus.Log_Error(ex.ToString()); }
    //    }

    //    public void setUltaCmb()
    //    {
    //        try
    //        {
    //            lmTipoDoc = busTipoDoc.Get_List_Documento_Tipo_ApareceTalonario();
    //            creaTabla(lmTipoDoc, tablaTipoDoc);
    //            this.ultraCmbE_TipoDoc.Properties.DataSource = tablaTipoDoc;
    //            this.ultraCmbE_TipoDoc.Properties.DisplayMember = "Descripcion                                 _";
    //            this.ultraCmbE_TipoDoc.Properties.ValueMember = "Codigo";

    //        }
    //        catch (Exception ex)
    //        {
    //            Log_Error_bus.Log_Error(ex.ToString());
    //        }
    //    }

    //    public void limpiar()
    //    {
    //        try
    //        {
    //            txtAut.Text = txtDocAct.Text = txtDocFin.Text = txtDocIni.Text = txtSerie1.Text = txtSerie2.Text = "";
    //        }
    //        catch (Exception ex)
    //        {
    //            Log_Error_bus.Log_Error(ex.ToString());
    //        }
    //    }

    //    public Boolean validar() 
    //    {
    //        try
    //        {
    //            if (Convert.ToDecimal(txtDocAct.Text) < Convert.ToDecimal(txtDocIni.Text)) { MessageBox.Show("Ingrese el Doc. Actual Correcto"); txtDocAct.Focus(); txtDocAct.Text = txtDocIni.Text; return true; }

    //            if (Convert.ToDecimal(txtDocAct.Text) > Convert.ToDecimal(txtDocFin.Text)) { MessageBox.Show("Ingrese el Doc. Actual Correcto"); txtDocAct.Focus(); txtDocAct.Text = txtDocIni.Text; return true; }

    //            if (Convert.ToDecimal(txtDocIni.Text) > Convert.ToDecimal(txtDocFin.Text)) { MessageBox.Show("Ingrese el Doc. Inicial y Doc. Final Correcto"); txtDocFin.Focus(); return true; }

    //            if (txtAut.Text == "") { MessageBox.Show("Ingrese Autorizacion"); return true; }
    //            if (txtSerie1.Text == "") { MessageBox.Show("Ingrese la Serie"); txtSerie1.Focus(); return true; }
    //            if (txtSerie2.Text == "") { MessageBox.Show("Ingrese la Serie"); txtSerie2.Focus(); return true; }
    //            if (txtDocIni.Text == "") { MessageBox.Show("Ingrese el Doc. Inicial"); txtDocIni.Focus(); return true; }

    //            //if (btn_Guardar.Text != "Actualizar")
    //            if (_Accion != Cl_Enumeradores.eTipo_action.actualizar)
    //            {
    //                if (busTipoDoc.VerificarNumAutorizacionExiste(param.IdEmpresa, ultraCmbE_TipoDoc.EditValue.ToString(), txtAut.Text.Trim()))
    //                {
    //                    MessageBox.Show("El numero de autorizacion ingresado ya existe por favor ingrese uno diferente");
    //                    return true;
    //                }
    //            }

    //            return false;
    //        }
    //        catch (Exception ex)
    //        {
    //            Log_Error_bus.Log_Error(ex.ToString());
    //            return true;
    //        }
            
    //    }

    //    private void ultraCmbE_TipoDoc_Validating(object sender, CancelEventArgs e)
    //    {
    //        try
    //        {
    //            if (this.ultraCmbE_TipoDoc.EditValue == null)
    //            {
    //                ultraCmbE_TipoDoc.EditValue = "";
    //                return;
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Log_Error_bus.Log_Error(ex.ToString());
    //        }
    //    }
  
    //    private void bloquear()
    //    {
    //        try
    //        {
    //            ucGe_Menu.Visible_btnGuardar = false;
    //        }
    //        catch (Exception ex)
    //        {
    //            Log_Error_bus.Log_Error(ex.ToString());
    //        }
    //    }

    //    private void dtFechaCad_Validating(object sender, CancelEventArgs e)
    //    {
    //        try
    //        {
    //            if (dtFechaCad.Value < DateTime.Now) { MessageBox.Show("Eliga la fecha Correcta"); dtFechaCad.Value = DateTime.Now; }
    //        }
    //        catch (Exception ex)
    //        {
    //            Log_Error_bus.Log_Error(ex.ToString());
    //        }
    //    }

    //    private void txtDocIni_Validating(object sender, CancelEventArgs e)
    //    {
    //        try
    //        {
    //            if (_Accion != Cl_Enumeradores.eTipo_action.grabar)
    //            {
    //                var val = from c in listaDocTalo
    //                          where c.CodDocumentoTipo == Convert.ToString(ultraCmbE_TipoDoc.EditValue) && c.IdEmpresa == param.IdEmpresa && c.IdSucursal == Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue) && c.IdBodega == Convert.ToInt32(UCSucursal.cmb_bodega.EditValue) && c.Estado == "A"
    //                          select c.DocFinal;
    //                string v = "0";
    //                foreach (var item in val)
    //                {
    //                    v = item;
    //                }
    //                if (Convert.ToDecimal((txtDocIni.Text == "") ? "0" : txtDocIni.Text) < Convert.ToDecimal(v))
    //                {
    //                    MessageBox.Show("Colocar el Documento Inicial Correcto"); txtDocIni.Text = v;
    //                    v = v.TrimStart('0');
    //                    decimal x = 0;
    //                    x = Convert.ToDecimal(v) + 1;
    //                    v = x.ToString();
    //                    x = txtDocIni.Text.Length - v.Length;
    //                    txtDocIni.Text = v;
    //                    for (int i = 0; i < x; i++)
    //                    {
    //                        txtDocIni.Text = "0" + txtDocIni.Text;
    //                    }
    //                }
    //            }
    //            int ini = txtDocIni.Text.Length;
    //            int fin = txtDocIni.Text.Length - txtDocFin.Text.Length;
    //            int act = txtDocIni.Text.Length - txtDocAct.Text.Length;
    //                for (int i = 0; i < fin; i++)
    //                {
    //                    txtDocFin.Text = "0" + txtDocFin.Text;
    //                }
    //                for (int i = 0; i < act; i++)
    //                {
    //                    txtDocAct.Text = "0" + txtDocAct.Text;
    //                }
    //            if(fin<0){
    //                txtDocFin.Text=txtDocFin.Text.Substring(Math.Abs(fin));
    //                txtDocAct.Text=txtDocAct.Text.Substring(Math.Abs(act));

                   
    //            }
    //            }
            
    //        catch (Exception ex)
    //        {
    //            Log_Error_bus.Log_Error(ex.ToString());
    //        }
    //        txtDocAct.Text = txtDocIni.Text;
    //    }

    //    private void txtSerie1_Validating(object sender, CancelEventArgs e)
    //            {
    //                try
    //                {
    //                        if (txtSerie2.Text.Length < txtSerie1.Text.Length)
    //                        {
    //                            string cero = "";
    //                            for (int i = 0; i < (txtSerie1.Text.Length - txtSerie2.Text.Length); i++)
    //                            {
    //                                cero = "0" + cero;
    //                            }
    //                            txtSerie2.Text = cero + txtSerie2.Text;
    //                        }
    //                        if (txtSerie2.Text.Length > txtSerie1.Text.Length)
    //                        {
                                
    //                            txtSerie2.Text = txtSerie2.Text.Substring(txtSerie2.Text.Length - txtSerie1.Text.Length);
    //                        }

                        
    //                }
    //                catch (Exception ex)
    //                {
    //                    Log_Error_bus.Log_Error(ex.ToString());
    //                }
    //            }

    //    private void txtSerie2_Validating(object sender, CancelEventArgs e)
    //    {
    //        try
    //        {
                
    //                if (txtSerie2.Text.Length > txtSerie1.Text.Length)
    //                {
    //                    string cero = "";
    //                    for (int i = 0; i < (txtSerie2.Text.Length - txtSerie1.Text.Length); i++)
    //                    {
    //                        cero = "0" + cero;
    //                    }
    //                    txtSerie1.Text = cero + txtSerie1.Text;
    //                }
    //                if (txtSerie1.Text.Length > txtSerie2.Text.Length)
    //                {
    //                    txtSerie1.Text =txtSerie1.Text.Substring(txtSerie1.Text.Length - txtSerie2.Text.Length);
    //                }
                
    //        }
    //        catch (Exception ex)
    //        {
    //            Log_Error_bus.Log_Error(ex.ToString());
    //        }
    //    }

    //    private void txtDocFin_Validating(object sender, CancelEventArgs e)
    //    {
    //        try
    //        {
                
    //                if (Convert.ToDecimal((txtDocFin.Text == "") ? "0" : txtDocFin.Text) < Convert.ToDecimal((txtDocIni.Text == "") ? "0" : txtDocIni.Text))
    //                {
    //                    MessageBox.Show("Escriba el Documento Final Correcto");
    //                    txtDocFin.Focus();
    //                }
    //                int U = txtDocIni.Text.Length - txtDocFin.Text.Length;
    //                for (int i = 0; i < U; i++)
    //                {
    //                    txtDocFin.Text = "0" + txtDocFin.Text;
    //                }
    //                for (int i = 0; i < txtDocFin.Text.Length - txtDocIni.Text.Length; i++)
    //                {
    //                    txtDocFin.Text = txtDocFin.Text.Substring(txtDocFin.Text.Length - txtDocIni.Text.Length);
    //                }
                
    //        }
    //        catch (Exception ex)
    //        {
    //            Log_Error_bus.Log_Error(ex.ToString());
    //        }
    //    }

    //    private void txtDocAct_Validating(object sender, CancelEventArgs e)
    //    {
    //        try
    //        {                
    //            int U = txtDocIni.Text.Length - txtDocAct.Text.Length;
    //            for (int i = 0; i < U; i++)
    //            {
    //                txtDocAct.Text = "0" + txtDocAct.Text;
    //            }
    //            for (int i = 0; i < txtDocAct.Text.Length - txtDocIni.Text.Length; i++)
    //            {
    //                txtDocAct.Text = txtDocAct.Text.Substring(txtDocAct.Text.Length - txtDocIni.Text.Length);
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Log_Error_bus.Log_Error(ex.ToString());
    //        }
    //    }

    //    private void txtAut_Validating(object sender, CancelEventArgs e)
    //    {
    //        try
    //        {
    //            var val = from c in listaDocTalo
    //                      where c.CodDocumentoTipo == Convert.ToString(ultraCmbE_TipoDoc.EditValue) && c.IdEmpresa == param.IdEmpresa && c.IdSucursal == Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue) && c.IdBodega == Convert.ToInt32(UCSucursal.cmb_bodega.EditValue)
    //                      select c;//.NAutorizacion;
    //                string v = "0";
    //                //int secuencia = 0;
    //                foreach (var item in val)
    //                {
    //                    if (item.Secuencia == ((info == null) ? 0 : info.Secuencia)) { return; }
    //                    if (txtAut.Text == item.NAutorizacion) { MessageBox.Show("Numero de Autorizacion ya ha sido Utilizada"); txtAut.Focus(); }
                        
    //                }

                    
                
    //        }
    //        catch (Exception ex)
    //        {
    //            Log_Error_bus.Log_Error(ex.ToString());
    //        }
    //    }

    //    private void ultraCmbE_TipoDoc_ValueChanged(object sender, EventArgs e)
    //    {
    //        try
    //        {
    //            txtAut_Validating(new object(), new CancelEventArgs());
    //        }
    //        catch (Exception ex)
    //        {
    //            Log_Error_bus.Log_Error(ex.ToString());
    //        }
    //    }

    //    //private void ultraCmbE_TipoDoc_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
    //    //{

    //    //}

    //    //private void btnGuardarYsalir_Click(object sender, EventArgs e)
    //    //{
    //    //    try
    //    //    {
    //    //        get();
    //    //        txtFoco.Focus();
    //    //        if (validar()) { return; }
    //    //        //if (btnGuardarYsalir.Text == "Actualizar y Salir") 
    //    //        if (_Accion != Cl_Enumeradores.eTipo_action.actualizar)       
    //    //        { 
    //    //            if (busTipoDoc.Modificar(info)) 
    //    //            { MessageBox.Show("Actualizado con Exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    //    //            } this.Close(); 
    //    //            return; 
    //    //        }
    //    //        if (busTipoDoc.grabar(info)) { MessageBox.Show("Guardado con Exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
    //    //        this.Close();
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        Log_Error_bus.Log_Error(ex.ToString());
    //    //    }
    //    //}

    //    //private void btn_Guardar_Click(object sender, EventArgs e)
    //    //{
    //    //    try
    //    //    {
    //    //        get();
    //    //        txtFoco.Focus();
    //    //        if (validar()) { return; }
    //    //        if (_Accion != Cl_Enumeradores.eTipo_action.actualizar)
    //    //        {
    //    //            if (busTipoDoc.Modificar(info))
    //    //            {
    //    //                MessageBox.Show("Actualizado con Exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    //    //            }
    //    //            return;
    //    //        }
    //    //        if (busTipoDoc.grabar(info))
    //    //        {
    //    //            MessageBox.Show("Guardado con Exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    //    //            bloquear();
    //    //        }
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        Log_Error_bus.Log_Error(ex.ToString());
    //    //    }
    //    //}

    //    //private void btn_salir_Click(object sender, EventArgs e)
    //    //{
    //    //    try
    //    //    {
    //    //        this.Close();
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        Log_Error_bus.Log_Error(ex.ToString());
    //    //    }

    //    //}

    
    }
}
