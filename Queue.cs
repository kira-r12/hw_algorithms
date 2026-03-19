public class Queue
    {
        private string[] _array = new string[10];

        private int _pointer = 0;

        public void Enqueue(string element)
        {
            if (_pointer == _array.Length)
            {
                var extendedArray = new string[_array.Length * 2];
                for (var i = 0; i < _array.Length; i++)
                {
                    extendedArray[i] = _array[i];
                }

                _array = extendedArray;
            }
            _array[_pointer] = element;
            _pointer += 1;
        }

        public string Dequeue()
        {
            if (_pointer == 0)
        {
            return null;
        }
        string firstElement = _array[0];
        for (var i = 0; i < _pointer - 1; i++)
            {
                _array[i] = _array[i + 1];
                    }
        _pointer -= 1;
        _array[_pointer] = null;
        return firstElement; }
        public string Peek()
        {
            if (_pointer == 0)
            {
                return null;
            }
            return _array[0];
        }
        public int Count()
        {
            return _pointer;
        }
}
