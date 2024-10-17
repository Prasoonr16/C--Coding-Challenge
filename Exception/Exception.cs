namespace Exception
{

	[Serializable]
	public class PolicyNotFoundException : System.Exception
	{
		public PolicyNotFoundException() { }
		public PolicyNotFoundException(string message) : base(message) { }
		public PolicyNotFoundException(string message, System.Exception inner) : base(message, inner) { }
		protected PolicyNotFoundException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
