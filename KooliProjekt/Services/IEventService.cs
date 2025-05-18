using KooliProjekt.Data;
using KooliProjekt.Search;

namespace KooliProjekt.Services
{
    public interface IEventService
    {
        Task<PagedResult<Event>> List(int page, int pageSize, EventSearch search = null);
        Task<Event> Get(int id);
        Task Save(Event list);
        Task Delete(int id);

    }
}
