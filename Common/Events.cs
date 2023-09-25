using System;
namespace assignment3.Common
{
	public class Events
	{
        public Guid Id { get; set; }

        public string Title { get; set; }

        public List<string> Details { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime FinishTime { get; set; }

        public Events()
        {
            Id = Guid.NewGuid();
        }
    }
}

