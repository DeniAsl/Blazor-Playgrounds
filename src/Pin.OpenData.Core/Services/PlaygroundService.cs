using Pin.OpenData.Core.Entities;
using Pin.OpenData.Core.Services.Interfaces;
using System.Diagnostics;

namespace Pin.OpenData.Core.Services
{
    public class PlaygroundService : IPlaygroundService
    {
        private List<Playground> _playgrounds = new();

        private async Task WritePlaygrounds()
        {
            JsonPlaygroundService jsonPlaygroundService = new();
            _playgrounds = await jsonPlaygroundService.GetAllAsync();
        }

        public async Task<List<Playground>> GetAllAsync()
        {
            if (_playgrounds.Count() == 0)
            {
                await WritePlaygrounds();
            }
            return await Task.FromResult(_playgrounds);
        }

        public Task AddAsync(Playground playground)
        {
            _playgrounds.Add(playground);

            return Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            var playground = await GetByIdAsync(id);
            _playgrounds.Remove(playground);
        }

        public async Task EditAsync(Playground playground)
        {
            var playgroundToEdit = await GetByIdAsync(playground.Id);
            playgroundToEdit.Title = playground.Title;
            playgroundToEdit.LocalDescription = playground.LocalDescription;
            playgroundToEdit.Description = playground.Description;
            playgroundToEdit.Longitude = playground.Longitude;
            playgroundToEdit.Latitude = playground.Latitude;
            playgroundToEdit.Themes = playground.Themes;
        }

        public async Task<Playground> GetByIdAsync(int id)
        {
            var playground = _playgrounds.FirstOrDefault(p => p.Id == id);
            return await Task.FromResult(playground);
        }

        //public async Task<IList<Playground>> SearchAsync(string title)
        //{
        //    var playgrounds = _playgrounds.Where(t => t.Title.Contains(title)).ToList();
        //    return await Task.FromResult(playgrounds);
        //}
    }
}
