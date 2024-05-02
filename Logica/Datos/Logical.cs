namespace Logica.Datos
{
    public class Logical
    {
        //determinar si una palabra es palindromo
        public bool IsPalindrome(string word)
        {
            int left = 0;
            int right = word.Length - 1;

            while (left < right)
            {
                if (word[left] != word[right])
                    return false;
                left++;
                right--;
            }

            return true;
        }

        //hola pinky winky
    }
}
