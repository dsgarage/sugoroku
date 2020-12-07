using Cinemachine;

public static class GameSystemFacerd
{
    public static CinemachineBlendListCamera GetBlendListCameraObject
    {
        get { return _cinemachineBlendListCamera; }
    }
    private static CinemachineBlendListCamera _cinemachineBlendListCamera;

    public static bool SetBlendListCamera(CinemachineBlendListCamera cinemachineBlendListCamera)
    {
        if (_cinemachineBlendListCamera)
        {
            return false;
        }
        else
        {
            _cinemachineBlendListCamera = cinemachineBlendListCamera;
            return true;
        }
    }

}
