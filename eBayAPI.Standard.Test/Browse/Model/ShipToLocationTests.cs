/* 
 * Browse API
 *
 * The Browse API has the following resources: item_summary: Lets shoppers search for specific items by keyword, GTIN, category, product, or item aspects and refine the results by using filters. item: Lets you retrieve the details of a specific item or all the items in an item group, which is an item with variations such as color and size. This resource also provides a bridge between the eBay legacy APIs, such as Trading and Finding, and the RESTful APIs, such as Browse, which use different formats for the item IDs. You can use the Browse API to retrieve the basic details of the item and the RESTful item ID using a legacy item ID.
 *
 * OpenAPI spec version: v1_beta.12.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ShipToLocation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ShipToLocationTests
    {
        // TODO uncomment below to declare an instance variable for ShipToLocation
        //private ShipToLocation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ShipToLocation
            //instance = new ShipToLocation();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ShipToLocation
        /// </summary>
        [Test]
        public void ShipToLocationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ShipToLocation
            //Assert.IsInstanceOfType<ShipToLocation> (instance, "variable 'instance' is a ShipToLocation");
        }


        /// <summary>
        /// Test the property 'Country'
        /// </summary>
        [Test]
        public void CountryTest()
        {
            // TODO unit test for the property 'Country'
        }
        /// <summary>
        /// Test the property 'PostalCode'
        /// </summary>
        [Test]
        public void PostalCodeTest()
        {
            // TODO unit test for the property 'PostalCode'
        }

    }

}
