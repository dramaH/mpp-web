using System;
using ARchGLCloud.Domain.MPP.Models;
using ARchGLCloud.Domain.Core.Repositories;

namespace ARchGLCloud.Domain.MPP.Interfaces
{
    public interface ICalendarRepository : IAddRepository<Calendar, Guid>, IUpdateRepository<Calendar, Guid>, IDeleteRepository<Calendar, Guid>
    {
    }
}
