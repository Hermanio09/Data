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




























// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 15282.40M;

// Console.WriteLine(valorMonetario.ToString("N2"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));


























// int numero1 = 10;
// string numero2 = "10";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);





// Pessoa p1 = new Pessoa(nome: "Buta", sobrenome: "Lima");
// Pessoa p2 = new Pessoa(nome: "Buta", sobrenome: "Guerra");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();
