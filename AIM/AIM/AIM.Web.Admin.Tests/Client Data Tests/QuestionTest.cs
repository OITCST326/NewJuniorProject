#region Includes
using System;
using System.Collections.Generic;
using System.Text;
//using NUnit.Framework;
//using TrackableEntities.Models;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AIM.Client.Entities.Models;
using TrackableEntities;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2014 (c) by Microsoft All Rights Reserved.
//  
// Project:      Models
// Module:       QuestionTest.cs
// Description:  Tests for the Question class in the Unknown Assembly Name assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:55 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace TrackableEntities.ModelsTest
{

    /// <summary>
    /// Tests for the Question Class
    /// Documentation: 
    /// </summary>
    [TestClass]//, Description("Tests for Question")]
    public class QuestionTest 
    {
        #region Class Variables
        private Question _question;
        #endregion

        #region Property Tests

        #region GeneratedProperties

        /// <summary>
        /// Extension Data Property Test
        /// Documentation:  
        /// Property Type:  System.Runtime.Serialization.ExtensionDataObject
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void ExtensionDataTest()
        {
            Question question = new Question(); //Trial Mode
            //Question question = new Question("place user name here", "place license key here"); //License Mode

            //question.ExtensionData = new System.Runtime.Serialization.ExtensionDataObject();
        }

        /// <summary>
        /// Applicant Question Answers Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.ApplicantQuestionAnswer[]
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void ApplicantQuestionAnswersTest()
        {
            Question question = new Question(); //Trial Mode
            //Question question = new Question("place user name here", "place license key here"); //License Mode

            //question.ApplicantQuestionAnswers = new TrackableEntities.Models.ApplicantQuestionAnswer[0];
            //question.ApplicantQuestionAnswers = new ApplicantQuestionAnswer[0];
        }

        /// <summary>
        /// Modified Properties Property Test
        /// Documentation:  
        /// Property Type:  string[]
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void ModifiedPropertiesTest()
        {
            Question question = new Question(); //Trial Mode
            //Question question = new Question("place user name here", "place license key here"); //License Mode

            question.ModifiedProperties = new string[20];
        }

        /// <summary>
        /// Question Interview Question Mappings Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.QuestionInterviewQuestionMapping[]
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void QuestionInterviewQuestionMappingsTest()
        {
            Question question = new Question(); //Trial Mode
            //Question question = new Question("place user name here", "place license key here"); //License Mode

            //question.QuestionInterviewQuestionMappings = new QuestionInterviewQuestionMapping[0];
            //question.QuestionInterviewQuestionMappings = new TrackableEntities.Models.QuestionInterviewQuestionMapping[0];
        }

        /// <summary>
        /// Question Questionnaires Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.QuestionQuestionnaire[]
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void QuestionQuestionnairesTest()
        {
            Question question = new Question(); //Trial Mode
            //Question question = new Question("place user name here", "place license key here"); //License Mode

           // question.QuestionQuestionnaires = new QuestionQuestionnaire[0];
            //question.QuestionQuestionnaires = new TrackableEntities.Models.QuestionQuestionnaire[0];
        }

        /// <summary>
        /// Tracking State Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.TrackingState
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void TrackingStateTest()
        {
            Question question = new Question(); //Trial Mode
            //Question question = new Question("place user name here", "place license key here"); //License Mode

            //question.TrackingState = new TrackableEntities.TrackingState();
        }

        /// <summary>
        /// interview Questions Identification Property Test
        /// Documentation:  
        /// Property Type:  int
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void interviewQuestionsIDTest()
        {
            Question question = new Question(); //Trial Mode
            //Question question = new Question("place user name here", "place license key here"); //License Mode

            question.interviewQuestionsId = 123;
            //question.interviewQuestionsID = 123;
        }

        /// <summary>
        /// q Answer String Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void qAnswerStringTest()
        {
            Question question = new Question(); //Trial Mode
            //Question question = new Question("place user name here", "place license key here"); //License Mode

            //not implemented yet
           // question.qAnswerString = "test";
        }

        /// <summary>
        /// q Option String Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void qOptionStringTest()
        {
            Question question = new Question(); //Trial Mode
            //Question question = new Question("place user name here", "place license key here"); //License Mode

            //not implemented yet
           // question.qOptionString = "test";
        }

        /// <summary>
        /// q Text Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void qTextTest()
        {
            Question question = new Question(); //Trial Mode
            //Question question = new Question("place user name here", "place license key here"); //License Mode


            //not implemented yet.
           // question.qText = "test";
        }

        /// <summary>
        /// q Type Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void qTypeTest()
        {
            Question question = new Question(); //Trial Mode
            //Question question = new Question("place user name here", "place license key here"); //License Mode

            //not implemented yet
            //question.qType = "test";
        }

        /// <summary>
        /// question Identification Property Test
        /// Documentation:  
        /// Property Type:  int
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void questionIDTest()
        {
            Question question = new Question(); //Trial Mode
            //Question question = new Question("place user name here", "place license key here"); //License Mode

            question.questionId = 123;
           // question.questionID = 123;
        }

        /// <summary>
        /// questionnaire Identification Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void questionnaireIDTest()
        {
            Question question = new Question(); //Trial Mode
            //Question question = new Question("place user name here", "place license key here"); //License Mode

            question.questionnaireId = new System.Nullable<int>();
            //question.questionnaireID = new System.Nullable<int>();
        }

        #endregion // End of GeneratedProperties

        #endregion

        #region Method Tests

        #region GeneratedMethods

        // No methods were found. No tests are generated for methods.

        #endregion // End of GeneratedMethods

        #endregion

    }
}
