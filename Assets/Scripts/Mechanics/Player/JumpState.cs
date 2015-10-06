﻿using UnityEngine;
using System.Collections;
using System;

public class JumpState : IPlayerState
{

    public void EnterState(Player player)
    {

    }

    public IPlayerState HandleInput(Player player)
    {
        if(player.GetIsGrounded() == true)
        {
            return new StandingState();
        }
        return null;
    }

    public void UpdateState(Player player)
    {
       
    }




}
