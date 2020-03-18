using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Item
    {
        [Display(Name = "Codigo do Produto")]
        public int ItemId { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

        public Item()
        {
        }

        public Item(int itemId, string nome, double valor, string descricao)
        {
            ItemId = itemId;
            Nome = nome;
            Valor = valor;
            Descricao = descricao;
        }
    }
}
