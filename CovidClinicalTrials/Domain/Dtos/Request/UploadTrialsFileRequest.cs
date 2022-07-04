using Microsoft.AspNetCore.Http;

namespace Domain.Dtos.Request
{
    /// <summary>
    /// Petición para subir un archivo de registros de estudios clinicos de Covid-19
    /// </summary>
    public class UploadTrialsFileRequest
    {
        /// <summary>
        /// Archivo con los registros
        /// </summary>
        public IFormFile File { get; set; }
    }
}
