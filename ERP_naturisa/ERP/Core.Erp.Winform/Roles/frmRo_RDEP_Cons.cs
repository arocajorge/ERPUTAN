/*CLASE: frmRo_RDEP_Cons
 *CREADO POR: ALBERTO MENA
 *FECHA: 04-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Controles;

using Core.Erp.Info.class_sri.RDEP;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_RDEP_Cons : Form
    {
        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";

        frmRo_RDEP_Mant frm = new frmRo_RDEP_Mant();

        //BUS
        BindingList<ro_Rdep_Info> oListRo_Rdep_Info = new BindingList<ro_Rdep_Info>();
        ro_Rdep_Bus oRo_Rdep_Bus = new ro_Rdep_Bus();

        //INFO
        ro_Rdep_Info _Info = new ro_Rdep_Info();


        #endregion



        public frmRo_RDEP_Cons()
        {
            try
            {
                InitializeComponent();

                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;

                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;

                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;

                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;

                ucGe_Menu_Mantenimiento_x_usuario.event_btnGenerarXml_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnGenerarXml_ItemClick;

     
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;

                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pu_Anular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                pu_ConsultarPorFecha();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

 

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnGenerarXml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pu_GenerarXML();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }   
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_Info != null)
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.consultar);
                }
                else
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_Info != null)
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
                }
                else
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


        private void frmRo_RDEP_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                pu_CargaInicial();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void pu_CargaInicial() {
            try {
                //LLENA LA GRILLA
                oListRo_Rdep_Info.Clear();
                oListRo_Rdep_Info = new BindingList<ro_Rdep_Info>(oRo_Rdep_Bus.GetListGeneral(param.IdEmpresa, ref mensaje));
                gridRDEP.DataSource = oListRo_Rdep_Info;


                //COMBO PERIODOFISCAL
                int anioActual = 0;
                anioActual = param.Fecha_Transac.Year;

                cmbAnioFiscal.Items.Clear();

                for (int i = 5; i > 0; i--)
                {
                    cmbAnioFiscal.Items.Add(anioActual);
                    anioActual -= 1;
                }

                if (cmbAnioFiscal.Items.Count > 0)
                {
                    cmbAnioFiscal.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }        
        }


        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmRo_RDEP_Mant();
                frm.Event_frmRo_RDEP_Mant_FormClosing += frm_Event_frmRo_RDEP_Mant_FormClosing;

                frm.setAccion(Accion);

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    _Info = (ro_Rdep_Info)viewRDEP.GetFocusedRow();
                    frm.setInfo(_Info);
                }

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void frm_Event_frmRo_RDEP_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                pu_CargaInicial();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void viewRDEP_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _Info = (ro_Rdep_Info)viewRDEP.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        //private void viewRDEP_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        //{
        //    try
        //    {
        //        var data = viewRDEP.GetRow(e.RowHandle) as ro_Rdep_Info;
        //        if (data == null)
        //            return;

        //        if (data.Estado == "I")
        //            e.Appearance.ForeColor = Color.Red;
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}


        private void pu_ConsultarPorFecha() {
            try {

                DateTime fechaInicial = ucGe_Menu_Mantenimiento_x_usuario.fecha_desde.Date;
                DateTime fechaFin = ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta.Date;

                //LLENA LA GRILLA
                oListRo_Rdep_Info.Clear();

                oListRo_Rdep_Info = new BindingList<ro_Rdep_Info>(oRo_Rdep_Bus.GetListGeneral(param.IdEmpresa, ref mensaje).Where(v => (v.FechaIngresa.Date>=fechaInicial) && (v.FechaIngresa.Date<=fechaFin)).ToList());
                gridRDEP.DataSource = oListRo_Rdep_Info;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }        
        }

        private void pu_SeleccionarTodos(Boolean opcion){

            try {

                if (oListRo_Rdep_Info.Count > 0)
                {
                    foreach (ro_Rdep_Info item in oListRo_Rdep_Info)
                    {
                        item.Check = opcion;
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


        private void pu_GenerarXML() {
            try {
                ucGe_Menu_Mantenimiento_x_usuario.Focus();
                string rutaArchivo = "C:/";
                int contSeleccionado=0;


                foreach(var item in oListRo_Rdep_Info){
                    
                    if(item.Check){
                        contSeleccionado++;
                        break;
                    }
                }

                if (contSeleccionado==0) {
                    MessageBox.Show("Debe seleccionar por lo menos un registro para la Generación del Archivo XML, revise por favor","ATENCION", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    return;
                }

                if (MessageBox.Show("Está seguro que desea generar el Archivo XML para el Año Fiscal: " + cmbAnioFiscal.Text + ", recuerde que unicamente los registros seleccioandos que tengan el estado de activo serán procesados", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (oListRo_Rdep_Info.Count > 0)
                    {
                        ro_Rdep_Bus oRo_Rdep_Bus = new Business.Roles.ro_Rdep_Bus();

                        List<ro_Rdep_Info> oListRdep = new List<ro_Rdep_Info>();

                        oListRdep.Clear();
                        foreach (ro_Rdep_Info item in oListRo_Rdep_Info)
                        {
                            if (item.Check && item.Estado == "A")
                            {
                                oListRdep.Add(item);
                            }
                        }

                        //GENERAR ARCHIVO XML             
                        if (oRo_Rdep_Bus.pu_GenerarXMLRDEP(oListRdep, param.IdEmpresa, Convert.ToInt32(cmbAnioFiscal.Text), ref rutaArchivo, ref mensaje))
                        {
                            MessageBox.Show("El Archivo XML ha sido generado con éxito, y se encuentra en la siguiente ruta: " + rutaArchivo.Trim(), "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se ha procedido a generar el archivo XML, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            { 
                pu_SeleccionarTodos(chkTodos.Checked); 
                gridRDEP.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }



        private void pu_ConsultarPorAnioFiscal()
        {
            try
            {

                DateTime fechaInicial = ucGe_Menu_Mantenimiento_x_usuario.fecha_desde;
                DateTime fechaFin = ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta;

                //LLENA LA GRILLA
                oListRo_Rdep_Info.Clear();

                oListRo_Rdep_Info = new BindingList<ro_Rdep_Info>(oRo_Rdep_Bus.GetListGeneral(param.IdEmpresa, ref mensaje).Where(v =>v.AnioFiscal==Convert.ToInt32(cmbAnioFiscal.Text)).ToList());
                gridRDEP.DataSource = oListRo_Rdep_Info;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void cmbAnioFiscal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pu_ConsultarPorAnioFiscal();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }




        private void pu_Anular() {
            try
            {
               
                _Info = (ro_Rdep_Info)viewRDEP.GetFocusedRow();

                if (_Info == null)
                {
                    MessageBox.Show("Debe seleccionar un registro, revise poer favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (_Info.Estado == "I")
                {
                    MessageBox.Show("No se procedió con la anulación porque ya está anulado", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (MessageBox.Show("¿Está seguro que desea ANULAR el registro seleccionado?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Motivo por Anulación
                    string motiAnulacion = "";
                    FrmGe_MotivoAnulacion frmAnula = new FrmGe_MotivoAnulacion();
                    frmAnula.ShowDialog();
                    motiAnulacion = frmAnula.motivoAnulacion;
                    
                    _Info.MotiAnula = motiAnulacion;
                    _Info.Fecha_UltAnu = param.Fecha_Transac;
                    _Info.IdUsuarioUltAnu = param.IdUsuario;
                    _Info.Estado = "I";

                    if (oRo_Rdep_Bus.GuardarBD(_Info, ref mensaje))
                    {
                        MessageBox.Show("El Registro ha anulado exitosamente", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pu_CargaInicial();
                    }
                    else
                        MessageBox.Show("Error al anular el contrato", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        
        }

        private void viewRDEP_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
              try
              {
                  var data = viewRDEP.GetRow(e.RowHandle) as ro_Rdep_Info;
                  if (data == null)
                      return;

                  if (data.Estado == "I")
                      e.Appearance.ForeColor = Color.Red;
              }
              catch (Exception ex)
              {
                  Log_Error_bus.Log_Error(ex.ToString());
                  MessageBox.Show(ex.ToString());
              }
        }
    }
}
