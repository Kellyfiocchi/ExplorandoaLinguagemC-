using ExemploExplorando.Models;
using Models;
using System.Data;
using System.Globalization;
using Newtonsoft.Json;


 string conteudoArquivo = File.ReadAllText("Arquivos/venda.json");

    List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

    foreach (Venda venda in listaVendas)
    {
        Console.WriteLine($"Id: {venda.Id} - Produto: {venda.Produto} - Preço: {venda.Preco} - Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
    }





































































// DateTime dataAtual = DateTime.Now;


// List<Venda> listaVendas = new List<Venda>();


// Venda v1 = new Venda (1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda (2, "Licença de Software", 125.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string  serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/venda.json", serializado);

// Console.WriteLine(serializado);




























// int numero = 10;
// bool ehPar = false;

// // IF TERNÁRIO
// ehPar = numero % 2 == 0;

// Console.WriteLine($"O numero {numero} é " + (ehPar? "par" : "impar"));

// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é ímpar");
// }










































// Pessoa p1 = new Pessoa("Kelly", "Fiochi");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome}  {sobrenome}");























// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//    // Console.WriteLine($"Quantidade de linhas do arquivo:" + QuantidadeLinhas);
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Erro ao ler o arquivo");
// }














// ( int, string, string, decimal) tupla = (1, "Kelly", "Fiochi", 1.55M);
// //ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Kelly", "Fiochi", 1.55M);
// //var outroExemploTuplaCreate = Tuple.Create(1, "Kelly", "Fiochi", 1.55M);

// Console.WriteLine($"Id: {tupla.Item1} - Nome: {tupla.Item2} - Sobrenome: {tupla.Item3} - Altura: {tupla.Item4}");






















// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("MG", "Minas Gerais");


// Console.WriteLine(estados["SP"]);




























// foreach (KeyValuePair<string, string> estado in estados)
// {
//     Console.WriteLine($"Sigla: {estado.Key} - Estado: {estado.Value}");
// }

// //estados.Add("MG2", "Minas Gerais");

// Console.WriteLine($"------------------");

// estados.Remove("MG");
// estados["SP"] = "São Paulo - valor alterado";

// foreach (KeyValuePair<string, string> estado in estados)
// {
//     Console.WriteLine($"Sigla: {estado.Key} - Estado: {estado.Value}");
// }

// string Sigla = "BA";
// Console.WriteLine($"Verificando o elemento: {Sigla}");

// if (estados.ContainsKey(Sigla))
// {
//     Console.WriteLine($"A sigla {Sigla} existe no dicionário:{estados}");
// }
// else
// {
//     Console.WriteLine($"A sigla {Sigla} não existe no dicionário. É seguro adicionar a Sigla. {Sigla}");
// }


























































// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }




















// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }





























//new ExemploExcecao().Metodo1();
















//string[] linhasExemplo = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");
//Console.WriteLine("Chegou até aqui");


// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/darquivoLeitura.txt");


//     foreach (string linha in linhas)
//     {
//     Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho de pasta não encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Ocorreu uma exceção genérica");
//     Console.WriteLine(ex.Message);
// } 
// finally
// {
//     Console.WriteLine("Chegou até aqui");

// }



















// string  dataString = "2021-08-33 10:00:00";

// bool sucesso = DateTime.TryParseExact(dataString, 
//                         "yyyy-MM-dd HH:mm:ss", 
//                         CultureInfo.InvariantCulture, 
//                         DateTimeStyles.None, out DateTime data);

//  if  (sucesso)
//  {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
//  }   
//  else    
//  {
//     Console.WriteLine($"{dataString} não é uma data válida");
//  }              

















//DateTime data = DateTime.Now;
// DateTime data = DateTime.Parse("2021-08-15 10:00:00");

// //Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
// //Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data);
// 
















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");


// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("N2"));

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));














// string numero1 = "10";
// int numero2 = 20;


// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);










// int numero1 = 10;
// int numero2 = 20;

// int resultado = numero1 + numero2;

// Console.WriteLine(resultado);






// string numero1 = "10";
// string numero2 = "20";


// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);
















// Pessoa p1 = new Pessoa()
// {
//     Nome = "Kelly",
//     Sobrenome = "Fiochi"
// };

// Pessoa p2 = new Pessoa()
// {
//     Nome = "João",
//     Sobrenome = "Silva"
// };

// Curso cursoIngles = new Curso()
// {
//     Nome = "Inglês",
//     Alunos = new List<Pessoa>()
// };

// cursoIngles.AdicionarAluno(p1);
// cursoIngles.AdicionarAluno(p2);
// cursoIngles.ListarAlunos();


















// Pessoa p1 = new Pessoa()
// {
//     Nome = "Kelly",
//     Idade = 34,
//     Sobrenome = "Fiochi"
// };
//   p1.Apresentar();
