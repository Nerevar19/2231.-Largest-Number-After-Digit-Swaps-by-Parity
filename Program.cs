namespace _2231._Largest_Number_After_Digit_Swaps_by_Parity
{
    internal class Program
    {
        static public int LargestInteger(int num)
        {
            int evenPtr = 0, oddPtr = 0;

            string result = string.Empty;

            string number = Convert.ToString(num);

            char[] even = number.Where(n => n % 2 == 0).OrderByDescending(n => (int)n).ToArray();
            char[] odd = number.Where(n => n % 2 != 0).OrderByDescending(n => (int)n).ToArray();
            
            
            for(int i = 0; i < number.Length; i++)
            {
                if (Convert.ToInt32(number[i]) % 2 == 0)
                {
                    result += even[evenPtr];
                    evenPtr++;
                }
                else
                {
                    result += odd[oddPtr];
                    oddPtr++;
                }
            }
            return Convert.ToInt32(result);
        }
        static void Main(string[] args)
        {
            /*string number = "12345666";
            char[] even = number.Where(n => n % 2 == 0).OrderByDescending(n => (int)n).ToArray();
            Array.ForEach(even,ch => Console.WriteLine(ch));*/
            int num = 13572468;
            Console.WriteLine(LargestInteger(num));
        }
    }
}