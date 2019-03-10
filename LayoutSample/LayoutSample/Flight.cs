using System;
using System.Collections.Generic;
using System.Text;

namespace LayoutSample
{
    public class Flight
    {
        private string Arv;


        public string getArv
        {
            get { return Arv; }
            set { Arv = value; }
        }
        private string Dep;
        
        public string getDep
        {
            get { return Dep; }
            set { Dep = value; }
        }
        private string Term;
          
        public string getTerm
        {
            get { return Term; }
            set { Term = value; }
        }
        private string Gate;
        
        public string getGate
        {
            get { return Gate; }
            set { Gate = value; }
        }
        private string Seat;
        
        public string getSeat
        {
            get { return Seat; }
            set { Seat = value; }
        }
        private string Depart;

        public string getDepart
        {
            get { return Depart; }
            set { Depart = value; }
        }
        public string getStatus
        {
            get { return Status; }
            set { Status = value; }
        }
        private string Status;
        private string City;

        public string getCity
        {
            get { return City; }
            set { City = value; }
        }
        private string STA;

        public string getSTA
        {
            get { return STA; }
            set { STA = value; }
        }
        private string ETA;

        public string getETA
        {
            get { return ETA; }
            set { ETA = value; }
        }
        private string Terminal;

        public string getTerminal
        {
            get { return Terminal; }
            set { Terminal = value; }
        }
        private string Status2;

        public string getStatus2
        {
            get { return Status2; }
            set { Status2 = value; }
        }
    }
}

