using System;
public class InsufficientWalletBalanceException : Exception
{
    public InsufficientWalletBalanceException():base("Insufficient balance in your digital wallet")
    {}
}