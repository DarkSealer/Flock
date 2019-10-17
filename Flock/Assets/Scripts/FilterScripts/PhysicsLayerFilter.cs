using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Filter/Physics Layer")]
public class PhysicsLayerFilter : ContextFilter
{
    public LayerMask mask;

    public override List<Transform> Filter(FlockAgent agent, List<Transform> original)
    {
        List<Transform> filtered = new List<Transform>();
        foreach (var item in original)
        {
            // daca obiectele sunt pe acelasi layer
            if (mask == (mask | (1 << item.gameObject.layer)))
            {
                filtered.Add(item);
            }
        }
        return filtered;
    }
}
