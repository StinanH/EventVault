using EventVault.Models.DTOs;
using EventVault.Models.ViewModels;

namespace EventVault.Services.IServices
{
    public interface IKBEventServices
    {
        Task<List<EventViewModel>> GetEventDataAsync();

        Task<IEnumerable<KBEventListViewModel>> GetListOfEventsAsync();

        Task<IEnumerable<EventViewModel>> GetPaginatedEventsSortedByDate(int page);
    }
}
