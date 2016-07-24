public class Solution {
        public IList<string> getLettersByNum(char num)
        {
            
            if (num <= '6')
            {
                // '2' - > 'a'
                char res1 = (char)((num - '2') * 3 + 'a');
                char res2 = (char)((num - '2') * 3 + 1 + 'a');
                char res3 = (char)((num - '2') * 3 + 2 + 'a');
                return new List<string>() { res1.ToString(), res2.ToString(), res3.ToString() };
            }
            else if (num == '7')
            {
                char res4 = (char)((num - '7') * 4 + 'p');
                char res5 = (char)((num - '7') * 4 + 1 + 'p');
                char res6 = (char)((num - '7') * 4 + 2 + 'p');
                char res7 = (char)((num - '7') * 4 + 3 + 'p');
                return new List<string>() { res4.ToString(), res5.ToString(), res6.ToString(), res7.ToString() };
            }
            else if (num == '8')
            {
                return new List<string>() {"t", "u", "v"};
            }
            else{
                return new List<string>() {"w", "x", "y", "z"};
            }
 
        }

        public IList<string> LetterCombinations(string digits)
        {
            //23 ->["ad", "ae" ...

            IList<string> result = new List<string>();

            if (String.IsNullOrEmpty(digits))
            {
                return result;
            }
            
            char[] digitChars = digits.ToString().ToCharArray();

            StringBuilder potential = new StringBuilder();

            int level = 0;
            dsf(result, digitChars, potential, level);

            return result;

        }

        private void dsf(IList<string> result, char[] digitChars, StringBuilder potential, int level)
        {
            if (level == digitChars.Count())
            {
                result.Add(potential.ToString());
                return;
            }

            var curChars = getLettersByNum(digitChars[level]);

            foreach(string cur in curChars)
            {
                potential.Append(cur);
                dsf(result, digitChars, potential, level + 1);
                potential.Remove(potential.Length - 1, 1);
            }
        }
}