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
	///Finds the missing proportion when to ratios equal eachother
	///Algebra:cross multiply and isolate x by itself by dividing by denom1 (basic algebra rules)
	//Time Complexity O(n)
	///<summary>
	public Convert(num1,denom1,denom2)
	{
		return (num1 * denom2)/denom1;
	}
	//Math
	//1/5 = x/20
	//1*20 = 20
	//5*x = 5x
	//5x = 20
	//20/5 = 4
	
    }
}