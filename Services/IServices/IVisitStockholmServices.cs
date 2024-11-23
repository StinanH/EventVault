
using EventVault.Models.DTOs;
using EventVault.Models.ViewModels;

namespace EventVault.Services.IServices
{
    public interface IVisitStockholmServices
    {
        Task<IEnumerable<EventViewModel>> GetResponse(string url);

        Task<IEnumerable<EventViewModel>> GetPaginatedEventsSortedByDate(int page);
    }
}
