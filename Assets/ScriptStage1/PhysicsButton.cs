using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PhysicsButton : MonoBehaviour
{
    [SerializeField] private float threshold = 0.1f;
    [SerializeField] private float deadZone = 0.025f;
    public UnityEvent OnPressed, OnReleased;

    private bool _isPressed;
    private Vector3 _startPos;
    private ConfigurableJoint _jont;

    // Start is called before the first frame update
    void Start()
    {
        _startPos = transform.localPosition;
        _jont = GetComponent<ConfigurableJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_isPressed && GetValue() + threshold >= 1)
            Pressed();
        if (_isPressed && GetValue() - threshold <= 0)
            Released();
    }

    private float GetValue()
    {
        var value = Vector3.Distance(_startPos, transform.localPosition) / _jont.linearLimit.limit;
        if (Mathf.Abs(value) < deadZone)
            value = 0;

        return Mathf.Clamp(value, -1f, 1f);
    }

    private void Pressed()
    {
        _isPressed = true;
        OnPressed.Invoke();
        Debug.Log(message: "Pressed");
    }

    private void Released()
    {
        _isPressed = false;
        OnReleased.Invoke();
        Debug.Log(message: "Released");
    }
}
