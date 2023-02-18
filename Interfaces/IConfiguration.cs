namespace Nml.Improve.Me.Interfaces
{
	public interface IConfiguration
	{
		string SupportEmail { get; set; }
		string Signature { get; set; }
		float TaxRate { get; set; }
	}
}