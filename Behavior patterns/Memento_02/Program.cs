using System;
using System.Collections.Generic;
using System.Text;

namespace Memento_02 {

    class Hero {
        private int patrons = 10;
        private int lives = 5;
        public void Shoot() {
            if(patrons > 0) {
                patrons--;
                Console.WriteLine("Производим выстрел. Осталось {0} патронов", patrons);
            }
            else 
                Console.WriteLine("Патронов больше нет");
        }

        public HeroMemento SaveState() {
            Console.WriteLine("Сохранение игры. Параметры: {0} патронов, {1} жизней", patrons, lives);
            return new HeroMemento(patrons, lives);
        }

        public void RestoreState(HeroMemento memento) {
            this.patrons = memento.Patrons;
            this.lives = memento.Lives;
            Console.WriteLine("Восстановление игры. Параметры: {0} патронов, {1} жизней", patrons, lives);
        }
    }

    public class HeroMemento {
        public HeroMemento(int patrons, int lives) {
            Patrons = patrons;
            Lives = lives;
        }

        public int Patrons { get; private set; }
        public int Lives { get; private set; }
    }


    class GameHistory {
       public Stack<HeroMemento> History { get; private set; }
        public GameHistory() {
            History = new Stack<HeroMemento>();
        }
    }
    class Program {
        static void Main(string[] args) {

            Console.OutputEncoding = Encoding.Unicode;
            Hero hero = new Hero();
            hero.Shoot();
            GameHistory game = new GameHistory();

            game.History.Push(hero.SaveState());
            hero.Shoot();
            hero.RestoreState(game.History.Pop());
            hero.Shoot();

            Console.ReadKey();
        }
    }
}
