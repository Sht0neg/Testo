namespace BankAccount.Tests
{
    public class Tests
    {
        [Test]
        public void DepositTest()
        {
            var account = new BankAccount("User1", 200);
            account.Deposit(50);
            Assert.AreEqual(250, account.Balance);
        }

        [Test]
        public void WithdrawTestF()
        {
            var account = new BankAccount("User1", 200);
            account.Withdraw(50);
            Assert.AreEqual(150, account.Balance);
        }

        [Test]
        public void WithdrawTestS()
        {
            var account = new BankAccount("User1", 50);
            account.Withdraw(150);
            Assert.AreEqual(50, account.Balance);
        }

        [Test]
        public void TransferTestF()
        {
            var sender = new BankAccount("Sender", 200);
            var recipient = new BankAccount("Recipient", 50);
            sender.Transfer(recipient, 50);
            Assert.AreEqual(150, sender.Balance);
            Assert.AreEqual(100, recipient.Balance);
        }

        [Test]
        public void TransferTestS()
        {
            var sender = new BankAccount("Sender", 50);
            var recipient = new BankAccount("Recipient", 50);
            sender.Transfer(recipient, 200);
            Assert.AreEqual(50, sender.Balance);
            Assert.AreEqual(50, recipient.Balance);
        }

        [Test]
        public void ConstructorTest()
        {
            // Act & Assert
            var account = new BankAccount("User1", -50);
            Assert.AreEqual(0, account.Balance);
        }
    }
}
