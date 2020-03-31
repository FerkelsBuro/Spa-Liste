using Domain.Models;
using System.Collections.Generic;

namespace Infrastructure.Repositories
{
    public interface IEntryRepository
    {
        IEnumerable<Entry> List();

        void Update(Entry entry);

        void Add(Entry entry);

        void Delete(Entry entry);

        void SaveChanges();
    }
}