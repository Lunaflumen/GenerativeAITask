using Bogus;

namespace MyProjectName
{
	internal class TitleFaker : Faker<TitleEntity>
	{
		public TitleFaker()
		{
			RuleFor(t => t.Id, f => f.UniqueIndex);
			RuleFor(t => t.Title, f => f.Lorem.Word());
			RuleFor(t => t.Description, f => f.Lorem.Sentence());
			RuleFor(t => t.ReleaseYear, f => f.Date.Past(50).Year);
			RuleFor(t => t.AgeCertification, f => f.PickRandom(new List<string> { "G", "PG", "PG-13", "R", "NC-17", "U", "U/A", "A", "S", "AL", "6", "9", "12", "12A", "15", "18", "18R", "R18", "R21", "M", "MA15+", "R16", "R18+", "X18", "T", "E", "E10+", "EC", "C", "CA", "GP", "M/PG", "TV-Y", "TV-Y7", "TV-G", "TV-PG", "TV-14", "TV-MAG", "PG", "PG - 13", "R", "NC - 17", "U", "U / A", "A", "S", "AL", "6", "9", "12", "12A", "15", "18", "18R", "R18", "R21", "M", "MA15 +", "R16", "R18 +", "X18", "T", "E", "E10 +", "EC", "C", "CA", "GP", "M / PG", "TV - Y", "TV - Y7", "TV - G", "TV - PG", "TV - 14", "TV - MA" }));
			RuleFor(t => t.Runtime, f => f.Random.Int(0, 240));
			RuleFor(t => t.Genres, f => new List<string> { f.Random.Word(), f.Random.Word(), f.Random.Word() });
			RuleFor(t => t.ProductionCountry, f => f.Address.CountryCode());
			RuleFor(t => t.Seasons, f => f.Random.Int(0, 10).ToString());
		}
	}
}
