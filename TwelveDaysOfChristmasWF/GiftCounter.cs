using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Author: Aaron Ehrlich
 * Date: Jan 24 2017
 * Description: This class is used to calculate the number of each gift for any given day and can return the 
 * results in a string
 */

namespace TwelveDaysOfChristmasWF
{
    public class GiftCounter
    {
        //constructor
        public GiftCounter() { }

        /// <summary>
        /// CountGifts
        /// Counts the amount of each gift for any given day in the 12 days of christmas 
        /// </summary>
        /// <param name="i">i represents a specific day</param>
        /// <returns>string result, which is the text with the total number of each gift for the specified day</returns> 
        public string CountGifts(int i)
        {
            //twelve days of Christmas Stack
            Stack<ChristmasDay> DaysOfChristmas = new Stack<ChristmasDay>();
            //the selected day that will hold the sum of gifts
            ChristmasDay GivenDay = new ChristmasDay(i, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            //load the stack with each day leading up to the specified day value
            while(i>0) {
                switch (i)
                {
                    case 1: DaysOfChristmas.Push(new ChristmasDay(1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                        break;
                    case 2: DaysOfChristmas.Push(new ChristmasDay(2, 1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                        break;
                    case 3: DaysOfChristmas.Push(new ChristmasDay(3, 1, 2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                        break;
                    case 4: DaysOfChristmas.Push(new ChristmasDay(4, 1, 2, 3, 4, 0, 0, 0, 0, 0, 0, 0, 0));
                        break;
                    case 5: DaysOfChristmas.Push(new ChristmasDay(5, 1, 2, 3, 4, 5, 0, 0, 0, 0, 0, 0, 0));
                        break;
                    case 6: DaysOfChristmas.Push(new ChristmasDay(6, 1, 2, 3, 4, 5, 6, 0, 0, 0, 0, 0, 0));
                        break;
                    case 7: DaysOfChristmas.Push(new ChristmasDay(7, 1, 2, 3, 4, 5, 6, 7, 0, 0, 0, 0, 0));
                        break;
                    case 8: DaysOfChristmas.Push(new ChristmasDay(8, 1, 2, 3, 4, 5, 6, 7, 8, 0, 0, 0, 0));
                        break;
                    case 9: DaysOfChristmas.Push(new ChristmasDay(9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0));
                        break;
                    case 10: DaysOfChristmas.Push(new ChristmasDay(10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 0));
                        break;
                    case 11: DaysOfChristmas.Push(new ChristmasDay(11, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 0));
                        break;
                    case 12: DaysOfChristmas.Push(new ChristmasDay(12, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12));
                        break;
                    default:
                        break;
                }
                i--;
            }
            
            //unload the days of Christmas stack, summing the gifts for successive
            //days, loading the "given day" object
            while(DaysOfChristmas.Count()>0) 
            {
                ChristmasDay Receiver = DaysOfChristmas.Pop();
                GivenDay._Partridge += Receiver._Partridge;
                GivenDay._TurtleDoves += Receiver._TurtleDoves;
                GivenDay._FrenchHens += Receiver._FrenchHens;
                GivenDay._CallingBirds += Receiver._CallingBirds;
                GivenDay._GoldenRings += Receiver._GoldenRings;
                GivenDay._Geese += Receiver._Geese;
                GivenDay._Swans += Receiver._Swans;
                GivenDay._Maids += Receiver._Maids;
                GivenDay._Ladies += Receiver._Ladies;
                GivenDay._Lords += Receiver._Lords;
                GivenDay._Pipers += Receiver._Pipers;
                GivenDay._Drummers += Receiver._Drummers;
            }
             
            //build the result string to return, giving each day its own line
           return BuildResult(GivenDay);
        }
        
        /// <summary>
        /// BuildResult
        /// Places gift values of a Christmas day into a string that displays each gift as its own line.
        /// </summary>
        /// <param name="d">ChristmasDay object</param>
        /// <returns>string result with carriage returns to indicate each gift</returns>
        private string BuildResult(ChristmasDay d) 
       {
            int ID = 1;
            string result = "";
            while (ID <= d._DayID)
            {
                switch (ID)
                {
                    case 1:
                        result += d._Partridge.ToString() + " Partridges in a Pear Tree";
                        break;
                    case 2:
                        result += "\n" + d._TurtleDoves.ToString() + " TurtleDoves";
                        break;
                    case 3:
                        result += "\n" + d._FrenchHens.ToString() + " French Hens";
                        break;
                    case 4:
                        result += "\n" + d._CallingBirds.ToString() + " Calling Birds";
                        break;
                    case 5:
                        result += "\n" + d._GoldenRings.ToString() + " Gooooolden Riiiings!!";
                        break;
                    case 6:
                        result += "\n" + d._Geese.ToString() + " Geese a laying";
                        break;
                    case 7:
                        result += "\n" + d._Swans.ToString() + " Swans a swimming";
                        break;
                    case 8:
                        result += "\n" + d._Maids.ToString() + " Maids a milking";
                        break;
                    case 9:
                        result += "\n" + d._Ladies.ToString() + " Ladies dancing";
                        break;
                    case 10:
                        result += "\n" + d._Lords.ToString() + " Lords a leaping";
                        break;
                    case 11:
                        result += "\n" + d._Pipers.ToString() + " Pipers piping";
                        break;
                    case 12:
                        result += "\n" + d._Drummers.ToString() + " Drummers drumming";
                        break;
                    default:
                        break;
                }
                ID++;
            }
            if(ID==2) { result = result.Remove(11,1); } //make the partridge singular if it is only day 1 (take away the s)
            return result;
         }//end build result function
      }//end class
   }//end namespace    


