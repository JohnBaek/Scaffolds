using System.ComponentModel.DataAnnotations;

namespace WebProject.Models.Core.V1
{

    public class MemberInfo
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MemberInfo()
        {
        }

        /// <summary>
        /// Id
        /// </summary>
        /// <value></value>
        [Key]
        public string Id { get; set; } = "";

        /// <summary>
        /// Name of the Member
        /// </summary>
        /// <value></value>
        [Required(ErrorMessage = "Member Name Required")]
        public string MemberName { get; set; } = "";
    }
}