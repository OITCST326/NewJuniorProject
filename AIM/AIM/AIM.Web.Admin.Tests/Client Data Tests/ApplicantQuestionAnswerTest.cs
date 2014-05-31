#region Includes
using System;
using System.Collections.Generic;
using System.Text;
//using NUnit.Framework;
using AIM.Client.Entities.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using TrackableEntities.Models;
using System.Runtime.Serialization;
using TrackableEntities.ModelsTest;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2014 (c) by Microsoft All Rights Reserved.
//  
// Project:      Models
// Module:       ApplicantQuestionAnswerTest.cs
// Description:  Tests for the Applicant Question Answer class in the Unknown Assembly Name assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:55 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace TrackableEntities.ModelsTest
{

    /// <summary>
    /// Tests for the Applicant Question Answer Class
    /// Documentation: 
    /// </summary>
    [TestClass]//, Description("Tests for Applicant Question Answer")]
    public class ApplicantQuestionAnswerTest
    {
        #region Class Variables
        private ApplicantQuestionAnswer _applicantQuestionAnswer;
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
            ApplicantQuestionAnswer applicantQuestionAnswer = new ApplicantQuestionAnswer(); //Trial Mode
            //ApplicantQuestionAnswer applicantQuestionAnswer = new ApplicantQuestionAnswer("place user name here", "place license key here"); //License Mode

           // applicantQuestionAnswer.ExtensionData = new System.Runtime.Serialization.ExtensionDataObject();
        }

        /// <summary>
        /// Applicant Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.Applicant
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void ApplicantTest()
        {
            ApplicantQuestionAnswer applicantQuestionAnswer = new ApplicantQuestionAnswer(); //Trial Mode
            //ApplicantQuestionAnswer applicantQuestionAnswer = new ApplicantQuestionAnswer("place user name here", "place license key here"); //License Mode

           // applicantQuestionAnswer.Applicant = new TrackableEntities.Models.Applicant();
            applicantQuestionAnswer.Applicant = new Applicant();
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
            ApplicantQuestionAnswer applicantQuestionAnswer = new ApplicantQuestionAnswer(); //Trial Mode
            //ApplicantQuestionAnswer applicantQuestionAnswer = new ApplicantQuestionAnswer("place user name here", "place license key here"); //License Mode

            applicantQuestionAnswer.ModifiedProperties = new string[20];
        }

        /// <summary>
        /// Question Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.Question
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void QuestionTest()
        {
            ApplicantQuestionAnswer applicantQuestionAnswer = new ApplicantQuestionAnswer(); //Trial Mode
            //ApplicantQuestionAnswer applicantQuestionAnswer = new ApplicantQuestionAnswer("place user name here", "place license key here"); //License Mode

            //applicantQuestionAnswer.Question = new TrackableEntities.Models.Question();
            applicantQuestionAnswer.Question = new Question();
        }

        /// <summary>
        /// Tracking State Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.TrackingState
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void TrackingStateTest()
        {
            ApplicantQuestionAnswer applicantQuestionAnswer = new ApplicantQuestionAnswer(); //Trial Mode
            //ApplicantQuestionAnswer applicantQuestionAnswer = new ApplicantQuestionAnswer("place user name here", "place license key here"); //License Mode

           // applicantQuestionAnswer.TrackingState = new TrackableEntities.TrackingState();
        }

        /// <summary>
        /// answer Identification Property Test
        /// Documentation:  
        /// Property Type:  int
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void answerIDTest()
        {
            ApplicantQuestionAnswer applicantQuestionAnswer = new ApplicantQuestionAnswer(); //Trial Mode
            //ApplicantQuestionAnswer applicantQuestionAnswer = new ApplicantQuestionAnswer("place user name here", "place license key here"); //License Mode

            //applicantQuestionAnswer.answerID = 123;
            applicantQuestionAnswer.answerId = 123;
        }

        /// <summary>
        /// answer String Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void answerStringTest()
        {
            ApplicantQuestionAnswer applicantQuestionAnswer = new ApplicantQuestionAnswer(); //Trial Mode
            //ApplicantQuestionAnswer applicantQuestionAnswer = new ApplicantQuestionAnswer("place user name here", "place license key here"); //License Mode

            applicantQuestionAnswer.answerJsonString = "test";
            //applicantQuestionAnswer.answerString = "test";
        }

        /// <summary>
        /// applicant Identification Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void applicantIDTest()
        {
            ApplicantQuestionAnswer applicantQuestionAnswer = new ApplicantQuestionAnswer(); //Trial Mode
            //ApplicantQuestionAnswer applicantQuestionAnswer = new ApplicantQuestionAnswer("place user name here", "place license key here"); //License Mode

            //applicantQuestionAnswer.applicantID = new System.Nullable<int>();
            applicantQuestionAnswer.applicantId = new System.Nullable<int>();
        }

        /// <summary>
        /// quesiton Identification Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void quesitonIDTest()
        {
            ApplicantQuestionAnswer applicantQuestionAnswer = new ApplicantQuestionAnswer(); //Trial Mode
            //ApplicantQuestionAnswer applicantQuestionAnswer = new ApplicantQuestionAnswer("place user name here", "place license key here"); //License Mode

            //applicantQuestionAnswer.quesitonID = new System.Nullable<int>();
            applicantQuestionAnswer.quesitonId = new System.Nullable<int>();
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
