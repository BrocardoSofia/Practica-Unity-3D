using UnityEngine;
using UnityEngine.Rendering;

public class AnimateCube : Interactable
{
    Animator animator;
    private string startPrompt;

    void Start()
    {
        animator = GetComponent<Animator>();
        startPrompt = prompMessage;
    }

    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Deffault"))
        {
            prompMessage = startPrompt;
        }
        else
        {
            prompMessage = "Animating...";
        }
    }

    protected override void Interact()
    {
        animator.Play("Spin");
    }
}
