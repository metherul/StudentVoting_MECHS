namespace StudentVoting_MECHS
{
    internal class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public bool Voted { get; set; }

        public Student(string _name, string _ID, bool _voted)
        {
            Name = _name;
            ID = _ID;
            Voted = _voted;
        }

        public void HasVoted()
        {
            Voted = true;
        }

        public string[] ReturnAll()
        {
            string[] list = new string[3];
            list[0] = Name;
            list[1] = ID;
            list[2] = Voted.ToString();

            return list;
        }
    }
}