<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	var lines = File.ReadAllLines(@"C:\Users\urza\Desktop\syn2010_word_abc_common.txt");
	StringBuilder result = new StringBuilder("wordlist = ["+Environment.NewLine);
	lines.Count().Dump();

	foreach (var line in lines)
	{

		if (!string.IsNullOrEmpty(line))
		{
			result.Append("\"");
			result.Append(line);
			result.Append("\"," + Environment.NewLine);
		}
	}
	
	result.Append("];");

	File.WriteAllText(@"C:\Users\urza\Desktop\syn2010_word_abc_common_js.txt", result.ToString());
}

// Define other methods and classes here
