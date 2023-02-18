namespace Nml.Improve.Me.Interfaces
{
	public interface IViewGenerator
	{
		string GenerateFromPath(string url, object viewModel);
	}
}