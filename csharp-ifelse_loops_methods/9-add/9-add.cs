using System;

/// <summary>
/// Provides mathematical operations for numbers
/// </summary>
class Number
{
	/// <summary>
	/// Adds two integers together
	/// </summary>
	/// <param name="a">The first integer to add</param>
	/// <param name="b">The second integer to add</param>
	/// <returns>The sum of the two integers</returns>
	public static int Add(int a, int b)
	{
		return a + b;
	}
}

/// <summary>
/// Main program class containing the application entry point
/// </summary>
class Program
{
	/// <summary>
	/// Main entry point of the application
	/// </summary>
	static void Main()
	{
		Console.WriteLine("{0}", Number.Add(1, 2));
		Console.WriteLine("{0}", Number.Add(98, 0));
		Console.WriteLine("{0}", Number.Add(100, -2));
	}
}