
    public class Solution
    {
        public int NumIslands(char[,] grid)
        {
            int result = 0;

            for (int i = 0; i < grid.GetLength(0); i++)
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i,j] == '1')
                    {
                        result++;
                        bfs(ref grid, i, j);

                    }

                }

            return result;

        }

        private void bfs(ref char[,] grid, int i, int j)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(i*grid.GetLength(0) + j);

            while (queue.Count > 0)
            {
                var idx = queue.Dequeue();
                int row = idx / grid.GetLength(0);
                int col = idx % grid.GetLength(0);
                if (grid[ row, col] == '1')
                {
                    grid[row, col] = '2';

                    
                    //UP
                    if (row > 1)
                    {
                        queue.Enqueue((row - 1) * grid.GetLength(0) + col);
                    }
                    
                    //DOWN
                    if (row < grid.GetLength(0) - 1)
                    {
                        queue.Enqueue((row + 1) * grid.GetLength(0) + col);
                    }
                    
                    //LEFT
                    if (col > 0)
                    {
                         queue.Enqueue(row* grid.GetLength(0) + col - 1);
                    }                   
                    

                    //RIGHT
                    if (col < grid.GetLength(1) -1)
                    {
                        queue.Enqueue(row* grid.GetLength(0) + col + 1);
                    }

                }


            }
        }
    }