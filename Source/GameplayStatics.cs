using UnityEngine;
using System.Collections;

public static class GameplayStatics<T> where T: Object {
    public static T Cast(Object a, MonoBehaviour callingClass)
    {
        T myT = (T)a;
        if(myT)
        {
            return myT;
        }
        else
        {
            Debug.LogError("Failed To Cast Object", callingClass);
            Debug.Break();
            return null;
        }
    }
}