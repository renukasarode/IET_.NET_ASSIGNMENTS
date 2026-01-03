namespace _31_demo_BvsAttribute
{
	[AttributeUsage(AttributeTargets.Class)]
    public class BoventureSystemsAttribute:Attribute
    {
		private string _companyName;
		private string _developerName;

		public string DeveloperName
		{
			get { return _developerName; }
			set { _developerName = value; }
		}


		public string CompanyName
		{
			get { return _companyName; }
			set { _companyName = value; }
		}


	}
}
