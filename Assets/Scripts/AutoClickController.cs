using System.Collections;
using UnityEngine;

public class AutoClickController : MonoBehaviour
{
    [SerializeField] private LoadedInfo _loadedInfo;

    [SerializeField] private MoneyController _moneyController;

    private Coroutine _job;

    private float _timeAutoClick, _valueAutoClick;
    void Start()
    {
        _valueAutoClick = _loadedInfo._countMoneyForAutoClick;
        _timeAutoClick = _loadedInfo._timeToAddMoneyForAutoClick;
        StartCoroutine(WaitFirstTime(_timeAutoClick));
    }

    IEnumerator WaitFirstTime(float _time)
    {
        yield return new WaitForSeconds(_time);
        _job = StartCoroutine(AddMoneyAutoClickCor(_valueAutoClick, _timeAutoClick));
    }

    IEnumerator AddMoneyAutoClickCor(float _value,float _time)
    {
        while (true)
        {
            _moneyController.AddMoney(_value);
            yield return new WaitForSeconds(_time);
        }
    }
}
