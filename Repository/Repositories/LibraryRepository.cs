using Domain.Models;
using Repository.Data;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class LibraryRepository : BaseRepository<Library>, ILibraryRepository
    {
        public List<Library> GetLibrariesByName(string name)
        {
           return AppDbContext<Library>.Datas.Where(m=>m.Name == name).ToList();
        }
    }
}
