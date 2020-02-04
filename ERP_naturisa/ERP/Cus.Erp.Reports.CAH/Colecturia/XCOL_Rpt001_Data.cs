using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.CAH.Colecturia
{
    public class XCOL_Rpt001_Data
    {
        public List<XCOL_Rpt001_Info> consultar_data(int idSede)
        {
            try
            {
                List<XCOL_Rpt001_Info> listadatos = new List<XCOL_Rpt001_Info>();

                using (EntitiesColecturia_CAH_Rpt ECompras = new EntitiesColecturia_CAH_Rpt())
                {
                    var select = from q in ECompras.vwCOL_Rpt001
                                 where q.IdSede == idSede
                                 //&& q.IdSucursal == idsucursal
                                 select q;

                    foreach (var item in select)
                    {
                        XCOL_Rpt001_Info itemInfo = new XCOL_Rpt001_Info();

                        itemInfo.IdInstitucion= item.IdInstitucion;
                        itemInfo.IdSede= item.IdSede;
                        itemInfo.IdSeccion = item.IdSeccion;
                        itemInfo.IdJornada = item.IdJornada;
                        itemInfo.IdCurso= item.IdCurso;
                        itemInfo.IdParalelo= item.IdParalelo;
                        itemInfo.IdEstudiante= item.IdEstudiante;
                        itemInfo.IdMatricula= item.IdMatricula;
                        itemInfo.CodMatricula= item.CodMatricula;
                        itemInfo.IdContrato= item.IdContrato;
                        itemInfo.IdAnioLectivo= item.IdAnioLectivo;
                        itemInfo.Tipo_documento_cat= item.Tipo_documento_cat;
                        itemInfo.IdBanco= item.IdBanco;
                        itemInfo.vt_total = item.vt_total;

                        itemInfo.Sede = item.Sede;
                        itemInfo.Jornada = item.Jornada;
                        itemInfo.Seccion = item.Seccion;
                        itemInfo.Curso = item.Curso;
                        itemInfo.Paralelo = item.Paralelo;

                        itemInfo.Cod_convivencia_doy_fe = item.Cod_convivencia_doy_fe;
                        itemInfo.tiene_seguro = item.tiene_seguro;

                        listadatos.Add(itemInfo);
                    }
                }
                return listadatos;
            }
            catch (Exception ex)
            {
                return new List<XCOL_Rpt001_Info>();
            }
        }
    }
}
