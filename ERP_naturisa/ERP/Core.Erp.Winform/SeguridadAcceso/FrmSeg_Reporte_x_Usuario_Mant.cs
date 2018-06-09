using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.SeguridadAcceso;


namespace Core.Erp.Winform.SeguridadAcceso
{
    public partial class FrmSeg_Reporte_x_Usuario_Mant : Form
    {
        string MensajeError = "";
        seg_usuario_x_tb_sis_reporte_Bus BusUsua_x_rep = new seg_usuario_x_tb_sis_reporte_Bus();
        

        BindingList<seg_usuario_x_tb_sis_reporte_Info> BindingListUsua_x_rep = new BindingList<seg_usuario_x_tb_sis_reporte_Info>();
        List<seg_usuario_x_tb_sis_reporte_Info> List_x_reporte = new List<seg_usuario_x_tb_sis_reporte_Info>();





        public FrmSeg_Reporte_x_Usuario_Mant()
        {
            InitializeComponent();
        }

        private void FrmSeg_Reporte_x_Usuario_Mant_Load(object sender, EventArgs e)
        {
            cargar_combo();
        }

        void cargar_combo()
        {
            try
            {
                seg_usuario_bus BusUsua = new seg_usuario_bus();
                List<seg_usuario_info> ListUsuario = new List<seg_usuario_info>();
                ListUsuario=BusUsua.Get_List_Usuario(ref MensajeError);
                cmb_usuario.Properties.DataSource = ListUsuario;



            }
            catch (Exception ex)
            {

            }

        }

        private void gridControlReporte_Click(object sender, EventArgs e)
        {

        }

        private void cmb_usuario_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                if (cmb_usuario.EditValue != null)
                {
                    string IdUsuario = cmb_usuario.EditValue.ToString();
                    BindingListUsua_x_rep = new BindingList<seg_usuario_x_tb_sis_reporte_Info>(BusUsua_x_rep.Get_List_Menu(IdUsuario));
                    gridControlReporte.DataSource = BindingListUsua_x_rep;
                }


            }
            catch (Exception ex)
            {

            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {

        }

        string MensajeError_ = "";


        Boolean Guardar()
        {

            try
            {
                
                string IdUsuario = "";


                Boolean Repuesto = false;
                IdUsuario = cmb_usuario.EditValue.ToString();
                
                Repuesto = BusUsua_x_rep.EliminarDB(IdUsuario, ref MensajeError_);

                List_x_reporte = new List<seg_usuario_x_tb_sis_reporte_Info>();


                foreach (var item in BindingListUsua_x_rep.Select(v => v.InfoReporte.esta_en_base == true))
                {
                    seg_usuario_x_tb_sis_reporte_Info info1 = new seg_usuario_x_tb_sis_reporte_Info();
                    info1.IdUsuario = "";
                    info1.CodReporte = "";
                    info1.observacion = "";

                    List_x_reporte.Add(info1);
                }


                if (Repuesto)
                {
                    Repuesto = BusUsua_x_rep.GrabarDB(List_x_reporte, ref MensajeError_);
                }

                return Repuesto;

            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
