namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }


        static string CustomReplace ( string input, string oldValue,string newValue)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(oldValue))
            {
                return input;
                
            }
           

             string result = "";

                int index = 0;

                while (index <= input.Length - oldValue.Length)
                {
                    if (input.Substring(index, oldValue.Length) == oldValue)
                    {
                        result += newValue;
                        index += oldValue.Length;
                    }
                    else
                    {
                        result += input[index]; 
                        index++;
                    }
                }

                result += input.Substring(index);
                return result;
            
        }

        static string CustomTrim(string input)
        {
            int start = 0;
            int end = input.Length - 1;

            while (start <= end && char.IsWhiteSpace(input[start]))
            {
                start++;
            }

            while (end >= start && char.IsWhiteSpace(input[end]))
            {
                end--;
            }

            return (start <= end) ? input.Substring(start, end - start + 1) : "";
        }


        static string CustomSubstring(string input, int startIndex, int length)
        {
            if (startIndex < 0 || length < 0 || startIndex + length > input.Length)
                throw new ArgumentOutOfRangeException("Invalid startIndex or length.");

            string result = "";

            for (int i = startIndex; i < startIndex + length; i++)
            {
                result += input[i];
            }

            return result;
        }



    }



}
