using System;
namespace myapp
{
    class Program
    {
        static List<Cliente> clientes = new List<Cliente>();
        static void Main(string[] args)
        {
            bool executando = true;
            while (executando)
            {
                Console.WriteLine("Digite a opção: \n1 - Inserir cliente.\n2 - Consultar clientes.\n3 - Sair.");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        AdicionarCliente();
                        break;
                    case 2:
                        ConsultarCliente();
                        break;
                    case 3: 
                        executando = false;
                        break;
                    default: Console.WriteLine("Opção invalida");
                        break;

                }
            }

            static void AdicionarCliente()
            {
                Console.WriteLine("Digite o nome do cliente: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o e-mail do cliente: ");
                string email = Console.ReadLine();

                Cliente cliente = new Cliente(nome, email);
                clientes.Add(cliente);

                Console.WriteLine("Cliente adicionado com sucesso!\n");

            }
            static void ConsultarCliente()
            {
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine("Nome: " + cliente.Nome);
                    Console.WriteLine("E-mail: " + cliente.Email);
                    Console.WriteLine("----------------------");
                }

            }
        }
    }
}
class Cliente
{
    public string Nome { get; set; }
    public string Email { get; set; }

    public Cliente(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }
}