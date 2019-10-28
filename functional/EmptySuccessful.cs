namespace functional
{
    public class EmptySuccessful : Successful<dynamic>
    {
        public EmptySuccessful Of()
        {
            return new EmptySuccessful();
        }
    }
}