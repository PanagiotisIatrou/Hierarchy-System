using System;
using System.Collections.Generic;

namespace HierarchySystem
{

	class Program
	{
		static void Main(string[] args)
		{

		}
	}

	public class HItem
	{
		private HItem parent = null;
		private List<HItem> childs = new List<HItem>();
		public int childCount { get { return childs.Count; } }

		public void SetParent(HItem item)
		{
			if (item != null)
			{
				// Return if the parent already has this as a child
				if (item.childs.Contains(this))
					return;
				item.AddChild(this);
				parent = item;
			}
			else
			{
				// Return if we already have no other parent
				if (parent == null)
					return;
				parent.RemoveChild(this);
				parent = null;
			}
		}

		public HItem GetParent()
		{
			return parent;
		}

		public void AddChild(HItem item)
		{
			childs.Add(item);
		}

		public void RemoveChild(HItem item)
		{
			childs.Remove(item);
		}

		public List<HItem> GetChilds()
		{
			return childs;
		}

		public HItem GetChild(int index)
		{
			return childs[index];
		}

	}

}
