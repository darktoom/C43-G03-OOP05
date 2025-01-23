using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP05
{
    internal class _3D_Point /*: ICloneable, IComparable*/
    {
      public  int x {  get; set; }
     public   int y { get; set; }
     public   int z { get; set; }

  public _3D_Point (int x,int y,int z)
        {

            this.x = x;
            this.y = y;
            this.z = z;

        }

        public _3D_Point ():this (0,0,0) { }




      
        public override string ToString()
        {
            return $"“Point Coordinates:({x}),({y}),({z})";
        }

        //public object Clone()
        //{
        //    throw new NotImplementedException();
        //}

        //public int CompareTo(object? obj)
        //{
        //    throw new NotImplementedException();
        //}

        public static bool operator == (_3D_Point p1, _3D_Point p2)
        {
            if (p1.x == p2.x && p1.y==p2.y && p1.z == p2.z) return true ;
            else return false ;


        }
        public static bool operator !=(_3D_Point p1, _3D_Point p2) { 
        if (p1.x!=p2.y || p1.y!=p2.y || p1.z!=p2.z)
                return true ;
        else return false;
        
        
        } 
        

    }
}
