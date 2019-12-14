<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\WPF\PresentationCore.dll</Reference>
  <Namespace>System.Windows</Namespace>
</Query>

// Actual logic
Func<int, int> getFuel = mass => Math.Max(mass / 3 - 2, 0);
Func<int, int> getTotalFuel = mass =>
{
	var total = 0;
	var modifier = mass;
	while ((modifier = getFuel(modifier)) != 0)
	{
		total += modifier;
	}
	return total;
};

// Print answer
Clipboard.GetText()
	.Trim()
	.Split('\n')
	.Select(line => getTotalFuel(int.Parse(line)))
	.Sum()
	.Dump("Answer");