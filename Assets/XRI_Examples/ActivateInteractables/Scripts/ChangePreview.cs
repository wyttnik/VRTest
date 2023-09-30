using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class ChangePreview : MonoBehaviour
{
    private static GameObject m_ProjectilePrefab = null;

    public static void SetProjection(GameObject prefab)
    {
        m_ProjectilePrefab = prefab;
    }
}
