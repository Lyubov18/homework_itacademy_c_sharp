namespace Test
{
    internal class MyStack
    {
        private int[] _customStack;

        private int _stackSize;

        private int _stackIndex;

        public int StackSize 
        {
            get             
            { 
                return _stackSize;
            }
            private set 
            {
                if (value < 1)
                {
                    Console.WriteLine("неверно задан размер стека");
                    _stackSize = 0;
                }
            }
        }

        public int[] myStack 
        { 
            get 
            {
                return _customStack; 
            }
        }

        public MyStack(int stackSize) 
        {
            StackSize = stackSize;
            _customStack = new int[_stackSize];
            _stackIndex = 0;
        }

        public void Push(int number) 
        {
            if (_stackIndex > _stackSize)
            {
                Console.WriteLine("Стек заполнен до кокнца. Удалите последний элемент");
            }
            else 
            {
                _customStack[_stackIndex] = number;
                _stackIndex++;
            }
        }

        public void Pop() 
        {
            if (_stackIndex-1 < 0)
            {
                Console.WriteLine("В стеке нет значений");
            }
            else
            {
                _customStack[_stackIndex - 1] = 0;
                _stackIndex--;
            }
        }
    }
}
