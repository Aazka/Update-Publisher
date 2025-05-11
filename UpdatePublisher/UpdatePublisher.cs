using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePublisher : MonoBehaviour
{
   private static List<IUpdateObserver> _observers=new List<IUpdateObserver>();
    private void Update()// the only update in scene
    {
        foreach (var observer in _observers)
        {
            observer.ObservedUpdate();
        }
    }
    public static void RegisterObserver(IUpdateObserver observer)
    {
        _observers.Add(observer); 
    }
    public static void UnregisterObserver(IUpdateObserver observer)
    {
        _observers.Remove(observer);
    }
}
public interface IUpdateObserver
{
    void ObservedUpdate();
}
