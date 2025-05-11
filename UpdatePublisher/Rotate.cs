
using UnityEngine;

public class Rotate : MonoBehaviour,IUpdateObserver
{
    public float OrbitSpeed = 100;
    public GameObject capsule;

    public void ObservedUpdate()
    {
        transform.RotateAround(capsule.transform.position, Vector3.forward, OrbitSpeed * Time.deltaTime);
    }
    private void OnEnable()
    {
        UpdatePublisher.RegisterObserver(this);
    }
    private void OnDisable()
    {
        UpdatePublisher.UnregisterObserver(this);
    }
}
