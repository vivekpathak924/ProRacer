using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagChildren : MonoBehaviour
{
    public string tagName = "Wall";

    void Start()
    {
        AssignTagToAll(transform, tagName);
    }

    void AssignTagToAll(Transform parent, string tagToAssign)
    {
        // Assign tag to the parent GameObject
        parent.gameObject.tag = tagToAssign;

        // Recursively assign tag to all child GameObjects
        foreach (Transform child in parent)
        {
            AssignTagToAll(child, tagToAssign);
        }
    }
}

