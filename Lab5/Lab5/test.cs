using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Lab5
{
    [TestFixture]
    class test
    {
        [TestCase]
        public void Add()
        {
            functions f = new functions();
            Assert.AreEqual(33, f.add(3, 30));
        }

        [TestCase]
        public void Sub()
        {
            functions f = new functions();
            Assert.AreEqual(33, f.sub(3, 30));
        }

        [TestCase]
        public void Con()
        {
            functions f = new functions();
            Assert.AreEqual(15.24, f.con(6));
        }

        [TestCase]
        public void Chet()
        {
            functions f = new functions();
            Assert.AreEqual(true, f.chet(12));
        }

        [TestCase]
        public void Max()
        {
            int[] m = { 0, 4, 10, 3, 7 };

            functions f = new functions();
            Assert.AreEqual(10, f.max(m));
        }

        [TestCase]
        public void Ost()
        {
            functions f = new functions();
            Assert.AreEqual(3, f.ost(7, 4));
        }
    }
}
