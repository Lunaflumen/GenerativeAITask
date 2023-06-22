using System.Globalization;

using CsvHelper;

using MyProjectName;

class MyProgramName
{
	static void Main()
	{
		Console.WriteLine("Started");

		var titleFaker = new TitleFaker();
		var titles = titleFaker.Generate(100);

		Console.WriteLine("Titles was generated");

		var titleIds = titles.Select(t => t.Id).ToList();
		var creditFaker = new CreditFaker(titleIds);
		var credits = creditFaker.Generate(10000);

		Console.WriteLine("Credit was generated");

		using var titleWriter = new StreamWriter("titles.csv");
		using var titleCsv = new CsvWriter(titleWriter, CultureInfo.InvariantCulture);
		titleCsv.WriteRecords(titles);

		Console.WriteLine("Finished creating titles.csv");

		using var creditWriter = new StreamWriter("credits.csv");
		using var creditCsv = new CsvWriter(creditWriter, CultureInfo.InvariantCulture);
		creditCsv.WriteRecords(credits);

		Console.WriteLine("Finished creating credits.csv");
	}
}
