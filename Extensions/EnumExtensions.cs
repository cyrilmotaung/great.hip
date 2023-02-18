using Nml.Improve.Me.Enums;

namespace great.hip.Domain.Extensions
{
	public static class EnumExtensions
	{
		public static string ToDescription(this ApplicationState state)
		{
			return state.ToString();
		}
	}
}