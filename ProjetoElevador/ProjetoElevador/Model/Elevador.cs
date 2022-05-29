using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    public class Elevador
    {
        public Elevador()
        {
            AndarAtual = 0;
            LimitePessoas = 0;
        }

        public int AndarAtual { get; set; }
        public int TotalAndares { get; set; }
        public int LimitePessoas { get; set; }
        public int CapacidadeElevador { get; set; }
        

        public void Inicializar(int capacidadeElevador, int totalAndares)
        {
            CapacidadeElevador = capacidadeElevador;
            TotalAndares = totalAndares;
        }

        public string Entrar()
        {
            if (LimitePessoas <= CapacidadeElevador)
            {
                LimitePessoas++;
                if (AndarAtual == 0)
                    return "Entrou uma pessoa, elevador atualmente no térreo e tem " + LimitePessoas + " pessoa(s) no elevador";
                else
                    return "Entrou uma pessoa, elevador atualmente no " + AndarAtual + "º andar e tem " + LimitePessoas + " pessoa(s) no elevador";
            }
            else
            {
                return "Elevador com capacidade limite, favor aguardar o próximo";

            }
        }

        public string Sair()
        {
            if (LimitePessoas > 0)
            {

                LimitePessoas--;
                return "Saiu uma pessoa, elevador atualmente no " + AndarAtual + "º andar e tem " + LimitePessoas + " pessoa(s) no elevador";
            }

            else
            {
                return "Elevador vazio";

            }
        }

        public string Subir()
        {
            if (AndarAtual < TotalAndares)
            {
                AndarAtual++;
                return "Subiu um andar, elevador atualmente no " + AndarAtual + "º andar e tem " + LimitePessoas + " pessoa(s) no elevador";
            }

            else
            {
                return "Elevador não pode subir,já está no ultimo andar e tem ocupação de " + LimitePessoas + " pessoa(s) no elevador";

            }
        }

        public string Descer()
        {
            if (AndarAtual > 0)
            {
                AndarAtual--;
                return "Desceu um andar, elevador atualmente está no " + AndarAtual + "º andar e tem " + LimitePessoas + " pessoa(s) no elevador";

            }
            else
            {
                return "Elevador não pode descer, já está no térreo";

            }
        }
        
    }

}
