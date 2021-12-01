﻿namespace ATMLibrary.Classes
{
    public interface IAutomatedTellerMachine
    {
        IAccount Account { get; }
        void Withdraw(decimal _amount);
        void Deposit(decimal _amount);
        void ViewBalance();
        Task Login(int _pin);
        void Logout();
        bool IsLoggedIn();
        void ConfigureBalance(decimal _amount);
    }
}