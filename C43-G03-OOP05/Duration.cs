using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP05
{
    internal class Duration
    {
      public   int Hours { get; set; }
        public  int Minutes { get; set; }
         public int Seconds { get; set; }

   

        public override bool Equals(object? obj)
        {
            if (obj is Duration other){
              return  this. Hours == other.Hours&&
                    this.Minutes == other.Minutes&&
                    this.Seconds == other.Seconds;  

            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);   
        }


        public Duration (int Hours, int Minutes, int Seconds)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Seconds = Seconds;

            norm();

        }
        public Duration (int totalsecends)
        {
            Hours = totalsecends/3600;
            Minutes = (totalsecends%3600)/60;
            Seconds = totalsecends%60;
            norm();
        }
        void norm()
        {
            if (Hours == 0&&Minutes==0 && Seconds <60)
            {

                Minutes = Seconds/60;
                Seconds = Seconds&60;

            }


        }
        public override string ToString()
        {
            string output = "";
            if (Hours > 0)
              return  output += $"hours:{Hours},mintes:{Minutes},sec:{Seconds}";
            else if (Minutes > 0)
              return  output += $"mintes:{Minutes},sec:{Seconds}";
            else 
              return  output += $"sec:{Seconds}";
        }


    }
}
