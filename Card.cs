using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentral
{
    public class Card
    {
        //Private datamedlemmer
        private int cardID;
        private string pin;
        private ValidityPeriod validity;

        ///Public datamedlemmer
        public int CardID { 
            get { return cardID; } 
            set { cardID = value; }
        }
        public string Pin
        {
            get { return pin; }
            set { pin = value; }
        }
        public ValidityPeriod Validity
        {
            get { return validity; }
            set { validity = value; }
        }
        public Card(int cardID) {
            this.cardID = cardID;
            this.pin = new Random().Next(0000,9999).ToString();
            this.validity = new ValidityPeriod();
        }
        public Card(int cardID, string pin, ValidityPeriod validity)
        {
            this.cardID = cardID;
            this.pin = pin;
            this.validity = validity;
        }
        public Card(int cardID, ValidityPeriod validity)
        {
            this.cardID = cardID;
            this.pin = new Random().Next(0000, 9999).ToString();
            this.validity = validity;
        }
        public string Info()
        {
            string vpInfo = this.validity.Info();
            string msg = "CardID: "+ CardID.ToString() + "\nPIN:"+ Pin +"\n" +vpInfo;
            return msg;
        }

        public bool Validate(int ID,int Pin)
        {
            //todo skal sjekke at en bruker med cardid = ID og CardPin = Pin finnes i DB
            return false;
        }
    }
}
