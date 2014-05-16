using System.ComponentModel;
using System.Runtime.Serialization;

namespace AIM.Service.Entities.Models
{
    [DataContract(Name = "QuestionType")]
    public enum TypeEnum : int
    {
        [EnumMember]
        [Description("Multiple Choice")]
        MultipleChoice = 0,

        [EnumMember]
        [Description("Select All That Apply")]
        AllThatApply = 1,

        [EnumMember]
        [Description("Free Form Question")]
        FreeForm = 2
    }
}