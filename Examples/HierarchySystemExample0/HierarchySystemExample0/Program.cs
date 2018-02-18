using System;
using HierarchySystem;

namespace HierarchySystemExample0
{
    class Program
	{
		static void Main(string[] args)
		{
			HItem grandfather = new HItem();
			HItem father = new HItem();
			HItem daughter = new HItem();

			father.SetParent(grandfather);
			daughter.SetParent(father);

			HItem _SameGrandfather = daughter.GetParent().GetParent();

			Console.WriteLine(_SameGrandfather.childCount);
			Console.Read();
		}
	}
}
