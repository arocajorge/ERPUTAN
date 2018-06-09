using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;

namespace Core.Erp.Winform.General
{
    public partial class FrmGe_Banco_Mant : Form
    {
        #region Variables

        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_banco_Info BancoInfo = new tb_banco_Info();
        tb_banco_Bus bus_Banco = new tb_banco_Bus();

        BindingList<tb_banco_procesos_bancarios_x_empresa_Info> blist_procesos_bancarios_x_empresa = new BindingList<tb_banco_procesos_bancarios_x_empresa_Info>();
        tb_banco_procesos_bancarios_x_empresa_Bus bus_procesos_bancarios_x_empresa = new tb_banco_procesos_bancarios_x_empresa_Bus();

        List<tb_banco_procesos_bancarios_tipo_Info> list_procesos_bancarios = new List<tb_banco_procesos_bancarios_tipo_Info>();
        tb_banco_procesos_bancarios_tipo_Bus bus_procesos_bancarios = new tb_banco_procesos_bancarios_tipo_Bus();
        List<ba_tipo_nota_Info> list_tipo_nota = new List<ba_tipo_nota_Info>();
        ba_tipo_nota_Bus bus_tipo_nota = new ba_tipo_nota_Bus();
        string mensaje = "";
        int IdBanco = 0;

        #region Delegados

        public delegate void delegate_FrmGe_Banco_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmGe_Banco_Mant_FormClosing event_FrmGe_Banco_Mant_FormClosing;

        #endregion

        #endregion

