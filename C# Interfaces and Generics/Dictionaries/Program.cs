// Create a Dict that maps strings to strings
Dictionary<string, string> fileTypes = new Dictionary<string, string>();

// Add some file type exts and their descriptions
fileTypes.Add(".txt", "Text File");
fileTypes.Add(".htm", "HTML Web Page");
fileTypes.Add(".html", "HTML Web Page");
fileTypes.Add(".css", "Cascading Style Sheet");
fileTypes.Add(".xml", "XML Data");

// TODO: How many key/ value pairs are there?
Console.WriteLine($"There are {fileTypes.Count()}");

// TODO: Try adding an existing key
try {
    fileTypes.Add(".txt", "This exists already");
} catch (Exception e) 
{
    Console.WriteLine(e.Message);
}

// TODO: Try removing and then finding a key
fileTypes.Remove(".txt");
Console.WriteLine($"Does fileTypes contain .txt? {fileTypes.ContainsKey(".txt")}"); // shouldn't because I removed it in the previous line

// TODO: Dump the contents of the Dictionary
Console.WriteLine("Dumping dictionary contents: ");
foreach (KeyValuePair<string,string> item in fileTypes)
{
    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
}