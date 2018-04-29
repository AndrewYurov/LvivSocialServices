using System.Linq;

namespace LvivSocialServices.Models
{
    public interface IPersonRepository
    {
        IQueryable<Person> People { get; }
    }
}