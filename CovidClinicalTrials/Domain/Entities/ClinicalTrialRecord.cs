using Domain.General;

namespace Domain.Entities
{
    /// <summary>
    /// Registro de estudio clinico
    /// </summary>
    public class ClinicalTrialRecord : BaseEntity<string>
    {
        /// <summary>
        /// Última actualización, posición 1
        /// </summary>
        public string LastRefreshedOn { get; set; }
        /// <summary>
        /// Título publico, posición 2
        /// </summary>
        public string PublicTitle { get; set; }
        /// <summary>
        /// Título cientifico, posición 3
        /// </summary>
        public string ScientificTitle { get; set; }
        /// <summary>
        /// Acrónimo, posición 4
        /// </summary>
        public string Acronym { get; set; }
        /// <summary>
        /// Patrocinador principal, posición 5
        /// </summary>
        public string PrimarySponsor { get; set; }
        /// <summary>
        /// Fecha de registro, posición 6
        /// </summary>
        public DateTime? DateRegistration { get; set; }
        /// <summary>
        /// Fecha de registro 3, posición 7
        /// </summary>
        public DateTime? DateRegistration3 { get; set; }
        /// <summary>
        /// Fecha de exportación, posición 8
        /// </summary>
        public DateTime? ExportDate { get; set; }
        /// <summary>
        /// Fuente, posición 9
        /// </summary>
        public string SourceRegister { get; set; }
        /// <summary>
        /// Dirección web, posición 10 
        /// </summary>
        public string WebAddress { get; set; }
        /// <summary>
        /// Estado de reclutamiento, posición 11
        /// </summary>
        public string RecruitmentStatus { get; set; }
        /// <summary>
        /// Otros registros, posición 12
        /// </summary>
        public string OtherRecords { get; set; }
        /// <summary>
        /// Criterios de inclusión, posiciónes: 13, 14, 15 y 28
        /// </summary>
        public Inclusion Inclusion { get; set; }
        /// <summary>
        /// Fecha de enrolamiento, posición 16
        /// </summary>
        public string DateEnrollement { get; set; }
        /// <summary>
        /// Tamaño objetivo, posición 17
        /// </summary>
        public string TargetSize { get; set; }
        /// <summary>
        /// Tipo de estudio, posición 18
        /// </summary>
        public string StudyType { get; set; }
        /// <summary>
        /// Diseño de estudio, posición 19 
        /// </summary>
        public string StudyDesign { get; set; }
        /// <summary>
        /// Fase, posición 20
        /// </summary>
        public string Phase { get; set; }
        /// <summary>
        /// Paises separados por ';', posición 21
        /// </summary>
        public string Countries { get; set; }
        /// <summary>
        /// Contacto
        /// </summary>
        public Contact Contact { get; set; }
        /// <summary>
        /// Criterio de exclusión, pósición 29
        /// </summary>
        public string ExclusionCriteria { get; set; }
        /// <summary>
        /// Condición, posición 30
        /// </summary>
        public string Condition { get; set; }
        /// <summary>
        /// Intervención, posición 31
        /// </summary>
        public string Intervention { get; set; }
        /// <summary>
        /// Resultado principal, posición 32
        /// </summary>
        public string PrimaryOutcome { get; set; }
        /// <summary>
        /// Fecha de resultados posteados, posición 33
        /// </summary>
        public string ResultsDatePosted { get; set; }
        /// <summary>
        /// Fecha de resultados completados, posición 34
        /// </summary>
        public string ResultsDateCompleted { get; set; }   
        /// <summary>
        /// Vinculo de resultados, posición 35
        /// </summary>
        public string ResultsUrlLink { get; set; }
        /// <summary>
        /// Retrospectiva, posición 36
        /// </summary>
        public bool Retrospective { get; set; }
        /// <summary>
        /// Puenteo?, posición 37
        /// </summary>
        public bool Bridging { get; set; }
        /// <summary>
        /// Tipo de puenteo, posición 38
        /// </summary>
        public string BridgedType { get; set; }
        /// <summary>
        /// Determina si existen resultados, posición 39
        /// </summary>
        public bool Results { get; set; }
    }
}