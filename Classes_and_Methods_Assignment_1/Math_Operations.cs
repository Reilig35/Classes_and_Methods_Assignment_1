using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Methods_Assignment_1
{
    public class Math_Operations
    {
        public int OperatorbyTwo( int num1) 
        {
            int result = num1 * 2;
            return result;
        }
        public float OperatorbyTwo( float num1) 
        {
            float result = num1 / 2f;
            return result;
        }
        public string OperatorbyTwo( string str1) 
        {
            int num1 = Convert.ToInt32(str1);
            int result = num1 - 2;
            return result.ToString();
        }
    }
}
