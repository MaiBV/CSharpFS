using CSharpFS.Models;
using System.Globalization;


string[] linhas = File.ReadAllLines("Arquivos/arquivosLeitura.txt");

foreach (string linha in linhas)
{
    Console.WriteLine(linha);
}
































// string dataString = "2024-17-09 16:35";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão obteve sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida.");
// }



// string dataString = data.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToLongDateString());
// Console.WriteLine(data.ToShortTimeString());
// Console.WriteLine(data.ToLongTimeString());
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture));



// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C2"));

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));




// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);




// Pessoa p1 = new Pessoa(nome: "Maiara", sobrenome: "Brito");

// Pessoa p2 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();




// Pessoa p1 = new Pessoa();
// p1.Nome = "Maiara";
// p1.Sobrenome = "Brito";
// p1.Idade = 47;
// p1.Apresentar();