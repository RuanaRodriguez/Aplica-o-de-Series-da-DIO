using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
       
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSeries();
                        break;
                    case "3":
                        AtuaizarSeries();
                        break;
                    case "4":
                        ExcluirSeries();
                        break;
                    case "5":
                        AtualizarSeries();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                        throw new ArgmentOutORangeException();
              
                } 

                opcaoUsuario =ObterOpcaoUsuario();    
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void ListarSerie()
        {
            console.WriteLine("Listar séries");

            var Lista = repositorio.Lista();

            if (lista.Cout == 0)
            {
                console.WriteLine("Nenhuma série cadastrada");
                return;
            }
            foreach (var serie in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retorneTitulo());
                return;
    
            console.WriteLine("Inserir nova série")
             //https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
             //https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                console .WriteLine("{0}-{1}", i,Enum.GetName(typeof(Genero), 1 ));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGeneo = int.Parse(Console.ReadLine());
        
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGeneo = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o Título da série: ");
            string entradaTitulo = Console.ReadLine();
        
            Console.Write("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string entraaDescricao = Console.ReadLine();

            serie novaSerie = new Serie(id: IndiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Atualiza(IndiceSerie, atualizaSerie);

        private static void AtualizarSeries()
        {
            Console.WriteLine("Listar séries");

            var Lista = repositorio.Lista();

            if (lista.Cout == 0)
            {
                console.WriteLine("Nenhuma série cadastrada");
                return;
            }
            foreach (var serie in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retorneTitulo());
                return;
            }
        }
        
        private static void InserirSerie()
        {
            console.WriteLine("Inserir nova série");

             //https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
             //https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                console .WriteLine("{0}-{1}", i,Enum.GetName(typeof(Genero), 1 ));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGeneo = int.Parse(Console.ReadLine());
        
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGeneo = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o Título da série: ");
            string entradaTitulo = Console.ReadLine();
        
            Console.Write("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string entraaDescricao = Console.ReadLine();

            serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Insere (novaSerie);

        }   

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizae série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
