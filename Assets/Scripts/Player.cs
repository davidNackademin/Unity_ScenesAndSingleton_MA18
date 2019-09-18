using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int points = 0;


	private static Player _instance;


    public static Player Instance { get
		{
            if (_instance == null)
			{
				_instance = Instantiate(Resources.Load<GameObject>("player")).GetComponent<Player>();
			}

			return _instance;
		}

	}


    private void Awake()
	{

        if (_instance != null && _instance != this) {
			Destroy(gameObject);
        }
        else
		{
			_instance = this;
			DontDestroyOnLoad(gameObject);
		}
	}


    private void OnMouseDown()
    {
        points++;
    }

}
