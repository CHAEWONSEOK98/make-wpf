namespace async_await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunAnything(Label lbl)
        {
            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(100);
                lbl.Text = i.ToString();
                lbl.Refresh();
            }
        }

        private async void RunAnythingAsync(Label lbl)
        {
            for (int i = 0; i < 30; i++)
            {
                await Task.Delay(100);
                lbl.Text = i.ToString();
                lbl.Refresh();
            }
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            RunAnythingAsync(lblWalk);
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            RunAnythingAsync(lblPhone);
        }

        private void btnTalk_Click(object sender, EventArgs e)
        {
            RunAnythingAsync(lblTalk);
        }

        // �񵿱� �޼��� : ��ȯ ������ Task�� ���´�.������ ��ȯ�ϰ� �ʹٸ� Task<Ÿ��>
        // Task �� ��ȯ�ؾ� await Ű���带 ����� �� �ִ�
        private async Task RunAllAsync(Label lbl)
        {
            for(int i = 0; i < 30; i++)
            {
                await Task.Delay(100);
                lbAll.Items.Add($"{lbl.Name} - {i}");
            }
        }

        private async void btnAll_Click(object sender, EventArgs e)
        {
            await RunAllAsync(lblWalk);
            await RunAllAsync(lblPhone);
            await RunAllAsync(lblTalk);
        }
    }
}
