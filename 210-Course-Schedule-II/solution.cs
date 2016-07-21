public class Solution {
        public int[] FindOrder(int numCourses, int[,] prerequisites)
        {

            List<int> result = new List<int>();

            //BFS

            //create a queue to save all courses without prerequisites
            Queue<int> noPrereqCourses = new Queue<int>();

            //array for <course,numPrerequsites> pair 
            int[] courses = new int[numCourses];

            if (prerequisites == null)
            {
                return result.ToArray();
            }

            for (int i = 0; i < prerequisites.GetLength(0); i++)
            {
                courses[prerequisites[i, 0]]++;
            }

            for (int i = 0; i < courses.Count(); i++)
            {
                if (courses[i] == 0)
                {
                    noPrereqCourses.Enqueue(i);
                    result.Add(i);
                }
            }

            int totalNum = noPrereqCourses.Count;

            //go through queue. If the other courses depends only on the current course
            //add it to queue and increase totalNum by 1
            while (noPrereqCourses.Count > 0)
            {
                int courseNum = noPrereqCourses.Dequeue();

                for (int i = 0; i < prerequisites.GetLength(0); i++)
                {
                    if (prerequisites[i, 1] == courseNum)  // prerequisites[i,0] depends on current course
                    {
                        courses[prerequisites[i, 0]]--;
                        if (courses[prerequisites[i, 0]] == 0)
                        {
                            totalNum++;
                            noPrereqCourses.Enqueue(prerequisites[i, 0]);
                            result.Add(prerequisites[i, 0]);
                        }
                    }
                }
            }

            if (totalNum == numCourses)
            {
                return result.ToArray(); ;
            }
            else
            {
                return new int[]{};
            }
        }
}