﻿using System;
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
        public void Con()
        {
            functions f = new functions();
            var ex = Assert.Throws<ArgumentException>(() => f.con(-6));
            Assert.That(ex.Message, Is.EqualTo("Число должно быть > 0"));

            Assert.DoesNotThrow(() => f.con(6));

            var ed = Assert.Throws<ArgumentException>(() => f.con(double.MaxValue));
            Assert.That(ed.Message, Is.EqualTo("Превышение максимального значения типа данных"));

            Assert.DoesNotThrow(() => f.con(6));

        }

        [TestCase]
        public void Chet()
        {
            functions f = new functions();
            Assert.IsTrue(f.chet(12));
            Assert.IsFalse(f.chet(13));
            Assert.IsTrue(f.chet(0));
            Assert.IsFalse(f.chet(-13));
        }

        [TestCase]
        public void Max()
        {
            int[] m = { 0, 4, 10, 3, 7 };
            int[] n = { -1, -4, -10, -3, -7 };
            int[] p = { };

            functions f = new functions();
            var ex = Assert.Throws<ArgumentException>(() => f.max(p));
            Assert.That(ex.Message, Is.EqualTo("Массив пуст"));

            Assert.DoesNotThrow(() => f.max(m));
            Assert.DoesNotThrow(() => f.max(n));


        }

        [TestCase]
        public void Ost()
        {
            functions f = new functions();
            var ex = Assert.Throws<ArgumentException>(() => f.ost(7, 0));
            Assert.That(ex.Message, Is.EqualTo("Делитель должен быть не равен 0"));

            Assert.DoesNotThrow(() => f.ost(7, 2));
            Assert.DoesNotThrow(() => f.ost(7, -2));

        }
    }
}
