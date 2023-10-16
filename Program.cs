using ExemploExplorando.Models;


Pessoa p1 = new Pessoa()
{
    Nome = "Kelly",
    Sobrenome = "Fiochi"
};

Pessoa p2 = new Pessoa()
{
    Nome = "João",
    Sobrenome = "Silva"
};

Curso cursoIngles = new Curso()
{
    Nome = "Inglês",
    Alunos = new List<Pessoa>()
};

cursoIngles.AdicionarAluno(p1);
cursoIngles.AdicionarAluno(p2);
cursoIngles.ListarAlunos();




























// Pessoa p1 = new Pessoa()
// {
//     Nome = "Kelly",
//     Idade = 34,
//     Sobrenome = "Fiochi"
// };
//   p1.Apresentar();
