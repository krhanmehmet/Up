using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Skill 
{
    void cast(GameObject source, List<GameObject> destination);
}
