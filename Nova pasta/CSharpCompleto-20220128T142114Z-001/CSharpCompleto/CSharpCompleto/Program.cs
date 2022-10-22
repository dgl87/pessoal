using System;
using System.Globalization;


namespace CSharpCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            #region While
            //while (condição)
            //{
            //    Comando 1;
            //    Comando 2;
            //}

            //Console.Write("Digite um número: ");
            //double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //while (x >= 0)
            //{
            //    double raiz = Math.Sqrt(x);
            //    Console.WriteLine(raiz.ToString("F2", CultureInfo.InvariantCulture));
            //    Console.Write("Digite um número: ");
            //    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}
            //Console.WriteLine("Numero negativo!");
            #endregion

            #region For
            /*for ( início; condição; incremento )
             *{
             *    Comando 1;
             *    Comando 2;
             *}
             */
            //int soma = 0;
            //Console.Write("Quantos números inteiros você vai digitar? ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write($"Valor #{i}: ");
            //    int valor = int.Parse(Console.ReadLine());

            //    soma += valor;
            //}
            //Console.WriteLine($"Soma = {soma}");
            #endregion

            #region Nullable
            //double? x = null;
            //double? y = 10.0;
            //Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(y.GetValueOrDefault());
            //Console.WriteLine();

            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(y.HasValue);
            //Console.WriteLine();

            //if (x.HasValue)
            //    Console.WriteLine(x.Value);
            //else
            //    Console.WriteLine("x is null");
            //if (y.HasValue)
            //    Console.WriteLine(y.Value);
            //else
            //    Console.WriteLine("y is null");
            //Console.WriteLine();

            ////Operador de coalescência nula
            //double? a = null;
            //double? b = 10.0;

            //double c = a ?? 0.0;
            //double d = b ?? 0.0;
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            #endregion

            #region Vetor
            //int n = int.Parse(Console.ReadLine());
            //double soma = 0.0;
            //double[] vet = new double[n];
            //for (int i = 0; i < n; i++)
            //{
            //    vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    soma += vet[i];
            //}
            //double media = soma / n;
            //Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

            //int n = int.Parse(Console.ReadLine());
            //Product[] vet = new Product[n];
            //double sum = 0.0;
            //for (int i = 0; i < n; i++)
            //{
            //    string nome = Console.ReadLine();
            //    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    vet[i] = new Product(nome, price);
            //    sum += vet[i].Price;
            //}

            //double avg = sum / n;
            //Console.WriteLine(avg.ToString("F2", CultureInfo.InvariantCulture));
            #endregion

            #region Testes
            //Produto p = new Produto();
            //Console.WriteLine("Entre com os dados do produto:");
            //Console.Write("Nome: ");
            //p.Nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //p.Quantidade = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine($"Dados do produto: {p}");
            //Console.WriteLine();

            //Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            //int quant = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(quant);
            //Console.WriteLine();
            //Console.WriteLine($"Dados atualizados: {p}");
            //Console.WriteLine();

            //Console.Write("Digite o número de produtos a ser removido do estoque: ");
            //quant = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(quant);
            //Console.WriteLine();
            //Console.WriteLine($"Dados atualizados: {p}");
            //Console.WriteLine();

            //Retangulo A = new Retangulo();
            //Console.WriteLine("Entre a largura e altura do retângulo:");
            //A.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //A.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("AREA = " + A.Area().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("PERÍMETRO = " + A.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("DIAGONAL = " + A.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            //Funcionario func = new Funcionario();
            //Console.Write("Nome: ");
            //func.Nome = Console.ReadLine();
            //Console.Write("Salário bruto: ");
            //func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Imposto: ");
            //func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine();

            //Console.WriteLine($"Funcionário: {func}");
            //Console.WriteLine();

            //Console.Write("Digite a porcentagem para aumentar o salário: ");
            //double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //func.AumentarSalario(porc);
            //Console.WriteLine();

            //Console.WriteLine($"Dados atualizados: {func}");

            //Console.Write("Qual é a cotação do dólar? ");
            //double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantos dólares você vai comprar? ");
            //double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double resultado = ConversorDeMoeda.Conversao(cotacao, dolares);
            //Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));

            ////Produtos
            //Console.WriteLine("Entre os dados do produto:");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Quantidade no estoque: ");
            //int quantidade = int.Parse(Console.ReadLine());
            //Produto p = new Produto(nome, preco, quantidade);
            //Console.WriteLine();

            //Console.WriteLine("Dados do produto: " + p);
            //Console.WriteLine();

            //Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            //int quant = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(quant);
            //Console.WriteLine();

            //Console.WriteLine("Dados atualizados: " + p);
            //Console.WriteLine();

            //Console.Write("Digite o número de produtos a ser removido do estoque: ");
            //quant = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(quant);
            //Console.WriteLine();

            //Console.WriteLine("Dados atualizados: " + p);

            ////ContaBancaria
            //ContaBancaria conta;
            //Console.Write("Entre o número da conta: ");
            //int numero = int.Parse(Console.ReadLine());
            //Console.Write("Entre o titular da conta: ");
            //string titular = Console.ReadLine();
            //Console.Write("Haverá depósito inicial(s / n) ? ");
            //char resp = char.Parse(Console.ReadLine());
            //if (resp == 'S' || resp == 's')
            //{
            //    Console.Write("Entre o valor de depósito inicial: ");
            //    double depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    conta = new ContaBancaria(numero, titular, depInicial);                
            //}
            //else
            //{
            //    conta = new ContaBancaria(numero, titular);                
            //}
            //Console.WriteLine();
            //Console.WriteLine("Dados da conta:");
            //Console.WriteLine(conta);
            //Console.WriteLine();

            //Console.Write("Entre um valor para depósito: ");
            //double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //conta.Deposito(quantia);
            //Console.WriteLine("Dados da conta atualizados:");
            //Console.WriteLine(conta);
            //Console.WriteLine();

            //Console.Write("Entre um valor para saque: ");
            //quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //conta.Saque(quantia);
            //Console.WriteLine("Dados da conta atualizados:");
            //Console.WriteLine(conta);
            #endregion

            Estudante[] vect = new Estudante[10];
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
