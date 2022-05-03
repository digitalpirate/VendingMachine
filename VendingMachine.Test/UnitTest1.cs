using System;
using Xunit;

namespace VendingMachine.Test
{
    public class UnitTest1
    {
        [Fact]
        public void EndTransaction_RefundsMoneyInWallet_WalletIsEmpty()
        {
            //Arrange

            var vend = new VendingManager();
            int result;
            vend.wallet = 50;
            double expected = 0;

            //Act

            vend.EndTransaction();
            result = vend.wallet;

            //Assert

            double dResult = Convert.ToInt32(result);
            Assert.Equal(expected, dResult);

        }
    }
}