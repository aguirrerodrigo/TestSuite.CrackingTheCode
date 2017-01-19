using System;
using System.Collections.Generic;
using TestSuite.CrackingTheCode.ReadThrough.Utils;

namespace TestSuite.CrackingTheCode.ReadThrough.TechnicalQuestions
{
    /// <summary>
    /// Print all positive integer solutions to the equation a^3 + b^3 = c^3 + d^3 where a, b, c
    /// and d are integers between 1 and 1000.
    /// </summary>
    public class EqualPolynomials
    {
        public BigOCounter Counter { get; set; } = new BigOCounter();

        public int[][] BruteForce(int min, int max)
        {
            var result = new List<int[]>();

            for(var a = min; a <= max; a++)
                for (var b = min; b <= max; b++)
                    for (var c = min; c <= max; c++)
                        for (var d = min; d <= max; d++)
                        {
                            this.Counter.Increment();

                            if (Math.Pow(a, 3) + Math.Pow(b, 3) == Math.Pow(c, 3) + Math.Pow(d, 3))
                                result.Add(new int[] { a, b, c, d });
                        }

            return result.ToArray();
        }

        public int[][] CalculateForD(int min, int max)
        {
            var result = new List<int[]>();

            for (var a = min; a <= max; a++)
                for (var b = min; b <= max; b++)
                    for (var c = min; c <= max; c++)
                    {
                        this.Counter.Increment();

                        var d = (int)CorrectRoundingPrecision(
                                    CubeRoot(Math.Pow(a, 3) + Math.Pow(b, 3) - Math.Pow(c, 3)));
                        if (Math.Pow(a, 3) + Math.Pow(b, 3) == Math.Pow(c, 3) + Math.Pow(d, 3)
                            && d >= min
                            && d <= max)
                        {
                            result.Add(new int[] { a, b, c, d });
                        }
                    }

            return result.ToArray();
        }

        public int[][] Optimized1(int min, int max)
        {
            var result = new List<int[]>();
            var dictionary = new Dictionary<int, List<int[]>>();

            for(var c = min; c <= max; c++)
                for(var d = min; d <= max; d++)
                {
                    var key = (int)Math.Pow(c, 3) + (int)Math.Pow(d, 3);
                    var value = new int[] { c, d };

                    var list = default(List<int[]>);
                    if (dictionary.ContainsKey(key))
                        list = dictionary[key];
                    else
                    {
                        list = new List<int[]>();
                        dictionary.Add(key, list);
                    }
                    
                    list.Add(new int[] { c, d });
                };

            for(var a = min; a <= max; a++)
                for(var b = min; b <= max; b++)
                {
                    var key = (int)Math.Pow(a, 3) + (int)Math.Pow(b, 3);
                    var value = new int[] { a, b };

                    if (dictionary.ContainsKey(key))
                    {
                        var list = dictionary[key];
                        foreach(var item in list)
                        {
                            this.Counter.Increment();

                            result.Add(new int[] { a, b, item[0], item[1] });
                        }
                    }
                }

            return result.ToArray();
        }

        public int[][] Optimized2(int min, int max)
        {
            var result = new List<int[]>();
            var dictionary = new Dictionary<int, List<int[]>>();

            for (var c = min; c <= max; c++)
                for (var d = min; d <= max; d++)
                {
                    var key = (int)Math.Pow(c, 3) + (int)Math.Pow(d, 3);
                    var value = new int[] { c, d };

                    var list = default(List<int[]>);
                    if (dictionary.ContainsKey(key))
                        list = dictionary[key];
                    else
                    {
                        list = new List<int[]>();
                        dictionary.Add(key, list);
                    }

                    list.Add(new int[] { c, d });
                };

            foreach(var kvp in dictionary)
            {
                foreach(var item1 in kvp.Value)
                {
                    foreach(var item2 in kvp.Value)
                    {
                        this.Counter.Increment();

                        result.Add(new int[] { item1[0], item1[1], item2[0], item2[1] });
                    }
                }
            }

            return result.ToArray();
        }

        private double CubeRoot(double n)
        {
            var root = Math.Pow(Math.Abs(n), 1D / 3D);
            var isNegative = n < 0;
            if (isNegative)
                root *= -1;

            return root;
        }

        private double CorrectRoundingPrecision(double n)
        {
            var real = Math.Round(n);
            var diff = Math.Abs(n - real);

            var epsilon = 0.0000000001;
            if (diff < epsilon)
                return real;
            else
                return n;
        }
    }
}
