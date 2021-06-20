using System;
using WebProject.Models.Core.Enums;

namespace WebProject.Models.Core.Interfaces
{
    /// <summary>
    /// Reponse Core Interface
    /// </summary>
    public interface IResponseCore 
    {
        /// <summary>
        /// Result of Reponse 
        /// </summary>
        EnumResponseResult Result { get; set; }

        /// <summary>
        /// Response Message
        /// </summary>
        /// <value></value>
        string Message { get; set; }
    }
}
