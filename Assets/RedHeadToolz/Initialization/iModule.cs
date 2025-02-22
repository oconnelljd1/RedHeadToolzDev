
public enum InitializationResult
{
    Success,
    Failure
}

public enum InitializationState
{
    NotInitialized,
    Initializing,
    Initialized
}

public interface iModule
{
    bool IsInitialized { get; }
    InitializationState InitState { get; }

    InitializationResult Init() { return InitializationResult.Success; }

    void Update(float deltaTime);
}