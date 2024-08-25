using TMPro;
using UnityEngine;

public class MoneyController : MonoBehaviour
{
    public float _earnedMoney;

    [SerializeField] private TMP_Text _moneyTextValue;

    public void AddMoney(float _value)
    {
        _earnedMoney += _value;
        _moneyTextValue.text = _earnedMoney.ToString();
    }
}
