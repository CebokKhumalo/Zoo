using System.Threading.Tasks;
using Abp.Application.Services;
using Zoo.Authorization.Accounts.Dto;

namespace Zoo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
