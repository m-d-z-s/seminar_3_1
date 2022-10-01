namespace seminar_2
{
    internal class MyStack<U>
    {
        public U[] array;
        public int maxSize;
        public int sizeArray;

        public MyStack()
        {
            maxSize = 0;
            array = new U[maxSize];
            sizeArray = 0;
        }

        public MyStack(int maxSize)
        {
            this.maxSize = maxSize;
            array = new U[this.maxSize];
            sizeArray = 0;

        }
        public void SetMaxSize(int value)
        {
            maxSize = value;
            array = new U[maxSize];
        }

        public bool Push(U valueAdd)
        {
            if (sizeArray == maxSize)
            {
                return false;
            }
            else
            {
                array[sizeArray] = valueAdd;
                sizeArray++;
                return true;
            }
        }

        public U Pop()
        {
            sizeArray--;
            return array[sizeArray];
        }

        public bool IsEmpty()
        {
            return sizeArray == 0;
        }
    }
}
