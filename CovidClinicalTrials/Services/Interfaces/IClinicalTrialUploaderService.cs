using Domain.Dtos.Request;
using Domain.Dtos.Response;

namespace Services.Interfaces
{
    /// <summary>
    /// Servicio de subida de archivos
    /// </summary>
    public interface IClinicalTrialUploaderService
    {
        /// <summary>
        /// Guardar registros a partir de un archivo subido
        /// </summary>
        /// <param name="request">Petición</param>
        /// <returns>Resultados</returns>
        Task<UploadResultResponse> UploadFile(UploadTrialsFileRequest request);

        /// <summary>
        /// Obtiene una lista de estudios 
        /// </summary>
        /// <param name="request">Petición</param>
        /// <returns>Lista con la tabla</returns>
        Task<GetTrialsResponse> Get(GetTrialsRequest request);
    }
}
