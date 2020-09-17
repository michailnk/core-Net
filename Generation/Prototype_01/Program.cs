using System;
/*
 * js не имеет классов как конструкции языка но можно сами формировать класс как совокупность  состояние
 * объекта прототипа (классы виды).
 */
namespace Prototype_01 {
    
    class Prototype {
        public string Class { get; set; }
        public string State { get; set; }
        public Prototype Clone() {
            return this.MemberwiseClone() as Prototype;
        }
    }

    class Program {
        static void Main(string[] args) {
            Prototype prototype = new Prototype();
            prototype.Class = "biology system";
            prototype.State = "";

            var Human = prototype.Clone() as Prototype;
            Human.Class = "Human";
            Human.State = "Genaric adjectives of human";

            var Man = Human.Clone();
            Man.Class = "man";
            Man.State = "man's adjectives";

            var Woman = Human.Clone();
            Woman.Class = "woman";
            Woman.State = "woman's adjectives";

            var adam = Human.Clone();
            adam.State = "Adam";

            var eva = adam.Clone();
            eva.State = "Eva"; 
        }
    }
}
