﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElemento.Models
{
    public class Animal
    {
        private string nome;
        private string idade;
        private string dono;
        private string especie;
        private string motivo;
        public required string Nome { get => nome; set => nome = value; }
        public required string Idade { get => idade; set => idade = value; }
        public required string Dono { get => dono; set => dono = value; }
        public required string Especie { get => especie; set => especie = value; }
        public required string Motivo { get => motivo; set => motivo = value; }
        public string Salva(Animal animal)
        {
            if (string.IsNullOrEmpty(animal.Nome) ||
                string.IsNullOrEmpty(animal.Idade) ||
                string.IsNullOrEmpty(animal.Dono) ||
                string.IsNullOrEmpty(animal.Especie) ||
                string.IsNullOrEmpty(animal.Motivo))
            {
                return "Um dos campos obrigatórios não foi preenchido";
            }
            else
            {
                return "Salvo com sucesso";
            }
        }
    }
}