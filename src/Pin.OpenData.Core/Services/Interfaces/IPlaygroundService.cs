using Pin.OpenData.Core.Entities;

namespace Pin.OpenData.Core.Services.Interfaces
{
    public interface IPlaygroundService
    {
        public Task<List<Playground>> GetAllAsync();
        public Task<Playground> GetByIdAsync(int id);
        public Task AddAsync(Playground playground);
        public Task EditAsync(Playground playground);
        public Task DeleteAsync(int id);
        //public Task<IList<Playground>> SearchAsync(string name);
    }
}
