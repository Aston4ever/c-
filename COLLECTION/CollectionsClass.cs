using System;
using System.Collections;
using System.Collections.Generic;

namespace COLLECTION;

public class CollectionsClass
{
    //Коллекции в отличие от массивов не имеют размера, можно хранить объектыб не ограничены одним типом объектов
    //non-generic могут содержать разные типы данныхю. Находятся в System.Collections
    //generic могут содержать только 1 тип данных и Находятся в System.Collections.generic
    void mainHere()
    {
        ArrayList myArrayList = new ArrayList();
        List<int> myIntList = new List<int>();
        
        myArrayList.Add("1");
        myArrayList.Add(2);
        myArrayList.Add(true);     
        myArrayList.Add(2);
        myArrayList.Add("Привет мой дорогой друг");
        
        //delete element 
        myArrayList.Remove(2); // удалит первый объект 2 тоесть под индексом 1, вторую двойку не тронет
        myArrayList.RemoveAt(0); //удаляет элемент под номером индекса
        Console.WriteLine(myArrayList.Count);
        double sum = 0;
        foreach (object obj in myArrayList)
        {
            if (obj is int)
            {
                sum += Convert.ToInt32(obj);
            }
            else if(obj is double)
            {
                sum += (double)obj;
            }
        }
    }
}