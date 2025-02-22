
public class BaseModule : iModule
{
    public bool IsInitialized => InitState == InitializationState.Initialized;

    private InitializationState _initState = InitializationState.NotInitialized;
    public InitializationState InitState => _initState;

    public virtual InitializationResult Init()
    {
        _initState = InitializationState.Initializing;

        // do initialization stuff here

        _initState = InitializationState.Initialized;
        return InitializationResult.Success;
    }

    public void Update(float deltaTime)
    {
        // do update stuff here
    }
}