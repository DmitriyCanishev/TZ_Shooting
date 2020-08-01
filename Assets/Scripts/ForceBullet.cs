using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Force/Force")]
public class ForceBullet : ScriptableObject
{
    [SerializeField] private float force;

    public float Force => force;  
}
