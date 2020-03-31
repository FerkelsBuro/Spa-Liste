using Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class EntryRepository : IEntryRepository
    {
        private List<Entry> entries = new List<Entry>();

        public void Add(Entry entry)
        {
            entries.Add(entry);
        }

        public void Delete(Entry entry)
        {
            var entryInDb = entries.FirstOrDefault(e => e.Id == entry.Id);

            if (entryInDb != null)
            {
                entries.Remove(entryInDb);
            }
        }

        public IEnumerable<Entry> List()
        {
            return entries;
        }

        public void SaveChanges()
        {
        }

        public void Update(Entry entry)
        {
        }
    }
}