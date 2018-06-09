using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Winform.Produc_Cirdesus;
using DevExpress.XtraPrinting;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class Frm_ProductividadSubgrupoTrabajo_Consulta : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public Frm_ProductividadSubgrupoTrabajo_Consulta()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Frm_ProductividadSubgrupoTrabajo_Mantenimiento frm = new Frm_ProductividadSubgrupoTrabajo_Mantenimiento();
             //   frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***"; frm.MdiParent = this.MdiParent;
                frm.Show();

               

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
              //  InfoGrupoTrabajo = (prd_SubGrupoTrabajo_Info)gridViewGrupoTrabajo.GetFocusedRow();

              //  if (InfoGrupoTrabajo == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               // else
               // {
                    Frm_ProductividadSubgrupoTrabajo_Mantenimiento frm = new Frm_ProductividadSubgrupoTrabajo_Mantenimiento();
                   // frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);

                    frm.Text = frm.Text + " ***MODIFICAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.Show(); 
                    //frm.setCab(InfoGrupoTrabajo);


              //  }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //InfoGrupoTrabajo = (prd_SubGrupoTrabajo_Info)gridViewGrupoTrabajo.GetFocusedRow();
                //if (InfoGrupoTrabajo == null)
                //    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //else
                //{
                Frm_ProductividadSubgrupoTrabajo_Mantenimiento frm = new Frm_ProductividadSubgrupoTrabajo_Mantenimiento();
                   // frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.Text = frm.Text + " ***CONSULTAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.Show();
                //frm.setCab(InfoGrupoTrabajo);





             //   }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string msg = "";

                //InfoGrupoTrabajo = (prd_SubGrupoTrabajo_Info)gridViewGrupoTrabajo.GetFocusedRow();
                //if (InfoGrupoTrabajo == null)
                //    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //else if (InfoGrupoTrabajo.Estado == "I")
                //    MessageBox.Show("Este Grupo de Trabajo ya esta Anulado / Inactivo", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //else if (MessageBox.Show("¿Está seguro que desea Anular / Inactivar el Grupo de Trabajo " + InfoGrupoTrabajo.Descripcion + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //{
                    Frm_ProductividadSubgrupoTrabajo_Mantenimiento frm = new Frm_ProductividadSubgrupoTrabajo_Mantenimiento();
                    //frm.set_Accion(Cl_Enumeradores.eTipo_action.borrar);

                    frm.Text = frm.Text + " ***ANULAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                //}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
    }
}
