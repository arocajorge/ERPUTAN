using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.SeguridadAcceso
{
    public partial class FrmSeg_Menu_Consulta : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        seg_Menu_info info;

        public FrmSeg_Menu_Consulta()
        {
            try
            {
                InitializeComponent();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {                
                FrmSeg_Menu_Mant frm = new FrmSeg_Menu_Mant();
                frm.MdiParent = this.MdiParent;               
                frm.event_FrmSeg_Menu_Mant_FormClosing +=frm_event_FrmSeg_Menu_Mant_FormClosing;
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    NodoSeleccionado();
                    frm.set_Menu(info);
                }
                frm.set_Accion(Accion);
                frm.Show();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_FrmSeg_Menu_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarMenu();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private seg_Menu_info NodoSeleccionado()
        {
            try
            {
                info = new seg_Menu_info();
                info.DescripcionMenu = (string)treeListMenu.Selection[0].GetValue("DescripcionMenu");
                info.Habilitado = (bool)treeListMenu.Selection[0].GetValue("Habilitado");
                info.icono = (byte[])treeListMenu.Selection[0].GetValue("icono");
                info.IdMenu = (int)treeListMenu.Selection[0].GetValue("IdMenu");
                info.IdMenuPadre = (int)treeListMenu.Selection[0].GetValue("IdMenuPadre");
                info.imagen_grande = (byte[])treeListMenu.Selection[0].GetValue("imagen_grande");
                info.imagen_peque = (byte[])treeListMenu.Selection[0].GetValue("imagen_peque");
                info.nivel = (int)treeListMenu.Selection[0].GetValue("nivel");
                info.nom_Asembly = (string)treeListMenu.Selection[0].GetValue("nom_Asembly");
                info.nom_Formulario = (string)treeListMenu.Selection[0].GetValue("nom_Formulario");
                info.PosicionMenu = (int)treeListMenu.Selection[0].GetValue("PosicionMenu");
                info.Tiene_FormularioAsociado = (bool)treeListMenu.Selection[0].GetValue("Tiene_FormularioAsociado");
                return info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new seg_Menu_info();
            }
        }

        private void FrmSeg_Menu_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                
                CargarMenu();                
                if (this.treeListMenu.Selection.Count != null)
                {
                    this.treeListMenu.Selection.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarMenu()
        {
            try
            {
                string MensajeError = "";
                treeListMenu.DataSource = new seg_Menu_bus().Get_List_Menu(ref MensajeError);                
                treeListMenu.Refresh();
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo in treeListMenu.Nodes)
                    nodo.Expanded = false;                
                treeListMenu.Focus();               
                treeListMenu.Nodes[0].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void uC_Menu_Consultas1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void uC_Menu_Consultas1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            

        private void uC_Menu_Consultas1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (treeListMenu.Selection.Count != 1)
                    MessageBox.Show("Debe seleccionar un item de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    string mensaje = "";
                    if (new seg_Menu_bus().ExisteRelacionMenu(NodoSeleccionado().IdMenu, ref mensaje))
                    {
                        if (!mensaje.Equals(""))
                        {
                            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string mensajeAdvertencia = "No se puede eliminar el menu, debido a que existe una relacion en la opcion \"Menu por Empresa\". \n Primero desmarque el registro desde esta opcion!";
                            MessageBox.Show(mensajeAdvertencia, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        return;
                    }
                    System.Windows.Forms.DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el menu seleccionado de manera permanente?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (new seg_Menu_bus().EliminarDB(NodoSeleccionado(), ref mensaje))
                        {
                            MessageBox.Show("Borrado Ok", "Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Cursor = Cursors.WaitCursor;
                            CargarMenu();
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void uC_Menu_Consultas1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (treeListMenu.Selection.Count != 1)
                    MessageBox.Show("Debe seleccionar un item de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    llama_frm(Cl_Enumeradores.eTipo_action.actualizar);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           

        }

        private void uC_Menu_Consultas1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (treeListMenu.Selection.Count != 1)
                    MessageBox.Show("Debe seleccionar un item de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    llama_frm(Cl_Enumeradores.eTipo_action.consultar);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
           

    }
}
