using System;

namespace Domain
{
    public class Activity
    {
        //biore z systemu;
        //generowane od serwera albo od klienta, oba zadzialaja
        //plusy: nie trzeba czekac na database jesli u klienta

        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    
    }
}