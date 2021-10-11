using System;
namespace HashSetAndHashSortEx4.Entities
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Person(){}
        public Person (string name, DateTime date) : this(){
            Name = name;
            Date = date;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if(!(obj is Person)){
                return false;
            }
            Person other = obj as Person;
            return Name.Equals(other.Name);
        }
    }
}