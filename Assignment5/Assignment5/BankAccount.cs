using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment5
{
    class BankAccount
    {
        string id;
        double checking;
        double saving;
        public BankAccount()
        {
            id="???";
            checking = 0;
            saving = 0;
        }
        public BankAccount(string initID, double initChecking, double initSaving)
        {
            this.id = initID;
            this.checking = initChecking;
            this.saving = initSaving;
        }
        public string getID() {

            return id;
        }
        public double getChecking()
        {
            return checking;
        }
        public double getSaving()
       {
           return saving;
       }
        public double getBalance()
        {
            return checking + saving;
        }
        public void setID(string name)
        {
            id = name;
        }

        public void deposit(double depositAmount)
        {
            checking = checking + depositAmount;
        }
        public bool withdraw(double withdrawAmount)
        {
            if (checking < withdrawAmount)
            {
                return false;
            }
            else
            checking = checking - withdrawAmount;
            return true;
        }
        public void addInterest()
        {
            if (saving < 1000)
            {
                saving = saving * 1.025;
                checking = checking * 1.025;
            }
            if (saving >= 1000 && saving <= 5000)
            {
                saving = saving * 1.035;
                checking = checking * 1.035;
            }
            if (saving > 5000)
            {
                saving = saving * 1.045;
                checking = checking * 1.045;
            }
        }
        public bool equals(string s)
        {
            if (string.Compare(s, id) == 0)
            {
                return true;
            }
            else
                return false;
        }
        public string toString()
        {
            string f = "ID:" + id + "\n" + String.Format("Checking Balance:${0:N2}\n", checking) + String.Format("Saving Balance:${0:N2}\n", saving);
            return f;
        }
    
    }
}
