﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CoreTraits
{
    offspringCount = 1,
    offspringMutationChance = 15, //0 to 100
    sensingRange = (int)GlobalEnvironmentLib.TileSize * 5,
    mass = 1,
    initStorageCap = 10
}

public class Core : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}