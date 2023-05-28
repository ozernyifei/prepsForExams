
using NUnit.Framework.Internal;

namespace CalcsTests
{
    public class AddTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(3, 4);
            Assert.AreEqual(7, result);
        }

        [Test]
        public void Add_PositiveAndNegativeNumbers_ReturnsSum()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(5, -2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsSum()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(-5, -2);
            Assert.AreEqual(-7, result);
        }

        [Test]
        public void Add_ZeroAndPositiveNumber_ReturnsSum()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(0, 9);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Add_ZeroAndNegativeNumber_ReturnsSum()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(0, -6);
            Assert.AreEqual(-6, result);
        }
    }
    public class FindMaxTests
    {
        [Test]
        public void FindMax_UnsortedArray_ReturnsMax()
        {
            Calculator Calculator = new Calculator();
            int[] numbers = { 4, 9, 2, 7, 5 };
            int result = Calculator.FindMax(numbers);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void FindMax_DescendingArray_ReturnsFirstElement()
        {
            Calculator Calculator = new Calculator();
            int[] numbers = { 10, 8, 6, 4, 2 };
            int result = Calculator.FindMax(numbers);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void FindMax_SingleElementArray_ReturnsElement()
        {
            Calculator Calculator = new Calculator();
            int[] numbers = { 7 };
            int result = Calculator.FindMax(numbers);
            Assert.AreEqual(7, result);
        }

        [Test]
        public void FindMax_AllNegativeNumbers_ReturnsMax()
        {
            Calculator Calculator = new Calculator();
            int[] numbers = { -4, -9, -2, -7, -5 };
            int result = Calculator.FindMax(numbers);
            Assert.AreEqual(-2, result);
        }
        [Test]

        public void FindMax_OneNegativeNumber_ReturnsMax()
        {
            Calculator Calculator = new Calculator();
            int[] numbers = { 1, 2, 3, 4, -5 };
            int result = Calculator.FindMax(numbers);
            Assert.AreEqual(4, result);

        }
    }
    public class MultiplyTests
    {
        [Test]
        public void Multiply_TwoPositiveNumbers_ReturnsProduct()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Multiply(3, 4);
            Assert.AreEqual(12, result);
        }

        [Test]
        public void Multiply_PositiveAndNegativeNumbers_ReturnsProduct()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Multiply(5, -2);
            Assert.AreEqual(-10, result);
        }

        [Test]
        public void Multiply_TwoNegativeNumbers_ReturnsProduct()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Multiply(-5, -2);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Multiply_ZeroAndNumber_ReturnsZero()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Multiply(0, 9);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Multiply_ZeroAndNegativeNumber_ReturnsZero()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Multiply(0, -6);
            Assert.AreEqual(0, result);
        }
    }
    public class FindMaxOfThreeTests
    {
        [Test]
        public void FindMax_FirstNumberIsMax_ReturnsFirstNumber()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.FindMaxOfThree(7, 4, 2);
            Assert.AreEqual(7, result);
        }

        [Test]
        public void FindMax_SecondNumberIsMax_ReturnsSecondNumber()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.FindMaxOfThree(3, 9, 5);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void FindMax_ThirdNumberIsMax_ReturnsThirdNumber()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.FindMaxOfThree(2, 4, 8);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void FindMax_AllNumbersAreEqual_ReturnsAnyNumber()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.FindMaxOfThree(5, 5, 5);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void FindMax_NegativeNumbers_ReturnsMax()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.FindMaxOfThree(-2, -7, -4);
            Assert.AreEqual(-2, result);
        }
    }
    public class CountLettersTests
    {
        [Test]
        public void CountLetters_StringWithLetters_ReturnsLetterCount()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.CountLetters("Hello, World!");
            Assert.AreEqual(10, result);
        }

        [Test]
        public void CountLetters_StringWithoutLetters_ReturnsZero()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.CountLetters("1234567890");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CountLetters_EmptyString_ReturnsZero()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.CountLetters("");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CountLetters_StringWithWhitespace_ReturnsLetterCount()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.CountLetters("   Hello   ");
            Assert.AreEqual(5, result);
        }

        [Test]
        public void CountLetters_StringWithSpecialCharacters_ReturnsLetterCount()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.CountLetters("Hello, $World!");
            Assert.AreEqual(10, result);
        }
    }
    public class CountDigitsTests
    {
        [Test]
        public void CountDigits_StringWithDigits_ReturnsDigitCount()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.CountDigits("Hello12345");
            Assert.AreEqual(5, result);
        }

        [Test]
        public void CountDigits_StringWithoutDigits_ReturnsZero()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.CountDigits("Hello, World!");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CountDigits_EmptyString_ReturnsZero()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.CountDigits("");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CountDigits_StringWithWhitespace_ReturnsDigitCount()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.CountDigits("  1 2 3  ");
            Assert.AreEqual(3, result);
        }

        [Test]
        public void CountDigits_StringWithSpecialCharacters_ReturnsDigitCount()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.CountDigits("Hello, 12345!");
            Assert.AreEqual(5, result);
        }
    }
    public class CountSpecialCharacters
    {
        [Test]
        public void CountSpecialCharacters_StringWithSpecialCharacters_ReturnsSpecialCharacterCount()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.CountSpecialCharacters("Hello, $World!");
            Assert.AreEqual(3, result);
        }

        [Test]
        public void CountSpecialCharacters_StringWithoutSpecialCharacters_ReturnsZero()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.CountSpecialCharacters("Hello12345");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CountSpecialCharacters_EmptyString_ReturnsZero()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.CountSpecialCharacters("");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CountSpecialCharacters_StringWithWhitespace_ReturnsSpecialCharacterCount()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.CountSpecialCharacters("  !@#$%^&*  ");
            Assert.AreEqual(8, result);
        }

        [Test]
        public void CountSpecialCharacters_StringWithOnlySpecialCharacters_ReturnsSpecialCharacterCount()
        {
            Calculator Calculator = new Calculator();
            int result = Calculator.CountSpecialCharacters("!@#$%^&*()");
            Assert.AreEqual(10, result);
        }
    }
}

        