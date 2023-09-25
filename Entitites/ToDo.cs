using System;
using assignment3.Abstract;
using assignment3.Common;

namespace assignment3.Entitites
{
	public class ToDo : Events, INotification
    {

        public string Importance { get; set; }

        public void GetNotification()
        {
            Console.WriteLine($" Time to make this To-Do: {Title}");
        }
    }
}

