using System;
using System.Linq;

class Welcome{
	public static void BridgeLabz(){
		Console.WriteLine("Welcome to BridgeLabz!");
	}
}

class Two{
	public static void Sum(){
		Console.WriteLine("Enter 2 numbers to add:");
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int sum = a+b;
		Console.WriteLine("Sum = "+sum);
	}
}

class Celsius{
	public static void ToFahrenheit(){
		Console.WriteLine("Enter Temperature in Celsius:");
		float celsius = float.Parse(Console.ReadLine());
		float fahrenheit = (celsius * 9f/5f) + 32;
		Console.WriteLine("Temperature in Fahrenheit: "+fahrenheit);
	}
}

class Circle{
	public static void Area(){
		Console.WriteLine("Enter radius of the Circle:");
		int radius = int.Parse(Console.ReadLine());
		double area = 3.14 * Math.Pow(radius, 2);
		Console.WriteLine("Area of the Circle: "+area);
	}
}

class Cylinder{
	public static void Volume(){
		Console.WriteLine("Enter radius of the Cylinder:");
		int radius = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter height of the Cylinder:");
		int height = int.Parse(Console.ReadLine());
		double volume = Math.PI * Math.Pow(radius, 2) * (double)height;
		Console.WriteLine("Volume of the Cylinder: "+ volume);
	}
}

class SimpleInterest{
	public static void Calculate(){
		Console.WriteLine("Enter Principle, Rate and Time:");
		string[] inputs = Console.ReadLine().Split();
		float p = float.Parse(inputs[0]);
		float r = float.Parse(inputs[1]);
		float t = float.Parse(inputs[2]);
		float si = (p*r*t)/100;
		Console.WriteLine("Simple Interest = "+si);
	}
}

class Rectangle{
	public static void Perimeter(){
		Console.WriteLine("Enter Length and Width of the rectangle:");
		string[] inputs = Console.ReadLine().Split();
		int l = int.Parse(inputs[0]);
		int w = int.Parse(inputs[1]);
		int perimeter = 2*(l+w);
		Console.WriteLine("Perimeter of the rectangle = "+perimeter);
	}
}

class Calculate{
	public static void Pow(){
		Console.WriteLine("Enter Base and Exponent:");
		string[] inputs = Console.ReadLine().Split();
		int bas = int.Parse(inputs[0]);
		int exp = int.Parse(inputs[1]);
		int ans = (int)Math.Pow(bas, exp);
		Console.WriteLine("Answer = "+ans);
	}
}

class Three{
	public static void Average(){
		Console.WriteLine("Enter 3 numbers:");
		int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
		int sum = 0;
		foreach (int i in nums){
			sum += i;
		}
		float avg = (float)sum/3;
		Console.WriteLine("Average = "+avg);
	}
}

class Conversion{
	public static void KmToMile(){
		Console.WriteLine("Enter distance in km:");
		int km = int.Parse(Console.ReadLine());
		double mi = km*0.621371;
		Console.WriteLine("Distance in miles: "+mi);
	}
}

class Program{
	public static void Main(string[] args){
		Welcome.BridgeLabz();
		Two.Sum();
		Celsius.ToFahrenheit();
		Circle.Area();
		Cylinder.Volume();
		SimpleInterest.Calculate();
		Rectangle.Perimeter();
		Calculate.Pow();
		Three.Average();
		Conversion.KmToMile();
	}
}