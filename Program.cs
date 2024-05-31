using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;


string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Vendas> listaVenda = JsonConvert.DeserializeObject<List<Vendas>>(conteudoArquivo);

foreach (Vendas venda in listaVenda) 
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " + 
    $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}"
    );
}



// DateTime dataAtual = DateTime.Now;

// List<Vendas> listaVendas = new List<Vendas>();

// Vendas v1 = new Vendas(1, "Corretor", 25.00M, dataAtual);
// Vendas v2 = new Vendas(2, "Martelo", 80.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);


// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);
























// for (int i = 0; --i < 5; i++) {
//     Console.WriteLine(i);
// }

// string[]nomes = {"Joao", "Maria", "Paulo", "Silva", "Vitor"};

// for (int cont = 1; cont <= 4; cont++) {

//     Console.WriteLine("{0}", nomes[cont]);
// }

// int a = 4^2-4;

// Console.WriteLine(a);


// int numero = 21;

// bool ehPar = false;

// // IF TERNÁRIO

// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));


// if(numero % 2 == 0) {
//     Console.WriteLine("Par");
// }
// else {
//      Console.WriteLine("Impar");
// }



// Pessoa p1 = new Pessoa("Fabio", "Santos");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} + {sobrenome}");

// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivosLeitura.txt");

// if (sucesso) {
//     //Console.WriteLine("Quantidade de linhas do arquivo: " + QuantidadeLinhas);
//     foreach(string linha in linhasArquivo) {
//         Console.WriteLine(linha);
//     }
// }
//     else {
//         Console.WriteLine("Não foi possível ler o arquivo");
//     }










// (int, string, string, decimal) tupla = (1, "Fabio", "Santos", 1.81M);

// ValueTuple<int, string,string,decimal> outroExemploTupla = (2, "Graziela", "Santos", 1.57M);

// var outroExemploTuplaCreate = Tuple.Create(1, "Fabio", "Santos", 1.81M);

// Console.WriteLine($" id: {tupla.Item1}");
// Console.WriteLine($" Nome: {tupla.Item2}");
// Console.WriteLine($" Sobrenom: {tupla.Item3}");
// Console.WriteLine($" Altura: {tupla.Item4}");






// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("MG", "Minas Gerais");
// estados.Add("PE", "Pernambuco");
// estados.Add("GO", "Goiás");

// foreach(var item in estados) {
//     Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
// }

// Console.WriteLine("--------------");

// estados.Remove("PE");
// estados["SP"] = "São Paulo - valor alterado";


// foreach(var item in estados) {
//     Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine("Verificando o elemento");

// if(estados.ContainsKey(chave)) {
//     Console.WriteLine($"Valor existente: {chave}");
// } else {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave} ");
// }






// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(8);
// pilha.Push(9);
// pilha.Push(10);

// foreach(int item in pilha) {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Pop();
// foreach(int item in pilha) {
//     Console.WriteLine(item);
// }







// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(5);
// fila.Enqueue(6);
// fila.Enqueue(7);

// foreach(int item in fila) {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()
// }");
// fila.Enqueue(10);

// foreach (int item in fila) {
//     Console.WriteLine(item);
// }















// new ExemploExcecao().Metodo1();











// try {

//     string[] linhas = File.ReadAllLines("Arquos/arquivosLeitura.txt");

// foreach(string linha in linhas) {

//     Console.WriteLine(linha);

// } 

// } catch(FileNotFoundException ex) 
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }

//  catch(DirectoryNotFoundException ex) 
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }

//  catch(Exception ex) 
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }

// finally {
//     Console.WriteLine("Chegou até aqui!");
// }



// Console.WriteLine("Chegou até aqui");


















// string dataString = "2022-13-15 17:00";

// bool sucesso = DateTime.TryParseExact(dataString,
//                      "yyyy-MM-dd HH:mm",
//                       CultureInfo.InvariantCulture, 
//                       DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }
















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 2084.52M;

// Console.WriteLine(valorMonetario.ToString("N2"));

// double porcentagem = .2452;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));












// Pessoa p1 = new Pessoa(nome:"Fabio", sobrenome:"Santos");
// Pessoa p2 = new Pessoa("Jean", "Oliveira");


// Curso ingles = new Curso();
// ingles.Nome = "Inglês";
// ingles.Alunos = new List<Pessoa>();

// ingles.AdicionarAluno(p1);
// ingles.AdicionarAluno(p2);
// ingles.listarAlunos();












// Pessoa p1 = new Pessoa();
// p1.Nome = "Giovanno";
// p1.Sobrenome = "Tolloni";

// p1.Idade = 31;
// p1.Apresentar();