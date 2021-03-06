using System;
using CADASTRO_PESSOA_FS1.Interfaces;

namespace CADASTRO_PESSOA_FS1.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica //herda a superclasse primeiro e depois a interface
    {
        public string cpf { get; set; }
        
        public string dataNascimento { get; set; }

        //enc remoto 3. exemplo com DateTime
        // public bool ValidarDataNascimento(DateTime dataNasc)
        // {
        //     DateTime dataAtual = DateTime.Today;

        //     double anos = (dataAtual - dataNasc).TotalDays / 365;

        //     if (anos >= 18)
        //     {
        //         Console.WriteLine("Maior de 18 anos.");
        //         return true;
        //     }

        //     Console.WriteLine("...xiii! Menor de 18 anos.");
        //     return false;
    
        // }

        public bool ValidarDataNascimento(string dataNasc) //validação data de nasc enc remoto 3 com string e TryParse
        {
            DateTime dataConvertida;
            if(DateTime.TryParse(dataNasc, out dataConvertida)) //tenta converter a data de nasc (string) e exibe a saída resultado
            {
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                if (anos >= 18 && anos < 90)
                {
                    // Console.WriteLine($"\nData de Nascimento: {dataConvertida}");
                    return true;
                }
                // Console.WriteLine(@$"
                // Data de Nascimento: {dataConvertida}
                // ");
                return false;
            }

            return false;
        }

        // *** Enc. Remoto 6 ***
        public override float PagarImposto(float rendimento) //override vai dizer que o método deve ser subrescrito
        {
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento > 1500 && rendimento <= 3500) //usar else if porque ainda está validando a variável rendimento
            {
                return (rendimento / 100) * 2;
            }
            else if (rendimento > 3500 && rendimento < 6000)
            {
                return (rendimento / 100) * 3.5f;
            }
            else
            {
                return (rendimento / 100) * 5;
            }

        }

        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}