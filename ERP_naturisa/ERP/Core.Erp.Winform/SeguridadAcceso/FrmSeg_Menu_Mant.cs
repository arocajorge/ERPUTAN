using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.General;
using Core.Erp.Business.General;



namespace Core.Erp.Winform.SeguridadAcceso
{
    public partial class FrmSeg_Menu_Mant : Form
    {
        private Cl_Enumeradores.eTipo_action accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        seg_Menu_info Info_Menu = new seg_Menu_info();
        seg_Menu_bus bus = new seg_Menu_bus();
        private bool guardo = false;
        public delegate void delegate_FrmSeg_Menu_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmSeg_Menu_Mant_FormClosing event_FrmSeg_Menu_Mant_FormClosing;

        public FrmSeg_Menu_Mant()
        {
            InitializeComponent();
            event_FrmSeg_Menu_Mant_FormClosing += FrmSeg_Menu_Mant_event_FrmSeg_Menu_Mant_FormClosing;
        }

        void FrmSeg_Menu_Mant_event_FrmSeg_Menu_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }         

        #region "Set"
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void set_Menu(seg_Menu_info info)
        {
            try
            {
                Info_Menu = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private bool Validar()
        {
            try
            {                
                if (txtDescripcion.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor Ingrese " + " Descripcion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (checkBoxTienePadre.Checked && RetornarNodoCheckeado(treeListMenuPadre.Nodes) == null)
                {
                    MessageBox.Show("Por favor Ingrese " + " Nodo Padre, Seleccione un nodo de la lista de menu", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (checkBoxTieneFormulario.Checked && txtNombreFormulario.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor Ingrese " + " Nombre del formulario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (checkBoxTieneFormulario.Checked && this.txtNombreAsembly.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor Ingrese " + " Nombre del emsamblado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Guardar()
        {
            try
            {
                guardo = false;                
                    Info_Menu = new seg_Menu_info();
                    Info_Menu.DescripcionMenu = txtDescripcion.Text;
                    Info_Menu.Habilitado = true;
                    if(txtIdMenu.Text != "")
                    Info_Menu.IdMenu = Convert.ToInt16(txtIdMenu.Text);
                    if (!checkBoxTienePadre.Checked)
                        Info_Menu.IdMenuPadre = 0;
                    else
                    {                        
                            int nodo = (int)RetornarNodoCheckeado(treeListMenuPadre.Nodes).GetValue("IdMenu");
                            if (nodo == null)
                                return false;
                            Info_Menu.IdMenuPadre = nodo;
                    }
                    Info_Menu.nom_Formulario = txtNombreFormulario.Text;
                    Info_Menu.nom_Asembly = txtNombreAsembly.Text;
                    Info_Menu.PosicionMenu = (int)numericUpDownPosicion.Value;
                    Info_Menu.Tiene_FormularioAsociado = checkBoxTieneFormulario.Checked;
                    if (this.checkBoxTienePadre.Checked)
                    {
                        Info_Menu.nivel = RetornarNodoCheckeado(treeListMenuPadre.Nodes).Level + 1;
                    }
                    else
                    {
                        Info_Menu.nivel = 0;
                    }
                     bus = new seg_Menu_bus();
                    string mensaje = "";
                    if (bus.GrabarDB(Info_Menu, ref mensaje))
                    {
                        MessageBox.Show("Grabado Ok", "Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        treeListMenuPadre.Selection[0].GetValue(Info_Menu.DescripcionMenu);
                        treeListMenuPadre.Selection[0].GetValue(Info_Menu.IdMenu);
                        guardo = true;
                        CargarMenu();
                        txtDescripcion.Text = "";
                        txtNombreAsembly.Text = "";
                        txtNombreFormulario.Text = "";
                        numericUpDownPosicion.Value = 0;
                        txtIdMenu.Text = new seg_Menu_bus().getIdMenu_Max(ref mensaje).ToString();
                        txtDescripcion.Focus();
                        this.uC_Menu_Mantenimientos1.Visible_bntGuardar_y_Salir = true;
                        this.uC_Menu_Mantenimientos1.Visible_btnGuardar = true;
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                return guardo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }       
      
        private bool Modificar()
        {
            try
            {                
                seg_Menu_bus bus = new seg_Menu_bus();                
                Info_Menu.IdMenu = this.Info_Menu.IdMenu;
                Info_Menu.DescripcionMenu = txtDescripcion.Text;
                Info_Menu.Habilitado = this.Info_Menu.Habilitado;
                if(numericUpDownPosicion.Value !=0)
                Info_Menu.PosicionMenu = (int)numericUpDownPosicion.Value;
                if(Info_Menu.nivel !=0)
                Info_Menu.nivel = RetornarNodoCheckeado(treeListMenuPadre.Nodes).Level + 1;
                if (!checkBoxTienePadre.Checked)
                    Info_Menu.IdMenuPadre = 0;
                else
                {
                    DevExpress.XtraTreeList.Nodes.TreeListNode nodo = RetornarNodoCheckeado(treeListMenuPadre.Nodes);
                    if (nodo == null)
                        return false;
                    Info_Menu.IdMenuPadre = (int)nodo.GetValue("IdMenu");
                }
                if (checkBoxTieneFormulario.Checked)
                {
                    Info_Menu.Tiene_FormularioAsociado = true;
                    Info_Menu.nom_Formulario = txtNombreFormulario.Text;
                    Info_Menu.nom_Asembly = txtNombreAsembly.Text;
                }
                string mensaje = "";
                if (bus.ModificarDB(Info_Menu, ref mensaje))
                {                
                    MessageBox.Show("Grabado Ok", "Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    treeListMenuPadre.Selection[0].GetValue(Info_Menu.DescripcionMenu);
                    treeListMenuPadre.Selection[0].GetValue(Info_Menu.IdMenu);
                    treeListMenuPadre.Selection[0].GetValue(Info_Menu.PosicionMenu);
                    return true;
                      
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        private DevExpress.XtraTreeList.Nodes.TreeListNode RetornarNodoCheckeado(DevExpress.XtraTreeList.Nodes.TreeListNodes listaNodos)
        {
            try
            {
                DevExpress.XtraTreeList.Nodes.TreeListNode nodoTemporal = null;
               
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo in listaNodos)
                {
                    if (nodo.Checked)
                    {
                        return nodo;
                    }
                    if (nodo.Nodes.Count > 0)
                    {
                        nodoTemporal = RetornarNodoCheckeado(nodo.Nodes);
                        if (nodoTemporal != null)
                        {
                            return nodoTemporal;
                        }
                    }
                }
                return nodoTemporal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
       
        private void FrmSeg_Menu_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                CargarMenu();
                string mensaje = "";
                switch (accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        txtIdMenu.Text = new seg_Menu_bus().getIdMenu_Max(ref mensaje).ToString();                      
                        uC_Menu_Mantenimientos1.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Cargar();
                        uC_Menu_Mantenimientos1.Visible_bntAnular = false;
                        uC_Menu_Mantenimientos1.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Cargar();
                        uC_Menu_Mantenimientos1.Visible_bntGuardar_y_Salir = false;
                        uC_Menu_Mantenimientos1.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Cargar();
                        uC_Menu_Mantenimientos1.Visible_bntGuardar_y_Salir = false;
                        uC_Menu_Mantenimientos1.Visible_btnGuardar = false;
                        uC_Menu_Mantenimientos1.Visible_bntAnular = false;
                        break;
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar()
        {
            try
            {

                txtIdMenu.Text = this.Info_Menu.IdMenu.ToString();
                txtDescripcion.Text = this.Info_Menu.DescripcionMenu;                
                if (this.Info_Menu.IdMenuPadre == 0)
                {
                    this.treeListMenuPadre.UncheckAll();
                    this.checkBoxTienePadre.Checked = false;
                }
                else
                {
                    RecorrerNodos(treeListMenuPadre.Nodes);
                    this.nodoCheckeado.Selected = true;
                }
                numericUpDownPosicion.Value = (decimal)this.Info_Menu.PosicionMenu;
                checkBoxTieneFormulario.Checked = this.Info_Menu.Tiene_FormularioAsociado;
                txtNombreFormulario.Text = this.Info_Menu.nom_Formulario;
                txtNombreAsembly.Text = this.Info_Menu.nom_Asembly;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DevExpress.XtraTreeList.Nodes.TreeListNode nodoCheckeado = null;
     
        private void RecorrerNodos(DevExpress.XtraTreeList.Nodes.TreeListNodes listaNodos)
        {
            try
            {
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo in listaNodos)
                {
                    nodo.Expanded = false;
                    if ((int)nodo.GetValue("IdMenu") == this.Info_Menu.IdMenuPadre)
                    {
                        nodo.CheckState = CheckState.Checked;
                        nodoCheckeado = nodo;
                        return;
                    }
                    if (nodo.Nodes.Count > 0)
                        RecorrerNodos(nodo.Nodes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeListMenuPadre_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
        {
            try
            {
                treeListMenuPadre.UncheckAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxTieneFormulario_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                bool checkeo = checkBoxTieneFormulario.Checked;
                lblNombreFormulario.Visible = checkeo;
                txtNombreFormulario.Visible = checkeo;
                lblNombreAsembly.Visible = checkeo;
                txtNombreAsembly.Visible = checkeo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxTienePadre_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                treeListMenuPadre.Enabled = checkBoxTienePadre.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMenu()
        {
            try
            {
                string mensaje = "";
                treeListMenuPadre.DataSource = new seg_Menu_bus().Get_List_Menu(ref mensaje);                
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                treeListMenuPadre.Refresh();              
                treeListMenuPadre.Focus();
                treeListMenuPadre.Nodes[0].Selected = true;               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uC_Menu_Mantenimientos1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                guardarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uC_Menu_Mantenimientos1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if(guardarDatos())
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uC_Menu_Mantenimientos1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uC_Menu_Mantenimientos1_event_btnAnular_Click(object sender, EventArgs e)
        {

        }

        public Boolean guardarDatos()
        {
            try
            {
                guardo = false;
                if (Validar())
                {
                    switch (accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            guardo = Guardar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            guardo = Modificar();
                            break;
                    }
                }
                return guardo;
            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void FrmSeg_Menu_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmSeg_Menu_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
    }
}
