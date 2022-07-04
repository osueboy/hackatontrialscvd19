using Domain.General;

namespace Domain.Entities
{
    /// <summary>
    /// Criterios de inclusión
    /// </summary>
    public class Inclusion : ValueObject
    {
        /// <summary>
        /// Texto descriptivo del criterio de inclusión, posición 28
        /// </summary>
        public string InclusionText { get; set; }
        /// <summary>
        /// Edad mínima de inclusión, posición 13
        /// </summary>
        public string AgeMin { get; set; }
        /// <summary>
        /// Edad máxima de inclusión, posición 14
        /// </summary>
        public string AgeMax { get; set; }
        /// <summary>
        /// Genero, posición 15
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Permite obtener los valores significativos para determinar si dos objetos de valor son iguales
        /// </summary>
        /// <returns>object</returns>
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return AgeMin;
            yield return AgeMax;
            yield return Gender;
        }
    }
}
