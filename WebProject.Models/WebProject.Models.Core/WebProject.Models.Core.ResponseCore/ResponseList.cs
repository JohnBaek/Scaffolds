using WebProject.Models.Core.Interfaces;
using WebProject.Models.Core.Enums;
using System.Collections.Generic;

namespace WebProject.Models.Core.ResponseCore 
{
    public class ResponseList<T> where T : class
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ResponseList()
        {            
        }

        /// <summary>
        /// Result of Reponse 
        /// </summary>
        public EnumResponseResult Result { get; set; } = EnumResponseResult.Success;

        /// <summary>
        /// Response Message
        /// </summary>
        /// <value></value>
        public string Message { get; set; } = "";


        /// <summary>
        /// List data Object
        /// </summary>
        /// <value></value>
        public IEnumerable<ResponseCore<T>> Items { get; set; }
    }
}