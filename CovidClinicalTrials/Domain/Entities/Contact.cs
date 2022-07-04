using Domain.General;

namespace Domain.Entities
{
    public class Contact : BaseEntity<Guid>
    {
        /// <summary>
        /// Nombre del contacto, posición 22
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Apellido del contacto, posición 23
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Dirección del contacto, posición 24
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Correo del contacto, posición 25
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Telefono del contacto, posición 26
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// Afiliación del contacto, posición 27
        /// </summary>
        public string Affiliation { get; set; }
    }
}
