using TypeGen.Core.TypeAnnotations;
using WebProject.Models.Core.Interfaces;
using WebProject.Models.Core.Enums;
namespace WebProject.Models.Core.ResponseCore
{
    [ExportTsClass]
    public class ResponseCore<T> : IResponseCore where T : class
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ResponseCore()
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
        /// Data Object
        /// </summary>
        /// <value></value>
        public T Data { get; set; }
    }
}