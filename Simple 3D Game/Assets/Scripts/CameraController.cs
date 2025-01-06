using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Transform target;

    private void FixedUpdate()
    {
        transform.LookAt(target);
    }
}
