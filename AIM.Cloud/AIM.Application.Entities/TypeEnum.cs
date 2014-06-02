/****************************** Module Header ******************************\
* Module Name:  TypeEnum.cs
* Project:	    A.I.M. - Automated Interview Manager
* Copyright (c) 5 Programers Of Tomorrow.
*
* Question Type Enum Model.
\***************************************************************************/


namespace AIM.Application.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    [DataContract(Name = "QuestionType")]
    [Flags]
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