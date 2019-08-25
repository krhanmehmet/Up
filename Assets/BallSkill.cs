using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSkill : MonoBehaviour
{
    public List<Skill> availableSkillList;
    private Skill currentSkill;
    private List<GameObject> targetList;
    
    // Start is called before the first frame update
    void Start()
    {
        availableSkillList = new ArrayList<Skill>();
        availableSkillList.Add(new IncreaseMassSkill());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            if(currentSkill != null)
            {
                currentSkill.cast(this.gameObject, targetList);
                currentSkill = null;
            }
        }
    }

    public Skill selectSkill(int skillIndex)
    {
        currentSkill = availableSkillList[skillIndex % availableSkillList.Count];
        return currentSkill;
    }
}
