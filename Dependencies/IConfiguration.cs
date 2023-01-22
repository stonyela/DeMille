namespace Nml.Improve.Me.Dependencies
{
	public interface IConfiguration
	{
		string SupportEmail { get; set; }
		string Signature { get; set; }
		double TaxRate { get; set; }
	}
}