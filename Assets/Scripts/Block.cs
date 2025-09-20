using UnityEngine;

public class Block : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}