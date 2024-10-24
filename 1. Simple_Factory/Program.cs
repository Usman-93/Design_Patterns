
using _1._Simple_Factory.BankAccountFactory;
using _1._Simple_Factory.Interface;

IBankAccount savingsAccount = BankAccountFactory.createBankAccount("SavingsAccount");
IBankAccount offsetAccount  = BankAccountFactory.createBankAccount("OffsetAccount");

savingsAccount.sendMoney(offsetAccount, 10);



