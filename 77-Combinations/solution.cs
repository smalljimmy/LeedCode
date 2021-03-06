public class Solution {
    
        public IList<IList<int>> Combine(int n, int k)
        {
            List<IList<int>> results = new List<IList<int>>();
            List<int> result = new List<int>();

            combine_help(results, result, 1, n, k);

            return results;
        }

        private void combine_help(List<IList<int>> results, List<int> result, int start, int n, int k)
        {
            if (result.Count() == k)
            {
                results.Add(result.ToList());
                return;
            }

            for (int j = start; j <=n; j++)
            {
                result.Add(j);
                combine_help(results, result, j+1, n, k);
                result.Remove(j);
            }

        }
}