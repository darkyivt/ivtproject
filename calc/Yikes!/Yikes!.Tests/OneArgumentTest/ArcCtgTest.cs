﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Yikes_.OneArgument;
using static System.Math;

namespace Yikes_.Tests
{
    class ArcCtgTests
    {
        [TestCase(33)]
        [TestCase(66)]
        [TestCase(77)]
        public
            void CalcTests(double testnum)
        {
            ArcCtg arcctgc = new ArcCtg();
            double ExpResult = 1 / Atan(testnum), ActResult = arcctgc.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
