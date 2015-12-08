﻿using System;
using Shouldly.Tests.Strings;
using Xunit;

namespace Shouldly.Tests.ShouldBe.WithTolerance
{
    public class FloatScenario
    {
        [Fact]
        public void FloatScenarioShouldFail()
        {
            const float pi = (float)Math.PI;
            Verify.ShouldFail(() =>
                pi.ShouldBe(3.24f, 0.01d, "Some additional context"),

errorWithSource:
@"pi
    should be within
0.01
    of
3.24
    but was
3.141593

Additional Info:
    Some additional context",

errorWithoutSource:
@"3.141593
    should be within
0.01
    of
3.24
    but was not

Additional Info:
    Some additional context");
        }

        [Fact]
        public void ShouldPass()
        {
            const float pi = (float)Math.PI;
            pi.ShouldBe(3.14f, 0.01d);
        }
    }
}