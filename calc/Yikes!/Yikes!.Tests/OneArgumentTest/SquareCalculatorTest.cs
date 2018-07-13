﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Yikes_.OneArgument;
using static System.Math;

namespace Yikes_.Tests
{
    class SquareCalculatorTests
    {
        [TestCase(13)]
        [TestCase(24)]
        [TestCase(17)]
        public
            void CalcTests(double testnum)
        {
            SquareCalculator sqare = new SquareCalculator();
            double ExpResult = Pow(testnum, 2), ActResult = sqare.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}