namespace Calculator 
{
    class Program 
    {
        static  void Main(string[] args) 
        {
            Util.viewApresentation();
            int escolha = 0;

            do 
            {
                Util.viewOptions();
                Console.Write("Sua escolha: ");    
                escolha = int.Parse(Console.ReadLine());

                switch(escolha) 
                {
                    case (int)OperacaoMatematica.Soma:
                        Console.WriteLine("------- Soma -------"); 
                        Operacoes.somaValores();   
                        break;
                    case (int)OperacaoMatematica.Subtracao:
                        Console.WriteLine("------- Substração -------"); 
                        Operacoes.subtraiValores();   
                        break;
                    case (int)OperacaoMatematica.Divisao:
                        Console.WriteLine("------- Divisão -------"); 
                        Operacoes.divideValores();   
                        break;
                    case (int)OperacaoMatematica.Multiplicao:
                        Console.WriteLine("------- Multiplicação -------"); 
                        Operacoes.multiplicaValores();   
                        break;
                }
            } while(escolha != (int)SairPrograma.Sair);
        }
    }
}