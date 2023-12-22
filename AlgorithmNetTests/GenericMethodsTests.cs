using AlgorithmNet;
using AlgorithmNet.Shared;
using AlgorithmNetTests.Models;
using System.Reflection;

namespace AlgorithmNetTests
{
    public class GenericMethodsTests
    {
        private GenericMethods genericMethods;
        [SetUp]
        public void Setup()
        {
            genericMethods = new GenericMethods();
        }

        [Test]
        public void HasProperty()
        {
            var arr = new List<Person> { new Person { Id = 1, Name = "asd" }};

            var result = genericMethods.HasProperty(arr, "Id");
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void HasNotProperty()
        {
            var arr = new List<Person> { new Person { Id = 1, Name = "asd" } };

            var result = genericMethods.HasProperty(arr, "No");
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void ValueByProperty()
        {
            var result = genericMethods.GetPropertyValue(new Person { Id = 1, Name = "asd" }, "Name");
            Assert.That(result, Is.EqualTo("asd"));
        }

        [Test]
        public void ValueByPropertyDidntFound()
        {
            var result = genericMethods.GetPropertyValue(new Person { Id = 1, Name = "asd" }, "No");
            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void ValueByPropertyId()
        {
            var result = genericMethods.GetPropertyValue(new Person { Id = 1, Name = "asd" }, "Id");
            Assert.That(Int32.Parse(result), Is.EqualTo(1));
        }
    }
}