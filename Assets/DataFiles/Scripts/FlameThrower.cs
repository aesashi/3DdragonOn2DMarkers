using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : MonoBehaviour
{
    Animator anim;
    public ParticleSystem flame;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        flame = GetComponentInChildren<ParticleSystem>();
        flame.Stop();
    }

    public void startFlame()
    {
        if (flame.isStopped)
        {
            flame.Play();
        }

    }

    public void stopFlame()
    {
        flame.Stop();
    }
}
