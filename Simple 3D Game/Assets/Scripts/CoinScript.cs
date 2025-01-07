using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float rotateSpeed;

    private void FixedUpdate()
    {
        transform.Rotate(0, 0, rotateSpeed);

    
    }
}
