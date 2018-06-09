//C# code
using System;

class Conversions
{
    public class Ratios
    {
        ///<summary>
        ///Converts degrees to radians
        ///</summary>
        public ConvertToRadians(float degrees)
        {
            return degrees * Mathf.PI / 180;
        }

        ///<summary>
    	///Converts radians to degrees
    	///</summary>
        public ConvertRadiansToDegrees(float radians)
        {
            return radians * 180 / radians;
        }
    }

    public class Proportions
    {
        ///<summary>
        ///Finds the missing proportion numerator
        ///</summary>
        public float Convert(num1, denom1, denom2)
        {
            return (num1 * denom2) / denom1;
        }
    }
}