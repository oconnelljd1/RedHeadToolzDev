using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TransformExtensions
{
    // public static List<Transform> Children(this Transform transform)
    // {
    //     List<Transform> children = new List<Transform>();
    //     for(int i = 0; i < transform.childCount; i++)
    //     {
    //         children.Add(transform.GetChild(i));
    //     }
    //     return children;
    // }

    public static List<Transform> GetChildren(this Transform transform)
    {
        List<Transform> children = new List<Transform>();
        foreach (Transform child in transform)
        {
            children.Add(child);
        }
        return children;
        // return transform.Cast<Transform>().ToList();
    }
}
