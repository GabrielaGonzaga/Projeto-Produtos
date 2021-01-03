using System;
using System.Collections.Generic;
using Projeto_de_Produtos.Classes;

namespace Projeto_de_Produtos
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca {get; set;}
        public Usuario CadastradoPor { get; set; }
        public List<Produto> ListaDeProdutos{ get; set; }

        public void Cadastrar(){
            Produto novoProduto = new Produto();
            
            Console.WriteLine("Digite o código do produto:");
            novoProduto.Codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o nome do produto:");
            novoProduto.NomeProduto = Console.ReadLine();
           
            Console.WriteLine("Digite o preço do produto:");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            DataCadastro =  DateTime.UtcNow;

            //Atribuição de marca através de um metodo criado para cadastro
            Marca = Marca.CadastrarMarca();

            //Atribuição de usuario através do método construtor
            CadastradoPor = new Usuario();
           


        }

        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;
            foreach( var item in ListaDeProdutos){
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.NomeProduto}");
                Console.WriteLine($"Preço: R$ {item.Preco}");
                Console.WriteLine($"Data de cadastro: R$ {item.DataCadastro}");
                Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                Console.WriteLine($"Cadastrado por: {item.CadastradoPor.Nome}");
                Console.WriteLine("");

            }
            Console.ResetColor();
        }

        public void Deletar(int cod){
            Produto prodDelete = ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);
        }
        
        
        
        
        
        
        
        
        
        
    }
}