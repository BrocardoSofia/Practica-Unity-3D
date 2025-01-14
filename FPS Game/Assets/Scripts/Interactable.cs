using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public string prompMessage;

    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {

    }
}
