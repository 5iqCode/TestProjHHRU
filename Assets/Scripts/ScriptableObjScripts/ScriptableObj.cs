using UnityEngine;

[CreateAssetMenu(fileName = "CountReceivedSoftCurrency", menuName = "ScriptableObject/CountReceivedSoftCurrency")]
public class ScriptableObj : ScriptableObject
{
    public float BaseValueSoftCurrencyFor1Click = 1; //Базовое число софт валюты получаемое за тап

    public float TapModifier = 1; // Модификатор тапа

    public float ModifierOfAnotherVariable;

    public float[] AmountOfIncomeInTTime = new float[2]; // AmountOfIncomeInTTime[0] - количество софт валюты, AmountOfIncomeInTTime[1] - время T через которое она начислится

    public float Divider; // Делитель, который задается гейм дизайнером

    private void OnValidate()
    {
        ModifierOfAnotherVariable = AmountOfIncomeInTTime[0] / Divider;
        TapModifier = AmountOfIncomeInTTime[0] * 0.1f;
    }
}
