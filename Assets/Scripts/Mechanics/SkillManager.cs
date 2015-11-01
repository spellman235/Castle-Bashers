﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SkillManager : MonoBehaviour {

    public List<ISkill> unlockedSkills;
    public ISkill[] currentSkillLoadout;

	// Use this for initialization
	void Start () {
        unlockedSkills = new List<ISkill>();
	}


    public void unlockSkill(ISkill newSkill)
    {
        unlockedSkills.Add(newSkill);
    }

    public void changeSkill(int skillID, int replaceIndex)
    {
        currentSkillLoadout[replaceIndex] = unlockedSkills[skillID];
    }

    public void UseSkill1()
    {
        if (unlockedSkills[0].GetCoolDownTimer() <= 0)
        {
            unlockedSkills[0].UseSkill(gameObject, null, 1f);
            Debug.Log("Use Skill 1");
        }

    }

    public void UseSkill2()
    {
        if (unlockedSkills[1].GetCoolDownTimer() <= 0)
        {
            unlockedSkills[1].UseSkill(gameObject, null, 1f);
            Debug.Log("Use Skill 2");
        }

    }

    public void UseSkill3()
    {
        if (unlockedSkills[2].GetCoolDownTimer() <= 0)
        {
            unlockedSkills[2].UseSkill(gameObject, null, 1f);
            Debug.Log("Use Skill 3");
        }
    }

    public void UseSkill4()
    {
        if (unlockedSkills[3].GetCoolDownTimer() <= 0)
        {
            unlockedSkills[3].UseSkill(gameObject, null, 1f);
            Debug.Log("Use Skill 4");
        }
    }

}