using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace DataStructures.Tests
{
	[TestClass]
	public class LinkedListTests
	{
		[TestMethod]
		public void Tautology()
		{
			Assert.AreEqual(1, 1);
		}

		[TestMethod]
		public void Add_EmptyList_ListContainsItem()
		{
			var list = new LinkedList();
			var item = 1;
			list.Add(item);
			Assert.AreEqual(list.Get(), item);
		}
	}
}
