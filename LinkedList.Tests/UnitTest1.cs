using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListLib;

namespace LinkedList.Tests
{
    [TestClass]
    public class UnitTest1
    {
       
        
        [TestMethod]
        public void Create()
        {
            var IntLinkedList = new LinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                IntLinkedList.AddLast(new ListItem<int>(i));
            }
            Assert.AreEqual(IntLinkedList.Count, 5);
        }

        [TestMethod]
        public void Find()
        {
            var IntLinkedList = new LinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                IntLinkedList.AddLast(new ListItem<int>(i));
            }
            Assert.AreEqual(IntLinkedList.Find(2), 2);
        }

        [TestMethod]
        public void Iterator()
        {
            var IntLinkedList = new LinkedList<int>();
            int [] exspect={0,1,2,3,4};
            int [] result = new int[5];
            for (int i = 0; i < 5; i++)
            {
                IntLinkedList.AddLast(new ListItem<int>(i));
            }
            int counter=0;
            foreach (var item in IntLinkedList)
            {
                result[counter] = item;
                counter++;
            }
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(result[i], exspect[i]);
            }            
        }
    }
}
