using Pin.OpenData.Core.Entities;
using Pin.OpenData.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pin.OpenData.Core.Services
{
    public class JsonPlaygroundService : IJsonPlaygroundService
    {
        private readonly string targetFile = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "Pin.OpenData.Core", "Data", "playgrounds.json"));


        public async Task<List<Playground>> GetAllAsync()
        {
            string savedSerialized = await File.ReadAllTextAsync(targetFile);
            List<Playground> savedPlaygrounds = JsonSerializer.Deserialize<List<Playground>>(savedSerialized);
            return savedPlaygrounds.ToList();
        }
        //public async Task<Playground> GetById(int id)
        //{
        //    List<Playground> movies = (await GetAll()).ToList();
        //    Playground existingMovie = movies.FirstOrDefault(search =>
        //    {
        //        return search.Id == id;
        //    });
        //    return existingMovie;
        //}
        //public async Task<Playground> Add(Playground playground)
        //{
        //    List<Playground> playgrounds = (await GetAll()).ToList();
        //    if (playgrounds.Count > 0)
        //    {
        //        if (playgrounds.Any(existingPlayground => existingPlayground?.Id == playground?.Id))
        //        {
        //            throw new ArgumentException("The movie you're trying to update already exists.");
        //        }
        //        else
        //        {
        //            playgrounds.Add(playground);
        //        }
        //    }
        //    await WritePlaygrounds(playgrounds);
        //    return playground;
        //}
        //public async Task<Playground> Update(Playground playground)
        //{
        //    List<Playground> playgrounds = (await GetAll()).ToList();
        //    Playground existingPlayground = playgrounds.FirstOrDefault(search =>
        //    {
        //        return search.Id == playground.Id;
        //    });
        //    if (existingPlayground != null)
        //    {
        //        playgrounds.Remove(existingPlayground);
        //        playgrounds.Add(playground);
        //    }
        //    else
        //    {
        //        throw new ArgumentException("The movie you're trying to update does not have a correct id.");
        //    }
        //    await WritePlaygrounds(playgrounds);
        //    return playground;
        //}
        //private void EnsureFileExists(string targetFile)
        //{
        //    if (!File.Exists(targetFile))
        //    {
        //        File.WriteAllText(targetFile, JsonSerializer.Serialize(new List<Playground>()));
        //    }
        //}
        //private async Task WritePlaygrounds(List<Playground> playgrounds)
        //{
        //    string serializedPlaygrounds = JsonSerializer.Serialize(playgrounds);
        //    await File.WriteAllTextAsync(targetFile, serializedPlaygrounds);
        //}
        //public async Task<Movie> ChooseRandom()
        //{
        //    var students = (await GetAll())
        //    .Where(student => student.IsPresent)
        //    .ToList();
        //    if (students.Count == 0) return null;
        //    Random random = new Random();
        //    int randomIndex = random.Next(0, students.Count);
        //    Student chosenStudent = students[randomIndex];
        //    chosenStudent.TimesChosen++;
        //    await Update(chosenStudent);
        //    return chosenStudent;
        //}
    }
}
