using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FallOffGenerator
{
    public static float[,] GenerateFalloffMap(int size)
    {
        float[,] map = new float[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                float x = i / (size);
            }
        }
    }
}
