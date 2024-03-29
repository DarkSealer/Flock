﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider2D))]
public class FlockAgent : MonoBehaviour
{
    private Flock agentFlock;
    private Collider2D agentCollider;

    public Collider2D AgentCollider { get => agentCollider; }
    public Flock AgentFlock { get => agentFlock; }

    // Start is called before the first frame update
    void Start()
    {
        agentCollider = GetComponent<Collider2D>();
    }

    public void Initialize(Flock flock)
    {
        agentFlock = flock;
    }

    public void Move(Vector2 velocity)
    {
        transform.up = velocity;                 // in 3D se foloseste transform.forward
        transform.position += (Vector3)velocity * Time.deltaTime;
    }
}
