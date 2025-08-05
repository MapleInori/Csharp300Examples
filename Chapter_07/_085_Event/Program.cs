namespace _085_Event
{
    //电话类
    class Phone
    {
        public event EventHandler<CallEventArgs> CallAlert;  //来电提醒事件
        public readonly long Number;                         //本机电话号码
        public Phone(long number) { this.Number = number; }
        public void Call(long number)                        //来电
        {
            if (CallAlert != null) CallAlert(this, new CallEventArgs(number));//触发来电提醒事件
        }
    }
    class CallEventArgs : EventArgs
    {
        public readonly long Number;                     //来电号码
        public CallEventArgs(long number) { this.Number = number; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建电话实例（本机号码13888888888）
            Phone phone = new Phone(13888888888);
            // 订阅来电提醒事件
            phone.CallAlert += new EventHandler<CallEventArgs>(phone_CallAlert);
            phone.Call(13999999999); // 13888888888呼叫13999999999
        }
        static void phone_CallAlert(object sender, CallEventArgs e)
        {
            Phone phone = sender as Phone;
            Console.WriteLine("号码{0}呼叫号码{1}...", phone.Number, e.Number);
        }
    }
}
