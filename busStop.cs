using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussimulator
{
    class busStop
    {
        private int humans { get; set; }         //number of humans at the busStop

        /// <summary>
        /// This is my constructor
        /// </summary>
        /// <param name="humans"></param>
/*        public busStop(int humans)
        {
            this.humans = humans;
        }
*/
        public int getHumans()
        {
            Random random = new Random();       //declare an instance of the random class
            //this.humans = random.Next(13);      //0 - 12 humans at the bus stop.

            return random.Next(13);
        }
    }
}
