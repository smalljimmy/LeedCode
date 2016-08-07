public class Solution {

        public IList<int> SpiralOrder(int[,] matrix)
        {
            List<int> result = new List<int>();
            printSpiralMatrix(0, 0, matrix.GetLength(0) -1, matrix.GetLength(1)-1, matrix, result);
            return result;
        }

        public void printSpiralMatrix(int start_row, int start_col, int end_row, int end_col, int[,] matrix, List<int> list)
        {
            //check stop condition
            if (start_row > end_row || start_col > end_col)
            {
                return;
            }


            //go right
            for (int i = start_col; i <= end_col; i++)
            {
                list.Add(matrix[start_row, i]);
            }

            //go down
            for (int j = start_row + 1; j <= end_row; j++)
            {
                list.Add(matrix[j, end_col]);
            }

            //go left
            for (int k = end_col - 1; end_row != start_row && k >= start_col; k--)
            {
                list.Add(matrix[end_row, k]);
            }


            //12( start_row : 1, start_col:1, end_row: 2; end_col: 2)

            //go up
            for (int l = end_row - 1; end_col != start_col &&  l > start_row; l--)
            {
                list.Add(matrix[l, start_col]);
            }

            printSpiralMatrix(start_row + 1, start_col + 1, end_row - 1, end_col - 1, matrix, list);

        }
}