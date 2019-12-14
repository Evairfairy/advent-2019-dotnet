<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\WPF\PresentationCore.dll</Reference>
  <Namespace>System.Windows</Namespace>
</Query>

// Actual logic
Func<int, int> getFuel = mass => mass / 3 - 2;

// Print answer
Clipboard.GetText()
	.Trim()
	.Split('\n')
	.Select(line => getFuel(int.Parse(line)))
	.Sum()
	.Dump("Answer");