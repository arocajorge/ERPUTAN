using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Winform.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;


namespace Core.Erp.Winform.Produc_Cirdesus
{
    
    public partial class FrmPrd_ObraMantemiento : Form
    {
        string msg = "";
        prd_Obra_Info Info = new prd_Obra_Info();
        prd_Obra_Bus Bus = new prd_Obra_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        prd_Obra_Info infoObra = new prd_Obra_Info();
        prd_Obra_Bus Bus_Tip_movi = new prd_Obra_Bus();
        Cl_Enumeradores.eTipo_action Accion;
       
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        BindingList<prd_Obra_Info> ListaBind;

        public delegate void delegate_FrmPrd_ObraMantemiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmPrd_ObraMantemiento_FormClosing event_FrmPrd_ObraMantemiento_FormClosing;
 
        public void set_Info(prd_Obra_Info Obra)
        {
            try
            {

                infoObra = Obra;

                infoObra = new prd_Obra_Info();
                infoObra = Obra;
                txtCodigo.Text = infoObra.CodObra;
                cmb_cliente.EditValue = infoObra.IdCliente;
                txtDescripcion.Text = infoObra.Descripcion;
                txtPesoObra.Text = infoObra.PesoObra.ToString();
                dTPFecha.Value = infoObra.Fecha;
                chkEstado.Checked = (infoObra.Estado == "A") ? true : false;
                lblAnulado.Visible = (infoObra.Estado == "I") ? true : false;
                txtReferencia.Text = infoObra.Referencia;
            }
            catch (Exception ex)
            {
                
                                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());

            }
        }

        public void get_Obra( )
        {
            try
            {


                infoObra = new prd_Obra_Info();
                infoObra.CodObra = txtCodigo.Text.ToString();
                infoObra.IdCliente = Convert.ToDecimal(this.cmb_cliente.EditValue);
                infoObra.Descripcion = txtDescripcion.Text.ToString();
                infoObra.Fecha = dTPFecha.Value ;
                infoObra.IdEmpresa = param.IdEmpresa;
                infoObra.PesoObra = Convert.ToDecimal(txtPesoObra.Text);
                infoObra.Referencia = txtReferencia.Text.ToString();

                infoObra.Estado = (chkEstado.Checked == true) ? "A" : "I";

               // return infoObra;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());

            }
        }
        
        private Boolean Validar()
  {
            try
            {
                if (txtCodigo.Text == string.Empty)
                    {
                        MessageBox.Show("Asigne un código a la Obra", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigo.Focus();
                        return false;
                        
                    }

                else if (cmb_cliente.EditValue == null)
                {
                    MessageBox.Show("Debe seleccionar un Cliente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_cliente.Focus();
                    return false;
                }

                else if (txtDescripcion .Text == string.Empty)
                    {
                        MessageBox.Show("Ingrese el Nombre a la Obra", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtDescripcion.Focus();
                        return false;

                    }
                else if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    

                } return true;

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); return false;
            }
        
 
        
        
        }

        public void set_Acccion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {

                Accion = _Accion;


                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        txtCodigo.Text = Bus_Tip_movi.ObtenerIdObra(ref msg).ToString();
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;

                        txtCodigo.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;


                        break;
                    default:
                        break;
                }



            }
            catch (Exception ex)
            {


            }

        }

        private Boolean Grabar()
          {
            try
            {
                
                if (Validar() == false)
                {
                    MessageBox.Show("No se Guardó", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    get_Obra();
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            infoObra.IdUsuario = param.IdUsuario;
                            infoObra.FechaTransac = param.Fecha_Transac;
                            if (Bus_Tip_movi.GuardarDB(infoObra, ref msg))
                            {
                                MessageBox.Show("Se ha grabado correctamente la Obra: "+infoObra.Descripcion);
                                ucGe_Menu.Visible_btnGuardar = false;
                                ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                                set_Acccion(Cl_Enumeradores.eTipo_action.actualizar);
                                set_Info(infoObra);
                                txtCodigo.Text = Bus_Tip_movi.ObtenerIdObra(ref msg).ToString();
                                return true;
                            }
                            else return false;
                           
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            infoObra.IdUsuarioUltModi = param.IdUsuario;
                            infoObra.FechaUltModi = param.Fecha_Transac;
                       
                            if (Bus_Tip_movi.ModificarDB(infoObra, ref msg))
                            {
                                MessageBox.Show("Se ha actualizado correctamente la Obra: " + infoObra.Descripcion);
                                //set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                                set_Info(infoObra);
                                return true;
                            }
                            else return false;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            infoObra.Estado = "I";
                            infoObra.IdUsuarioAnu = param.IdUsuario;
                            infoObra.FechaAnu = param.Fecha_Transac;
                            if (Bus_Tip_movi.AnularDB(infoObra, ref msg))
                            {
                                MessageBox.Show("Se ha anulado correctamente la Obra: " + infoObra.Descripcion);
                                set_Acccion(Cl_Enumeradores.eTipo_action.consultar);
                                 set_Info(infoObra);return true;
                            }
                            else return false;  
                      default:
                            return false;
                           
                    }
                
                
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); return false;
            }
        
        
        }

        void Anular()
        {
            try
            {
                if (infoObra != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    if (infoObra.Estado == "A")
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular la Obra: " + infoObra.Descripcion + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //string msg = "";
                            oFrm.ShowDialog();
                            infoObra.MotivoAnu = oFrm.motivoAnulacion;
                            if (Grabar())
                                MessageBox.Show("Anulado con exito la Obra: " + infoObra.Descripcion);
                            chkEstado.Checked = false;
                            lblAnulado.Visible = true;
                            set_Acccion(Cl_Enumeradores.eTipo_action.consultar);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo anular la Obra: " + infoObra.Descripcion, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        public FrmPrd_ObraMantemiento()
        {
            InitializeComponent();
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            event_FrmPrd_ObraMantemiento_FormClosing += FrmIn_Motivo_Inven_Mant_event_FrmIn_Motivo_Inven_Mant_FormClosing;
                 
        }

        void FrmIn_Motivo_Inven_Mant_event_FrmIn_Motivo_Inven_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        
        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Anular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
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
               Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
                {
            try
            {
                if (Grabar())
                { this.Close(); }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
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
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void FrmPrd_ObraMantemiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            // MessageBox.Show("form closinf del lado de mantenimiento");

            event_FrmPrd_ObraMantemiento_FormClosing(sender, e);
        }

        private void FrmPrd_ObraMantemiento_Load(object sender, EventArgs e)
        {
            try
            {
           // txtCodigo.Text = Bus_Tip_movi.ObtenerIdObra(ref msg).ToString();
            fa_Cliente_Bus busCateg = new fa_Cliente_Bus();
            List<fa_Cliente_Info> lista = new List<fa_Cliente_Info>();
            lista = busCateg.Get_List_Clientes(param.IdEmpresa);

            cmb_cliente.Properties.DataSource = lista;
            cmb_cliente.Properties.DisplayMember = "Nombre_Cliente";
            cmb_cliente.Properties.ValueMember = "IdCliente";
            
            


            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error "+ex.Message);
            }
        }

        internal void set_InfoCotiza(prd_CotizacionCompras_Info InfoCotiza)
        {
            throw new NotImplementedException();
        }

        internal void set_Info(prd_CotizacionCompras_Info InfoCotiza)
        {
            throw new NotImplementedException();
        }
        List<prd_Obra_Info> lista;

        private void cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
        
    }
}
