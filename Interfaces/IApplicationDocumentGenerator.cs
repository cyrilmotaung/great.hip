using System;

namespace Nml.Improve.Me.Interfaces
{
	public interface IApplicationDocumentGenerator
	{
		byte[] Generate(Guid applicationId, string baseUri);
	}
}