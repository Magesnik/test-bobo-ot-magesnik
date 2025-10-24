namespace PetShoop
{
    public class Animal
    {
        public int id;
        public string Names;
        public string Owner;
        public int Age;
        public string Type;
        public bool SickOrNot = false;
        public string Notes = "";

        public void MakeOlder()
        {
            Age += 3;
        }

        public void Heal()
        {
            SickOrNot = false;
            Notes = "feeling ok i guess";
        }
    }
}