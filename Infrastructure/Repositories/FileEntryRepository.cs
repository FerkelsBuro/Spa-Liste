using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Newtonsoft.Json;

namespace Infrastructure.Repositories
{
    public class FileEntryRepository : IEntryRepository
    {
        private readonly string _file = "file.txt";
        private List<Entry> _entries;

        public FileEntryRepository()
        {
            string content = "";

            if (File.Exists(_file))
            {
                content = File.ReadAllText(_file);
            }

            try
            {
                _entries = JsonConvert.DeserializeObject<List<Entry>>(content) ?? new List<Entry>();
            } catch
            {
                _entries = new List<Entry>();
            }
        }

        public void Add(Entry entry)
        {
            entry.Id = _entries.Select(e => e.Id).DefaultIfEmpty(0).Max() + 1;
            _entries.Add(entry);

            SaveChanges();
        }

        public void Delete(Entry entry)
        {
            _entries = _entries.Where(e => e.Id != entry.Id).ToList();
            SaveChanges();
        }

        public IEnumerable<Entry> List()
        {
            return _entries;
        }

        public void SaveChanges()
        {
            var content = JsonConvert.SerializeObject(_entries);

            File.WriteAllText(_file, content);
        }

        public void Update(Entry entry)
        {
            var entryInContext = _entries.SingleOrDefault(e => e.Id == entry.Id);

            entryInContext.Value = entry.Value;
        }
    }
}
