using System;
using assignment3.Abstract;
using assignment3.Common;

namespace assignment3.Entitites
{
	public class Meeting : Events, INotification
    {
     
        public List<string> Guests { get; set; }

        public void GetNotification()
        {
            foreach (var guest in Guests)
            {
                Console.WriteLine($" Inviting : {guest}");
            }
        }
    }
}

