using System;
using System.Windows.Forms;

public class ExampleForm : Form
{
    public ExampleForm()
    {
        Button button = new Button();
        button.Text = "Ŭ���ϼ���!";
        button.Click += Button_Click; // ��ư Ŭ�� �̺�Ʈ �ڵ鷯 ����
        Controls.Add(button);
    }

    private void Button_Click(object sender, EventArgs e)
    {
        MessageBox.Show("��ư�� Ŭ���Ǿ����ϴ�!");
    }
}

class Program
{
    static void Main()
    {
        Application.Run(new ExampleForm());
    }
}
