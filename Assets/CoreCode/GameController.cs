using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController
{

    /// <summary>
    /// The save game name.
    /// </summary>
    private static string mFileName;

    /// <summary>
    /// The instance of the GameController.
    /// </summary>
    private static GameController mInstance;

    private bool isPaused;


    private GameController()
    {
        //init stuff
    }

    //Singleton
    public static GameController GetInstance()
    {
        //TODO: make this throw an exception to 'encourage' use of Init()
        if (mInstance == null)
        {
            mInstance = new GameController();
        }

        return mInstance;
    }

    /// <summary>
    /// Initializes the GameController
    /// </summary>
    public static void Init()
    {
        mInstance = new GameController();
    }
    public void TogglePause()
    {
        isPaused = !isPaused;
    }

    public bool GetPaused()
    {
        return isPaused;
    }


}
