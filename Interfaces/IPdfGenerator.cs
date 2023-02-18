using Nml.Improve.Me.DocumentOptions;
using Nml.Improve.Me.Entities;

namespace great.hip.Domain.Interfaces
{
	public interface IPdfGenerator
	{
		PdfDocument GenerateFromHtml(string view, PdfOptions pdfOptions);
	}
}