﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behavior/Alignment")]
public class AlignmentBehavior : FilterFlockBihavior
{
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        // if no neighbors, mentain current alignment
        if (context.Count == 0)
        {
            return agent.transform.up;              // in 3D se foloseste transform.forward in loc de "up"
        }

        // add all points together and average
        Vector2 alignmentMove = Vector2.zero; 
        List<Transform> filteredContext = (filter == null) ? context : filter.Filter(agent, context);

        foreach (var item in filteredContext)
        {
            alignmentMove += (Vector2)item.transform.up;
        }
        alignmentMove /= context.Count;

        return alignmentMove;
    }
}
