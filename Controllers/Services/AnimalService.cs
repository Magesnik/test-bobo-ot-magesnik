using System;
using PetShoop;

namespace AnimalServices
{
    public class AnimalService
    {
        private DbThingy _db;
        public AnimalService(DbThingy d) { _db = d; }

        public void DoHeal(int id)
        {
            var x = _db.Animal.Find(id);
            if (x != null)
            {
                x.Heal();
                Console.WriteLine("Healed animal id=" + id);
            }
        }

        public void AddNewAnimal(string name, string owner, int age, string type)
        {
            var newAnimal = new Animal();
            newAnimal.id = new Random().Next(1000, 9999);
            newAnimal.Names = name;
            newAnimal.Owner = owner;
            newAnimal.Age = age;
            newAnimal.Type = type;
            newAnimal.SickOrNot = false;
            _db.Animal.Add(newAnimal);
        }

        public void RandomAgeUp()
        {
            foreach (var x in _db.Animal.ToList())
            {
                x.Age += 7;
            }
        }
    }
}
