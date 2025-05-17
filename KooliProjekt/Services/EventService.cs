using KooliProjekt.Data;
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

        public async Task<PagedResult<Event>> List(int page, int pageSize)
        {
            return await _context.Events.GetPagedAsync(page, pageSize);
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
