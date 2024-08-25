using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnergyInfo", menuName = "ScriptableObject/EnergyInfo")]
public class ScriptableObjEnergy : ScriptableObject
{
    public float StartEnergy = 1000; //C�������� �������

    public float MinusEnergyFor1Click = 1; //������� ��������� ��� ������� �����
}
