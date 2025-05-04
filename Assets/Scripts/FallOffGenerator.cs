using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FallOffGenerator
{
    public static float[,] GenerateFalloffMap(int size, float fallOffStart, float fallOffEnd)
    {
        float[,] map = new float[size, size];

        for (int y = 0; y < size; y++)
        {
            for (int x = 0; x < size; x++)
            {
                Vector2 position = new Vector2(
                    (float)x / size * 2 - 1,
                    (float)y / size * 2 - 1);

                float t = Mathf.Max(Mathf.Abs(position.x), Mathf.Abs(position.y));

                if (t < fallOffStart)
                {
                    map[x, y] = 1;
                }
                else if (t > fallOffEnd)
                {
                    map[x, y] = 0;
                }
                else
                {
                    map[x, y] = Mathf.SmoothStep(1, 0, Mathf.InverseLerp(fallOffStart, fallOffEnd, t));
                }
            }
        }

        return map;
    }

    static float Evaluate(float value)
    {
        float a = 3;
        float b = 2.2f;

        return Mathf.Pow(value, a) / (Mathf.Pow(value, a) + Mathf.Pow(b - b * value, a));
    }
}
