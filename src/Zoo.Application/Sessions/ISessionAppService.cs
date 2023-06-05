using System.Threading.Tasks;
using Abp.Application.Services;
using Zoo.Sessions.Dto;

namespace Zoo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
