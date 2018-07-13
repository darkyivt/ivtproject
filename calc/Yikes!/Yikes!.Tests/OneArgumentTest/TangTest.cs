﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Yikes_.OneArgument;
using static System.Math;

namespace Yikes_.Tests
{
    class TanhTests
    {
        [TestCase(33)]
        [TestCase(66)]
        [TestCase(77)]
        public
            void CalcTests(double testnum)
        {
            TanH tanhc = new TanH();
            double ExpResult = Tanh(testnum), ActResult = tanhc.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}