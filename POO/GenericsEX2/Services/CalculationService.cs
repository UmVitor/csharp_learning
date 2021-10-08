using System;
using System.Collections.Generic;
namespace GenericsEX2.Services
{
    public class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable{ // Declaração de método genérico, porém com ( where T : IComparable), ou seja eu so irei poder declarar listas que sejam comparaveis
            if(list.Count == 0){ // lista vazia
                throw new ArgumentException("The list can not be empty");
            }
            T max = list[0];
            for(int i=1; i<list.Count; i++){
                if(list[i].CompareTo(max) > 0){
                    max = list[i];
                }
            }
            return max;
        }
    }
}