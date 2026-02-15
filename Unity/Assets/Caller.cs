using UnityEngine;

public class Caller : MonoBehaviour
{

    [SerializeField] private Receiver receiver;

    void Start()
    {
        Debug.Log("Hello Friend");
        receiver.OnCalled();
    }
}
