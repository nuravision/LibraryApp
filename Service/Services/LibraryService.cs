using Domain.Models;
using Repository.Repositories;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly ILibraryRepository _libraryRepo;
        public LibraryService()
        {
            _libraryRepo=new LibraryRepository();
        }
        public void Create(Library library)
        {
            _libraryRepo.Create(library);
        }

        public void Delete(Library library)
        {
            _libraryRepo.Delete(library);
        }

        public List<Library> GetAll()
        {
            return _libraryRepo.GetAll();
        }

        public List<Library> GetAllByName(string name)
        {
            return _libraryRepo.GetLibrariesByName(name);
        }

        public Library GetById(int id)
        {
           return _libraryRepo.GetById(id);
        }
    }
}
