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

			HItem _SameGrandfather = grandfather.GetChild(0).GetChild(0);

			Console.WriteLine(_SameGrandfather.childCount);
			Console.Read();
		}
	}
}
