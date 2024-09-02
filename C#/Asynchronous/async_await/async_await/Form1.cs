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

        // 비동기 메서드 : 반환 값으로 Task를 갖는다.형식을 반환하고 싶다면 Task<타입>
        // Task 를 반환해야 await 키워드를 사용할 수 있다
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
