using System.Text.Json.Serialization;
using Newtonsoft.Json;


var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");

var salesFiles = FindFiles(storesDirectory);

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);

var salesTotal = CalculateSalesTotal(salesFiles);
File.AppendAllText(Path.Combine(salesTotalDir, "totals.txt"), $"{salesTotal}{Environment.NewLine}");

GenerateSummary(salesTotalDir, salesTotal, salesFiles);

// foreach (var file in salesFiles)
// {
//     Console.WriteLine(file);
// }


IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        var extension = Path.GetExtension(file);
        if (extension == ".json")
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}

double CalculateSalesTotal(IEnumerable<string> salesFiles)
{
    double salesTotal = 0;

    foreach (var file in salesFiles)
    {
        string salesJson = File.ReadAllText(file);
        SalesData? data = JsonConvert.DeserializeObject<SalesData?>(salesJson);
        salesTotal += data?.Total ?? 0;
    }

    return salesTotal;
}

// additional functions
void GenerateSummary(string outputDir, double total, IEnumerable<string> files)
{
    var reportPath = Path.Combine(outputDir, "summary.txt");

    var report = new System.Text.StringBuilder();
    report.AppendLine("Sales Summary-----------------------------------");
    report.AppendLine($" Total Sales: ${total:N2}");
    report.AppendLine();
    report.AppendLine(" Details:");

    foreach (var file in files)
    {
        string salesJson = File.ReadAllText(file);
        SalesData? data = JsonConvert.DeserializeObject<SalesData?>(salesJson);

        
        report.AppendLine($" {file}: ${data?.Total ?? 0:N2}");
    }

    File.WriteAllText(reportPath, report.ToString());
}

record SalesData (double Total);
