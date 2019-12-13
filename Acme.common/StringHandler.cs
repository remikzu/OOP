using System;
using System.Text;

namespace Acme.common
{
    public static class StringHandler
    {
        /// <summary>
        /// Inserts spaces before each capital letter in a string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string input)
        {
            StringBuilder sb = new StringBuilder();
            char[] inputArray = input.ToCharArray();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (char.IsUpper(inputArray[i]) && i != 0)
                {
                    sb.Append(" ");
                }
                sb.Append(inputArray[i]);
            }

            return sb.ToString();
        }
    }
}
