using System;

namespace Tamrin;

public static class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter X :");
		int X = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Y :");
		int Y = Convert.ToInt32(Console.ReadLine());
		int K_M_M = KMM(X, Y);
		Console.WriteLine("KMM is :");
		Console.WriteLine(K_M_M);
		int B_M_M = BMM(X, Y);
		Console.WriteLine("BMM is :");
		Console.WriteLine(B_M_M);

	}

	static int BMM(int x, int y)
	{
		int bmm = 1;
		for (int i = 1; i <= x && i <= y; i++)
		{
			if (x % i == 0 && y % i == 0)
			{
				bmm = i;
			}
		}
		return bmm;
	}

	static int KMM(int x, int y)
	{
		int kmm = x * y / BMM(x, y);
		return kmm;
	}
}
