﻿using System;
using System.Linq;

namespace MyMath
{
    ///<summary>Creates a public class.</summary>
    public class Operations
    {
        ///<summary>Creates a protype.</summary>
        public static int Max(List<int> nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            return (nums.Max());
        }
    }
}