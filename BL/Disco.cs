using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Disco
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.MSandovalPruebaTecnicaEntities context=new DL.MSandovalPruebaTecnicaEntities())
                {
                    var query = context.DiscoGetAll().ToList();
                    result.Objects = new List<object>();

                    if (query!=null)
                    {
                        foreach (var item in query)
                        {
                            ML.Disco disco = new ML.Disco();
                            disco.IdDisco = item.IdDisco;
                            disco.Titulo = item.Titulo;
                            disco.Artista = item.Artista;
                            disco.GeneroMusical = item.GeneroMusical;
                            disco.Duracion = double.Parse(item.Duracion.ToString());
                            disco.Anio = item.Año;
                            disco.Distribuidora = item.Distribuidora;
                            disco.Ventas = int.Parse(item.Ventas.ToString());
                            disco.Disponibilidad = item.Disponibilidad;

                            result.Objects.Add(disco);

                        }

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No hay registros";
                    }
                }
            }
            catch (Exception ex)
            {

                result.Correct = true;
                result.ErrorMessage = ex.Message;
                result.Ex=ex;
            }
            return result;
        }
        public static ML.Result Delete(int IdDisco)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.MSandovalPruebaTecnicaEntities context = new DL.MSandovalPruebaTecnicaEntities())
                {
                    var query = context.DiscoDelete(IdDisco);
                    //result.Objects = new List<object>();

                    if (query>0)
                    {
                        
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo eliminar el disco";
                    }
                }
            }
            catch (Exception ex)
            {

                result.Correct = true;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
    }
}
