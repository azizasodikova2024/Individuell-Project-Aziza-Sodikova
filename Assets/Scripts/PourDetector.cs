using UnityEngine;

public class PourDetector : MonoBehaviour
{
    public Transform kettleTip;       // Tip of the kettle
    public ParticleSystem steamParticles; // Particle system above bowl
    public PonyoController ponyo;     // Ponyo reaction script

    void Update()
    {
        float tilt = Vector3.Dot(kettleTip.up, Vector3.down);

        if (tilt > 0.7f)
        {
            if (!steamParticles.isPlaying) steamParticles.Play();
            ponyo.React();
        }
        else
        {
            if (steamParticles.isPlaying) steamParticles.Stop();
        }
    }
}
