﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Yikes_.OneArgument;
using static System.Math;

namespace Yikes_.Tests
{
    class CubeCalculatorTests
    {
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(7)]
        public void CalcTests(double testnum)
        {
            CubeCalculator powc = new CubeCalculator();
            double ExpResult = Pow(testnum, 3), ActResult = powc.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}