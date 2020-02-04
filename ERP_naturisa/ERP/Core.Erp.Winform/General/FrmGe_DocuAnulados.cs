using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Core.Erp.Winform.General
{
    public partial class FrmGe_DocuAnulados : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Cl_Enumeradores.eTipo_action _Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Documento_Tipo_x_Empresa_Anulados_Info Doc_I = new tb_sis_Documento_Tipo_x_Empresa_Anulados_Info();
        tb_sis_Documento_Tipo_x_Empresa_Anulados_Bus Doc_B = new tb_sis_Documento_Tipo_x_Empresa_Anulados_Bus();
        tb_sis_Documento_Tipo_x_Empresa_Anulados_Info Info = new tb_sis_Documento_Tipo_x_Empresa_Anulados_Info();
        public tb_sis_Documento_Tipo_x_Empresa_Anulados_Info set { get; set; }
        public delegate void delegate_FrmGe_DocuAnulados_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmGe_DocuAnulados_FormClosing event_FrmGe_DocuAnulados_FormClosing;
        #endregion
        
        public FrmGe_DocuAnulados()
        {
            InitializeComponent();           
        }

        void carga_combos()
       {
           try
           {
               List<tb_sis_tipoDocumento_Info> lst = new List<tb_sis_tipoDocumento_Info>();
               tb_sis_tipoDocumento_Bus b = new tb_sis_tipoDocumento_Bus();
               lst = b.Get_List_sis_tipoDocumento();

               List<tb_Catalogo_Info> listCatalog= new List<tb_Catalogo_Info>();
               tb_Catalogo_Bus C_B = new tb_Catalogo_Bus();
               listCatalog=C_B.Get_List_MotivoAnulacion();
               listCatalog.ForEach(c=>c.ca_descripcion="[" + c.IdCatalogo+"] - " + c.ca_descripcion);

               cmbMotivoAnula.Properties.DataSource = listCatalog;
               cmbMotivoAnula.Properties.DisplayMember = "ca_descripcion";
               cmbMotivoAnula.Properties.ValueMember = "IdCatalogo";

               List<cp_TipoDocumento_Info> LstTipDoc = new List<cp_TipoDocumento_Info>();
               cp_TipoDocumento_Bus TipDoc_B = new cp_TipoDocumento_Bus();
               LstTipDoc = TipDoc_B.Get_List_TipoDocumento().FindAll(c => c.Estado == "A");
               LstTipDoc.ForEach(c => c.Descripcion = "[" + c.CodSRI + "] - " + c.Descripcion);
               cmbTipoDocu.Properties.DataSource = LstTipDoc;
               cmbTipoDocu.Properties.DisplayMember = "Descripcion";
               cmbTipoDocu.Properties.ValueMember = "CodTipoDocumento";
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
    
       }
        
        public void set_Info()
        {
            try
            {              
               
                cmbTipoDocu.EditValue = set.codDocumentoTipo;
                cmbMotivoAnula.EditValue = set.IdMotivoAnu;

                dtp_fecha.Value = set.Fecha;
                txt_AutSRI.Text = set.Autorizacion;
                txt_serie1.Text = set.Serie1;
                txt_docIni.Text = set.Documento;
                txt_serie2.Text = set.Serie2;
                txt_docFin.Text = set.Documento;
                txt_detalle.Text = set.MotivoAnu;

                Doc_I = set;
            }
            catch(Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void get_Info()
        {
            try
            {              
                Doc_I.codDocumentoTipo = Convert.ToString(cmbTipoDocu.EditValue);            
                Doc_I.IdMotivoAnu = Convert.ToInt32(cmbMotivoAnula.EditValue);
                Doc_I.Fecha = dtp_fecha.Value;
                Doc_I.Autorizacion = txt_AutSRI.Text;
                Doc_I.Serie1 = txt_serie1.Text.PadLeft(3, '0');
                Doc_I.Serie2 = txt_serie2.Text.PadLeft(3, '0');
                //Doc_I.Documento = txt_docIni.Text;
                //Doc_I.DocumentoFin = txt_docFin.Text;
                Doc_I.MotivoAnu = txt_detalle.Text;
                Doc_I.Fecha_Transac = param.Fecha_Transac;
                Doc_I.IdUsuario = param.IdUsuario;
                Doc_I.IdEmpresa = param.IdEmpresa;
                Doc_I.ip = param.ip;
                Doc_I.nom_pc = param.nom_pc;
                Doc_I.IdUsuarioUltAnu = param.IdUsuario;
                Doc_I.Fecha_UltAnu = param.Fecha_Transac;

                if(this.rb_Documento.Checked==true)
                {
                    Doc_I.Documento = txt_doc.Text.PadLeft(9,'0');
                    Doc_I.DocumentoFin = txt_doc.Text.PadLeft(9,'0');               
                }

                if (this.rb_Lote.Checked == true)
                {
                    Doc_I.Documento = txt_docIni.Text.PadLeft(9,'0');
                    Doc_I.DocumentoFin = txt_docFin.Text.PadLeft(9,'0');
                }
             
            }
            catch(Exception ex){
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGe_DocuAnulados_Load(object sender, EventArgs e)
        {
            try
            {
                                            
                carga_combos();
                
                this.event_FrmGe_DocuAnulados_FormClosing += FrmGe_DocuAnulados_event_FrmGe_DocuAnulados_FormClosing;


                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        if (rb_Documento.Checked == true)
                        {
                            groupBox2.Visible = false;

                        }

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        rb_Documento.Visible = false;
                        rb_Lote.Visible = false;
                        groupBox3.Visible = false;
                        
                        this.set_Info();

                        break;
                    default:
                        break;
                }
            }
            catch(Exception ex){
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;

                switch(_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                       
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:

                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:

                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntAnular = false;

                        break;

                    default:
                        break;
                }
            }
            catch(Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FrmGe_DocuAnulados_event_FrmGe_DocuAnulados_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void FrmGe_DocuAnulados_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.event_FrmGe_DocuAnulados_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Grabar()
        {
            try
            {
                if (validaColumna())
                {
                    get_Info();

                    if(_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (rb_Documento.Checked == true)
                        {
                            string msj = "";
                            if (Doc_B.GuardarDB(Doc_I, ref msj))
                            {
                                MessageBox.Show("Documento Anulado correctamente", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ucGe_Menu.Visible_bntAnular = false;
                                this.Close();
                            }
                            else
                            {
                                if (msj.Length > 0)
                                {
                                    MessageBox.Show(msj, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ucGe_Menu.Visible_bntAnular = false;
                                }
                                else
                                    MessageBox.Show("No se pudo Anular.. Comuníquese con Sistemas", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            if (rb_Lote.Checked == true)
                            {
                                string msg = "";
                                string msg2 = "";
                                int conta = Convert.ToInt32(txt_docFin.Text) - Convert.ToInt32(txt_docIni.Text);
                                int r = 0;
                                string micadena;
                                int d = Convert.ToInt32(txt_docIni.MaxLength);
                                //Boolean allOk = true;
                                for (int i = 0; i <= conta; i++)
                                {
                                    Info = new tb_sis_Documento_Tipo_x_Empresa_Anulados_Info();
                                    cp_TipoDocumento_Info obj = (cp_TipoDocumento_Info)cmbTipoDocu.Properties.View.GetFocusedRow();
                                    tb_Catalogo_Info obj2 = (tb_Catalogo_Info)cmbMotivoAnula.Properties.View.GetFocusedRow();
                                    //asigno la empresa
                                    Info.IdEmpresa = param.IdEmpresa;
                                    Info.codDocumentoTipo =obj.CodTipoDocumento;
                                    Info.Fecha = dtp_fecha.Value;
                                    //asigno valor a mi numero inicial serie1 y serie2
                                    Info.Serie1 = txt_serie1.Text.PadLeft(3,'0');
                                    Info.Serie2 = txt_serie2.Text.PadLeft(3,'0');
                                    r = i + Convert.ToInt32(txt_docIni.Text);
                                    micadena = r.ToString();
                                    Info.Documento = micadena.PadLeft(d, '0');
                                    Info.DocumentoFin = txt_docFin.Text;
                                    Info.Autorizacion = txt_AutSRI.Text;
                                    Info.IdMotivoAnu = obj2.IdCatalogo;
                                    Info.MotivoAnu = txt_detalle.Text;
                                    Info.Fecha_Transac = param.Fecha_Transac;
                                    Info.IdUsuario = param.IdUsuario;
                                    Info.IdEmpresa = param.IdEmpresa;
                                    Info.ip = param.ip;
                                    Info.nom_pc = param.nom_pc;
                                    Info.IdUsuarioUltAnu = param.IdUsuario;
                                    Info.Fecha_UltAnu = param.Fecha_Transac;
                                    if (!Doc_B.GuardarDB(Info, ref msg))
                                    {
                                        msg2 = msg;
                                        //allOk = false;
                                    }
                                }
                                MessageBox.Show("Los documementos han sido anulados correctamente", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ucGe_Menu.Visible_bntAnular = false;
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            { 
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
        public Boolean validaColumna()
        {
            try
            {
                Boolean estado = true;
          
                if (cmbTipoDocu.EditValue == null || cmbTipoDocu.EditValue == "")
                {
                    MessageBox.Show("Antes de continuar debe Seleccionar el Tipo de Documento", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
             
                if (cmbMotivoAnula.EditValue == null || Convert.ToInt32(cmbMotivoAnula.EditValue) == 0)
                {
                    MessageBox.Show("Antes de continuar debe Seleccionar el Motivo de Anulación", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }

                if (txt_AutSRI.Text == "" || Convert.ToDouble(txt_AutSRI.Text)<0)
                {
                    MessageBox.Show("Antes de continuar debe ingresar Autorización", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txt_AutSRI.Text.Length < 3)
                {
                    MessageBox.Show("#Aut.SRI debe ser Mínimo de 3 dígitos", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_AutSRI.Focus(); return false;
                }
                if (txt_serie1.Text == "" || Convert.ToDouble(txt_serie1.Text) < 0)
                {
                    MessageBox.Show("Antes de continuar debe ingresar Serie 1", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txt_serie2.Text == "" || Convert.ToDouble(txt_serie2.Text) < 0)
                {
                    MessageBox.Show("Antes de continuar debe ingresar Serie 2", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
               
                if (txt_detalle.Text == "")
                {
                    MessageBox.Show("Antes de continuar debe ingresar el detalle de la Anulación", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (this.rb_Documento.Checked == true)
                {
                    if (txt_doc.Text == "" || Convert.ToDouble(txt_doc.Text) < 0)
                    {
                        MessageBox.Show("Antes de continuar debe ingresar el Número de Documento", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                if (this.rb_Lote.Checked == true)
                {
                    if (txt_docIni.Text == "" || Convert.ToDouble(txt_docIni.Text) < 0)
                    {
                        MessageBox.Show("Antes de continuar debe ingresar el Número de Documento", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        if (Convert.ToInt32(txt_docIni.Text) >= Convert.ToInt32(txt_docFin.Text))
                        {
                            MessageBox.Show("El documento final debe de ser mayor al documento inicial", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                return estado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void txt_serie1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsDigit(e.KeyChar) == char.IsControl(e.KeyChar))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            catch(Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_serie2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsDigit(e.KeyChar) == char.IsControl(e.KeyChar))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_AutSRI_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsDigit(e.KeyChar) == char.IsControl(e.KeyChar))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_docIni_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsDigit(e.KeyChar) == char.IsControl(e.KeyChar))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_docFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsDigit(e.KeyChar) == char.IsControl(e.KeyChar))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_docIni_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                 txt_docFin.Text = txt_docIni.Text;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void txt_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsDigit(e.KeyChar) == char.IsControl(e.KeyChar))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rb_Documento_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rb_Documento.Checked==true)
                {
                    groupBox2.Visible = false;
                    groupBox3.Visible = true;
                }
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rb_Lote_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                    if(rb_Lote.Checked==true)
                    {
                    groupBox3.Visible=false;
                    groupBox2.Visible = true;
                    }
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
