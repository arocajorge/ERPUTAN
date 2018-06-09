using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Academico
{
    public class XACA_Rpt001_Data
    {
        tb_Empresa_Data DataEmp = new tb_Empresa_Data();
        tb_Empresa_Info InfoEmp = new tb_Empresa_Info();

        public List<XACA_Rpt001_Info> Consultar_data(int IdEmpresa, int IdEstudiante, ref string mensaje)
        {
            List<XACA_Rpt001_Info> listadedatos = new List<XACA_Rpt001_Info>();

            try
            {
                

                using (Entities_Academico_Reporte FichaEstudiante = new Entities_Academico_Reporte())
                {
                    var select = from h in FichaEstudiante.vwACA_Rpt001
                                 where h.IdEmpresa == IdEmpresa
                                 && h.IdEstudiante == IdEstudiante
                                 select h;


                    InfoEmp = DataEmp.Get_Info_Empresa(IdEmpresa);


                    foreach (var item in select)
                    {

                        XACA_Rpt001_Info itemInfo = new XACA_Rpt001_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdEstudiante = item.IdEstudiante;
                        itemInfo.IdPersonaEstudiante = item.IdPersonaEstudiante;
                        itemInfo.cod_estudiante = item.cod_estudiante;
                        itemInfo.IdTipoDocumento = item.IdTipoDocumento;
                        itemInfo.DescTipoDocumento = item.DescTipoDocumento;
                        itemInfo.pe_cedulaRuc = item.pe_cedulaRuc;
                        itemInfo.pe_nombre = item.pe_nombre;
                        itemInfo.pe_apellido = item.pe_apellido;
                        itemInfo.IdPais_Nacionalidad = item.IdPais_Nacionalidad;
                        itemInfo.Nacionalidad = item.Nacionalidad;
                        itemInfo.lugar = item.lugar;
                        itemInfo.barrio = item.barrio;
                        itemInfo.pe_direccion = item.pe_direccion;
                        itemInfo.pe_celular = item.pe_celular;
                        itemInfo.pe_telefonoCasa = item.pe_telefonoCasa;
                        itemInfo.pe_correo = item.pe_correo;
                        itemInfo.pe_fechaNacimiento = Convert.ToDateTime(item.pe_fechaNacimiento);
                        itemInfo.pe_sexo = item.pe_sexo;
                        itemInfo.descripcion_sexo = item.descripcion_sexo;
                        itemInfo.IDGrupoSanguineo = item.IDGrupoSanguineo;
                        itemInfo.DescGrupoSanguineo = item.DescGrupoSanguineo;
                        itemInfo.Medica_contraIndic = item.Medica_contraIndic;
                        itemInfo.Otras_Indicaciones_medicas = item.Otras_Indicaciones_medicas;
                        itemInfo.Seguro_medico = item.Seguro_medico;
                        itemInfo.IdFamiliarMadre = Convert.ToDecimal(item.IdFamiliarMadre);
                        itemInfo.CedulaMadre = item.CedulaMadre;
                        itemInfo.ApellidoMadre = item.ApellidoMadre;
                        itemInfo.NombreMadre = item.NombreMadre;
                        itemInfo.IdPersonaMadre = Convert.ToDecimal(item.IdPersonaMadre);
                        itemInfo.IDParentescoMadre = item.IDParentescoMadre;
                        itemInfo.DescParentescoMadre = item.DescParentescoMadre;
                        itemInfo.empresa_direccionMadre = item.empresa_direccionMadre;
                        itemInfo.empresa_donde_trabajaMadre = item.empresa_donde_trabajaMadre;
                        itemInfo.empresa_telefonoMadre = item.empresa_telefonoMadre;
                        itemInfo.idNivelEducativoMadre = item.idNivelEducativoMadre;
                        itemInfo.DescNivelEducativoMadre = item.DescNivelEducativoMadre;
                        itemInfo.TituloMadre = item.TituloMadre;
                        itemInfo.IdFamiliarPadre = Convert.ToDecimal(item.IdFamiliarPadre);
                        itemInfo.CedulaPadre = item.CedulaPadre;
                        itemInfo.ApellidoPadre = item.ApellidoPadre;
                        itemInfo.NombrePadre = item.NombrePadre;
                        itemInfo.IdPersonaPadre = Convert.ToDecimal(item.IdPersonaPadre);
                        itemInfo.IDParentescoPadre = item.IDParentescoPadre;
                        itemInfo.DescParentescoPadre = item.DescParentescoPadre;
                        itemInfo.empresa_direccionPadre = item.empresa_direccionPadre;
                        itemInfo.empresa_donde_trabajaPadre = item.empresa_donde_trabajaPadre;
                        itemInfo.empresa_telefonoPadre = item.empresa_telefonoPadre;
                        itemInfo.idNivelEducativoPadre = item.idNivelEducativoPadre;
                        itemInfo.DescNivelEducativoPadre = item.DescNivelEducativoPadre;
                        itemInfo.TituloPadre = item.TituloPadre;
                        itemInfo.TituloPadre = item.TituloPadre;
                        itemInfo.IdFamiliarRepEco = Convert.ToDecimal(item.IdFamiliarRepEco);
                        itemInfo.ApellidoRepEco = item.ApellidoRepEco;
                        itemInfo.NombreRepEco = item.NombreRepEco;
                        itemInfo.IdPersonaRepEco = Convert.ToDecimal(item.IdPersonaRepEco);
                        itemInfo.DescParentescoRepEco = item.DescParentescoRepEco;
                        itemInfo.empresa_direccionRepEco = item.empresa_direccionRepEco;
                        itemInfo.empresa_donde_trabajaRepEco = item.empresa_donde_trabajaRepEco;
                        itemInfo.empresa_telefonoRepEco = item.empresa_telefonoRepEco;
                        itemInfo.idNivelEducativoRepEco = item.idNivelEducativoRepEco;
                        itemInfo.DescNivelEducativoRepEco = item.DescNivelEducativoRepEco;
                        itemInfo.TituloRepEco = item.TituloRepEco;
                        itemInfo.Nom_Empresa = InfoEmp.NombreComercial;
                        itemInfo.Logo = InfoEmp.em_logo_Image;
                        

                        listadedatos.Add(itemInfo);


                    }
                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                return listadedatos;
            }
        }

    }
}
