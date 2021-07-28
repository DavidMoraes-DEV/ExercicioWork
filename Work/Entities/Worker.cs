using System;
using Work.Entities;
using Work.Entities.Enum;

namespace Work.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Worker (string name, WorkerLevel level, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }

        public void AddContract (HourContract contract)
        {
            contract.totalValue
        }

        public void RemoveContract (HourContract contract)
        {

        }

        public double Income (int year, int month)
        {
            return 0;
        }
    }
}
