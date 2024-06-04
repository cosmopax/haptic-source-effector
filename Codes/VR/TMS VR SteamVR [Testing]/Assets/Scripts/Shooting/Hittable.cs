using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHittable 
{
    void OnHit(Vector3 position);
    Vector3 GetPosition();
}
