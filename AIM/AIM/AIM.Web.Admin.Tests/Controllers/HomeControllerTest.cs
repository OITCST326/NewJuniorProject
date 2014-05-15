#region Includes
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
//using NUnit.Framework;
using AIM.Web.Admin.Controllers;
using System.Linq;
using System.Web;
using System.Web.Mvc;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2014 (c) by Microsoft All Rights Reserved.
//  
// Project:      Web
// Module:       HomeControllerTest.cs
// Description:  Tests for the Home Controller class in the AIM. Web. Admin assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:54 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace AIM.Web.Admin.ControllersTest
{

    /// <summary>
    /// Tests for the Home Controller Class
    /// Documentation: 
    /// </summary>
    [TestClass]//, Description("Tests for Home Controller")]
    public class HomeControllerTest
    {
        #region Class Variables
        private HomeController _homeController;
        #endregion

        #region Property Tests

        #region GeneratedProperties

        // No public properties were found. No tests are generated for non-public scoped properties.

        #endregion // End of GeneratedProperties

        #endregion

        #region Method Tests

        #region GeneratedMethods

        /// <summary>
        /// Index Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult Index()
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void IndexTest()
        {
            HomeController homeController = new HomeController(); //Trial Mode
            //HomeController homeController = new HomeController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters

            results = homeController.Index();
        }

        /// <summary>
        /// About Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult About()
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void AboutTest()
        {
            HomeController homeController = new HomeController(); //Trial Mode
            //HomeController homeController = new HomeController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters

            results = homeController.About();
        }

        /// <summary>
        /// Contact Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult Contact()
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void ContactTest()
        {
            HomeController homeController = new HomeController(); //Trial Mode
            //HomeController homeController = new HomeController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters

            results = homeController.Contact();
        }

        #endregion // End of GeneratedMethods

        #endregion

    }
}
