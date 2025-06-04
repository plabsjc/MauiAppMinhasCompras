using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {
        string descricao;
        double quantidade;
        double preco;
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao
        {
            get => descricao;
            set
            {
                if (value == null)
                {
                    throw new Exception("Insira a descrição");
                }
                else
                {
                    descricao = value;
                }
            }
        }
        public double Quantidade
        {
            get => quantidade;
            set
            {
                if (value == 0)
                {
                    throw new Exception("Insira a quantidade");
                }
                else
                {
                    quantidade = value;
                }
            }
        }
        public double Preco
        {
            get => preco;
            set
            {
                if(value == 0)
                {
                    throw new Exception("Insira o valor corretamente");
                }
                else
                {
                    preco = value;
                }
                
            }
        }
        public double Total { get => Quantidade * Preco; }


    }
}
