using AlgorithmNet;
using AlgorithmNetTests.Models;
using System.Reflection;

namespace AlgorithmNetTests
{
    public class SortsTests
    {
        private Sorts shorts;
        [SetUp]
        public void Setup()
        {
            shorts = new Sorts();
        }
        #region BubbbleSort
        [Test]
        public void BubbleSortSuccesfull()
        {
            int[] arr = { 5, 2, 1, 4, 3 };

            var result = shorts.BubbleSort(arr);
            Assert.That(result[0], Is.EqualTo(1));
            Assert.That(result[0], Is.LessThan(result[1]));
            Assert.That(result[4], Is.EqualTo(5));
        }

        [Test]
        public void BubbleSortEmpty()
        {
            int[] arr = { };

            var result = shorts.BubbleSort(arr);
            Assert.That(result.Length, Is.EqualTo(0));
        }

        [Test]
        public void BubbleSortListSuccesfull()
        {
            var arr = new List<int> { 5, 2, 1, 4, 3 };

            var result = shorts.BubbleSort(arr);
            Assert.That(result[0], Is.EqualTo(1));
            Assert.That(result[0], Is.LessThan(result[1]));
            Assert.That(result[4], Is.EqualTo(5));
        }

        [Test]
        public void BubbleSortListEmpty()
        {
            var arr = new List<int> { };

            var result = shorts.BubbleSort(arr);
            Assert.That(result.Count, Is.EqualTo(0));
        }
        
        [Test]
        public void BubbleSortListObjet()
        {
            var arr = new List<Person> {
                new Person {Id=2, Name="dddd"},
                new Person {Id=1, Name="asd"},
                new Person {Id=4, Name="dddd"},
                new Person {Id=3, Name="asd"}
            };

            var result = shorts.BubbleSort(arr, "Id");
            Assert.That(result.Count, Is.EqualTo(4));
            Assert.That(result[0].Id, Is.EqualTo(1));
        }
        [Test]
        public void BubbleSortListObjetFailed()
        {
            var arr = new List<Person> {
                new Person {Id=2, Name="dddd"},
                new Person {Id=1, Name="asd"},
                new Person {Id=4, Name="dddd"},
                new Person {Id=3, Name="asd"}
            };

            var result = shorts.BubbleSort(arr, "Name");
            Assert.That(result.Count, Is.EqualTo(4));
            Assert.That(result[0].Id, Is.EqualTo(2));
        }
        #endregion Bubblesort

        #region SelectionSort
        [Test]
        public void SelectionSortListSuccesfull()
        {
            var arr = new List<int> { 5, 2, 1, 4, 3 };

            var result = shorts.SelectionSort(arr);
            Assert.That(result[0], Is.EqualTo(1));
            Assert.That(result[0], Is.LessThan(result[1]));
            Assert.That(result[4], Is.EqualTo(5));
        }
        [Test]
        public void SelectionSortListEmpty()
        {
            var arr = new List<int> {};

            var result = shorts.SelectionSort(arr);
            Assert.That(result.Count, Is.EqualTo(0));
        }
        [Test]
        public void SelectionSortSuccesfull()
        {
            int[] arr = { 5, 2, 1, 4, 3 };

            var result = shorts.SelectionSort(arr);
            Assert.That(result[0], Is.EqualTo(1));
            Assert.That(result[0], Is.LessThan(result[1]));
            Assert.That(result[4], Is.EqualTo(5));
        }
        [Test]
        public void SelectionSortEmpty()
        {
            int[] arr = {};

            var result = shorts.SelectionSort(arr);
            Assert.That(result.Count, Is.EqualTo(0));
        }
        [Test]
        public void SelectionSortListObjet()
        {
            var arr = new List<Person> {
                new Person {Id=2, Name="dddd"},
                new Person {Id=1, Name="asd"},
                new Person {Id=4, Name="dddd"},
                new Person {Id=3, Name="asd"}
            };

            var result = shorts.SelectionSort(arr, "Id");
            Assert.That(result.Count, Is.EqualTo(4));
            Assert.That(result[0].Id, Is.EqualTo(1));
        }
        [Test]
        public void SelectionSortListObjetEmpty()
        {
            var arr = new List<Person> {};

            var result = shorts.SelectionSort(arr, "Id");
            Assert.That(result.Count, Is.EqualTo(0));
        }
        [Test]
        public void SelectionSortListObjetFailed()
        {
            var arr = new List<Person> {
                new Person {Id=2, Name="dddd"},
                new Person {Id=1, Name="asd"},
                new Person {Id=4, Name="dddd"},
                new Person {Id=3, Name="asd"}
            };

            var result = shorts.SelectionSort(arr, "Name");
            Assert.That(result.Count, Is.EqualTo(4));
            Assert.That(result[0].Id, Is.EqualTo(2));
        }
        #endregion SelectionSort
    }
}