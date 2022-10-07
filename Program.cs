using Csharp.Models;
using System.Globalization;

string datastring = "2022-10-07 15:26";

bool sucesso = DateTime.TryParseExact(datastring, 
                        "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None, 
                        out DateTime data);

if (sucesso)
{
    Console.Write($"Coversao com sucesso data: {data}");
}
else
{
    Console.WriteLine($"{datastring} naao e uma data valida");
}
