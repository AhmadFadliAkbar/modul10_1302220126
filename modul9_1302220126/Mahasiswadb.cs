using Microsoft.EntityFrameworkCore;
using Model.mahasiswa;

namespace modul9_1302220126
{
    public class Mahasiswadb : DbContext
    {
        public Mahasiswadb(DbContextOptions<Mahasiswadb> options) 
        : base(options) { }
        public DbSet<Mahasiswa> mhs => Set<Mahasiswa>();
    }
}
