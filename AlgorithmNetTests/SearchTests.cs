using AlgorithmNet;
using AlgorithmNetTests.Models;
using System.Reflection;

namespace AlgorithmNetTests
{
    public class SearchTests
    {
        private Search search;
        [SetUp]
        public void Setup()
        {
            search = new Search();
        }
        [Test]
        public void BinarySearchSuccesfull()
        {
            int[] arr = { 1, 2, 3, 4,5 };

            var result = search.BinarySearch(arr, 3);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void BinarySearchSuccesfull2()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            var result = search.BinarySearch(arr, 1);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void BinarySearchSuccesfull3()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            var result = search.BinarySearch(arr, 5);
            Assert.That(result, Is.EqualTo(4));
        }
        [Test]
        public void BinarySearchEmpty()
        {
            int[] arr = {};

            var result = search.BinarySearch(arr, 5);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void BinarySearchListSuccesfull()
        {
            var arr = new List<int> { 1, 2, 3, 4, 5 };

            var result = search.BinarySearch(arr, 3);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void BinarySearchListSuccesfull2()
        {
            var arr = new List<int> { 1, 2, 3, 4, 5 };

            var result = search.BinarySearch(arr, 1);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void BinarySearchListSuccesfull3()
        {
            var arr = new List<int> { 1, 2, 3, 4, 5 };

            var result = search.BinarySearch(arr, 5);
            Assert.That(result, Is.EqualTo(4));
        }
        [Test]
        public void BinarySearchListEmpty()
        {
            var arr = new List<int>{};

            var result = search.BinarySearch(arr, 5);
            Assert.That(result, Is.EqualTo(-1));
        }
    }
}