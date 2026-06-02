namespace CommandPattern
{
    public class OpenGarageDoor : ICommand
    {
        GarageDoor garageDoor;
        
        public OpenGarageDoor(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        
        public void Execute()
        {
            garageDoor.Open();
        }

        public void Undo()
        {
            garageDoor.Close();
        }
    }
}
