using System;
using System.Collections.Generic;

namespace Command_001 {
    // "Invoker" (Инициатор") 
    // execution device
    class ControlUnit {
        private List<Command> commands = new List<Command>();
        private int current = 0;
        public void StoreCommand(Command command) {
            commands.Add(command);
        }
        public void ExecuteCommand() {
            commands[current].Execute();
            current++;
        }
        public void Undo(int levels) {
            for(int i = 0; i < levels; i++)
                if(current > 0)
                    commands[--current].UnExecute();
        }

        public void Redo(int levels) {
            for(int i = 0; i < levels; i++) {
                if(current < commands.Count - 1)
                    commands[current++].Execute();
            }
        }
    }
    abstract class Command {
        protected ArithmeticUnit unit;
        protected int operand;
        public abstract void Execute();
        public abstract void UnExecute();
    }

    class ArithmeticUnit {
        public int Register { get; private set; }
        public void Run(char operationCode, int operand) {
            switch(operationCode) {
                case '+': Register += operand; break;
                case '-': Register -= operand; break;
                case '*': Register *= operand; break;
                case '/': Register /= operand; break;
            }
        }
    }


    class Add:Command {
        public Add(ArithmeticUnit unit, int operand) {
            this.unit = unit;
            this.operand = operand;
        }
        public override void Execute() {
            unit.Run('+', operand);
        }

        public override void UnExecute() {
            unit.Run('-', operand);
        }
    }
    class Mul:Command {
        public Mul(ArithmeticUnit unit, int operand) {
            this.unit = unit;
            this.operand = operand;
        }
        public override void Execute() {
            unit.Run('*', operand);
        }

        public override void UnExecute() {
            unit.Run('/', operand);
        }
    }
    class Div:Command {
        public Div(ArithmeticUnit unit, int operand) {
            this.unit = unit;
            this.operand = operand;
        }
        public override void Execute() {
            unit.Run('/', operand);
        }

        public override void UnExecute() {
            unit.Run('*', operand);
        }
    }
    //client
    class Calculator {
        ArithmeticUnit arithmeticUnit;
        ControlUnit controlUnit;
        public Calculator() {
            arithmeticUnit = new ArithmeticUnit();
            controlUnit = new ControlUnit();
        }
        private int Run(Command command) {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();
            return arithmeticUnit.Register;
        }

        public int Add(int operand) {
            return Run(new Add(arithmeticUnit, operand));
        }

        public int Sub(int operand) {
            return Run(new Sub(arithmeticUnit, operand));
        }

        public int Undo(int i) {
            controlUnit.Undo(i);
            return arithmeticUnit.Register;
        }
        public int Mul(int com) {
            return Run(new Mul(arithmeticUnit, com));
        }
        public int Div(int com) {
            return Run(new Div(arithmeticUnit, com));
        }
    }

    internal class Sub:Command {
        private ArithmeticUnit arithmeticUnit;

        public Sub(ArithmeticUnit arithmeticUnit, int operand) {
            this.arithmeticUnit = arithmeticUnit;
            this.operand = operand;
        }

        public override void Execute() {
            arithmeticUnit.Run('-', operand);
        }

        public override void UnExecute() {
            arithmeticUnit.Run('+', operand);
        }
    }

    class Program {
        static void Main(string[] args) {
            Calculator calc = new Calculator();
            int result = 0;
            result = calc.Add(4);
            Console.WriteLine("   {0, -1}", result);

            result = calc.Sub(9);
            Console.WriteLine("   {0, -1}", result);

            result = calc.Mul(-4);
            Console.WriteLine("   {0, -1}", result);

            result = calc.Div(2);
            Console.WriteLine("   {0, -1}", result);

            result = calc.Undo(4);
            Console.WriteLine("   {0, -1}", result);
        }
    }
}
