using UnityEngine;

public class PonyoController : MonoBehaviour
{
    public Animator animator; // Reference to the Animator

    // Called when Ponyo should start reacting (for example, when water is poured)
    public void React()
    {
        animator.SetBool("IsHappy", true); // Set boolean to true to play jump/splash animation
    }

    // Called when the reaction should stop (for example, when water stops boiling)
    public void StopReacting()
    {
        animator.SetBool("IsHappy", false); // Return Ponyo to idle animation
    }
}
