﻿using System.Collections.Generic;

[System.Serializable]
public class GameBehaviorCollection
{

    List<GameBehaviour> behaviours = new List<GameBehaviour>();

    public int Count => behaviours.Count;

    public void Add(GameBehaviour behaviour)
    {
        behaviours.Add(behaviour);
    }

    public void GameUpdate()
    {
        for (int i = 0; i < behaviours.Count; i++)
        {
            if (!behaviours[i].GameUpdate())
            {
                int lastIndex = behaviours.Count - 1;
                behaviours[i] = behaviours[lastIndex];
                behaviours.RemoveAt(lastIndex);
                i -= 1;
            }
        }
    }
}