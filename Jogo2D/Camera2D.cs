using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Jogo2D
{
    class Camera2D
    {
        // Definição da posição da Camera2D no ambiente do jogo. 
        // Vector2 é um tipo de dado que armazena em Vector os valores de X e Y. 
        // Definimos a posição inicial como Zero. 
        public Vector2 posicaoCamera = Vector2.Zero;
        // Definição dos limites da Camera2D no ambiente do jogo. 
        private Vector2 limites;
        private Vector2 posicao;

        // Definição das dimensões da tela do jogo. 
        private float widthTela, heightTela;

        // Método que constrói a Camera2D ao ser inicializada 
        // Recebe como parâmetro o dispositivo gráfico e a 
        // posição inicial dela no ambiente 
        public Camera2D(GraphicsDeviceManager graphics, Vector2 posicaoInicial)
        {
            // Define o tamanho da tela conforme a viewport do usuário 
            this.widthTela = graphics.GraphicsDevice.Viewport.Width;
            this.heightTela = graphics.GraphicsDevice.Viewport.Height;
            // Define a posição inicial da Camera2D na tela 
            this.posicao = posicaoInicial;
         
        }


        // Método para seguir o objeto-alvo atualizando a 
        // posição da Camera2D conforme a posição do objeto 
        public void Atualizar(Vector2 posicaoAlvo)
        {
            // Se a posição X do alvo for maior que o limite X da Camera2D 
            if (posicaoAlvo.X > limites.X)
            {
                // Atualiza a posição da Camera2D em X 
                this.posicaoCamera.X = posicaoAlvo.X - limites.X;
                // Se a posição Y do alvo for maior que o limite Y da Camera2D 
                if (posicaoAlvo.Y > limites.Y)
                {
                    // Atualiza a posição da Camera2D em Y 
                    this.posicaoCamera.Y = posicaoAlvo.Y - limites.Y;
                }
            }
        }


        // Método que transforma a posição de cada objeto na tela 
        // na direção oposta para qual a Camera2D se locomove e 
        // retorna a nova posição do objeto na tela 
        public Vector2 Transformar(Vector2 posicaoAntiga)
        {
            return new Vector2(posicaoAntiga.X - posicaoCamera.X,
                                            posicaoAntiga.Y - posicaoCamera.Y);
        }

    }
}
