﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEA
{
    /// <summary>
    /// Helper with TSP result returned from algorithms, generic, but used only in int values
    /// Basic values are cost, path and time, but there is also a variable used in tabu search tests
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class TSPResult<T>
    {
        public T PathCost;
        public int[] Path;
        public long Time; //time taken in ms
        public int ImprovementCounter;

        public TSPResult(T cost, int[] path, long t = 0, int impr = 0)
        {
            this.PathCost = cost;
            this.Path = path;
            this.Time = t;
            this.ImprovementCounter = impr;
        }

        public String ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Best path cost: " + PathCost);
            str.AppendLine("Calculated in: " + Time + "ms");
            str.Append("Path: ");
            foreach (var item in Path)
                str.Append(item + " ");
            str.AppendLine();

            return str.ToString();
        }

        /// <summary>
        /// Use this in tests, give results in CSV format
        /// </summary>
        /// <returns></returns>
        public String ToStringInTests()
        {
            return PathCost + "," + Time + "\n";
        }
    }
}
