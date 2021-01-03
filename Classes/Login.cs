using System;

namespace Projeto_de_Produtos.Classes
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login(){
            Usuario user = new Usuario();
            Logar(user);

            if(Logado){
                GerarMenu();
            }
        }

        public void GerarMenu(){

            Produto produto = new Produto();
            Marca marca = new Marca();

            string opçao = "n";

            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("[1] - Cadastrar Produto");
                Console.WriteLine("[2] - Listar Produtos");
                Console.WriteLine("[3] - Deletar Produto");
                Console.WriteLine("[4] - Cadastrar Marca");
                Console.WriteLine("[5] - Listar Marca");
                Console.WriteLine("[6] - Deletar Marca");
                Console.WriteLine("[0] - Sair da aplicação");

                opçao = Console.ReadLine();

                switch(opçao){
                    case "1":
                        produto.Cadastrar();
                        break;
                    
                    case "2":
                        produto.Listar();
                        break;
                    
                    case "3":
                        Console.WriteLine("Digite o código do produto que deseja excluir");
                        int cod = int.Parse(Console.ReadLine());
                        produto.Deletar(cod);
                        break;
                    
                    case "4":
                        marca.CadastrarMarca();
                        break;
                    
                    case "5":
                        marca.Listar();
                        break;
                    
                    case "6":
                        Console.WriteLine("Digite o código do marca que deseja excluir");
                        int codMarca = int.Parse(Console.ReadLine());
                        marca.Deletar(codMarca);
                        break;
                    
                    default:
                        break;
                }
            }
            while(opçao != "0");

        }
        
        public void Logar(Usuario usuario){
              
            Console.WriteLine("Digite seu E-mail:");
            string emailogin = Console.ReadLine();
            
            Console.WriteLine("Digite sua senha:");
            string senhaLogin = Console.ReadLine();
            
            if(emailogin == usuario.Email && senhaLogin == usuario.Senha){
            Logado = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Login efetuado com sucesso");
            Console.ResetColor();
            }
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Falha ao logar");
                Console.ResetColor();
            }
        }
        public void Deslogar(){
            Logado = false;
        }
    }
}