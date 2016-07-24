public class Solution {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            //[2,3,6,7] => 7
            //2, 5
            //3, 2
            // if target - sum == 0, found
            // if target - sum < 0, not found            
            // [2,3], target - sum
            // try all candidates smaller than (target -sum)
            List<IList<int>> results = new List<IList<int>>();
            List<int> potential = new List<int>();

            bfs(results, candidates.ToList(), potential, 0,  target);

            return results;

        }

        private void bfs (List<IList<int>> results, IList<int> candidates, List<int> potential, int start, int target)
        {
            int sum = potential.Sum();

            if (target == sum)
            {
                results.Add(potential.ToList());
                return;
            }

            if (target > sum)
            {
                for (int j = start; j <= candidates.Count -1; j ++)
                {
                    if (candidates.ElementAt(j) <= target - sum)
                    {
                        potential.Add(candidates.ElementAt(j));
                        bfs(results, candidates, potential, j, target);
                        potential.RemoveAt(potential.Count - 1);
                    }
                }
            }


        }
}