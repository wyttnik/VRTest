using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class ChangeProjectile : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The projectile that's created")]
    LaunchProjectile launch = null;

    [SerializeField]
    [Tooltip("The projectile that's created")]
    GameObject m_ProjectilePrefab = null;

    [SerializeField]
    [Tooltip("The projectile that's created")]
    List<Material> m_MaterialList = null;

    [SerializeField]
    [Tooltip("The projectile that's created")]
    GameObject m_preview = null;

    public void Change()
    {
        int randInt = Random.Range(0, 12);
        m_ProjectilePrefab.GetComponent<Renderer>().material = m_MaterialList[randInt];
        LaunchProjectile.SetProjection(m_ProjectilePrefab);

        m_preview.GetComponent<MeshRenderer>().material = m_MaterialList[randInt];
    }
}
