using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseMassSkill : Skill
{

    Rigidbody rigidbody;
    Transform transform;

    void Skill.cast(GameObject source, List<GameObject> destination)
    {
        rigidbody = source.GetComponent<Rigidbody>();
        transform = source.GetComponent<Transform>();
        rigidbody.mass *= 2;
        transform.localScale = new Vector3(2, 2, 2);
    }


}
