﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask1
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Next;
        public Node(T data)
        {
            Data = data;
        }
    }
}
