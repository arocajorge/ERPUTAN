using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.CuentasxPagar;

//version 23-04-2013  19:02
namespace Core.Erp.Winform.CuentasxPagar
{ 
    public partial class frmCP_RetencionProveedor : Form
    {

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_Periodo_Bus Per_B = new ct_Periodo_Bus();
        ct_Periodo_Info Per_I = new ct_Periodo_Info();
        cp_parametros_Info paramCP_I = new cp_parametros_Info();
        cp_parametros_Bus paramCP_B = new cp_parametros_Bus();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public ct_Cbtecble_Info CbteCble_R { get; set; }

        private List<cp_retencion_det_Info> LstRetencion { get; set; }
        public cp_retencion_Info CabRetencion { get; set; }

        string nDocu = "";
        string TipoDoc = "";
        string NomProve = "";

        public frmCP_RetencionProveedor(double DvalorIVA, double DBaseImponible, cp_retencion_Info CabRetencion, decimal IdProveedor, DateTime fechaRetencion, Boolean VerNumRetencion = false, decimal NRetencion = 0)
        {

            try
            {
                InitializeComponent();

                string MensajeError = "";

                nDocu = CabRetencion.NumRetencion;
                TipoDoc = CabRetencion.TipoDocumento;
                NomProve = CabRetencion.NomProveedor;

                Per_I = Per_B.Get_Info_Periodo(param.IdEmpresa, fechaRetencion, ref MensajeError);

                paramCP_I = paramCP_B.Get_Info_parametros(param.IdEmpresa);
             
                    if(CabRetencion ==null)
                    {
                    CabRetencion = new cp_retencion_Info();
                    }

                ucCp_Retencion1.set_Valores(DBaseImponible, DvalorIVA);

                ucCp_Retencion1.carga_codigoSRI_x_Proveedor(param.IdEmpresa, IdProveedor);
              
              
                LstRetencion = CabRetencion.ListDetalle;
                ucCp_Retencion1.Dock = DockStyle.Fill;
             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean getDiarioRetencion()
        {
            Boolean res = true;
            try
            {
                CbteCble_R = new ct_Cbtecble_Info();
                CbteCble_R = ucCp_Retencion1.Get_Info_CbteCble_Retencion();

                if (CbteCble_R._cbteCble_det_lista_info.Count != 0)
                {
                    double total = 0;
                    string Tipo = ""; string Porc = "";
                    int c = 0; int i = 0;

                
                    foreach (var item in CbteCble_R._cbteCble_det_lista_info)
                    {
                        if (c == 0)
                        {
                            try
                            {
                                Tipo = item.tipo;
                            }
                            catch (Exception ex)
                            {
                                Log_Error_bus.Log_Error(ex.ToString());
                            }

                            i++;
                        }
                        else
                            c = 0;
                        item.IdEmpresa = param.IdEmpresa;

                        item.dc_Observacion = "Ret x Conciliacion de Caja " + Tipo + "/" + Porc + "% al Prov:"
                            + NomProve + " " + TipoDoc + " Doc#" + nDocu + " "
                            + item.dc_Observacion;

                        if (item.dc_Valor > 0)
                            total = item.dc_Valor + total;
                    }

                    CbteCble_R.IdEmpresa = param.IdEmpresa;
                    CbteCble_R.IdTipoCbte = Convert.ToInt32(paramCP_I.pa_IdTipoCbte_x_Retencion);
                    CbteCble_R.CodCbteCble = "";
                    CbteCble_R.IdPeriodo = Per_I.IdPeriodo;
                    CbteCble_R.cb_Fecha = ucCp_Retencion1.dtp_fechaEmisionRetencion.Value;

                    CbteCble_R.cb_Valor = total;
                    CbteCble_R.cb_Observacion = "Diario x Cbte Ret x Conciliacion de Caja del Prov:"
                                + NomProve + " " + TipoDoc + " Doc#" + nDocu;
                    CbteCble_R.Secuencia = 0;
                    CbteCble_R.Estado = "A";
                    CbteCble_R.Anio = ucCp_Retencion1.dtp_fechaEmisionRetencion.Value.Year;
                    CbteCble_R.Mes = ucCp_Retencion1.dtp_fechaEmisionRetencion.Value.Month;

                    CbteCble_R.IdUsuario = param.IdUsuario;
                    CbteCble_R.IdUsuarioUltModi = param.IdUsuario;
                    CbteCble_R.cb_FechaTransac = param.Fecha_Transac;
                    CbteCble_R.cb_FechaUltModi = param.Fecha_Transac;
                    CbteCble_R.Mayorizado = "N";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            } return res;
        }

       
        private void FrmCP_RetencionProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean validar(ref string msg)
        {
            try
            {
                            
                if (Per_I == null)
                {
                    MessageBox.Show("No se procedió a Grabar porque el Periodo no se encuentra ingresado ", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (Per_I.pe_cerrado == "S")
                {
                    MessageBox.Show("No se procedió a Grabar porque el Periodo se encuentra cerrado ", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (paramCP_I.pa_IdTipoCbte_x_Retencion == null || paramCP_I.pa_IdTipoCbte_x_Retencion == 0)
                {
                    MessageBox.Show("No puede continuar porque están incompletos los parámetros de Cuentas por Pagar, Falta ingresar el tipo de Comprobante Con el que se Genera la Retención.. " +
                        "\nIngréselos desde la pantalla de parámetros Cuentas por Pagar,o comuníquese con sistemas", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                
        }

        private void toolStripButton_Aplicar_Click(object sender, EventArgs e)
        {
            try
            {
                bool valida=true;

                CabRetencion = ucCp_Retencion1.Get_Info_Retencion(ref valida);
                LstRetencion = ucCp_Retencion1.Get_list_det_Retencion(ref valida);
                 
                if (!ucCp_Retencion1.ValidarAsientosContables())
                {
                    valida= false;
                }

                string msg = "";
                if (validar(ref msg) == false)
                {
                    valida = false;
                }
                else
                {
                    getDiarioRetencion();               
                }
                             
                CabRetencion.ListDetalle = LstRetencion;

                  if(valida == true)
                    this.Close();
                else
                    LstRetencion=null;
            }
            catch(Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
    }
}

/// <summary>
/// Prog: Katiuska Franco
/// Ult Mod: 14/02/2014 11:42
/// </summary>