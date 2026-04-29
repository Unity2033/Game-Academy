using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Enumerator<T> : IEnumerator
{
    private T [] items;
    private int count;
    private int position = -1;

    public Enumerator(T [] items, int count)
    {
        this.items = items;
        this.count = count;
    }

    public object Current => items[position];

    public bool MoveNext()
    {
        position++;

        return position < count;
    }

    public void Reset()
    {
        position = -1;
    }
}