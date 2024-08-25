using TMPro;
using UnityEngine;

public class EnergyController : MonoBehaviour
{
    public float _energyValue;

    private float _minusEnergyFor1Click;

    [SerializeField] private LoadedInfo _loadedInfo;

    [SerializeField] private TMP_Text _textEnergyValue;
    private void Start()
    {
        _energyValue = _loadedInfo._startEnergy;
        _minusEnergyFor1Click = _loadedInfo._minusEnergyFor1Click;
        _textEnergyValue.text = _energyValue.ToString();
    }

    public bool CanMinusEnergy()
    {
        if(_energyValue< _minusEnergyFor1Click)
        {
            Debug.Log("Закончилась энергия!");
            return false;
        }
        else
        {
            _energyValue-= _minusEnergyFor1Click;
            _textEnergyValue.text = _energyValue.ToString();
            return true;
        }
    }
}
