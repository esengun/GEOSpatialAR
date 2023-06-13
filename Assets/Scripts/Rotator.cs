using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class Rotator : MonoBehaviour
{
    public float speed;
}

class RotatorSystem : ComponentSystemBase
{
    // Behavior
    struct Components
    {
        public Rotator rotator;
        public Transform transform;
    }

    public override void Update()
    {
        
    }
}