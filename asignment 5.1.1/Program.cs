namespace asignment_5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if its a palindrome");
            int x = Convert.ToInt32(Console.ReadLine());
            string notnegative = Math.Abs(x).ToString();
            int[] input = Array.ConvertAll(x.ToString().ToCharArray(), c=> c - '0');
            if (Ispalindrome(input))
            {
                Console.WriteLine($"{x} is a palindrome");
            }
            else if (x.ToString().Contains("-")) 
            {
                Console.WriteLine($"{x} is not a palindrome because its a negative");
            }
            else
            {
                Console.WriteLine($"{x} is not a palindrome");
            }
            
            
        }




        public static bool Ispalindrome(int[] i)
        {
            

            int left = 0;
            int right = i.Length - 1;

            while (left < right)
            {
                if (i[left] != i[right]) 
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
            
        }
    }
}
