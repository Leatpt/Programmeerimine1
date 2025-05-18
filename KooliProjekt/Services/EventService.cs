using KooliProjekt.Data;
using KooliProjekt.Search;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Services
{
    public class EventService : IEventService
    {
        private readonly ApplicationDbContext _context;

        public EventService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResult<Event>> List(int page, int pageSize, EventSearch search = null)
        {
            var query = _context.Events.AsQueryable();

            //Otsingu asjad
            if (search != null)
            {
                if(!string.IsNullOrWhiteSpace(search.Keyword))
                {
                    search.Keyword = search.Keyword.Trim(); //Trim method removes white space from the start and end of string

                    query = query.Where(eventItem => 
                                    eventItem.Name.Contains(search.Keyword) ||
                                    eventItem.AttachedFiles.Any(attachedFile => attachedFile.FileName.Contains(search.Keyword))
                    );
                }

                if(search.IsPaidEvent != null)
                {    
                    query = query.Where(eventItem => eventItem.IsPaidEvent == search.IsPaidEvent.Value);              
                }
            }

            return await query
                .OrderBy(eventItem => eventItem.Date)
                .GetPagedAsync(page, pageSize);
        }

        public async Task<Event?> Get(int id)
        {
            return await _context.Events
                .Include(eventItem => eventItem.AttachedFiles)
                .Where(eventItem => eventItem.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task Save(Event eventItem)
        {
            if (eventItem.Id == 0)
            {
                _context.Events.Add(eventItem);
            }
            else
            {
                _context.Events.Update(eventItem);
            }

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            await _context.Events
                .Where(eventItem => eventItem.Id == id)
                .ExecuteDeleteAsync();

            // DELETE FROM Events WHERE Id = Event.Id
        }
    }
}
