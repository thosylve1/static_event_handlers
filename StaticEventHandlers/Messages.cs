using System;

namespace StaticEventHandlers
{
    public class Prepare
    {
        public Prepare(int ballot) => throw new NotImplementedException();
    }
    public class Learn
    {
        public Learn(int ballot, string proposal) => throw new NotImplementedException();
    }

    public class Promise
    {
        public int Ballot { get; set; }
    }
    public class Learned
    {
        public int Ballot { get; set; }
        public string Value { get; set; }
    }

    public class Nack
    {
        public int Ballot { get; set; }
    }

}
