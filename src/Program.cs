var patt = Environment.GetEnvironmentVariable("PATH") ?? string.Empty;

var pats = patt.Split(';');

Array.Sort(pats, StringComparer.OrdinalIgnoreCase);

foreach (var pat in pats)
    Console.WriteLine(pat);