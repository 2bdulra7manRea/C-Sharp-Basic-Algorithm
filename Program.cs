using System;
using System.Text;
namespace myapp
{
    class Program
    {
        public static void Main(string[] args)
        {
        }


        public static int SumValues(int num1, int num2)
        {
            if (num1 == num2)
            {
                return (num1 + num2) * 3;
            }
            return num1 + num2;
        }

        public static int absValues(int num1)
        {
            int diff = num1 - 51;
            if (num1 > 51)
            {
                return diff * 3;
            }

            return diff * -1;
        }

        public static bool checkNumbers(int num1, int num2)
        {
            if (num1 == 30 | num2 == 30 | (num2 + num1) == 30)
            {
                return true;
            }
            return false;
        }

        public static string RemoveCharAtIndex(string text, int position)
        {
            string newText = text.Remove(position, 1);


            return newText;
        }

        public static string editText(string Text)
        {
            string x;
            bool checkForIf = Text.Contains("if");
            if (!checkForIf)
            {
                x = Text.Insert(0, "If ");
                return x;
            }
            return Text;
        }

        public static int getLargestValueOfFirstMiddleLastInArray(int[] x)
        {
            int y = x.Length;
            if (y % 2 == 0)
            {
                return 0;
            }
            int firstVal = x[0];
            int lastVal = x[y - 1];
            int middleVal = x[(y / 2)];
            int[] values = new int[] { firstVal, middleVal, lastVal };
            int maxValue = firstVal;
            foreach (var item in values)
            {
                if (maxValue < item)
                {
                    maxValue = item;
                }
            }
            return maxValue;
        }

        public static int countEvenNumberInArray(int[] x)
        {
            int count = 0;
            foreach (int item in x)
            {
                if (item % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static int SumOfNumbersInArrayException(int[] x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 5)
                {
                    if (x[i] == x[x.Length - 1])
                    {

                    }
                    else if (x[i + 1] == 6)
                    {
                        sum += 0;
                    }
                    else
                    {
                        sum += x[i];
                    }
                }
                else
                {
                    if (!(x[i] == 6 && x[i - 1] == 5))
                    {
                        sum += x[i];
                    }
                   ;
                }
            }
            return sum;
        }

        public static bool chackForIncreasingAdjacentNumbersInArray(int[] x)
        {

            int lastIndex = x.Length - 1;
            for (int i = 0; i < x.Length; i++)
            {
                if (!(i == lastIndex || (i + 1) == lastIndex || (i + 2) == lastIndex))
                {
                    int fNum1 = x[i];
                    int fNum2 = x[i + 1];
                    int fNum3 = x[i + 2];
                    if (fNum1 - fNum2 == fNum2 - fNum3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool checkForNumberTwo(int num)
        {
            string numToText=num.ToString();
            return numToText.Contains('2')?true :false;
         }
    }

    

}
