using System.Runtime.Serialization;

namespace AIM.Service.Entities.Models
{
    [DataContract(Name = "QuestionType")]
    public enum TypeEnum : int
    {
        [EnumMember]
        MultipleChoice = 0,

        [EnumMember]
        AllThatApply = 1,

        [EnumMember]
        FreeForm = 2
    }
}