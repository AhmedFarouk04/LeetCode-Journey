using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_08Graph
{
    public class Course_Schedule
    {
        public class Solution
        {
            public bool CanFinish(int numCourses, int[][] prerequisites)
            {
                List<int>[] graph = new List<int>[numCourses];

                for (int i = 0; i < numCourses; i++)
                {
                    graph[i] = new List<int>();
                }

                foreach (int[] pair in prerequisites)
                {
                    int course = pair[0];
                    int prerequisite = pair[1];

                    graph[prerequisite].Add(course);
                }

                int[] state = new int[numCourses];

                for (int course = 0; course < numCourses; course++)
                {
                    if (HasCycle(course, graph, state))
                        return false;
                }

                return true;
            }

            private bool HasCycle(int course, List<int>[] graph, int[] state)
            {
                if (state[course] == 1)
                    return true;

                if (state[course] == 2)
                    return false;

                state[course] = 1;

                foreach (int nextCourse in graph[course])
                {
                    if (HasCycle(nextCourse, graph, state))
                        return true;
                }

                state[course] = 2;

                return false;
            }
        }
    }
}
