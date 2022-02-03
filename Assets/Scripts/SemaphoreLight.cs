using UnityEngine;

public class SemaphoreLight : MonoBehaviour
{
    [SerializeField]
    private protected Light Light;
    [SerializeField]
    protected float Duration = 3;
    [SerializeField]
    public SemaphoreLight NextLight;

    protected bool _isLit;

    public virtual void TurnOn()
    {
        if (_isLit)
            return;

        Light?.gameObject.SetActive(true);
        _isLit = true;
        Invoke("SwitchLight", Duration);
    }

    public virtual void TurnOff()
    {
        if (!_isLit)
            return;

        Light?.gameObject.SetActive(false);
        _isLit = false;
    }

    protected void SwitchLight()
    {
        TurnOff();
        NextLight?.TurnOn();
    }
}
