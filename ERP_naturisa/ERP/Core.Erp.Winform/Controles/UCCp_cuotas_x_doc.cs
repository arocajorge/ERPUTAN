using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;

namespace Core.Erp.Winform.Controles
{
    public partial class UCCp_cuotas_x_doc : UserControl
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_cuotas_x_doc_Info info_cuota = new cp_cuotas_x_doc_Info();
        cp_cuotas_x_doc_Bus bus_cuota = new cp_cuotas_x_doc_Bus();
        cp_cuotas_x_doc_det_Bus bus_cuota_det = new cp_cuotas_x_doc_det_Bus();
        BindingList<cp_cuotas_x_doc_det_Info> blst_cuotas_det = new BindingList<cp_cuotas_x_doc_det_Info>();
        #endregion

        public UCCp_cuotas_x_doc()
        {
            InitializeComponent();
        }        

        private void txt_num_cuotas_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Calcular_cuotas();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_dias_plazo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Calcular_cuotas();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_total_a_pagar_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Calcular_cuotas();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void de_fecha_inicio_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Calcular_cuotas();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Calcular_cuotas()
        {
            try
            {
                blst_cuotas_det = new BindingList<cp_cuotas_x_doc_det_Info>();
                int Dias_plazo = (txt_dias_plazo.EditValue == null || txt_dias_plazo.Text == "") ? 0 : Convert.ToInt32(txt_dias_plazo.EditValue);
                int Num_cuotas = (txt_num_cuotas.EditValue == null || txt_num_cuotas.Text == "") ? 0 : Convert.ToInt32(txt_num_cuotas.EditValue);
                double Total_a_pagar = (txt_total_a_pagar.EditValue == null || txt_total_a_pagar.Text == "") ? 0 : Convert.ToDouble(txt_total_a_pagar.EditValue);
                DateTime Fecha_inicio = de_fecha_inicio.EditValue == null ? DateTime.Now : Convert.ToDateTime(de_fecha_inicio.EditValue);
                DateTime ult_fecha_vcto = Fecha_inicio.Date.AddDays(Dias_plazo);
                double valor_cuota = Total_a_pagar /Num_cuotas;

                if (Dias_plazo == 0 || Num_cuotas == 0 || Total_a_pagar == 0)
                    return;

                for (int i = 0; i < Num_cuotas; i++)
                {
                    cp_cuotas_x_doc_det_Info info = new cp_cuotas_x_doc_det_Info();

                    info.IdEmpresa = param.IdEmpresa;
                    info.Secuencia = i + 1;
                    info.Num_cuota = i + 1;
                    info.Valor_cuota = Math.Round(valor_cuota < Total_a_pagar ? valor_cuota : Total_a_pagar ,2,MidpointRounding.AwayFromZero);
                    Total_a_pagar = Total_a_pagar - valor_cuota;
                    info.Fecha_vcto_cuota = ult_fecha_vcto;
                    ult_fecha_vcto = ult_fecha_vcto.Date.AddDays(Dias_plazo);
                    info.Estado = false;

                    blst_cuotas_det.Add(info);
                }

                gridControlCuotas.DataSource = blst_cuotas_det;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCCp_cuotas_x_doc_Load(object sender, EventArgs e)
        {
            try
            {                
                gridControlCuotas.DataSource = blst_cuotas_det;
              //  de_fecha_inicio.EditValue = DateTime.Now;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_info_cuota(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                info_cuota = bus_cuota.Get_info_cuotas_x_doc(IdEmpresa, IdTipoCbte, IdCbteCble);
                if (info_cuota!= null)
                {
                    Set_info_cuota_in_controls();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_info_cuota(int IdEmpresa, decimal IdCuota)
        {
            try
            {
                info_cuota = bus_cuota.Get_info_cuotas_x_doc(IdEmpresa, IdCuota);
                if (info_cuota != null)
                {
                    Set_info_cuota_in_controls();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Set_info_cuota_in_controls()
        {
            try
            {
                txt_dias_plazo.Text = info_cuota.Dias_plazo.ToString();
                txt_num_cuotas.Text = info_cuota.Num_cuotas.ToString();
                txt_observacion.Text = info_cuota.Observacion;
                txt_total_a_pagar.Text = info_cuota.Total_a_pagar.ToString();
                de_fecha_inicio.EditValue = info_cuota.Fecha_inicio.Date;

                info_cuota.lst_cuotas_det = bus_cuota_det.Get_list_cuotas_x_doc_det(info_cuota.IdEmpresa, info_cuota.IdCuota);
                blst_cuotas_det = new BindingList<cp_cuotas_x_doc_det_Info>(info_cuota.lst_cuotas_det);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public cp_cuotas_x_doc_Info Get_info_cuota()
        {
            try
            {
                info_cuota.IdEmpresa = param.IdEmpresa;
                info_cuota.Dias_plazo = (txt_dias_plazo.EditValue == null || txt_dias_plazo.Text == "") ? 0 : Convert.ToInt32(txt_dias_plazo.EditValue);
                info_cuota.Num_cuotas = (txt_num_cuotas.EditValue == null || txt_num_cuotas.Text == "") ? 0 : Convert.ToInt32(txt_num_cuotas.EditValue);
                info_cuota.Total_a_pagar = (txt_total_a_pagar.EditValue == null || txt_total_a_pagar.Text == "") ? 0 : Convert.ToDouble(txt_total_a_pagar.EditValue);
                info_cuota.Fecha_inicio = de_fecha_inicio.EditValue == null ? DateTime.Now : Convert.ToDateTime(de_fecha_inicio.EditValue);
                info_cuota.Observacion = txt_observacion.Text;

                info_cuota.lst_cuotas_det = new List<cp_cuotas_x_doc_det_Info>(blst_cuotas_det);
                return info_cuota;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

    }
}
