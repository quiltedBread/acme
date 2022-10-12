
namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Inserts spaces before each capital letter in a string
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;

            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach (char c in source)
                {
                    if (char.IsUpper(c))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += c;
                }
            }
            return result.Trim();
        }
    }
}
