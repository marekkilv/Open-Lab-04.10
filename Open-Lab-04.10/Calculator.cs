using System;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            int[] a =  Queryable.Average(nums.AsQueryable());
            return a;
        }
    }
}
