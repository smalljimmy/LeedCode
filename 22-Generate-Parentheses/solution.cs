public class Solution {

        public IList<string> GenerateParenthesis(int n)
        {
            // refuse:  ( count or ) count > n / 2 + 1
            // accept:  i = n, count ( == count )

            IList<string> result = new List<string>();
            StringBuilder sb = new StringBuilder();
            Stack<char> stack = new Stack<char>();
            
            helper(result, sb, n, stack);

            return result;

        }

        private void helper(IList<string> result, StringBuilder sb, int n, Stack<char> stack)
        {
            if (sb.Length == n*2)
            {
                if (stack.Count == 0)
                {
                    result.Add(sb.ToString());
                }
                
                return;
            } 
            


            if (stack.Count() > n * 2 - sb.Length )
            {
                return;
            }

            sb.Append('(');
            stack.Push('(');
            helper(result, sb, n, stack);
            stack.Pop();
            sb.Remove(sb.Length - 1, 1);

            if (stack.Count > 0)
            {
                sb.Append(')');
                stack.Pop();
                helper(result, sb, n, stack);
                sb.Remove(sb.Length - 1, 1);
                stack.Push('(');
            }


        }
}