namespace AulaClasse
{
    class Pessoa
    {
        //Atributo da classe
        private string nome;
        private int idade;
        private double altura;
        private string sexo;
        // Construtor sem parâmetros
        public Pessoa(){
            this.nome = null;
            this.idade = 0;
            this.altura = 0.0;
            sexo = null;
        }
        // Construtor com parâmetros
        public Pessoa(string nome, int idade, double altura, char sexo){
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            sexo = sexo.ToString();
        }
        // propriedade do campo nome para acesso ao conteúdo
        public string Nome{
            get 
            { 
                return this.nome;   //retornar o valor armazenado em um campo.
            }
            set 
            {
                nome = value; // armazena o valor do campo.
            }

        }
        public int Idade{
            get 
            { 
                return this.idade;   //retornar o valor armazenado em um campo.
            }
            set 
            {
                idade = value; // armazena o valor do campo.
            }

        }
         public double Altura{
            get 
            { 
                return this.altura;   //retornar o valor armazenado em um campo.
            }
            set 
            {
                altura = value; // armazena o valor do campo.
            }

        }
         public string Sexo{
            get 
            { 
                return this.sexo;   //retornar o valor armazenado em um campo.
            }
            set 
            {
                if (value.ToUpper() == "M"){
                    this.sexo = "MASCULINO";
                }else{
                    this.sexo = "FEMININO";
                }
                //sexo = value.ToUpper()=="M" ? "MASCULINO": "FEMININO"; // armazena o valor do campo.
            }

        }
        // NÃO USADO SEMPRE***********=========>>>>>
        public double calcularPesoIdeal(){
            if (sexo.Equals("MASCULINO"))
            return (72.2 * altura) - 58;
            else
            return (62.1 * altura) - 44.7;
        }

        // Método que retorna uma string contendo as informações da pessoa
        public override string ToString()
        {
            return (string.Format("Nome: {0} \n Idade: {1} \n Altura: {2} \n Sexo: {3} \n",
            nome, idade, altura, sexo ));
        }
    }
}