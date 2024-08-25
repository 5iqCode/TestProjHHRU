using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
public class ClickScript : MonoBehaviour,IPointerDownHandler
{
    [SerializeField] private GameObject _animatedTextPrefab;

    private float _endMoneyFor1Click; //конечное значение с учётом 10% от получаемой софт валюты автосбора

    [SerializeField] private MoneyController _moneyController;
    
    [SerializeField] private EnergyController _energyController;

    [SerializeField] private LoadedInfo _loadedInfo;

    private void Start()
    {
        _endMoneyFor1Click = _loadedInfo._baseValueSoftCurrencyFor1Click + _loadedInfo._tapModifier;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (_energyController.CanMinusEnergy() == true)
        {
            _moneyController.AddMoney(_endMoneyFor1Click);
            SpawnAnimatedText();
        }
    }
    private void SpawnAnimatedText()
    {
        GameObject _tempAnimatedTextObj = Instantiate(_animatedTextPrefab, transform);
        TMP_Text _textAnimatedTextObj = _tempAnimatedTextObj.GetComponent<TMP_Text>();
        _textAnimatedTextObj.text = "+" + _endMoneyFor1Click;
    }
}
