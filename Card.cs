using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAndDeck
{
    public class Card
    {
        string Suit;
        string Value;

        string[] vals = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "j", "jack", "q", "queen", "k", "king", "a", "ace"};

        public Card(string value, string suit)
        {
            Suit = suit.ToLower();
            Value = value;
        }

        private bool checkSuit(string s)
        {
            if (s.Equals("spades") || s.Equals("clubs") || s.Equals("hearts") || s.Equals("diamonds"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkValue(string v)
        {
            v = v.ToLower();
            for (int i = 0; i < vals.Length; i++)
            {
                if (v.Equals(vals[i]))
                {
                    if (v.Length > 1)
                    {
                        v = v.Remove(1, v.Length - 1);
                        v = v.ToUpper();
                        Value = v;
                    }
                    return true;
                }
            }

            return false;
        }

        public string print()
        {
            if (checkValue(Value) && checkSuit(Suit))
            {
                string s = Suit;
                s = s.Remove(1, s.Length - 1);
                s = s.ToUpper();
                s = String.Concat(s, Suit.Remove(0, 1));
                return Value + " of " + s;
            }
            else
            {
                return "0";
            }
        }


    }
}
