using System;
using System.Linq;
using System.Xml.Linq;
using Bukimedia.PrestaSharp.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp.Serializers.Xml;

namespace Bukimedia.PrestaSharp.Deserializers.Tests
{

    class FakeObject
    {
        public string StringProperty { get; set; }
        public int IntProperty { get; set; }
        public decimal DecimalProperty { get; set; }
    }

    [TestClass()]
    public class PrestaSharpDeserializerTests
    {
        [TestMethod()]
        public void DeserializeObjectTest()
        {
            var instanceUnderTest = new XmlDeserializer();
            string fileContent = System.IO.File.ReadAllText("FakeObject.xml");
            var objectToMap = instanceUnderTest.Deserialize<FakeObject>(new RestSharp.RestResponse { Content = fileContent });

            Assert.AreEqual("This is my value", objectToMap.StringProperty);
            Assert.AreEqual(42, objectToMap.IntProperty);
            Assert.AreEqual(1.2m, objectToMap.DecimalProperty);
        }
        [TestMethod()]
        public void DeserializeProductTest()
        {
            var instanceUnderTest = new XmlDeserializer();
            string fileContent = System.IO.File.ReadAllText("FakeProduct.xml");
            var objectToMap = instanceUnderTest.Deserialize<product>(new RestSharp.RestResponse { Content = fileContent });

            Assert.AreEqual(74, objectToMap.id);
            Assert.AreEqual("PALAN MANUEL A CHAÎNE", objectToMap.name[0].Value);
            Assert.AreEqual("<p>PALAN MANUEL A CHAÎNE</p>", objectToMap.description[1].Value);
        }
    }
}