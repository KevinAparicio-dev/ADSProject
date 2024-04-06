using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class MateriaRepository : IMateria
    {
        private List<Materia> lstMateria = new List<Materia>
        {
            new Materia{IdMateria = 1, NombreMateria = "Matematicas"}
        };

        public int ActualizarMateria(int idMateria, Materia materia)
        {
            try
            {
                int indice = lstMateria.FindIndex(tmp => tmp.IdMateria == idMateria);

                lstMateria[indice] = materia;

                return idMateria;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AgregarMateria(Materia materia)
        {
            try
            {
                if (lstMateria.Count > 0)
                {
                    materia.IdMateria = lstMateria.Last().IdMateria + 1;
                }
                lstMateria.Add(materia);

                return materia.IdMateria;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarMateria(int idMateria)
        {
            try
            {
                int indice = lstMateria.FindIndex(tmp => tmp.IdMateria == idMateria);

                lstMateria.RemoveAt(indice);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Materia ObtenerMateriaPorID(int idMateria)
        {
            throw new NotImplementedException();
        }

        public Materia ObtenerMateriaPorId(int idMateria)
        {
            try
            {
                Materia materia = lstMateria.FirstOrDefault(tmp => tmp.IdMateria == idMateria);

                return materia;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Materia> ObtenerTodasLasMaterias()
        {
            try
            {
                return lstMateria;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}