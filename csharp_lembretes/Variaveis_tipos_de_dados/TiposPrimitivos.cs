namespace csharp_lembretes.Variaveis_tipos_de_dados
{
    internal class TiposPrimitivos
    {
        //Tipos primitivos

        public byte byte_ = byte.MaxValue;         //  0 a 255                                                 |   1byte
        public sbyte sbyte_ = sbyte.MinValue;       //  -128 a 127                                              |   1byte 
        public short short_;       //  -32.768 a 32.767                                        |   2bytes
        public ushort ushort_;     //  0 a 65535                                               |   2bytes
        public int int_;           //  -2.147.483.648 a 2.147.483.647                          |   4bytes
        public uint uint_;         //  0 a 4.294.967.295                                       |   4bytes  
        public long long_;         //  -9.223.372.036.854.775.808L a 9.223.372.036.854.775.807L|   8bytes  
        public ulong ulong_;       //  0 a 18.446.744.073.709.551.615                          |   8bytes  
        public nint nint_;         //  Depende da plataforma (computada em runtime)            |   4bytes
        public nuint nuint_;       //  Depende da plataforma (computada em runtime)            |   4bytes


        public float float_;       //  ±1.4E-45f a ±3.4028235E+38f
        public double double_;     //  ±4.9E-324 a ±1.7976931348623157E+308                    |   8bytes  
        public decimal decimal_;   //  28 números significativos                               |   16bytes  

        public bool boleano;       //  true ou false                                           |   1byte

        public char char_;         //  'a', 'b', 'c', '1'...                                   |   16 bits

        public TiposPrimitivos()
        {
             uint_ = uint.MaxValue; //Valor máximo de uint
            int_ = int.MinValue;    //Valor mímnimo de uint
        }

        public TiposPrimitivos(char var_s)
        {
            var var_ = var_s;
            Console.WriteLine($"{var_} é tipo: char");
            /*
             * Esse tipo tem seu tipo de acordo com o primeiro valor recebido; Precisa
             * sempre receber um valor na declaração; Só pode ser declarados detro de
             * métodos.
             * 
             */
        }

        public TiposPrimitivos(int var_i)
        {
            var var_ = var_i;
            Console.WriteLine($"{var_} é tipo: int");
            /*
             * Esse tipo tem seu tipo de acordo com o primeiro valor recebido; Precisa
             * sempre receber um valor na declaração; Só pode ser declarados detro de
             * métodos.
             * 
             */
        }

        public TiposPrimitivos(bool var_b)
        {
            var var_ = var_b;
            Console.WriteLine($"{var_} é tipo: bool");
            /*
             * Esse tipo tem seu tipo de acordo com o primeiro valor recebido; Precisa
             * sempre receber um valor na declaração; Só pode ser declarados detro de
             * métodos.
             * 
             */
        }




    }
}
