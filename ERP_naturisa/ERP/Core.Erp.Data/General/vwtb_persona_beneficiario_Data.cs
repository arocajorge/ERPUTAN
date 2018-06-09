using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.General
{
  public  class vwtb_persona_beneficiario_Data
    {
      string mensaje = "";
      public List<vwtb_persona_beneficiario_Info> Get_List_PersonaBeneficiario(int IdEmpresa)
      {
          try
          {
              List<vwtb_persona_beneficiario_Info> lM = new List<vwtb_persona_beneficiario_Info>();
              EntitiesGeneral OEUs = new EntitiesGeneral();

              var selectBeneficiario = from selec in OEUs.vwtb_persona_beneficiario
                            where selec.IdEmpresa == IdEmpresa
                            select selec;
              foreach (var item in selectBeneficiario)
              {

                  vwtb_persona_beneficiario_Info info = new vwtb_persona_beneficiario_Info();

                  info.IdEmpresa = item.IdEmpresa;
                  info.IdBeneficiario = item.IdBeneficiario;
                  info.IdTipo_Persona = item.IdTipo_Persona;
                  info.IdPersona = item.IdPersona;
                  info.IdEntidad = item.IdEntidad;
                  info.Codigo = item.Codigo;
                  info.Nombre = item.Nombre;
                  info.pr_girar_cheque_a = item.pr_girar_cheque_a;
                  info.pe_razonSocial = item.pe_razonSocial;
                  info.pe_cedulaRuc = item.pe_cedulaRuc;

                  info.pe_Naturaleza = item.pe_Naturaleza;
                  info.IdCtaCble = item.IdCtaCble;
                  info.IdCentroCosto = item.IdCentroCosto;
                  info.IdSubCentroCosto = item.IdSubCentroCosto;

                  info.NombreCompleto = "[" + info.IdTipo_Persona + "]" + "[" + item.IdEntidad + "]" + "[" + item.Nombre + "]";

                 

                  info.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                  info.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                  info.Estado = item.Estado;

                  lM.Add(info);
              }
              return (lM);
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public List<vwtb_persona_beneficiario_Info> Get_List_PersonaBeneficiario(int IdEmpresa, string IdTipo_Persona)
      {
          try
          {
              if (IdTipo_Persona == "TODOS")
              {
                  IdTipo_Persona = "";
              }


              List<vwtb_persona_beneficiario_Info> lM = new List<vwtb_persona_beneficiario_Info>();
              EntitiesGeneral OEUs = new EntitiesGeneral();
              var selectBeneficiario = from selec in OEUs.vwtb_persona_beneficiario
                                           where selec.IdEmpresa == IdEmpresa
                                           && selec.IdTipo_Persona.Contains(IdTipo_Persona)
                                           select selec;
              
              foreach (var item in selectBeneficiario)
              {
                  vwtb_persona_beneficiario_Info info = new vwtb_persona_beneficiario_Info();
                  info.IdEmpresa = item.IdEmpresa;
                  info.IdBeneficiario = item.IdBeneficiario;
                  info.IdTipo_Persona = item.IdTipo_Persona;
                  info.IdPersona = item.IdPersona;
                  info.IdEntidad = item.IdEntidad;
                  info.Codigo = item.Codigo;
                  info.Nombre = item.Nombre;
                  info.pr_girar_cheque_a = item.pr_girar_cheque_a;
                  info.pe_razonSocial = item.pe_razonSocial;
                  info.pe_cedulaRuc = item.pe_cedulaRuc;
                  info.pe_Naturaleza = item.pe_Naturaleza;
                  info.IdCtaCble = item.IdCtaCble;
                  info.IdCentroCosto = item.IdCentroCosto;
                  info.IdSubCentroCosto = item.IdSubCentroCosto;
                  info.NombreCompleto = "[" + info.IdTipo_Persona + "]" + "[" + item.IdEntidad + "]" + "[" + item.Nombre + "]";
                  info.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                  info.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                  info.Estado = item.Estado;
                  lM.Add(info);
              }
              return (lM);
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public vwtb_persona_beneficiario_Info Get_Info_PersonaBeneficiario(int IdEmpresa, decimal IdEntidad, string IdTipo_Persona)
      {
          try
          {
              vwtb_persona_beneficiario_Info info = new vwtb_persona_beneficiario_Info();
              EntitiesGeneral OEUser = new EntitiesGeneral();

              var selectBeneficiario = from selec in OEUser.vwtb_persona_beneficiario

                                       where selec.IdEmpresa == IdEmpresa
                                       && selec.IdEntidad == IdEntidad
                                       && selec.IdTipo_Persona == IdTipo_Persona
                                       select selec;
              foreach (var item in selectBeneficiario)
              {
                  vwtb_persona_beneficiario_Info info_beneficiario = new vwtb_persona_beneficiario_Info();

                  info_beneficiario.IdEmpresa = item.IdEmpresa;
                  info.IdBeneficiario = item.IdBeneficiario;
                  info_beneficiario.pr_girar_cheque_a = item.pr_girar_cheque_a;

                  info_beneficiario.IdTipo_Persona = item.IdTipo_Persona;
                  info_beneficiario.IdEntidad = item.IdEntidad;
                  info_beneficiario.Nombre = "[" + item.IdTipo_Persona + "]" + "[" + item.IdEntidad + "]" + "[" + item.Nombre + "]";
                  info_beneficiario.pe_cedulaRuc = item.pe_cedulaRuc;
                  info_beneficiario.pe_Naturaleza = item.pe_Naturaleza;
                  info_beneficiario.IdPersona = item.IdPersona;
                  info_beneficiario.IdCtaCble = item.IdCtaCble;

                  info_beneficiario.IdCentroCosto = item.IdCentroCosto;
                  info_beneficiario.IdSubCentroCosto = item.IdSubCentroCosto;

                  info_beneficiario.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                  info_beneficiario.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                  info_beneficiario.Estado = item.Estado;



                  info = info_beneficiario;
              }
              return (info);
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }




      public List<vwtb_persona_beneficiario_Info> Get_List_Datos_Beneficiarios(int IdEmpresa)
      {              List<vwtb_persona_beneficiario_Info> lM = new List<vwtb_persona_beneficiario_Info>();

          try
          {
              EntitiesGeneral OEUs = new EntitiesGeneral();
              {
                  lM = (from q in OEUs.vwtb_persona_beneficiario_por_Banco_Acreditacion
                        where q.IdEmpresa == IdEmpresa

                        select new vwtb_persona_beneficiario_Info
                        {
                            IdEmpresa=q.IdEmpresa,
                            IdEntidad=q.IdEntidad,
                            IdPersona=q.IdPersona,
                            IdTipo_Persona=q.IdTipo_Persona,
                            pe_cedulaRuc=q.pe_cedulaRuc,
                            ba_descripcion= q.ba_descripcion,
                            IdTipoDocumento=q.IdTipoDocumento,
                            CodigoLegal=q.CodigoLegal,
                            num_cta_acreditacion=q.num_cta_acreditacion,
                            IdTipoCta_acreditacion_cat=q.IdTipoCta_acreditacion_cat
                        }).ToList();


              }
             
             
                  
              
              return (lM);
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

    }
}
