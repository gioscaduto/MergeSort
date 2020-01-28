namespace MergeSort
{
    public class Nota
    {
        public Nota(string aluno, double valor)
        {
            Aluno = aluno;
            Valor = valor;
        }

        public string Aluno { get; set; }
        public double Valor { get; set; }

        public override string ToString()
        {
            return $"Nome: {Aluno}, Nota: {Valor}";
        }
    }
}
