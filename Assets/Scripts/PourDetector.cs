using UnityEngine;

public class PourDetector : MonoBehaviour
{
    public Transform kettleTip;           // Tip of the kettle
    public ParticleSystem steamParticles; // Particle system above bowl
    public PonyoController ponyo;         // Ponyo reaction script

    private bool isPouring = false;

    void Update()
    {
        // Calculate how much the kettle is tilted
        float tilt = Vector3.Dot(kettleTip.up, Vector3.down);

        // If the kettle is tilted enough to pour water
        if (tilt > 0.7f)
        {
            if (!isPouring)
            {
                isPouring = true;

                // Start steam effect
                if (!steamParticles.isPlaying)
                    steamParticles.Play();

                // Tell Ponyo to react (IsHappy = true)
                ponyo.React();
            }
        }
        else
        {
            if (isPouring)
            {
                isPouring = false;

                // Stop steam effect
                if (steamParticles.isPlaying)
                    steamParticles.Stop();

                // Tell Ponyo to stop reacting (IsHappy = false)
                ponyo.StopReacting();
            }
        }
    }
}
