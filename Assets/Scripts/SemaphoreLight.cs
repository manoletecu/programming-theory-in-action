using UnityEngine;

public class SemaphoreLight : MonoBehaviour
{
    [SerializeField]
    private protected Light Light;
    [SerializeField]
    protected float Duration = 3;
    [SerializeField]
    public SemaphoreLight NextLight;

    //ENCAPSULATION
    public bool IsLit { get; protected set; }

    public virtual void TurnOn()
    {
        if (IsLit)
            return;

        Light?.gameObject.SetActive(true);
        IsLit = true;
        Invoke("SwitchLight", Duration);
    }

    public virtual void TurnOff()
    {
        if (!IsLit)
            return;

        Light?.gameObject.SetActive(false);
        IsLit = false;
    }

    //ABSTRACTION
    protected void SwitchLight()
    {
        TurnOff();
        NextLight?.TurnOn();
    }
}
