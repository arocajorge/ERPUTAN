using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.General;


namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_ComprobanteContableXEmpresa : Form
    {
        public frmCon_ComprobanteContableXEmpresa()
        {
            InitializeComponent();
        }


        //tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        //public frmCon_ComprobanteContableXEmpresa()
        //{
        //    try
        //    {
        //      InitializeComponent();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}
        //ct_Cbtecble_tipo_Info InfoIzquir = new ct_Cbtecble_tipo_Info();
        //ct_Cbtecble_tipo_Info InfoDerecha = new ct_Cbtecble_tipo_Info();
        //List<ct_Cbtecble_tipo_Info > LstInfoIzquir = new List<ct_Cbtecble_tipo_Info>();
        //List<ct_Cbtecble_tipo_Info> LstInfoDerechane = new List<ct_Cbtecble_tipo_Info>();
        ////ct_cbtecble_tipo_x_empresa_Bus BustipoXEmpresa = new ct_cbtecble_tipo_x_empresa_Bus();
        //cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        //string MensajeError = "";
        //private void frmCt_ComprobanteContableXEmpresa_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //ct_Cbtecble_tipo_Bus Bus = new ct_Cbtecble_tipo_Bus();
        //        //LstInfoIzquir = Bus.Get_list_Cbtecble_tipo(Info.General.Cl_Enumeradores.eTipoFiltro.Normal, ref MensajeError);

        //        //var TxEmpre = BustipoXEmpresa.Get_list_cbtecble_tipo_x_empresa(param.IdEmpresa);
        //        //var ids = from q in TxEmpre
        //        //          select q.IdTipoCbte;

        //        //var Derecha = from q in LstInfoIzquir
        //        //              where ids.Contains(q.IdTipoCbte)
        //        //              select q;

        //        //gridControlCbteTipoXEmpresa.DataSource = Derecha.ToList();
        //        //foreach (var item in Derecha.ToList())
        //        //{
        //        //    LstInfoIzquir.Remove(item);
        //        //}
        //        //gridControlCbteTipo.DataSource = LstInfoIzquir;

        //        //LstInfoDerechane = (List<ct_Cbtecble_tipo_Info>)gridControlCbteTipoXEmpresa.DataSource;
        //        //foreach (var item in LstInfoDerechane)
        //        //{
        //        //    dicder.Add(item.IdTipoCbte, item);
        //        //}
        //        //LstInfoIzquir = (List<ct_Cbtecble_tipo_Info>)gridControlCbteTipo.DataSource;
        //        //foreach (var item in LstInfoIzquir)
        //        //{
        //        //    dicderIzquei.Add(item.IdTipoCbte, item);
        //        //}


        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
                
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        //private void btnDerechaTodos_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        List<ct_Cbtecble_tipo_Info> CbtesLstxEmpre;
        //        List<ct_Cbtecble_tipo_Info> CbtesLst = (List<ct_Cbtecble_tipo_Info>)gridControlCbteTipo.DataSource;
        //        if (gridViewCbteTipoXEmpresa.RowCount == 0)
        //        {
        //            CbtesLstxEmpre = new List<ct_Cbtecble_tipo_Info>();

        //        }
        //        else
        //        {
        //            CbtesLstxEmpre = (List<ct_Cbtecble_tipo_Info>)gridControlCbteTipoXEmpresa.DataSource;
        //        }
        //        if (CbtesLst != null)
        //        {
        //            foreach (var item in CbtesLst)
        //            {
        //                CbtesLstxEmpre.Add(item);
        //                gridControlCbteTipoXEmpresa.DataSource = null;
        //                gridControlCbteTipoXEmpresa.DataSource = CbtesLstxEmpre;
        //                ct_cbtecble_tipo_x_empresa_Info Info = new ct_cbtecble_tipo_x_empresa_Info();
        //                Info.IdEmpresa = param.IdEmpresa;
        //                Info.IdTipoCbte = item.IdTipoCbte;
        //                var asd = BustipoXEmpresa.GuardarDB(Info);
        //            }
        //            gridControlCbteTipo.DataSource = null;
        //            LstInfoIzquir.Clear();
        //            dicderIzquei.Clear();
        //            LstInfoDerechane = (List<ct_Cbtecble_tipo_Info>)gridControlCbteTipoXEmpresa.DataSource;
        //            dicder.Clear();
        //            foreach (var item in LstInfoDerechane)
        //            {
        //                dicder.Add(item.IdTipoCbte, item);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void BtnIzquierdaTodos_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        List<ct_Cbtecble_tipo_Info> CbtesLst; //= (List<ct_Cbtecble_tipo_Info>)gridControlCbteTipoXEmpresa.DataSource;
        //        List<ct_Cbtecble_tipo_Info> CbtesLstxEmpre = (List<ct_Cbtecble_tipo_Info>)gridControlCbteTipoXEmpresa.DataSource;
        //        if (gridViewCbteTipo.RowCount == 0)
        //        {
        //            CbtesLst = new List<ct_Cbtecble_tipo_Info>();

        //        }
        //        else
        //        {
        //            CbtesLst = (List<ct_Cbtecble_tipo_Info>)gridViewCbteTipo.DataSource;
        //        }
        //        if (CbtesLstxEmpre != null)
        //        {

        //            foreach (var item in CbtesLstxEmpre)
        //            {

        //                ct_cbtecble_tipo_x_empresa_Info Info = new ct_cbtecble_tipo_x_empresa_Info();
        //                Info.IdEmpresa = param.IdEmpresa;
        //                Info.IdTipoCbte = item.IdTipoCbte;
        //                if (BustipoXEmpresa.EliminarDB(Info))
        //                {

        //                    CbtesLst.Add(item);
        //                    gridControlCbteTipo.DataSource = null;
        //                    gridControlCbteTipo.DataSource = CbtesLst;
        //                }



        //            }
        //            gridControlCbteTipoXEmpresa.DataSource = null;
        //            LstInfoDerechane.Clear();
        //            dicder.Clear();
        //            LstInfoIzquir = (List<ct_Cbtecble_tipo_Info>)gridControlCbteTipo.DataSource;
        //            dicderIzquei.Clear();
        //            foreach (var item in LstInfoIzquir)
        //            {
        //                dicderIzquei.Add(item.IdTipoCbte, item);
        //            }
        //        }
        //         Recargar() ;
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
                
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //int focus;
        //Dictionary<int, ct_Cbtecble_tipo_Info> dicder = new Dictionary<int, ct_Cbtecble_tipo_Info>();
        //private void btnDerechaUno_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (InfoIzquir != null)
        //        {
        //            dicder.Add(InfoIzquir.IdTipoCbte, InfoIzquir);
        //            dicderIzquei.Remove(InfoIzquir.IdTipoCbte);

        //            ct_cbtecble_tipo_x_empresa_Info Info = new ct_cbtecble_tipo_x_empresa_Info();
        //            Info.IdEmpresa = param.IdEmpresa;
        //            Info.IdTipoCbte = InfoIzquir.IdTipoCbte;


        //            LstInfoDerechane.Add(InfoIzquir);
        //            var asd = BustipoXEmpresa.GuardarDB(Info);
        //            gridControlCbteTipoXEmpresa.DataSource = null;
        //            gridControlCbteTipoXEmpresa.DataSource = LstInfoDerechane;
        //            focus = gridViewCbteTipo.FocusedRowHandle;
        //            LstInfoIzquir.Remove(InfoIzquir);
        //            gridControlCbteTipo.DataSource = null;
        //            gridControlCbteTipo.DataSource = LstInfoIzquir;
        //            gridViewCbteTipo.FocusedRowHandle = focus;

                   
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void gridViewCbteTipo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    try
        //    {
        //        InfoIzquir = (ct_Cbtecble_tipo_Info)gridViewCbteTipo.GetFocusedRow();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void gridViewCbteTipoXEmpresa_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    try
        //    {
        //        InfoDerecha = (ct_Cbtecble_tipo_Info)gridViewCbteTipoXEmpresa.GetFocusedRow();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        //int focus2;
        //Dictionary<int, ct_Cbtecble_tipo_Info> dicderIzquei = new Dictionary<int, ct_Cbtecble_tipo_Info>();
        //private void btnIzquierdaUno_Click(object sender, EventArgs e)
        //{
        //    try
        //    {   ct_cbtecble_tipo_x_empresa_Info Info = new ct_cbtecble_tipo_x_empresa_Info();
        //        Info.IdEmpresa = param.IdEmpresa;
        //        Info.IdTipoCbte = InfoDerecha.IdTipoCbte;
        //        if (BustipoXEmpresa.EliminarDB(Info))
        //        {
        //            dicderIzquei.Add(InfoDerecha.IdTipoCbte, InfoDerecha);
        //            dicder.Remove(InfoDerecha.IdTipoCbte);



        //            if (InfoDerecha != null)
        //            {
        //                LstInfoIzquir.Add(InfoDerecha);
        //                gridControlCbteTipo.DataSource = null;
        //                gridControlCbteTipo.DataSource = LstInfoIzquir;
        //                focus2 = gridViewCbteTipoXEmpresa.FocusedRowHandle;

        //                LstInfoDerechane.Remove(InfoDerecha);
        //                gridControlCbteTipoXEmpresa.DataSource = null;
        //                gridControlCbteTipoXEmpresa.DataSource = LstInfoDerechane;
        //                gridViewCbteTipoXEmpresa.FocusedRowHandle = focus2;
        //            }
        //        }
        //        else 
        //        {

        //            MessageBox.Show("No Se puede Quitar Este Tipo de comprobante debido a que tiene movimientos");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        //public void Recargar() 
        //{
        //    try
        //    {
        //         dicder.Clear();
        //        dicderIzquei.Clear();
        //        frmCt_ComprobanteContableXEmpresa_Load(new Object(),new EventArgs());
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

       
        //private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

     
       
    }
}
