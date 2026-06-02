namespace CommandPattern
{
    public class TurnOnLightSwitch : ICommand
    {
        LightSwitch lightSwitch;
        
        public TurnOnLightSwitch(LightSwitch lightSwitch)
        {
            this.lightSwitch = lightSwitch;
        }
        
        public void Execute()
        {
            lightSwitch.On();
        }

        public void Undo()
        {
            lightSwitch.Off();
        }
    }
}
