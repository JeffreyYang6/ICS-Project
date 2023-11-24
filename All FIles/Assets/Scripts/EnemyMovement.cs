using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    private float _xPosition;
    private float _yPosition;
    private float _speed;

    // Constructor for enemy movement
    public EnemyMovement(float xPosition, float yPosition, float speed)
    {
        this._xPosition = xPosition;
        this._yPosition = yPosition;
        this._speed = speed;
    }

    // Encapsulation: getting x position
    public float GetXPosition()
    {
        return this._xPosition;
    }

    // Encapsulation: setting x position
    public void SetXPosition(int xPosition)
    {
        this._xPosition = xPosition;
    }

    // Encapsulation: getting y position
    public float GetYPosition()
    {
        return this._yPosition;
    }

    // Encapsulation: setting y position
    public void SetYPosition(int yPosition)
    {
        this._yPosition = yPosition;
    }

    // Encapsulation: getting speed
    public float GetSpeed()
    {
        return this._speed;
    }

    // Encapsulation: setting speed
    public void SetSpeed(float speed)
    {
        this._speed = speed;
    }

}
