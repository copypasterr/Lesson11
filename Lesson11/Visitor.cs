namespace Lesson11
{
    public class Visitor
    {
        public Visitor() { }

        public int ID { get; set; }

        public string Fullname { get; set; }

        public int Age { get; set; }

        public string PhoneNumber { get; set; }

        public string Adress { get; set; }

        public Visitor (int id, string fullname, int age, string phoneNumber, string adress) 
        {
            ID = id;
            Fullname = fullname;
            Age = age;
            PhoneNumber = phoneNumber;
            Adress = adress;
        }
    }
}
