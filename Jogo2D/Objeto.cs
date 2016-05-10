using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.XNA.Framework;
using Microsoft.XNA.Framework.Graphics;


namespace Jogo2D
{
    class Objeto
    {
        // Enumeração dos tipos de colisão existentes
        public enum TipoColisao
        {
            // Refere-se ao Tile passável
            passa,

            // Refere-se ao Tile impassável
            naoPassa,

            // Refere-se ao Tile plataforma
            plataforma,
        }
        public class Tile
        {
            // Definição da textura do Tile
            protected Texture2D tile;
            // Definicão do tipo de colisão do Tile, observe
            // a variável é do tipo enumerador que criamos
            public TileColisao colisao;
            // Definição do tamanho do Tile
            public Vector2 tamanho;

            // Método que constrói o nosso Tile, recebendo
            // a textura e o tipo da colisão
            public Tile(Textura2D textura, TileColisao _colisao)
            {
                this.tile = textura;
                this.colisao = _colisao;
                this.tamanho = new Vector2(textura.Width, textura.Height);
            }
        }


    }
}
