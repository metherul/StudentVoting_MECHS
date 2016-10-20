namespace StudentVoting_MECHS
{
    internal class Candidate
    {
        public string Name { get; set; }
        public string ID { get; set; }
        private int VoteCount { get; set; }

        public Candidate(string _name, string _ID)
        {
            Name = _name;
            ID = _ID;
            VoteCount = 0;
        }

        public int IncrementVote()
        {
            VoteCount++;

            return VoteCount;
        }

        public int ReturnVoteCount()
        {
            return VoteCount;
        }

        public string[] ReturnAll()
        {
            string[] list = new string[3];
            list[0] = Name;
            list[1] = ID;
            list[2] = VoteCount.ToString();

            return list;
        }
    }
}