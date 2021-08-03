using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;
            
            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Error says Can not return a null",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Im trying to create an integer function in my program .But everytime i cal the function it pops an error .",
                   Topic = "Functions",
                    Module = "PPA",
                   Campus = "Soshanguve",
                },
                new Activity
                {
                     Title = "Error says an Edit Button does not have caption attribute",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Im trying to  run my program but its saying have not followed proper naming of variable but everything seems fine",
                   Topic = "Strings Manipulation",
                    Module = "TPG201",
                   Campus = "Soshanguve",
                },
                new Activity
                {
                    Title = "Error says wrong constructor name",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "My c++ code is failing to run ,everytime i include constructors in my classes",
                   Topic = "Classes",
                    Module = "TPG111",
                   Campus = "Soshanguve",
                },
                new Activity
                {
                   Title = "Error says Java does not contain IsEqual() function",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Im trying to compare my strings but my program is saying java program does not contain IsEqual built in functio",
                   Topic = "Strings ",
                    Module = "TPG12AT",
                   Campus = "Soshanguve",
                },
                new Activity
                {
                   Title = "Error says You array is out of bounds",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Im trying to display my data stored in an array of size 5 using a loop , But getting an error of out of bounds Check my code snippet below ",
                   Topic = "Arrays",
                    Module = "DS017BT",
                   Campus = "Soshanguve",
                },
                new Activity
                {
                   Title = "Error says the number of parameters in the functions does not equal the ones in the arguments",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Im trying to call my function in the main funtion but giving me an error check my code snippet below ",
                   Topic = "Functions",
                    Module = "PPA",
                   Campus = "Soshanguve",
                },

                  new Activity
                {
                   Title = "Error says can not access any file in C:Users;user;Desktop;GeniusDocument  with the name Artificial Intelligence",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Im trying to access and display coontent in a file saved on my document but getting error saying no file data  acced",
                   Topic = "Files",
                    Module = "TPG111",
                   Campus = "Soshanguve",
                },
               
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}