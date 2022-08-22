using System;
using System.Collections.Generic;
using System.Text;

namespace Livperiodesystemet___Genafalevering
{
    public class Aktivitet
    {
        public int _id;
        public int _minAlder;
        public int _maxAlder;
        public string _navnId;
        public DateTime _startTidspunkt;
        public DateTime _slutTidspunkt;


        public Aktivitet(int id, int minAlder, int maxAlder, string navnId, DateTime startTidspunkt, DateTime slutTidspunkt)
        {
            _id = id;
            _minAlder = minAlder;
            _maxAlder = maxAlder;
            _navnId = navnId;
            _startTidspunkt = startTidspunkt;
            _slutTidspunkt = slutTidspunkt;

        }

        public Aktivitet(int id)
        {

        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }

        }

        public int MinAlder
        {
            get { return _minAlder; }
            set { _minAlder = value; }
        }

        public int MaxAlder
        {
            get { return _maxAlder; }
            set { _maxAlder = value; }
        }

        public string NavnId
        {
            get { return _navnId; }
            set { _navnId = value; }
        }

        public DateTime StartTidspunkt
        {
            get { return _startTidspunkt; }
            set { _startTidspunkt = value; }
        }

        public DateTime SlutTidspunkt
        {
            get { return _slutTidspunkt; }
            set { _slutTidspunkt = value; }
        }

        public override string ToString()
        {
            return $"Id:{Id}, minimumsAlder:{MinAlder} MaksimumAlder:{MaxAlder}, navnId:{NavnId}, startTidspunkt:{StartTidspunkt}, slutTidspunkt:{SlutTidspunkt}";
        }






    }

    
        

}
