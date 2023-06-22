using System.ComponentModel.Design;
using System.IO;

using Bogus;
using Bogus.DataSets;

namespace MyProjectName
{
	internal class CreditFaker : Faker<CreditEntity>
	{
		public CreditFaker(IEnumerable<int> titleIds)
		{
			RuleFor(c => c.Id, f => f.UniqueIndex);
			RuleFor(c => c.TitleId, f => f.PickRandom(titleIds));
			RuleFor(c => c.RealName, f => f.Name.FullName());
			RuleFor(c => c.CharacterName, f => f.Name.FirstName());
			RuleFor(c => c.Role, f => f.PickRandom(new List<string> { "Director", "Producer", "Screenwriter", "Actor", "Actress", "Cinematographer", "Film Editor", "Production Designer", "Costume Designer", "Music Composer" }));
		}
	}
}
