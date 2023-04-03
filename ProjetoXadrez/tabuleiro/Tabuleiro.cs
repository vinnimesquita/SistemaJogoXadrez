

namespace tabuleiro
{
    // Explicar a classe : Criar um tabuleiro, instaciar a matrioz de peças e definir quantas linhas e colunas o tabuleiro vai ter
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas; // Matriz de peças

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
    }
}
