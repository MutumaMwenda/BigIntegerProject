using System;

namespace Excercise01
{
    public static class Excercise
    {
        static string[] cvttext;
        static string cvt100;


        public static string Towards(int Amount)
        {
            int TempAmt;
            double Remainder;
            double DecimalPart = 0;
            string Joiner = "";
            string DeciStr = "";
            int PosDot;
            string AmtPassed = "";
            string GetWord = "";
            CvtInit();
            PosDot = -1;
            AmtPassed = Amount.ToString();
            AmtPassed = AmtPassed.Replace(",", ".");
            GetWord = "";
            Remainder = 0.0;
            if (Amount > 999999999)
            {
                TempAmt = Amount / 1000000000;
                GetWord = Cvt100_(TempAmt) + cvttext[30] + " ";
                Amount = Amount - (TempAmt * 1000000000);
            }
            if (Amount > 999999)
            {
                TempAmt = Amount / 1000000;
                GetWord = GetWord + Cvt100_(TempAmt) + cvttext[29] + " ";
                Amount = Amount - (TempAmt * 1000000);
            }
            if (Amount > 999)
            {
                TempAmt = Amount / 1000;
                Remainder = Amount % 1000;

                if (Remainder < 100)
                    Joiner = " and ";
                else if (Remainder == 0)
                    Joiner = "";
                else
                    Joiner = ", ";

                GetWord = GetWord + Cvt100_(TempAmt) + cvttext[28];
                Amount = Amount - (TempAmt * 1000);
            }
            if (Amount > 0)
                GetWord = GetWord + Joiner + Cvt100_(Amount);

            GetWord = GetWord;

            return GetWord;
        }

        private static void CvtInit()
        {
            cvttext = new string[] {"one", "two", "three", "four", "five", "six",
                "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen",
                "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen","twenty",
                "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety","hundred","thousand","million","billion"
            };
        }

        private static string Cvt100_(int SubAmount)
        {
            CvtInit();
            int TempAmount;
            double Remainder00;
            string Joiner = "";
            cvt100 = "";
            Remainder00 = 0.0;
            if (SubAmount > 999)
            {
                cvt100 = "Error 100";
                return cvt100;
            }
            if (SubAmount > 99)
            {
                TempAmount = SubAmount / 100;
                Remainder00 = SubAmount % 100;
                cvt100 = cvttext[TempAmount-1] + " " + cvttext[27] + " ";
                SubAmount = SubAmount - (TempAmount * 100);

                if (Remainder00 < 100)
                    Joiner = "and ";
                else if (Remainder00 == 0)
                    Joiner = "";
                else
                    Joiner = "and ";
            }
            if (SubAmount > 20)
            {
                TempAmount = SubAmount / 10;
                Remainder00 = SubAmount % 10;
                cvt100 = cvt100 + Joiner + cvttext[TempAmount + 18-1] + " ";
                Joiner = "";
                SubAmount = SubAmount - (TempAmount * 10);
            }
            if (SubAmount > 0)
                cvt100 = cvt100 + Joiner + cvttext[SubAmount-1] + " ";

            return cvt100;
        }

    }
}
