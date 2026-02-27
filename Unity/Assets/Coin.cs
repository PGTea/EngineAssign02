using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.SetActive(false);
        Debug.Log("Coin collected!");
    }
}
