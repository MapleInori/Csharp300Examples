// 在VS2022中，应该创建的是Windos窗体类库，而非类库，类库中没有Forms
// 然后将其引用到002项目中调用
namespace _003_CreateWinFormDLL
{
    public class HelloClass
    {
        /// <summary>
        /// 弹窗显示一行内容
        /// </summary>
        public void HelloWorld()
        {
            System.Windows.Forms.MessageBox.Show("Hello World Win Form DLL");
        }
    }
}
