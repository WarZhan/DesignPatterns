namespace CommandPattern
{
    /// <summary>
    /// 请求者
    /// </summary>
    public class Invoker
    {
        private Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void ExcuteCommand()
        {
            command.ExcuteCommand();
        }
    }
}
