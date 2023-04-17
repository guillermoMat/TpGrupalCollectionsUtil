using System.Collections;
using System.Collections.Specialized;


namespace TestProject1
{
    public class UnitTest1
    {


        [Fact]
        //SortedList
        public void SortedListBasico()
        {
            SortedList list1 = new SortedList();
            list1.Add("Lionel", "Messi");
            list1.Add("Wayne", "Rooney");
            list1.Add("Burrito", "Ortega");
            list1.Add("Roman", "Riquelme");
            /*//FORMA DE MOSTRAR 1
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine($"Clave: {list1.GetKey(i)} - Valor: {list1.GetByIndex(i)}");
            }
            */
            /*//FORMA DE MOSTRAR 2
            foreach (DictionaryEntry item in list1)//si pongo de tipo SortedList me da error de casteo, me dice que tiene que ser de tipo DictionaryEntry
            {
                //Console.WriteLine($"Clave: {item.Key} - Valor: {item.Value}");
            }
            */
            var result = list1["Lionel"];

            Assert.Equal("Messi", result);
            Assert.Equal("Riquelme", list1["Roman"]);
            Assert.NotEqual("Riquelme", list1["roman"]);
        }

        [Fact]
        public void SortedListConCollectionsUtil()
        {
            SortedList list2 = CollectionsUtil.CreateCaseInsensitiveSortedList();

            list2.Add("Chaco", "Resistencia");
            list2.Add("Corrientes", "Corrientes");
            list2.Add("Misiones", "Posadas");
            list2.Add("Entre Rios", "Parana");


            Assert.Equal("Posadas", list2["Misiones"]);
            Assert.Equal("Posadas", list2["mIsiOneS"]);
        }
        [Fact]
        public void HashTableBasico()
        {
            Hashtable hash1 = new Hashtable();
            hash1.Add("Chaco", "Resistencia");
            hash1.Add("Corrientes", "Corrientes");
            hash1.Add("Misiones", "Posadas");
            hash1.Add("Entre Rios", "Parana");

            var result = hash1["coRrientes"];

            Assert.Equal("Parana", hash1["Entre Rios"]);
            Assert.NotEqual("Corrientes", result);

        }

        [Theory]
        [InlineData("Misiones")]
        /*
        [InlineData("Chaco")]
        [InlineData("Corrientes")]
        [InlineData("Entre Rios")]
        */
        public void HashTableBasico2(string clave)
        {
            Hashtable hash1 = new Hashtable();
            hash1.Add("Chaco", "Resistencia");
            hash1.Add("Corrientes", "Corrientes");
            hash1.Add("Misiones", "Posadas");
            hash1.Add("Entre Rios", "Parana");

            //UTILIZANDO THEORY - INLINEDATA
            //foreach (var item in clave)
            //{
            //    Console.WriteLine(hash1[item]);
            //}

            Assert.NotNull(hash1);
            Assert.Equal("Posadas", hash1[clave]);
        }

        //HASHTABLE CON COLLECTIONS UTIl
        [Fact]
        public void HashTableConCollectionsUtil()
        {
            Hashtable hash2 = CollectionsUtil.CreateCaseInsensitiveHashtable();

            hash2.Add("Lionel", "Messi");
            hash2.Add("Wayne", "Rooney");
            hash2.Add("Burrito", "Ortega");
            hash2.Add("Roman", "Riquelme");

            //MANERA DE MOSTRAR 1
            //foreach (/*string*/var item in hash2.Keys)
            //{
            //    Console.WriteLine($"Clave: {item} - Valor: {hash2[item]}");
            //}
            ////MANERA DE MOSTRAR 2
            //foreach (DictionaryEntry item in hash2)
            //{
            //    Console.WriteLine($"Clave: {item.Key} - Valor: {item.Value}");
            //}

            Assert.NotNull(hash2);
            Assert.Equal("Ortega", hash2["buRRitO"]);
            Assert.Equal("Ortega", hash2["Burrito"]);


        }






    }
}