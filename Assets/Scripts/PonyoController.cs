using UnityEngine;

public class PonyoController : MonoBehaviour
{
    public Animator animator; // Add Animator component

    public void React()
    {
        animator.SetTrigger("Happy"); // Ponyo jumps or splashes
    }
}
