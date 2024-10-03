using CSharpFS.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Maiara";
p1.Sobrenome = "Brito";

Pessoa p2 = new Pessoa();
p2.Nome = "Leonardo";
p2.Sobrenome = "Buta";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
































// Pessoa p1 = new Pessoa();
// p1.Nome = "Maiara";
// p1.Sobrenome = "Brito";
// p1.Idade = 47;
// p1.Apresentar();