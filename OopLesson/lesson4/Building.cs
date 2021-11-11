using System;
using System.Collections.Generic;
using System.Text;

namespace OopLesson.lesson4
{
    class Building
    {
        private int Id { get; set; }
        private int Height { get; set; }
        private int StoreysNumber { get; set; }
        private int ApartmentsNumber { get
            {
                return ApartmentsNumber;
            }
            set
            {
                if (value % EntrancesNumber == 0)
                {
                    ApartmentsNumber = value;
                }
                else
                {
                    throw new Exception("With given entrances number, apartments number makes storeys uneven.");
                }
            }
        }
        private int EntrancesNumber { get; set; }


        private static int LastId = 0;

        public Building(int height, int apartmentsNumber, int entrancesNumber)
        {
            LastId++;
            Id = LastId;
            Height = height;
            EntrancesNumber = entrancesNumber;
            ApartmentsNumber = apartmentsNumber;
            StoreysNumber = StoreysCount();
        }

        private int StoreysCount()
        {
            return ApartmentsNumber / EntrancesNumber;
        }
    }
}
