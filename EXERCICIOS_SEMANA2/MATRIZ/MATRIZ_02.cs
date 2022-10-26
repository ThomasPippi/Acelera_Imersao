int[,] MatrizA = new int[3, 3];
            int[] somaLinha = new int[3];
            int[] somaColuna = new int[3];
            int i, j,  soma;
            Console.WriteLine("Exercícios de Matriz");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite o valor do Indice [" + i + ", " + j + "]");
                    MatrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for(i = 0; i < 3; i++)
            {
                soma = 0;
                for(j = 0; j < 3; j++)
                {
                    soma += MatrizA[i, j];
                }
                somaLinha[i] = soma;
                Console.WriteLine("A soma da linha " + i + " é: " + somaLinha[i]);
            }
            for (j = 0; j < 3; j++)
            {
                soma = 0;
                for (i = 0; i < 3; i++)
                {
                    soma += MatrizA[i, j];
                }
                somaColuna[j] = soma;
                Console.WriteLine("A soma da coluna " + j + " é: " + somaColuna[j]);
            }