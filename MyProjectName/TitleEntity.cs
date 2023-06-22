namespace MyProjectName
{
	internal class TitleEntity
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int ReleaseYear { get; set; }
		public string AgeCertification { get; set; }
		public int Runtime { get; set; }
		public List<string> Genres { get; set; }
		public string ProductionCountry { get; set; }
		public string Seasons { get; set; }
	}
}
