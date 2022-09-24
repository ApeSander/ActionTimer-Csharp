using System.Collections.Generic;

public class ActionTimer
{
    private static List<Action> actions = new List<Action>(); //A list with all current actions in it
    
    public static void AddAction(float startTime, string actionName) //Adds action with <actionName> to the list
    {
        actions.Add(new Action(startTime, actionName));
    }

    public static void RemAction(string actionName) //Removes all actions with <actionName> from the list
    {
        foreach (Action action in new List<Action>(actions))
        {
            if (action.name.Equals(actionName)) actions.Remove(action);
        }
    }

    public static void ClearActions() //Clears all actions
    {
        actions.Clear();
    }

    public static bool ContainsAction(string actionName) //Checks if list contains action with <actionName>
    {
        foreach (Action action in new List<Action>(actions))
        {
            if (action.name.Equals(actionName)) return true;
        }

        return false;
    }

    public static void ResetAction(string actionName) //Resets the time of all actions with <actionName>
    {
        foreach (Action action in new List<Action>(actions))
        {
            if (action.name.Equals(actionName)) action.time = action.startTime;
        }
    }

    public static void ResetAllActions() //Resets the time of all actions
    {
        foreach (Action action in new List<Action>(actions))
        {
            action.time = action.startTime;
        }
    }

    public static void Update(float delta, bool removeTimeout = true) //Updates the timer, removes timeout actions if <removeTimeout> is true
    {
        foreach (Action action in new List<Action>(actions))
        {
            action.time -= delta;
            if (removeTimeout && action.time <= 0) actions.Remove(action);
        }
    }
}