using TMPro;
using UnityEngine;

public class LoadedInfo : MonoBehaviour
{
    [SerializeField] private TMP_Text _infoAutoClick;

    public float _startEnergy;
    
    public float _minusEnergyFor1Click;

    public float _baseValueSoftCurrencyFor1Click;
    
    public float _tapModifier;
    
    public float _countMoneyForAutoClick;
    
    public float _timeToAddMoneyForAutoClick;
    private void Awake()
    {
        LoadInfoFromResources();
        LoadInfoEnergyFromResources();
        _infoAutoClick.text = "+" + _countMoneyForAutoClick.ToString() + " Софт валюты каждые " + _timeToAddMoneyForAutoClick + " секунд";
    }

    private void LoadInfoFromResources() //получение данных из ресурсов и запись их в публичные переменные
    {
       var _loadedInfoFromResources = Resources.Load<ScriptableObj>("Info/CountReceivedSoftCurrency");
        _baseValueSoftCurrencyFor1Click = _loadedInfoFromResources.BaseValueSoftCurrencyFor1Click;
        _countMoneyForAutoClick = _loadedInfoFromResources.AmountOfIncomeInTTime[0];
        _timeToAddMoneyForAutoClick = _loadedInfoFromResources.AmountOfIncomeInTTime[1];
        _tapModifier = _loadedInfoFromResources.TapModifier;
    }

    private void LoadInfoEnergyFromResources()
    {
       var _loadedInfoEnergyFromResources = Resources.Load<ScriptableObjEnergy>("Info/EnergyInfo");
        _startEnergy = _loadedInfoEnergyFromResources.StartEnergy;
        _minusEnergyFor1Click = _loadedInfoEnergyFromResources.MinusEnergyFor1Click;
    }
}
