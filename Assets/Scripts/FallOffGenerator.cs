using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FallOffGenerator
{
    public static float[,] GenerateFallOffMap(int size)
    {
        float[,] map = new float[size, size];

        for (int y = 0; y < size; y++)
        {
            for (int x = 0; x < size; x++)
            {
                float a = x / (float)size * 2 - 1;
                float b = y / (float)size * 2 - 1;

                float value = Mathf.Max(Mathf.Abs(a), Mathf.Abs(b));
                map[x, y] = Evaluate(value);

                // Extra logic
                //if (value < fallOffStart)
                //{
                //    map[x, y] = 1;
                //}
                //else if (value > fallOffEnd)
                //{
                //    map[x, y] = 0;
                //}
                //else
                //{
                //    map[x, y] = Mathf.SmoothStep(1, 0, Mathf.InverseLerp(fallOffStart, fallOffEnd, value));
                //}
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
