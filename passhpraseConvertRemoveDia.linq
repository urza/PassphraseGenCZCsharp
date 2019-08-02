<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	var lines = File.ReadAllLines(@"C:\Users\urza\Desktop\syn2010_word_abc_full.txt");
	StringBuilder result = new StringBuilder("");
	lines.Count().Dump();
	
	var safe = "abcdefghijklmnopqrstuvwz";
	foreach (var word in lines)
	{
		if (word.All(letter => safe.Contains(letter)))
			result.Append(word + Environment.NewLine);
	}
	
	File.WriteAllText(@"C:\Users\urza\Desktop\syn2010_word_abc_bezdia.txt",result.ToString());
}

// Define other methods and classes here