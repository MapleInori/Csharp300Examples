using _003_CreateWinFormDLL;

namespace _002_CreateWindowFromApp
{
    public partial class Form1 : Form           //���崰����Form1������̳�Form��
    {
        public Form1()                           //Form1���幹�캯��
        {
            InitializeComponent();                //�����ʼ������
            label1.Text = "Hello World";          // label1��Դ��Form1.Designer.cs�ļ���˽�б���
            // 003����е���ʵ��������������
            HelloClass hello = new HelloClass();
            hello.HelloWorld();
        }
    }
}

