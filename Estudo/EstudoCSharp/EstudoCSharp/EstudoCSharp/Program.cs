using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace EstudoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tipos de Dados
            //Console.WriteLine("Hello World!");
            //decimal x = decimal.MaxValue;
            //Console.WriteLine(x);
            //DateTime a = new DateTime(1987, 4, 7, 0, 0, 0);
            //TimeSpan b = DateTime.Now - a;
            //Console.WriteLine(b);
            #endregion

            #region Conversões
            ////Conversão implícita
            //int q = 23;
            //double w = q;

            ////Conversão explícita
            //int e = (int)w;

            ////Conversão utilizando convert
            //string z = "1986";
            //int c = Convert.ToInt32(z);

            ////Conversão utilizando ToString
            //int v = int.Parse(z);
            //long n = long.Parse(z);

            ////Verifica conversão
            //string l = "1987A";
            //if (int.TryParse(l, out int val))
            //{
            //    Console.WriteLine("Sucesso na conversão");
            //}
            //else
            //{
            //    Console.WriteLine("Número Inválido");
            //}
            #endregion

            #region Operadores Aritméticos
            ////unários ++, --, + e -
            //int valor = 4;
            //Console.WriteLine(valor++); //4
            //Console.WriteLine(valor--); //5

            //Console.WriteLine(++valor); //5
            //Console.WriteLine(--valor); //4

            //Console.WriteLine(valor);
            //Console.WriteLine(-valor);
            //Console.WriteLine(-(-valor));

            //var soma = 4 + 5;
            //var subtracao = 4 - 5;
            //var multiplicacao = 4 * 5;
            //var divisao = 20 / 3;
            //var divisaoDouble = (double)20 / 3;

            //var multiplos = (4 * 5) + 10;

            #endregion

            #region Operadores de comparação > >= < <=
            //Console.WriteLine(4 > 5);
            //Console.WriteLine(5 > 5);
            //Console.WriteLine(6 >= 5);

            //Console.WriteLine(5 < 4);
            //Console.WriteLine(5 <= 5);
            //Console.WriteLine(5 < 6);
            #endregion

            #region Operadores de Igualdade ==, !=
            //Console.WriteLine(5 == 5);
            //Console.WriteLine(4 == 5);

            //Console.WriteLine(5 != 5);
            //Console.WriteLine(4 != 5);

            #endregion

            #region Operadores Lógicos ANS && e OR ||
            //var minhaNota = 7;
            //var ultimoAno = true;
            //if (minhaNota >= 7 && ultimoAno)
            //{
            //    Console.WriteLine("Parabéns");
            //}
            //if (minhaNota >= 7 || ultimoAno)
            //{
            //    Console.WriteLine("Aprovado");
            //}
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || true);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);

            //Console.WriteLine(true && false);
            //Console.WriteLine(false && true);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            #endregion

            #region Estrutura de Condição if else
            //var nota = int.Parse(Console.ReadLine());
            //if (nota >= 70)
            //{
            //    Console.WriteLine("Aprovado");
            //}
            //else if (nota >= 40)
            //{
            //    Console.WriteLine("Em recuperação");
            //}
            //else
            //{
            //    Console.WriteLine("Reprovado");
            //}

            #endregion

            #region Estrutura de Condição switch case
            //Console.WriteLine("Seja bem vindo a Empresa x");
            //Console.WriteLine("Digite 1 - Contratação de um plano");
            //Console.WriteLine("Digite 2 - Reclamação de serviço prestado");
            //Console.WriteLine("Digite 3 - Segunda via de boleto");
            //Console.WriteLine("Digite 4 - Sair");
            //var opcao = Console.ReadLine();
            //switch (opcao)
            //{
            //    case "1":
            //        Console.WriteLine("Informações de plano novo");
            //        break;
            //    case "2":
            //        Console.WriteLine("Fale sobre sua reclamação");
            //        break;
            //    case "3":
            //        Console.WriteLine("Solicite segunda via de boleto");
            //        break;
            //    case "4":
            //        Console.WriteLine("Tenha um bom dia!");
            //        break;
            //    default:
            //        Console.WriteLine("Opção não encontrada");
            //        break;
            //}

            #endregion

            #region Estrutura de Repetição for
            //Console.WriteLine("digite uma sequência de números separados por espaços");
            //string[] numeros = Console.ReadLine().Split(' ');
            //Console.WriteLine("numeros: ");
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}
            //Console.WriteLine();
            #endregion

            #region Estrutura de Repetição while
            //string[] numeros = Console.ReadLine().Split(' ');
            //var contador = 0;
            //while (contador < numeros.Length)
            //{
            //    Console.WriteLine(numeros[contador]);
            //    contador++;
            //}

            #endregion

            #region Estrutura de Repetição foreaach
            //string[] numeros = Console.ReadLine().Split(' ');
            //foreach (string item in numeros)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Trabalhando com Strings - Principais Métodos
            string frase = "   C# é uma linguagem moderna e versátil. " +
                "Com C# consigo desenvolver para Web, Desktop, Jogos, " +
                "Mobile, entre outros.   ";

            ////Lenght
            //int tamanho = frase.Length;
            //Console.WriteLine(tamanho);

            ////Empty
            //var vazio = string.Empty;
            //Console.WriteLine(vazio);

            ////To lower, To Upper
            //string fraseMaiuscula = frase.ToUpper();
            //Console.WriteLine(fraseMaiuscula);
            //string fraseMinuscula = frase.ToLower();
            //Console.WriteLine(fraseMinuscula);

            //Split
            //var frases = frase.Split(' ');
            //foreach (var item in frases)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();

            //Trim, TrimEnd e TrimStart
            //var paragrafoTrim = frase.Trim();
            //Console.WriteLine(paragrafoTrim);
            //var paragrafotrimend = frase.TrimEnd();
            //Console.WriteLine(paragrafotrimend);
            //var paragrafoTrimStart = frase.TrimStart();
            //Console.WriteLine(paragrafoTrimStart);

            ////IsNullOrWhiteSpace
            //bool paraIsNullOrWhiteSpace = string.IsNullOrWhiteSpace(frase);

            //Replace
            //string fraseCSharp = frase.Replace("C#", "C-Sharp");
            //Console.WriteLine(fraseCSharp);
            #endregion

            #region Trabalhando com Strings - Buscas
            ////IndexOf
            //int indexOf = frase.IndexOf("C#");
            //Console.WriteLine(indexOf);
            ////LastIndexOf
            //int lastIndexOf = frase.LastIndexOf("C#");
            //Console.WriteLine(lastIndexOf);
            ////StartsWith
            //bool startsWith = frase.StartsWith("Douglas");
            //Console.WriteLine(startsWith);
            ////Substring
            //int indexOfMobile = frase.IndexOf("Mobile");
            //string substring = frase.Substring(indexOfMobile, 6);
            //Console.WriteLine(substring);
            ////contains
            //bool contains = frase.Contains("mobile");
            //Console.WriteLine(contains);
            //bool contains2 = frase.Contains("mobile", StringComparison.OrdinalIgnoreCase); //Ignora maiúsculo e minúsculo
            //Console.WriteLine(contains2);
            #endregion

            #region Arrays e Listas
            ////Arrays / Matriz
            //int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] numbersCopy = new int[numbers.Length];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbersCopy[i] = numbers[i];
            //    Console.WriteLine(numbersCopy[i]);
            //}

            //string[] numerosString = "11 12 13 14 15 16 17 18 19".Split(' ');
            //int[] numbersConverted = Array.ConvertAll(numerosString, Convert.ToInt32);

            ////Listas
            //List<int> list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //list.Add(10);
            //list.AddRange(new List<int> { 11, 12, 13, 14 });
            //list.AddRange(new int[] { 15, 16, 17, 18, 19, 20 });
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //int count = list.Count;
            //bool contains14 = list.Contains(14);

            //Console.WriteLine("Lista Reversa");
            //list.Reverse();
            //list.ForEach(l => Console.WriteLine(l));

            //Console.WriteLine("Lista Ordenada");
            //list.Sort();
            //list.ForEach(l => Console.WriteLine(l));

            //Console.WriteLine("Removendo elementos da Lista");
            //list.Remove(20);
            //list.RemoveAll(l => l > 15);
            //list.ForEach(l => Console.WriteLine(l));
            //list.Clear();
            #endregion

            #region LINQ - Language Integrated-Query
            //    List<Student> students = new List<Student>
            //    {
            //        new Student(1, "luis", "12345678910", 100),
            //        new Student(2, "zoin", "9876543210", 35),
            //        new Student(3, "cristina", "32165498701", 85),
            //        new Student(4, "guducho", "78945612301", 70),
            //        new Student(5, "luis", "43265487699", 75)
            //    };

            //    //Any            
            //    bool any = students.Any();
            //    bool any100 = students.Any(l => l.Grade == 100);
            //    Console.WriteLine(any);

            //    //Single, SingleOrDefault
            //    Student single = students.Single(l => l.Id == 4);
            //    Student singleOrDefault = students.SingleOrDefault(l => l.Id == 0);
            //    Console.WriteLine(singleOrDefault);


            //    //First, FirstOrDefault
            //    Student first = students.First(l => l.FullName == "luis");
            //    Student firstOrDefault = students.FirstOrDefault(l => l.Grade == 0);


            //    //OrderBy, OrderByDescending
            //    var orderBy = students.OrderBy(l => l.Grade);
            //    var orderByDesc = students.OrderByDescending(l => l.Grade);

            //    //Where
            //    var approvedStudents = students.Where(l => l.Grade >= 70);

            //    //Select, SelectMany
            //    var grades = students.Select(l => l.Grade);
            //    var phoneNumber = students.SelectMany(l => l.PhoneNumbers);


            //    //Sum, Min, Max, Count
            //    var sum = students.Sum(l => l.Grade);
            //    var min = students.Min(l => l.Grade);
            //    var max = students.Max(l => l.Grade);
            //    var count = students.Count;
            //}

            //public class Student
            //{
            //    public int Id { get; set; }
            //    public string FullName { get; set; }
            //    public string Document { get; set; }
            //    public int Grade { get; set; }

            //    public List<string> PhoneNumbers { get; set; }

            //    public Student(int id, string fullName, string document, int grade)
            //    {
            //        Id = id;
            //        FullName = fullName;
            //        Document = document;
            //        Grade = grade;
            //        PhoneNumbers = new List<string> { "123323232", "23412412312", "2809138231" };
            //    }
            //}
            #endregion

            #region Trabalhando com Datas: DateTime
            //DateTime now = DateTime.Now;
            //DateTime today = DateTime.Today;

            //DateTime threeDaysAgoHour = now.AddDays(-3); 
            //DateTime threeDaysAgo = today.AddDays(-3);
            //DateTime sixMonthsLater = today.AddMonths(6);
            //DateTime twoYearsLater = today.AddYears(2);

            //string shortDate = now.ToShortDateString();
            //string longDate = now.ToLongDateString();

            //string shortTime = now.ToShortTimeString();
            //string longTime = now.ToLongTimeString();

            //DateTime date = now.Date;
            //int day = now.Day;
            //int month = now.Month;
            //int year = now.Year;
            //int hour = now.Hour;
            //int minute = now.Minute;
            //int second = now.Second;

            //DayOfWeek dayOfWeek = now.DayOfWeek;
            //if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
            //{
            //    Console.WriteLine("Faz parte do final de semana");
            //}

            //int dayOfYear = now.DayOfYear;
            #endregion

            #region Trabalhando com Datas: Formatação
            //DateTime now = DateTime.Now;
            //string[] formats = new string[] { "d", "D", "f", "F", "g", "G", "m", "o", "r",
            //    "s", "t", "T", "u", "U", "Y" };
            //foreach (string format in formats)
            //{
            //    //Console.WriteLine("Data no formato {0}: {1}", format, now.ToString(format));
            //    Console.WriteLine($"Data no formato {format}: {now.ToString(format)}");
            //}

            //Console.WriteLine("Diferentes maneiras de formatar manualmente");
            //Console.WriteLine($"Data no formato d: {now:d}");
            //Console.WriteLine($"Data no formato MM-dd-yyyy: {now:MM-dd-yyyy}");
            //string dateFormat = now.ToString("MM-dd-yyyy");
            //string dateFormatBr = now.ToString("dd/MM/yyyy HH-mm-ss");

            #endregion

            #region Trabalhando com Diretórios
            //string folderName = "pasta";
            //string subFolderName = "subpasta";
            //string subFolderNameStatic = "subpasta_usingStatic";

            //var directoryInfoSubFolder = new DirectoryInfo(subFolderName);
            //if (!Directory.Exists(subFolderName) || !directoryInfoSubFolder.Exists)
            //{
            //    Directory.CreateDirectory(subFolderNameStatic);
            //    Directory.CreateDirectory(folderName);
            //    directoryInfoSubFolder.Create();

            //    directoryInfoSubFolder.MoveTo($"{folderName}//{subFolderName}");
            //    Directory.Move(subFolderNameStatic, @$"{folderName}\{subFolderNameStatic}");
            //}
            //var name = directoryInfoSubFolder.Name;
            //var parent = directoryInfoSubFolder.Parent;
            //var root = directoryInfoSubFolder.Root;
            //var exists = directoryInfoSubFolder.Exists;

            //foreach (var directory in Directory.GetDirectories(folderName))
            //{
            //    Console.WriteLine(directory);
            //}
            //Directory.Delete($@"{folderName}\{subFolderName}");
            #endregion

            #region Trabalhando com Arquivos
            ////File e FileInfo
            //var file = @"pasta\texto.txt";
            //if (!File.Exists(file))
            //{
            //    File.CreateText(file);
            //}
            //var fileInfo = new FileInfo(file);
            //Console.WriteLine($"Nome: {fileInfo.Name}, tamanho: {fileInfo.Length}, Data de Atualização: {fileInfo.LastWriteTime}");
            #endregion

            #region Tratando Exceções
            //var seteString = "sete";
            //string valorNull = null;
            //var longValue = long.MaxValue.ToString();

            //try
            //{
            //    var formatException = int.Parse(seteString);
            //    var argumentNullException = int.Parse(valorNull);
            //    var overflowException = Convert.ToInt32(longValue);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"Format Exception: {ex.Message}");
            //}
            //catch (ArgumentNullException ex)
            //{
            //    Console.WriteLine($"Argument Null Exception {ex.Message}");
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine($"Overflow Exception {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine($"Este código é executado sempre.");
            //}

            #endregion

            #region Herança - Upcasting e Downcasting
            //Account acc = new Account(1001, "Joe", 0.00);
            //BusinessAccount baac = new BusinessAccount(1002, "Bob", 200.00, 1500.00);

            //Account acc2 = baac;
            //Account acc3 = new BusinessAccount(1003, "John", 300.00, 1200.00);
            //Account acc4 = new SavingsAccount(1004, "Noah", 400.00, 0.01);

            ////Downcasting
            //BusinessAccount acc5 = (BusinessAccount)acc2;
            ////BusinessAccount acc6 = (BusinessAccount)acc4; //Apresenta erro em tempo de execução

            //if (acc4 is BusinessAccount)
            //{
            //    BusinessAccount acc6 = (BusinessAccount)acc4;
            //    BusinessAccount acc6 = acc4 as BusinessAccount; //outro tipo de casting
            //    acc6.Loan(200.0);
            //    Console.WriteLine("Loan!");
            //}
            //if (acc4 is SavingsAccount)
            //{
            //    SavingsAccount acc6 = (SavingsAccount)acc4;
            //    BusinessAccount acc6 = acc4 as SavingsAccount; //outro tipo de casting
            //    acc6.UpdateBalance();
            //    Console.WriteLine("Update!");
            //}
            #endregion

            #region Exercício de Fixação StreamWriter, File
            //string path = @"c:\temp\file.csv";

            //try
            //{
            //    string folder = Path.GetDirectoryName(path);
            //    string newFolder = folder + @"\out";
            //    string newFile = newFolder + @"\summary.csv";
            //    Directory.CreateDirectory(newFolder);

            //    string[] lines = File.ReadAllLines(path);
            //    using (StreamWriter sw = File.AppendText(newFile))
            //    {
            //        foreach (string line in lines)
            //        {
            //            string[] fields = line.Split(',');
            //            string name = fields[0];
            //            double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
            //            int quantity = int.Parse(fields[2]);
            //            Product prod = new Product(name, price, quantity);
            //            sw.WriteLine(prod.Name + ", " + prod.Total().ToString(CultureInfo.InvariantCulture));
            //        }
            //    }
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            Console.ReadKey();

        }
    }
}