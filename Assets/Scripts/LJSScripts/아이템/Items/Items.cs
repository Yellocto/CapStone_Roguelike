﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Quality { C, B, A, S ,Curse}

public abstract class Items : ScriptableObject, IDescribable
{
    [SerializeField]
    private Sprite icon;

    [SerializeField]
    private int stackSize;
    private SlotScript slot;

    [SerializeField]
    private string title;

    [SerializeField]
    private Quality quality;

    public Sprite MyIcon
    {
        get
        {
            return icon;
        }
    }

    // 아이템이 중첩될 수 있는 개수
    // 예) 소모성 물약의 경우 한개의 Slot에 여러개가
    //     중첩되어서 보관될 수 있음.
    public int StackSize
    {
        get
        {
            return stackSize;
        }
    }

    protected SlotScript Slot
    {
        get
        {
            return slot;
        }

        set
        {
            slot = value;
        }
    }

    public virtual string GetDescription()
    {
        string color = string.Empty;

        switch (quality)
        {
            case Quality.C:
                color = "#d6d6d6";
                break;
            case Quality.B:
                color = "#00ff00ff";
                break;
            case Quality.A:
                color = "#0000ffff";
                break;
            case Quality.S:
                color = "#800080ff";
                break;
            case Quality.Curse:
                color = "#FF0000";
                break;
        }

        return string.Format("<color={0}>{1}</color>", color, title);
    }

}