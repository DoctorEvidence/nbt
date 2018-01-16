namespace Nbt.ServiceModel.Types
{
	using System.Runtime.Serialization;

	[DataContract]
	public class CustomerDemographic
	{
		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public string CustomerDesc { get; set; }
	}
}