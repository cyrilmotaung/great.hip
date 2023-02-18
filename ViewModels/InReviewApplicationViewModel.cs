using Nml.Improve.Me.Entities;

namespace Nml.Improve.Me.ViewModels
{
	public class InReviewApplicationViewModel
		: ApplicationViewModel
	{
		public string InReviewMessage { get; set; }
		public Review InReviewInformation { get; set; }
	}
}