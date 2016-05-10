using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.XNA.Framework;
using Microsoft.XNA.Framework.Graphics;

namespace Jogo2D
{
    class Animacao
    {
        // Lista que contém os quadros da Animacao
        private List<Rectangle> quadrosAnimacao = new List<Rectangle>();
        // Método para obter essa lista quando necessário
        public List<Rectangle> QuadrosAnimacao { get { return this.quadrosAnimacao; } }


        // Tempo de intervalo de transição dos quadros da Animacao
        private float intervalo = 0.10f
// Métodos para obter e setar o intervalo quando necessário
public float getIntervalo() { return this.intervalo; }
        public void setIntervalo(float _intervalo) { this.intervalo = _intervalo; }


        // Define se existe repetição na Animacao
        private bool existeLoop = false;
        // Métodos para obter e setar a existência de repetição
        public bool getExisteLoop() { return this.existeLoop; }
        public void setExisteLoop(bool _loop) { this.existeLoop = _loop; }


        // Define a quantidade total de frames da Animacao
        private int quadrosTotal = 0;
        // Método que constrói nossa Animacao
        // é enviado para esse método uma lista de quadros
        // com inicio, e total de quadros dela
        public Animacao(List<Rectangle> quadros, int inicio, int total)
        {
            // Define a quantidade de quadros da Animacao
            this.quadrosTotal = total;


            // Adiciona cada quadro que foi recebido a lista de quadros da Animacao
            for (int i = inicio; i < (inicio + total); i++)
            {
                this.quadrosAnimacao.Add(quadros[i]);
            }
        }

    }
}
