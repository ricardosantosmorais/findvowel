using System;
using System.Collections.Generic;

namespace FindVowel
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var vowels = "aeiou";
            var consonants = "bcdfghjklmnpqrstvx";
            var vower = String.Empty;
            var rejects = String.Empty;

            Console.WriteLine("Digite o texto:");
            string word = Console.ReadLine();

            for (var i = 0; i < word.Length; i++) {

                var actual = word[i];

                //Verifica se a letra atual é uma vogal
                if(vowels.IndexOf(actual.ToString(), StringComparison.OrdinalIgnoreCase) >= 0) {

                    //Validação para a letra não ser repetida
                    if (rejects.IndexOf(actual.ToString(), StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if(actual.ToString() == vower) {
                            vower = String.Empty;
                        }
                        continue;
                    }

                    //Adicionando a vogal atual na lista de rejeitadas, evitando repetição
                    rejects = rejects + actual;

                    //Validação caso a primeira letra seja uma vogal
                    if (i > 0)
                    {
                        var consonant = word[i - 1];

                        if (consonants.IndexOf(consonant.ToString(), StringComparison.OrdinalIgnoreCase) <= 0)
                        {
                            continue;
                        }
                    } else {
                        continue;
                    }

                    //Caso já exista uma vogal. Ela sempre será a primeira
                    if (String.IsNullOrEmpty(vower))
                    {
                        vower = actual.ToString();
                    }

                }
            }

            if(String.IsNullOrEmpty(vower)) {
                Console.WriteLine("Nenhuma vogal encontrada!");
            } else {
                Console.WriteLine(String.Format("A letra buscada é:{0}", vower));
            }
        }

        public static bool hasNext() {
            throw new NotImplementedException();
        }

        public static bool getNext()
        {
            throw new NotImplementedException();
        }
    }
}
