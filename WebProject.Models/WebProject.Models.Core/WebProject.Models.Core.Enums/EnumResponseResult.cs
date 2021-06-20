using System.ComponentModel;

namespace WebProject.Models.Core.Enums 
{
    /// <summary>
    /// Reponse Type
    /// </summary>
    public enum EnumResponseResult
    {
        [Description("Response Success")]
        Success = 0 , 

        [Description("Response Warning")]
        Warning = 1 ,

        [Description("Response Error")]
        Error = -99,
    }
}