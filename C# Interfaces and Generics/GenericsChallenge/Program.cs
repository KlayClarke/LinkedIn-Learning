using System;
using System.Collections.Generic;

namespace GenChallengeSolution
{
    public class ClassicCar
    {
        public string m_Make;
        public string m_Model;
        public int m_Year;
        public int m_Value;

        public ClassicCar(string make, string model, int year, int val) {
            m_Make = make;
            m_Model = model;
            m_Year = year;
            m_Value = val;
        }
    }

    class Program
    {
        static void Main(string[] args) {
            List<ClassicCar> carList = new List<ClassicCar>();
            populateData(carList);

            // How many cars are in the collection?
            Console.WriteLine($"There are {carList.Count()} cars in the entire collection.");

            // How many Fords are there?
            carList.ForEach(TotalFords);
            Console.WriteLine($"There are {totalFs} Fords in the entire collection.");

            // What is the most valuable car?
            carList.ForEach(MostValuable);
            Console.WriteLine($"The most valuable car is a {mvc.m_Year} {mvc.m_Make} {mvc.m_Model} at {mvc.m_Value:C}");

            // What is the entire collection worth?
            carList.ForEach(TotalValue);
            Console.WriteLine($"The collection is worth {totalVal:C}");

            // How many unique manufacturers are there?
            carList.ForEach(TotalUnique);
            Console.WriteLine($"The collection contains {dic.Count()} unique manufacturers.");

            Console.WriteLine("\nHit Enter key to continue...");
            Console.ReadLine();
        }
        
        // delegate below to find number of fords in list
        static int totalFs = 0;
        static void TotalFords(ClassicCar c)
        {
            if (c.m_Make == "Ford")
            {
                totalFs++;
            }
        }
        
        // delegate below to facilitate search for most valuable car
        static int highestValue = 0;
        static ClassicCar mvc;
        static void MostValuable(ClassicCar c) 
        {
            if (c.m_Value > highestValue)
            {
                highestValue = c.m_Value;
                mvc = c;
            }
        }
        
        // delegate below to calculate total collection value
        static int totalVal = 0;
        static void TotalValue(ClassicCar c)
        {
            totalVal += c.m_Value;
        }
        
        // delegate below to calculate total unique manufacturers
        static int totalUnique = 0;
        static Dictionary<string, int> dic = new Dictionary<string, int>();
        static void TotalUnique(ClassicCar c) 
        {
            if (!dic.ContainsKey(c.m_Make))
            {
                dic.Add(c.m_Make, 0);
            }
        }
        
        // helper function to seed data
        static void populateData(List<ClassicCar> theList) {
            theList.Add(new ClassicCar("Alfa Romeo", "Spider Veloce", 1965, 15000));
            theList.Add(new ClassicCar("Alfa Romeo", "1750 Berlina", 1970, 20000));
            theList.Add(new ClassicCar("Alfa Romeo", "Giuletta", 1978, 45000));

            theList.Add(new ClassicCar("Ford", "Thunderbird", 1971, 35000));
            theList.Add(new ClassicCar("Ford", "Mustang", 1976, 29800));
            theList.Add(new ClassicCar("Ford", "Corsair", 1970, 17900));
            theList.Add(new ClassicCar("Ford", "LTD", 1969, 12000));

            theList.Add(new ClassicCar("Chevrolet", "Camaro", 1979, 7000));
            theList.Add(new ClassicCar("Chevrolet", "Corvette Stringray", 1966, 21000));
            theList.Add(new ClassicCar("Chevrolet", "Monte Carlo", 1984, 10000));

            theList.Add(new ClassicCar("Mercedes", "300SL Roadster", 1957, 19800));
            theList.Add(new ClassicCar("Mercedes", "SSKL", 1930, 14300));
            theList.Add(new ClassicCar("Mercedes", "130H", 1936, 18400));
            theList.Add(new ClassicCar("Mercedes", "250SL", 1968, 13200));
        }
    }
}