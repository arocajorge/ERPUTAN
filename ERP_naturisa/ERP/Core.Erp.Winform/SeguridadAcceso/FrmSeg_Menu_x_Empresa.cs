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
    public partial class FrmSeg_Menu_x_Empresa : Form
    {
        public FrmSeg_Menu_x_Empresa()
        {
            try
            {
                InitializeComponent();
                UCGe_Menu.btnGuardar.Text = "Guardar";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        void UCGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (treeListMenu.Nodes.Count < 1)
                {
                    MessageBox.Show("No hay datos para grabar, primero filtre el menu", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                EstablecerCheckeo(treeListMenu.Nodes);
                var listaModificada = (from c in listaBinding
                                       where c.SeModificoValor == true || c.Checkeado != c.Existe
                                       select c);
                if (listaModificada.Count() > 0)
                {
                    seg_Menu_x_Empresa_bus bus = new seg_Menu_x_Empresa_bus();
                    string msg = "";
                    //bool existeRelacion = bus.ExisteRelacion(listaModificada.ToList(), ref msg);
                    //if (existeRelacion)
                    //{
                    //    if (!msg.Equals(""))
                    //    {
                    //        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }
                    //    else
                    //    {
                    //        string mensajeAdvertencia = "No se pueden guardar los cambios debido a que se quiere eliminar un menu que tiene una relacion en la opcion \"Menu por Empresa por Usuario\", Primero elimine el menu en esta opcion y luego vuelva a intentarlo";
                    //        MessageBox.Show(mensajeAdvertencia, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    }
                    //    return;
                    //}



                    bool grabo = bus.GrabarDB(listaModificada.ToList(), ref msg);
                    if (grabo)
                    {

                        foreach (var item in listaModificada.ToList())
                        {
                            item.SeModificoValor = false;
                        }
                        CargarMenu();
                    }
                    else
                    {
                        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No hay cambios por modificar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void UCGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void EstablecerCheckeo(DevExpress.XtraTreeList.Nodes.TreeListNodes lNodos)
        {
            try
            {
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo in lNodos)
                {
                    if (nodo.CheckState == CheckState.Unchecked)
                    {
                        nodo.SetValue("Checkeado", false);
                    }
                    else
                    {
                        nodo.SetValue("Checkeado", true);
                    }
                    if (nodo.Nodes.Count > 0)
                        EstablecerCheckeo(nodo.Nodes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        

        private void FrmSeg_Menu_x_Empresa_Load(object sender, EventArgs e)
        {
            try
            {
                string msg = "";
                tb_Empresa_Bus bus = new tb_Empresa_Bus();
                object objDataSource = bus.Get_List_Empresa();
                if (msg.Equals(""))
                {
                    searchLookUpEditEmpresa.Properties.DisplayMember = "em_nombre";
                    searchLookUpEditEmpresa.Properties.ValueMember = "IdEmpresa";
                    searchLookUpEditEmpresa.Properties.DataSource = objDataSource;
                }
                else
                {
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeListMenu_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            try
            {
                //EventoCheckearNodoPadre(e.Node,e.Node.Checked);
                //EventoCheckearNodoHijo(e.Node, e.Node.Checked);
                accionSeleccionarUsuario = true;
                if (e.Node.Checked == false)
                    chkCheckearTodo.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        BindingList<seg_Menu_x_Empresa_info> listaBinding = new BindingList<seg_Menu_x_Empresa_info>();
        
        private void searchLookUpEditEmpresa_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                CargarMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void CargarMenu()
        {
            try
            {
                treeListMenu.DataSource = null;
                chkCheckearTodo.Checked = false;
                seg_Menu_x_Empresa_bus bus = new seg_Menu_x_Empresa_bus();
                string msg = "";
                Int32 idEmpresa = Convert.ToInt32(searchLookUpEditEmpresa.EditValue);
                if (idEmpresa == 0)
                {
                    return;
                }
                this.Cursor = Cursors.WaitCursor;
                List<seg_Menu_x_Empresa_info> listaMenu_x_Empresa = bus.Get_List_Menu_x_Empresa(idEmpresa, ref msg);
                if (msg.Equals(""))
                {
                    listaMenu_x_Empresa.AddRange(bus.Get_No_List_DescripcionMenu_x_Empresa(idEmpresa, ref msg));
                    if (msg.Equals(""))
                    {
                        listaBinding.Clear();
                        foreach (seg_Menu_x_Empresa_info item in listaMenu_x_Empresa)
                        {
                            listaBinding.Add(item);
                        }
                        treeListMenu.DataSource = listaBinding;
                        treeListMenu.ExpandAll();
                        CheckearMenu(treeListMenu.Nodes);
                        ArreglarCheckeo(treeListMenu.Nodes);
                    }
                    else
                    {
                        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckearMenu(DevExpress.XtraTreeList.Nodes.TreeListNodes lNodos)
        {
            try
            {
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo in lNodos)
                {
                    if ((bool)nodo.GetValue("Existe"))
                        nodo.Checked = true;
                    if (nodo.Nodes.Count > 0)
                        CheckearMenu(nodo.Nodes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ArreglarCheckeo(DevExpress.XtraTreeList.Nodes.TreeListNodes lNodos)
        {
            try
            {
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo in lNodos)
                {
                    if ((bool)nodo.GetValue("Existe"))
                    {
                        if (nodo.Nodes.Count > 0)
                        {
                            ArreglarCheckeo(nodo.Nodes);
                            bool todoCheckeado = true;
                            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodoHijo in nodo.Nodes)
                            {
                                if (nodoHijo.Checked == false)
                                {
                                    todoCheckeado = false;
                                }
                            }
                            if (todoCheckeado == false)
                            {
                                nodo.CheckState = CheckState.Indeterminate;
                            }                            
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeListMenu_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            try
            {
                e.Node.SetValue("SeModificoValor", true);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeListMenu_CellValueChanging(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            try
            {
                e.Node.SetValue("SeModificoValor", true);
                e.Node.SetValue(e.Column.FieldName, e.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private bool accionSeleccionarUsuario = false;
        
        private void chkCheckearTodo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!accionSeleccionarUsuario)
                    SeleccionarTodo(treeListMenu.Nodes, chkCheckearTodo.Checked);
                accionSeleccionarUsuario = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void SeleccionarTodo(DevExpress.XtraTreeList.Nodes.TreeListNodes lnodos,bool seleccion)
        {
            try
            {
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo in lnodos)
                {
                    nodo.Checked = seleccion;
                    nodo.SetValue("Checkeado", seleccion);                    
                    if (nodo.Nodes.Count > 0)
                    {
                        SeleccionarTodo(nodo.Nodes, seleccion);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                this.treeListMenu.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
