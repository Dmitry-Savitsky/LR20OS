namespace LR1
{
    public class Class1
    {
        public static double SumOfNumbersGreaterThanFive(double num1, double num2, double num3, double num4)
        {
            double sum = 0;

            if (num1 > 5)
                sum += num1;

            if (num2 > 5)
                sum += num2;

            if (num3 > 5)
                sum += num3;

            if (num4 > 5)
                sum += num4;

            return sum;
        }
    }
}
