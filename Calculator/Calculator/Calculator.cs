namespace Calculator1
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int FindMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int FindMaxOfThree(int a, int b, int c)
        {
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            return max;
        }

        public int CountLetters(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    count++;
                }
            }
            return count;
        }

        public int CountDigits(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
        }

        public int CountSpecialCharacters(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}