using UnityEngine;

public class SlowMotionController
{
    public float slowMoValue = 0.07f;
    public float slowMoDuration = 2f;

    void Update()
    {
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0.0f, 1.0f);
        Time.fixedDeltaTime = Mathf.Clamp(Time.timeScale, 0.0f, 0.02f);
        Time.timeScale += (1.0f / slowMoDuration) * Time.unscaledDeltaTime;
        Time.fixedDeltaTime += (0.02f / slowMoDuration) * Time.unscaledDeltaTime;
    }

    public void SlowMotion()
    {
        Time.timeScale = slowMoValue;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }
}

