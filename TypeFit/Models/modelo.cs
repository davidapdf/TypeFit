﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TypeFit.Models
{
    [DataContract]
    public abstract class BaseModel
    {
        [DataMember]
        public int Id { get; set; }
    }

    public class Produto : BaseModel
    {
        public Produto()
        {
        }
        [Required]
        public string Codigo { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public decimal Preco { get; set; }
        public Produto(string codigo, string nome, decimal preco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
        }
    }

    public class Cadastro : BaseModel
    {
        public Cadastro()
        {
        }

        public virtual Pedido Pedido { get; set; }
        [MinLength(5, ErrorMessage = "Nome deve ter no mínimo 5 caracteres")]
        [MaxLength(50, ErrorMessage = "Nome deve ter no máximo 50 caracteres")]
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Email é obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefone é obrigatório")]
        public string Telefone { get; set; }

        internal void Update(Cadastro novoCadastro)
        {
            this.Nome = novoCadastro.Nome;
            this.Email = novoCadastro.Email;
            this.Telefone = novoCadastro.Telefone;

        }
    }

    [DataContract]
    public class ItemPedido : BaseModel
    {
        [Required]
        [DataMember]
        public Pedido Pedido { get; set; }
        [Required]
        [DataMember]
        public Produto Produto { get; set; }
        [Required]
        [DataMember]
        public decimal Preco { get; set; }

        public ItemPedido()
        {
        }
        public ItemPedido (Pedido pedido, Produto produto, decimal preco)
        {
            this.Pedido = pedido;
            this.Produto = produto;
            this.Preco = preco;
        }


    }

    public class Pedido : BaseModel
    {
        public Pedido()
        {
            Cadastro = new Cadastro();
        }

        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
        [Required]
        public virtual Cadastro Cadastro { get; set; }
    }

    [DataContract]
    public class Chat : BaseModel
    {
        [Required]
        [DataMember]
        public Cadastro UserRemetente { get; set; }
        [Required]
        [DataMember]
        public Cadastro UserDestinatario { get; set; }
        [Required]
        [DataMember]
        public string Mensagem { get; set; }
        public Chat()
        {
        }
        public Chat(Cadastro userRemetente, Cadastro userDestinatario,string mensagem)
        {
            this.UserDestinatario = userDestinatario;
            this.UserRemetente = userRemetente;
            this.Mensagem = mensagem;
        }

    }


}
