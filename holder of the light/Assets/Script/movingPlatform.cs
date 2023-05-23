using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{

   [SerializeField]
    private Transform _targetA, _targetB; // Doelposities van de platformbeweging
    private float _speed = 5f; // Snelheid van de platformbeweging
    private bool _targetReached = false; // Geeft aan of het doel is bereikt

    private void FixedUpdate()
    {
        if(_targetReached == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, _targetB.position, _speed * Time.deltaTime);
        }else if(_targetReached == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, _targetA.position, _speed * Time.deltaTime);
        }
        if(transform.position == _targetB.position)
        {
            _targetReached = true;
        }
        if(transform.position == _targetA.position)
        {
            _targetReached = false;
        }
    }

























}