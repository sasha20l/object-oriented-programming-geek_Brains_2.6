using System;

namespace HomeworkOnObjectOrientedProgramming_6
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkingWithCitizens ClientFirst = new WorkingWithCitizens(); ClientFirst.verificationForWorkingWithMoneyTransfers();

            Console.WriteLine(ClientFirst.GetHashCode());
            Console.WriteLine(ClientFirst.ToString());

            WorkingWithCitizens ClientSecond = new WorkingWithCitizens();
            ClientFirst.verificationForWorkingWithMoneyTransfers();

            Console.WriteLine(ClientFirst.GetHashCode());
            Console.WriteLine(ClientFirst.ToString());
        }
    }


    public class BankAccount
    {

        private int _account = 101110111;
        public int Accaunt { get { return _account; } }

        public bool checkForAccountIdentity(int accountBeingVerified)
        {
            if (accountBeingVerified == _account) return true;
            else return false;
        }

        public bool checkAccountIdentityForEquals(int accountBeingVerified)
        {
            if (_account.Equals(accountBeingVerified)) return true;
            else return false;
        }

    }

    public class WorkingWithMoneyTransfers : BankAccount
    {

    }

    public class WorkingWithLending : BankAccount
    {

    }

    public class WorkingWithCitizens
    {
        private WorkingWithMoneyTransfers personFirstForWorkingWithMoneyTransfers = new WorkingWithMoneyTransfers();
        private WorkingWithMoneyTransfers personSecondForWorkingWithMoneyTransfers = new WorkingWithMoneyTransfers();

        private WorkingWithLending personFirstForCredit = new WorkingWithLending();
        private WorkingWithLending personSecondForCredit = new WorkingWithLending();

        private bool verificationFirstPerson;
        private bool verificationFirstPersonForEquals;
        private bool verificationSecondPerson;
        private bool verificationSecondPersonForEquals;

        private static int transactionТumber = 0;



        public void overrideOperators()
        {
            verificationForWorkingWithMoneyTransfers();

            verificationForCredit();
        }

        public void verificationForWorkingWithMoneyTransfers()
        {
            verificationFirstPerson = personFirstForWorkingWithMoneyTransfers.checkForAccountIdentity(101110111);
            verificationFirstPersonForEquals = personFirstForWorkingWithMoneyTransfers.checkAccountIdentityForEquals(101110111);
            verificationSecondPerson = personSecondForWorkingWithMoneyTransfers.checkForAccountIdentity(105435111);
            verificationSecondPersonForEquals = personSecondForWorkingWithMoneyTransfers.checkAccountIdentityForEquals(105435111);

        }

        public void verificationForCredit()
        {

            verificationFirstPerson = personFirstForCredit.checkForAccountIdentity(101110111);
            verificationFirstPersonForEquals = personFirstForCredit.checkAccountIdentityForEquals(101110111);
            verificationSecondPerson = personSecondForCredit.checkForAccountIdentity(105435111);
            verificationSecondPersonForEquals = personSecondForCredit.checkAccountIdentityForEquals(105435111);

        }

        public override string? ToString()
        {
            return $"Верификация первого человека {verificationFirstPerson} и {verificationFirstPersonForEquals}, " +
                $"второго человека {verificationSecondPerson} и {verificationSecondPersonForEquals}";
        }

        public override int GetHashCode()
        {
            transactionТumber++;
            Console.Write($"Номер операции ");
            return transactionТumber;
        }
    }
}
