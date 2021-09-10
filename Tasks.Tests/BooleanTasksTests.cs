using Bolian;
using FluentAssertions;
using NUnit.Framework;

namespace Tasks.Tests
{
    public class BooleanTasksTests
    {
        /*Даны три целых числа: A, B, C.Проверить истинность высказывания: «Ровно одно из чисел A, B, C положительное»*/
        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(-1, 2, 3)]
        public void Bolian14_MoreThanOnePositive_ReturnsFalse(int a, int b, int c)
        {
            BooleanTasks.Bolian14(a, b, c).Should().BeFalse();
        }

        [Test]
        [TestCase(-1, -2, -3)]
        [TestCase(-42, -222, -31)]
        public void Bolian14_NoPositives_ReturnsFalse(int a, int b, int c)
        {
            BooleanTasks.Bolian14(a, b, c).Should().BeFalse();
        }

        [Test]
        [TestCase(-1, -2, 3)]
        [TestCase(1, -2, -3)]
        [TestCase(-1, -2, 3)]
        public void Bolian14_OnePositive_ReturnsTrue(int a, int b, int c)
        {
            BooleanTasks.Bolian14(a, b, c).Should().BeTrue();
        }

        /*Даны три целых числа: A, B, C.Проверить истинность высказывания: «Ровно два из чисел A, B, C являются положительными».*/
        [Test]
        [TestCase(-1, -2, 3)]
        [TestCase(1, -2, -3)]
        [TestCase(-1, -2, 3)]
        public void Bolian15_NotEnoughtPositives_ReturnsFalse(int a, int b, int c)
        {
            BooleanTasks.Bolian15(a, b, c).Should().BeFalse();
        }

        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(10, 20, 30)]
        public void Bolian15_TooMuchPositives_ReturnsFalse(int a, int b, int c)
        {
            BooleanTasks.Bolian15(a, b, c).Should().BeFalse();
        }

        [Test]
        [TestCase(1, 2, -3)]
        [TestCase(10, -20, 30)]
        [TestCase(-10, 20, 30)]
        public void Bolian15_EnoughPositives_ReturnsTrue(int a, int b, int c)
        {
            BooleanTasks.Bolian15(a, b, c).Should().BeTrue();
        }

        /*Проверить истинность высказывания: «Среди трех данных целых чисел есть хотя бы одна пара совпадающих»*/
        [Test]
        [TestCase(1, 2, -3)]
        [TestCase(10, -20, 30)]
        [TestCase(-10, 20, 30)]
        public void Bolian18_NoPairs_ReturnsFalse(int a, int b, int c)
        {
            BooleanTasks.Bolian18(a, b, c).Should().BeFalse();
        }

        [Test]
        [TestCase(1, 1, -3)]
        [TestCase(10, -20, -20)]
        [TestCase(30, 20, 30)]
        public void Bolian18_OnePair_ReturnsTrue(int a, int b, int c)
        {
            BooleanTasks.Bolian18(a, b, c).Should().BeTrue();
        }

        [Test]
        [TestCase(1, 1, 1)]
        [TestCase(-20, -20, -20)]
        [TestCase(30, 30, 30)]
        public void Bolian18_AllSame_ReturnsTrue(int a, int b, int c)
        {
            BooleanTasks.Bolian18(a, b, c).Should().BeTrue();
        }
    }
}
