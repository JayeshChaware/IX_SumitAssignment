public static class StringHelper
{
    public static string ChangeFirstChase(this string inputString)//extending string class
    {
        if (inputString.Length > 0)
        {
            char[] charArray = inputString.ToCharArray();
            charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
            return new string(charArray);
        }
        return inputString;
    }
}