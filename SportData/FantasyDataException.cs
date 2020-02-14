using System;
using System.Collections.Generic;
using System.Text;

namespace SportData
{
    /// <summary>
    /// FantasyData Exception
    /// </summary>
    [Serializable]
    public class FantasyDataException : Exception
    {
        /// <summary>
        /// Exception
        /// </summary>
        /// <param name="message">The exception message.</param>
        public FantasyDataException(string message) : base(message) { }

        /// <summary>
        /// Exception
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">The exception that caused this exception to be thrown.</param>
        public FantasyDataException(string message, Exception innerException)
          : base(message, innerException)
        { }
    }
}
