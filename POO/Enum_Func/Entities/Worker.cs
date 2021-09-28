using System;
using System.Collections.Generic;
using Enum_Func.Entities.Enums;

namespace Enum_Func.Entities
{
    public class Worker
    {
        public string Name {get; set;}
        public WorkerLevel Level { get; set;}
        public double BaseSalary {get; set;}
        public Department Department {get; set;} //associação entre duas classes diferentes
        public List<HourContract> Contracts { get; set; } = new  List<HourContract>(); // Composição com uma lista de possíveis contratos

        public Worker(){

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department){ // não é usual passa listas pelo construtor, a medida que precisamos, vamos adicionando os elementos.
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract){
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract){
            Contracts.Remove(contract);
        }

        public double Income(int year, int month){
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts){
                if(contract.Date.Year == year && contract.Date.Month == month){
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}