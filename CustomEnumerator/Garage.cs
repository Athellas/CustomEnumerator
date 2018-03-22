﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Garage : IEnumerable
    {

        private Car[] carArray = new Car[4];

        public Garage()
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // return the array object's IEnumerator
            return carArray.GetEnumerator();
        }
    }
}
