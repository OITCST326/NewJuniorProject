#region Includes
using System;
using System.Collections.Generic;
using System.Text;
//using NUnit.Framework;
using TrackableEntities;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AIM.Client.Entities.Models;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2014 (c) by Microsoft All Rights Reserved.
//  
// Project:      Models
// Module:       EmployeeTest.cs
// Description:  Tests for the Employee class in the Unknown Assembly Name assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:55 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace TrackableEntities.ModelsTest
{

    /// <summary>
    /// Tests for the Employee Class
    /// Documentation: 
    /// </summary>
    [TestClass]//, Description("Tests for Employee")]
    public class EmployeeTest
    {
        #region Class Variables
        private Employee _employee;
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
       // [Ignore("Please Implement")]
        public void ExtensionDataTest()
        {
            Employee employee = new Employee(); //Trial Mode
            //Employee employee = new Employee("place user name here", "place license key here"); //License Mode

           // employee.ExtensionData = new System.Runtime.Serialization.ExtensionDataObject();
        }

        /// <summary>
        /// Job Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.Job
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void JobTest()
        {
            Employee employee = new Employee(); //Trial Mode
            //Employee employee = new Employee("place user name here", "place license key here"); //License Mode

           // employee.Job = new TrackableEntities.Models.Job();
            employee.Job = new Job();
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
            Employee employee = new Employee(); //Trial Mode
            //Employee employee = new Employee("place user name here", "place license key here"); //License Mode

            employee.ModifiedProperties = new string[20];
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
            Employee employee = new Employee(); //Trial Mode
            //Employee employee = new Employee("place user name here", "place license key here"); //License Mode

           // employee.TrackingState = new TrackableEntities.TrackingState();
        }

        /// <summary>
        /// Users Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.User[]
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void UsersTest()
        {
            Employee employee = new Employee(); //Trial Mode
            //Employee employee = new Employee("place user name here", "place license key here"); //License Mode

            //employee.Users = new TrackableEntities.Models.User[0];
            //employee.Users = new User[0];
        }

        /// <summary>
        /// employee Identification Property Test
        /// Documentation:  
        /// Property Type:  int
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void employeeIDTest()
        {
            Employee employee = new Employee(); //Trial Mode
            //Employee employee = new Employee("place user name here", "place license key here"); //License Mode

           // employee.employeeID = 123;
            employee.employeeId = 123;
        }

        /// <summary>
        /// job Identification Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void jobIDTest()
        {
            Employee employee = new Employee(); //Trial Mode
            //Employee employee = new Employee("place user name here", "place license key here"); //License Mode

           // employee.jobID = new System.Nullable<int>();
            employee.jobId = new System.Nullable<int>();
        }

        /// <summary>
        /// permissions Identification Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void permissionsIDTest()
        {
            Employee employee = new Employee(); //Trial Mode
            //Employee employee = new Employee("place user name here", "place license key here"); //License Mode

          //  employee.permissionsID = new System.Nullable<int>();
           //is this implemented???
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
