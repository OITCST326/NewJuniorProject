using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AIM.Admin.Service.WorkerRole.Models
{
    [DataContract(Name = "QuestionType")]
    public enum TypeEnum : int
    {
        [EnumMember]
        [Display(Name = "Multiple Choice")]
        MultipleChoice = 0,

        [EnumMember]
        [Display(Name = "Select All That Apply")]
        AllThatApply = 1,

        [EnumMember]
        [Display(Name = "Free Form Question")]
        FreeForm = 2
    }
}