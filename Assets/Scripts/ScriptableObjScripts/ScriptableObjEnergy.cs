using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnergyInfo", menuName = "ScriptableObject/EnergyInfo")]
public class ScriptableObjEnergy : ScriptableObject
{
    public float StartEnergy = 1000; //Cтартовая энергия

    public float MinusEnergyFor1Click = 1; //Энергии требуется для каждого клика
}
