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
    ///  Class for testing BuyingOptionDistribution
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class BuyingOptionDistributionTests
    {
        // TODO uncomment below to declare an instance variable for BuyingOptionDistribution
        //private BuyingOptionDistribution instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of BuyingOptionDistribution
            //instance = new BuyingOptionDistribution();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BuyingOptionDistribution
        /// </summary>
        [Test]
        public void BuyingOptionDistributionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" BuyingOptionDistribution
            //Assert.IsInstanceOfType<BuyingOptionDistribution> (instance, "variable 'instance' is a BuyingOptionDistribution");
        }


        /// <summary>
        /// Test the property 'BuyingOption'
        /// </summary>
        [Test]
        public void BuyingOptionTest()
        {
            // TODO unit test for the property 'BuyingOption'
        }
        /// <summary>
        /// Test the property 'MatchCount'
        /// </summary>
        [Test]
        public void MatchCountTest()
        {
            // TODO unit test for the property 'MatchCount'
        }
        /// <summary>
        /// Test the property 'RefinementHref'
        /// </summary>
        [Test]
        public void RefinementHrefTest()
        {
            // TODO unit test for the property 'RefinementHref'
        }

    }

}
