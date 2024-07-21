namespace MeetingApp.Models
{
    public class MeetingInfo//toplantı bilgilerini barındıracak
    {
        public int Id { get; set; }

        public string? Location { get; set; }

        public DateTime Date { get; set; }

        public int NumberOfPeople { get; set; }

    }
}