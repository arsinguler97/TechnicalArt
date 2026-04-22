using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class HDRISkyRotate : MonoBehaviour
{
    public Volume volume;
    public float speed = 10f;

    HDRISky sky;

    void Start()
    {
        volume.profile.TryGet(out sky);
    }

    void Update()
    {
        if (sky != null)
            sky.rotation.value += speed * Time.deltaTime;
    }
}