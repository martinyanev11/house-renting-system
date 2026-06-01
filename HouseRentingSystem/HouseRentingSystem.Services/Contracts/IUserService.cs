namespace HouseRentingSystem.Services.Contracts
{
    public interface IUserService
    {
        Task<bool> IsAgentAsync(Guid id);
    }
}
