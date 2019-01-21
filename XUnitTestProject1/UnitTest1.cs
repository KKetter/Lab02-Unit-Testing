using System;
using Xunit;
using Lab02_Unit_Testing;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        //Really nice work on the code for the atm. Right now you have not met the requirements for testing though. 
        //Every non-void method should have at least two tests. You need to test for invalid input on the deposit and withdraw methods. 
        //-3 for missing tests. Let me know if you have any questions. You can resubmit for full credit. 
        //NewDeposit, DisplayBalance, NewWithdraw each need one more test - have them test not possible inputs for the methods
        [Fact]
        public void DepositFunctionality()
        {
            // Deposit of 500 w/ a starting balance of 500 generates an output 1000
            Assert.Equal(1000, Program.NewDeposit(500, 500)); //refactor to remove inputs (readline, readkey);
        }
        [Fact]
        public void BadDepositFunctionality()
        {
            // Deposit of -100 w/ a starting balance of 500 generates an output 500 by erroring input value
            Assert.NotEqual(500, Program.NewDeposit(-100, 500)); //refactor to remove inputs (readline, readkey);
        }
        [Fact]
        public void DisplayBalanceTest()
        {
            // If display Balance is fed a value of 500 output should be 500
            Assert.Equal(500, Program.DisplayBalance(500)); 
        }
        [Fact]
        public void BadDisplayBalanceTest()
        {
            // If display Balance is fed a value of -500 output should be -500
            Assert.Equal(-500, Program.DisplayBalance(-500));
        }
        [Fact]
        public void WithdrawFuncationality()
        {
            // Withdraw of 200 dollars w/ a starting balance of 500 generates output of 300
            Assert.Equal(300, Program.NewWithdraw(500, 200)); //refactor to remove inputs (readline, readkey);
        }
        [Fact]
        public void FaultyWithdrawFuncationality()
        {
            // Withdraw of 200 dollars w/ a starting balance of 500 generates output of 300
            Assert.Equal(500, Program.NewWithdraw(500, -200)); //refactor to remove inputs (readline, readkey);
        }


    }
}
