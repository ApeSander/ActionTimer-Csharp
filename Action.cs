public class Action
{
    public float startTime; //The initial time of the action
    public float time; //The time the action is running
    public string name; //The name of the action

    public Action(float startTime, string name)
    {
        this.startTime = startTime;
        time = startTime;
        this.name = name;
    }
}