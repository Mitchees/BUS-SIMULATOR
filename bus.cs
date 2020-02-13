using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussimulator
{
    class bus
    {
        private int passengerCount { get; set; }        //number of passengers on board
        private int busStops { get; set; }              //number of bus stops
        private int pastBusStops { get; set; }          //number of past bus stops
        private int remBusStops { get; set; }           //number of remaining bus stops

        /// <summary>
        /// This is the number of passengers on board
        /// </summary>
        /// <returns></returns>
        public int getPassengerCount()
        {
            //this.passengerCount = 0;
            return this.passengerCount;
        }

        public int getbusStops()
        {
            Random random = new Random();
            this.busStops = random.Next(20, 41);
            return this.busStops;
        }

    }
}
