using css2.Application.Common.Interfaces;

namespace css2.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
