


using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class HealthController : MonoBehaviour
{
    public UnityEvent triggerDeathEvent;
    public SimpleFloatData floatObject;
    public Slider Slider;

    void Update()
    {
        Slider.value = floatObject.value;
        if (Slider.value <=0)
        {
            triggerDeathEvent.Invoke();
        }
    }
}