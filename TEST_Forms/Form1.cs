using System;
using System.Windows.Forms;

public class ExampleForm : Form
{
    public ExampleForm()
    {
        Button button = new Button();
        button.Text = "클릭하세요!";
        button.Click += Button_Click; // 버튼 클릭 이벤트 핸들러 연결
        Controls.Add(button);
    }

    private void Button_Click(object sender, EventArgs e)
    {
        MessageBox.Show("버튼이 클릭되었습니다!");
    }
}

class Program
{
    static void Main()
    {
        Application.Run(new ExampleForm());
    }
}
