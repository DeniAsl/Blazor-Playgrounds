using Pin.OpenData.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.OpenData.Core.Services.Interfaces
{
    interface IJsonPlaygroundService
    {
        Task<List<Playground>> GetAllAsync();
    }
}
