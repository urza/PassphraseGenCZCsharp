<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	var lines = File.ReadAllLines(@"C:\Users\urza\Desktop\syn2010_word.txt");
	StringBuilder result = new StringBuilder("");
	lines.Count().Dump();

	foreach (var line in lines)
	{

		var chunks = line.Split('\t');
		//line.Dump();
			if (!string.IsNullOrEmpty(chunks[0]) && Char.IsLetter(chunks[0].ToLower().First()))
				result.Append( chunks[0] + Environment.NewLine);
			if (!string.IsNullOrEmpty(chunks[1]) &&Char.IsLetter(chunks[1].ToLower().First()))
				result.Append(chunks[1] + Environment.NewLine);

	}
	
	File.WriteAllText(@"C:\Users\urza\Desktop\syn2010_word_abc_full.txt",result.ToString());
}

// Define other methods and classes here
