using System;
using Xunit;
using ConsoleApp1;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    public class MathTest
    {
        [Fact]
        public void Add_Numbers()
        {
              
            var nummer1 = 2.9;
            var nummer2 = 3.1;
            var förväntatVärde = 6;
     
            var summa =  MathOperation.Add(nummer1, nummer2);
            
            Assert.Equal(förväntatVärde, summa, 1);
        }

        
    }
}
