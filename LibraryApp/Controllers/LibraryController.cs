using Service.Helpers.Extentions;
using Service.Services;
using Service.Services.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Controllers
{
    public class LibraryController
    {
        private readonly ILibraryService _libraryService;
        public LibraryController()
        {
            _libraryService = new LibraryService();
        }
        public void Create()
        {
            Name: ConsoleColor.Cyan.WriteConsole("Add name: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                ConsoleColor.Red.WriteConsole("This field is required!");
                goto Name;
            }

            ConsoleColor.Cyan.WriteConsole("Add seat count: ");
            SeatCount: string countStr = Console.ReadLine();

            int seatCount;
            bool isCorrectCount=int.TryParse(countStr, out seatCount);
            if (isCorrectCount)
            {
                _libraryService.Create(new Library{ Name = name ,SeatCount=seatCount});
                ConsoleColor.Green.WriteConsole("Library create successed");

            }
            else
            {
                ConsoleColor.Red.WriteConsole("Seat count format is wrong,please try again:");
                goto SeatCount;
            }
        }

        public void GetAll()
        {
            var result=_libraryService.GetAll();
            foreach (var item in result)
            {
                string res = $"{item.Id}-{item.Name}-{item.SeatCount}";
                ConsoleColor.Cyan.WriteConsole(res);
            }
        }
    }
}
