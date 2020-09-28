using System;
/*  proxy hase 4 types
 * 1) удаленный заместитель (посол, ambassador) (WCF) proxy может являтся локальным предстовителем 
 *     в другом адрессном пространсве
 * 2) виртуальный заместитель. Создает тяжелые объекты по требованию (подгузка изображений размытая, а затем детальная)
 * 3) защищающий заместитель. Контролирует доступ к объекту, когда для разных
 *     объетов определены различные права доступа.(CRUD)
 * 4) умная ссылка (указатель) в С++ подсчет колличество ссылок на экземпляр. Конструкция lock, 
 *     переменная значения LINQ - умная ссылка, оператор yield, async await(машина асинхронных состояний)
 */
namespace Proxy_01 {
    class Program {
        static void Main(string[] args) {
            IHuman Bruce = new Operator();
            IHuman surrogate = new Surrogate(Bruce);
            surrogate.Request();        
        }
    }

    interface IHuman {
        void Request();
    }

    class Operator:IHuman {
        public void Request() {
            Console.WriteLine("Operator");
        }
    }

    class Surrogate:IHuman {
        IHuman @operator;

        public Surrogate(IHuman @operator) {
            this.@operator = @operator;
        }

        public void Request() {
            this.@operator?.Request();
        }
    }
}
