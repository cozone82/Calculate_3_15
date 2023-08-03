namespace Calculate_3_15.Models
{
    public class Calculate
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public string? Sum { get; set; }
        public string? Product { get; set; }
        public string? Difference { get; set; }
        public string? Quotient { get; set; }

        public string SumOfNumbers()
        {
            string sum;
            sum = Convert.ToString(Num1 + Num2);
            return sum;
        }

        public string ProductOfNumbers()
        {
            string product;
            product = Convert.ToString(Num1 * Num2);
            return product;
        }

        public string DifferenceOfNumbers()
        {
            string difference;
            difference = Convert.ToString(Num1 - Num2);
            return difference;
        }

        public string QuotientOfNumbers()
        {
            string quotient;
            quotient = Convert.ToString(Num1 / Num2);
            return quotient;
        }


    }
}
