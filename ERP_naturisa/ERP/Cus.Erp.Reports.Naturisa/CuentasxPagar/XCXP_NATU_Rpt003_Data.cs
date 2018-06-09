using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt003_Data
    { 
        public List<XCXP_NATU_Rpt003_Info> consultar_data
        (int IdEmpresa, Decimal IdProveedor, string Tipo_Persona,  DateTime co_fechaOg_Ini, DateTime co_fechaOg_Fin, ref String mensaje)
        {
            try
            {
                List<XCXP_NATU_Rpt003_Info> listadedatos = new List<XCXP_NATU_Rpt003_Info>();

                DateTime FechaIni = Convert.ToDateTime(co_fechaOg_Ini.ToShortDateString());
                DateTime FechaFin = Convert.ToDateTime(co_fechaOg_Fin.ToShortDateString());

                double? Saldo = 0;
                Boolean PrimerRegistro = true;

                if (Tipo_Persona == "TODOS")
                {
                    Tipo_Persona = "";
                }

                using (EntitiesCXP_Rpt_Naturisa Estactaprovee = new EntitiesCXP_Rpt_Naturisa())
                {
                    var select = from h in Estactaprovee.spCXP_NATU_Rpt003(IdEmpresa, IdProveedor, Tipo_Persona, co_fechaOg_Ini, co_fechaOg_Fin)
                                 where h.IdEmpresa == IdEmpresa
                                 && h.IdProveedor == IdProveedor
                                 && h.co_fechaOg >= FechaIni && h.co_fechaOg <= FechaFin
                                 && h.Tipo_persona.Contains(Tipo_Persona)
                                 select h;

                    foreach (var item in select)
                    {
                        if (PrimerRegistro)
                        {
                            Saldo = (item.SaldoInicial == null) ? 0 : Convert.ToDouble(item.SaldoInicial);
                            PrimerRegistro = false;
                        }
                        XCXP_NATU_Rpt003_Info Info = new XCXP_NATU_Rpt003_Info();
                        //lleno los campos de mi clase info
                        Info.IdEmpresa=item.IdEmpresa;
                        Info.IdCbteCble_Ogiro=item.IdCbteCble_Ogiro;
                        Info.IdTipoCbte_Ogiro=item.IdTipoCbte_Ogiro;
                        Info.IdOrden_giro_Tipo=item.IdOrden_giro_Tipo;
                        Info.Documento=item.Documento;
                        Info.nom_tipo_doc=item.nom_tipo_doc;
                        Info.cod_tipo_doc=item.cod_tipo_doc;
                        Info.co_fechaOg=item.co_fechaOg;
                        Info.Tipo_persona=item.Tipo_persona;
                        Info.IdProveedor=item.IdProveedor;
                        Info.IdPersona=item.IdPersona;
                        Info.nom_proveedor=item.nom_proveedor;
                        Info.Observacion=item.Observacion;
                        Info.Valor_a_pagar=item.Valor_a_pagar;
                        Info.Valor_debe=item.Valor_debe;
                        Info.Valor_Haber=item.Valor_Haber;
                        //elementos del spCXP_NATU_Rpt003
                        Info.SaldoInicial=item.SaldoInicial;
                        Info.SaldoFinal=item.SaldoFinal;
                        //datos de la tb_empresa
                        Info.ruc_Empresa=item.ruc_Empresa;
                        Info.nom_empresa=item.nom_empresa;
                        //calculo mi saldo y lo asigno a mi info
                        Saldo = Saldo + ((item.Valor_debe > 0) ? item.Valor_debe : item.Valor_Haber * -1);
                        Info.Saldo = Saldo;                        
                        //añado mi información a la lista
                        listadedatos.Add(Info);
                    }
                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                return new List<XCXP_NATU_Rpt003_Info>();
            }
	    }
       
    }
}
