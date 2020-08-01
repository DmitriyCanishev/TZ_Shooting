using UnityEngine;

class DestroyDecal : MonoBehaviour
{
    public float live = 5.0f;
    public float timer = 0.0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (live < timer)
        {
            Destroy(gameObject);
        }
    }
}
