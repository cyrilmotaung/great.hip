using Nml.Improve.Me.Entities;
using System.Linq;

namespace great.hip.Domain.Interfaces
{
	public interface IDataContext
	{
		IQueryable<Application> Applications { get; set; }
	}
}