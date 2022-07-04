using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.General
{
    /// <summary>
    /// Clase base
    /// </summary>
    /// <typeparam name="TId">Tipo</typeparam>
    public class BaseEntity<TId>
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public TId Id { get; set; }
    }
}
