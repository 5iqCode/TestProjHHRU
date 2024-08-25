using UnityEngine;

[CreateAssetMenu(fileName = "CountReceivedSoftCurrency", menuName = "ScriptableObject/CountReceivedSoftCurrency")]
public class ScriptableObj : ScriptableObject
{
    public float BaseValueSoftCurrencyFor1Click = 1; //������� ����� ���� ������ ���������� �� ���

    public float TapModifier = 1; // ����������� ����

    public float ModifierOfAnotherVariable;

    public float[] AmountOfIncomeInTTime = new float[2]; // AmountOfIncomeInTTime[0] - ���������� ���� ������, AmountOfIncomeInTTime[1] - ����� T ����� ������� ��� ����������

    public float Divider; // ��������, ������� �������� ���� ����������

    private void OnValidate()
    {
        ModifierOfAnotherVariable = AmountOfIncomeInTTime[0] / Divider;
        TapModifier = AmountOfIncomeInTTime[0] * 0.1f;
    }
}
