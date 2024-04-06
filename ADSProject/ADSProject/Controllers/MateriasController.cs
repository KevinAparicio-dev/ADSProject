using ADSProject.Interfaces;
using ADSProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADSProject.Controllers
{
    [Route("api/materias/")]
    public class MateriasController : ControllerBase
    {
        private readonly IMateria materia;
        private const string COD_EXITO = "000000";
        private const string COD_ERROR = "999999";
        private string pCodRespuesta;
        private string pMensajeUsuario;
        private string pMensajeTecnico;

        public MateriasController(IMateria materia)
        {
            this.materia = materia;
        }

        [HttpPost("agregarMateria")]

        public ActionResult<string> AgregarMateria([FromBody] Materia materia)
        {
            try
            {
                int contador = this.materia.AgregarMateria(materia);

                if (contador > 0)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Registro insertado con exito";
                    pMensajeUsuario = pCodRespuesta + " || " + pMensajeUsuario;
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Ocurrio un problema al insertar el registro";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }

                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("actualizarMateria/{idMateria}")]

        public ActionResult<string> ActualizarMateria(int idMateria, [FromBody] Materia materia)
        {
            try
            {
                int contador = this.materia.ActualizarMateria(idMateria, materia);

                if (contador > 0)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Registro actualizado correctamente";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Ocurrio un problema al actualizar el registro";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }

                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpDelete("eliminarMateria/{idMateria}")]

        public ActionResult<string> EliminarMateria(int idMateria)
        {
            try
            {
                bool eliminado = this.materia.EliminarMateria(idMateria);
                if (eliminado)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Registro eliminado con exito";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Ocurrio un problema al eliminar el registro";
                    pMensajeTecnico = pCodRespuesta + " || " + pCodRespuesta;
                }
                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("obtenerMateriaPorID/{idMateria}")]
        public ActionResult<Materia> ObtenerMateriaPorID(int idMateria)
        {
            try
            {
                Materia materia = this.materia.ObtenerMateriaPorId(idMateria);

                if (materia != null)
                {
                    return Ok(materia);
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "No se encontraron registros";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;

                    return NotFound(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("obtenerMaterias")]

        public ActionResult<List<Materia>> ObtenerMaterias()
        {
            try
            {
                List<Materia> lstMateria = this.materia.ObtenerTodasLasMaterias();

                return Ok(lstMateria);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
