using employees.Entities.Enums;
using System;
using System.Collections.Generic;

namespace employees.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public Double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HoursContract> Contracts { get; set; } = new List<HoursContract>();
        public Worker(){

        }
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }
        public void AddContract(HoursContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HoursContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HoursContract contract in Contracts)
            {
                if(contract.Data.Year == year && contract.Data.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }



    }
}
