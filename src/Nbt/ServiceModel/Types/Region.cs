namespace Nbt.ServiceModel.Types
{
	using System.Runtime.Serialization;

	[DataContract]
	public class Region
	{
		[DataMember]
		public int Id { get; set; }

		[DataMember]
		public string RegionDescription { get; set; }
	}
}