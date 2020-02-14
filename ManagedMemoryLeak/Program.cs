using System;

namespace ManagedMemoryLeak
{
	class Program
	{
		static void Main(string[] args)
		{
			// Memory leak with managed objects
			var managedBigObjectGenerator = new ManagedBigObjectGenerator();
			managedBigObjectGenerator.CreateObjects();

			Console.WriteLine("Done");

			Console.ReadLine();
		}
	}
}
