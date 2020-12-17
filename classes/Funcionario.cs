namespace _Introducao_Polimorfismo_Overload.classes
{
    public class Funcionario
    {
        // Atributos
        public string[] lista = {"Luiza", "José", "Marta", "João", "Giovanni", "Rafael", "Vincius"};


        // Métodos
        public string Mostrar() {

            return "Luiza \nJosé \nMarta \nJoão \nGiovanni \nRafael \nVinicius ";
        }

        public string Mostrar(int indice){

            for (var i = 1; i <= lista.Length; i++)
            {
                
                if (i == indice)
                {
                    return $"{lista[i]}";
                }

            }

            return "";

        }

        public string Mostrar(string busca){

            for (var i = 1; i < lista.Length; i++)
            {
                
                if (lista[i] == busca)
                {

                    return $"O nome esta na lista";
                
                }

            }

            return "O nome não esta na lista";

        }

        


    }
}