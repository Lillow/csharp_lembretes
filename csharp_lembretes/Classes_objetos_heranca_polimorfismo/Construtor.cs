namespace csharp_lembretes.Classes_objetos_heranca_polimorfismo
{
    public class Construtor //Construtor primário
    {
        //"prop" atalho para propriedade 
        public int MyProperty1 { get; set; }
        public string MyProperty2 { get; set; } = "";
        public int MyProperty3 { get; set; }

        //"ctor" atalho para criar construtor 
        public Construtor(int myProperty1)
        {
            MyProperty1 = myProperty1;
        }

        public Construtor(int myProperty1, string myProperty2)
        {
            MyProperty1 = myProperty1;
            MyProperty2 = myProperty2;
        }


        //Usos de construtores

        Construtor construtor1 = new Construtor(1);

        Construtor construtor2 = new(1, "Propriedade2")
        {
            MyProperty3 = 3
        };
    }
}
