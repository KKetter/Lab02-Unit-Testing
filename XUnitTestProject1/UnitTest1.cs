using System;
using Xunit;
using Lab02_Unit_Testing;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void DepositFunctionality()
        {
            // Deposit of 500 w/ a starting balance of 500 generates an output 1000
            Assert.Equal(1000, Program.NewDeposit(500, 500)); //refactor to remove inputs (readline, readkey);
        }
        [Fact]
        public void DisplayBalanceTest()
        {
            // If display Balance is fed a value of 500 output should be 500
            Assert.Equal(500, Program.DisplayBalance(500)); 
        }
        [Fact]
        public void WithdrawFuncationality()
        {
            // Withdraw of 200 dollars w/ a starting balance of 500 generates output of 300
            Assert.Equal(300, Program.NewWithdraw(500, 200)); //refactor to remove inputs (readline, readkey);
        }

    }
}
