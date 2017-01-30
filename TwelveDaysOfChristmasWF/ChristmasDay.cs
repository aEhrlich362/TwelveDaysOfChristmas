using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Author: Aaron Ehrlich
 * Date: Jan 24 2017
 * Description: This class represents a day in the 12 days of Christmas. It holds the quantity of each gift on a day.

12 Drummers Drumming
 11 Pipers Piping
 10 Lords a Leaping
 9 Ladies Dancing
 8 Maids a Milking
 7 Swans a Swimming
 6 Geese a Laying
 5 Golden Rings
 4 Calling Birds
 3 French Hens
 2 Turtle Doves
 and a Partridge in a Pear Tree 
 */
namespace TwelveDaysOfChristmasWF
{
    
    class ChristmasDay
    {
        public int _DayID { get; set; }
        public int _Partridge { get; set; }
        public int _TurtleDoves { get; set; }
        public int _FrenchHens { get; set; }
        public int _CallingBirds { get; set; }
        public int _GoldenRings { get; set; }
        public int _Geese { get; set; }
        public int _Swans { get; set; }
        public int _Maids { get; set; }
        public int _Ladies { get; set; }
        public int _Lords { get; set; }
        public int _Pipers { get; set; }
        public int _Drummers { get; set; }

        //constructor
        public ChristmasDay() { }

        //overloaded constructor
        public ChristmasDay (int DayID, int Partridge, int TurtleDoves, int FrenchHens, int CallingBirds, 
        int GoldenRings, int Geese, int Swans, int Maids, int Ladies, int Lords,int Pipers, int Drummers)
        {
            _DayID = DayID;
            _Partridge = Partridge;
            _TurtleDoves = TurtleDoves;
            _FrenchHens = FrenchHens;
            _CallingBirds = CallingBirds;
            _GoldenRings = GoldenRings;
            _Geese = Geese;
            _Swans = Swans;
            _Maids = Maids;
            _Ladies = Ladies;
            _Lords = Lords;
            _Pipers = Pipers;
            _Drummers = Drummers;

        }
    }
   
}
