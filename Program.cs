using assignment3.Entitites;
using assignment3.Common;

Console.WriteLine("Calender App");


var meeting = new Meeting()
{
    Id = Guid.NewGuid(),
    Title = "YetGen Jump & Akbank Backend Planning Meeting ",
    Details = new List<string>()
    {
    "Anonymization of evaluation results and creation of graphics",
    "The mail from Akbank will be discussed",
    "The budget planning will be discussed"
    },
    StartTime = new DateTime(2023, 09, 25, 19, 00, 00),
    FinishTime = new DateTime(2023, 09, 25, 21, 00, 00),
    Guests = new List<string> { "hakan@outlook.com", "zeynep@outlook.com", "deniz@outlook.com" }

};

meeting.GetNotification();


var todo = new ToDo()
{
    Id = Guid.NewGuid(),
    Title = "Deliver Participants Feedback ",
    Details = new List<string>()
    {
        "Anonymization of evaluation results and creation of graphics, " +
        "The mail from Akbank will be discussed, " +
        "The budget planning will be discussed  "
    },
    StartTime = new DateTime(2023, 09, 25, 20, 00, 00),
    FinishTime = new DateTime(2023, 09, 25, 21, 00, 00),
    Importance = " High Priority ",
};

todo.GetNotification();



