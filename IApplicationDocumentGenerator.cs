using System;

namespace great.hip
{
	public interface IApplicationDocumentGenerator
	{
		byte[] Generate(Guid applicationId, string baseUri);
	}
}