        public FrmGe_Banco_Mant()
        {
            InitializeComponent();
            event_FrmGe_Banco_Mant_FormClosing += FrmGe_Banco_Mant_event_FrmGe_Banco_Mant_FormClosing;
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Set_Banco(tb_banco_Info Info)
        {
            try
            {
                BancoInfo = Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public tb_banco_Info GetBanco(ref string mensaje)
        {
            try
            {
                tb_banco_Info Info = new tb_banco_Info();

                Info.IdBanco = Convert.ToInt32(txtId.Text);
                Info.ba_descripcion = txtNombre.Text;
                Info.Estado = (chkEstado.Checked == true) ? "A" : "I";
                Info.CodigoLegal = txtCodigoLegal.Text;
                Info.TieneFormatoTransferencia = chkFormatoTransfer.Checked;

                Info.lst_procesos_bancarios_x_empresa = Get_procesos_x_banco();

                return Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw new Exception();
            }
        }
        
        public void Cargar_Datos()
        {
            try
            {
                txtId.Text = "0";
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                    txtId.Text = BancoInfo.IdBanco.ToString();
                txtNombre.Text = BancoInfo.ba_descripcion;
                txtCodigoLegal.Text = BancoInfo.CodigoLegal;
                chkFormatoTransfer.Checked = Convert.ToBoolean(BancoInfo.TieneFormatoTransferencia);
                chkEstado.Checked = (BancoInfo.Estado == "A") ? true : false;

                list_tipo_nota = bus_tipo_nota.Get_List_tipo_nota(param.IdEmpresa,"NDBA");
                cmb_tipo_nota.DataSource = list_tipo_nota;

                blist_procesos_bancarios_x_empresa = new BindingList<tb_banco_procesos_bancarios_x_empresa_Info>(bus_procesos_bancarios_x_empresa.Get_list_procesos_bancarios_x_empresa(param.IdEmpresa, BancoInfo.IdBanco));
                gridControlProcesosBancarios.DataSource = blist_procesos_bancarios_x_empresa;

                list_procesos_bancarios = bus_procesos_bancarios.Get_list_procesos();
                cmb_procesos_bancarios.DataSource = list_procesos_bancarios;

                gridControlProcesosBancarios.DataSource = blist_procesos_bancarios_x_empresa;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<tb_banco_procesos_bancarios_x_empresa_Info> Get_procesos_x_banco()
        {
            try
            {
                List<tb_banco_procesos_bancarios_x_empresa_Info> Lista = new List<tb_banco_procesos_bancarios_x_empresa_Info>();

                foreach (var item in blist_procesos_bancarios_x_empresa)
                {
                    tb_banco_procesos_bancarios_x_empresa_Info info = new tb_banco_procesos_bancarios_x_empresa_Info();
                    
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdProceso_bancario_tipo = item.IdProceso_bancario_tipo;
                    info.IdBanco = txtId.Text == "" ? 0 : Convert.ToInt32(txtId.Text);
                    info.cod_banco = txtCodigoLegal.Text;
                    info.Codigo_Empresa = item.Codigo_Empresa;
                    info.Secuencial_detalle_inicial = item.Secuencial_detalle_inicial;
                    info.IdTipoNota = item.IdTipoNota;
                    info.Se_contabiliza = item.Se_contabiliza;

                    Lista.Add(info);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<tb_banco_procesos_bancarios_x_empresa_Info>();
            }
        }

        public Boolean Grabar()
        {
            try
            {
                bool resultado = false;
                tb_banco_Info Info = new tb_banco_Info();
                bus_Banco= new tb_banco_Bus();
                Info = GetBanco(ref mensaje);
                IdBanco = Convert.ToInt32(Info.IdBanco);
                if (resultado = bus_Banco.GrabarDB(Info, ref mensaje))
                {                    
                    return resultado;
                }
                else
                {
                    MessageBox.Show("No se guardaron los datos", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public Boolean Modificar()
        {
            try
            {
                bool resultado = false;
                tb_banco_Info Info = new tb_banco_Info();
                bus_Banco = new tb_banco_Bus();
                Info = GetBanco(ref mensaje);
                IdBanco = Convert.ToInt32(Info.IdBanco);
                if (resultado=bus_Banco.ActualizarDB(Info, ref mensaje))
                {
                    return resultado;
                }
                else
                {
                    MessageBox.Show("No se guardaron los datos", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public Boolean Grabar_Datos()
        {
            try
            {
                if (Validaciones())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            Grabar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            Modificar();
                            break;
                    }
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public Boolean Validaciones()
        {
            try
            {
                txtNombre.Focus();
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Digite un Nombre", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtCodigoLegal.Text))
                {
                    MessageBox.Show("Digite un codigo legal", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigoLegal.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Boolean Anular()
        {
            try
            {
                bool resultado = false;
                if (BancoInfo.Estado != "I")
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el Banco # " + txtId.Text.Trim() + " ?", "Anulación de Banco", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();

                        bus_Banco = new tb_banco_Bus();
                        tb_banco_Info Info = new tb_banco_Info();
                        string mensaje = string.Empty;

                        Info = GetBanco(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (bus_Banco.AnulaDB(Info, ref mensaje))
                        {
                            MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                            resultado = true;
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resultado = false;
                        }
                    }
                    return resultado;
                }
                else
                {
                    MessageBox.Show("El Banco #: " + txtId.Text.Trim() + " ya se encuentra anulado.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public void Limpiar()
        {
            try
            {
                txtId.Text = "0";
                txtNombre.Text = "";
                txtCodigoLegal.Text = "";
                chkEstado.Checked = false;
                chkFormatoTransfer.Checked = false;
                /*BindLista = new BindingList<tb_banco_procesos_bancarios_Info>();
                gridControlProcesosBancarios.DataSource = BindLista;*/
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        void FrmGe_Banco_Mant_event_FrmGe_Banco_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void FrmGe_Banco_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmGe_Banco_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {

            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar_Datos())
                    Limpiar();
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar_Datos())
                    Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Anular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGe_Banco_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Datos();
                
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridControlProcesosBancarios_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                    gridViewProcesosBancarios.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewProcesosBancarios_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                /*tb_banco_procesos_bancarios_Info row = (tb_banco_procesos_bancarios_Info)gridViewProcesosBancarios.GetFocusedRow();

                int cont = 0;

                if (!string.IsNullOrEmpty(row.IdProceso_bancario))
                {
                    cont = BindLista.Where(v => v.IdBanco == row.IdBanco && v.IdProceso_bancario == row.IdProceso_bancario).Count();
                }

                if (cont > 1)
                {
                    MessageBox.Show("El Producto ingresado ya se encuentra en el Detalle. Se procederá a Eliminar", "Sistemas");
                    gridViewProcesosBancarios.DeleteSelectedRows();
                }*/
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
