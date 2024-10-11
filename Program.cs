using CSharpFS.Models;
using System.Globalization;


int numero = 10;
bool ehPar = false;

// IF Ternário
ehPar = numero % 2 == 0 ? true : false;

Console.WriteLine(ehPar ? $"O número {numero} é par." : $"O número {numero} é ímpar.");




// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par.");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é ímpar.");
// }


// Pessoa p1 = new Pessoa("Leonardo", "Buta");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");


// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     //Console.WriteLine("Quantidade de linhas do arquivo:" + quantidadeDeLinhas);
//     foreach (var linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Ocorreu um erro ao ler o arquivo.");
// }



// (int, string, string, decimal) tupla = (1, "Leonardo", "Buta", 1.80M);

//ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Leonardo", "Buta", 1.80M);

//var outroExemploTuplaTuplaCreate = Tuple.Create(1, "Leonardo", "Buta", 1.80M);


// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");


// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Sigla: {item.Key} - Estado: {item.Value}");
// }

// Console.WriteLine("-----------------");

// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado";
// estados.Add("RJ", "Rio de janeiro");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Sigla: {item.Key} - Estado: {item.Value}");
// }

// string Sigla = "SP";
// Console.WriteLine($"Verificando o elemento: {Sigla}");

// if (estados.ContainsKey(Sigla))
// {
//     Console.WriteLine($"Valor existente: {Sigla}");
// }
// else
// {
//     Console.WriteLine($"Valor não encontrado: É seguro adicionar {Sigla}");
// }   


// LIFO - Last IN First OUT

// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");

// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }


// FIFO - First IN First OUT

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }


//new ExemploExcecao().Metodo1();


// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro de leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro de leitura do arquivo. Caminho da pasta não encontrado." + ex.Message);
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu um erro de leitura do arquivo. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui.");
// }


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