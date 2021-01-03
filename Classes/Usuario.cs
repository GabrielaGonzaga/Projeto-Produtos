using System;

namespace Projeto_de_Produtos.Classes
{
    public class Usuario
    {
        public Usuario(){
            //Cadastrar ususario automaticamente quando a classe for instanciada
            Cadastrar();
        }

        public Usuario(int _codigo, string _nome, string _email, string _senha){
            Codigo =_codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.UtcNow;

        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        
        
        public void Cadastrar(){
            Console.WriteLine("Digite seu nome");
            Nome = Console.ReadLine();
            
            Console.WriteLine("Digite seu e-mail");
            Email = Console.ReadLine();
            
            Console.WriteLine("Digite sua senha");
            Senha = Console.ReadLine();

            DataCadastro = DateTime.UtcNow;
        }

        public void Deletar(int cod){
            Nome = "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }
                
        
        
        
        
        
    }
}