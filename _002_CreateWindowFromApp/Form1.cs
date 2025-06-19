using _003_CreateWinFormDLL;
using System.Windows.Forms;                     //.NET窗体命名空间

namespace _002_CreateWindowFromApp
{
    public partial class Form1 : Form           //定义窗体类Form1，该类继承Form类
    {
        public Form1()                           //Form1窗体构造函数
        {
            InitializeComponent();                //窗体初始化函数
            label1.Text = "Hello World";          // label1来源于Form1.Designer.cs文件的私有变量
            // 003类库中的类实例化及方法调用
            HelloClass hello = new HelloClass();
            hello.HelloWorld();
        }
    }
}

