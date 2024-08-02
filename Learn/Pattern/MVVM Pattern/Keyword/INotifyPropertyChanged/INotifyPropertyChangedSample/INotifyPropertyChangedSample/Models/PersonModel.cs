

namespace INotifyPropertyChangedSample.Models
{
    internal class PersonModel : ObservableObject
    {
        private string _name;

		public string Name
		{
			get { return _name; }
			set 
            {
                _name = value;
                OnPropertyChanged();
            }
		}

        public PersonModel()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    Random rd = new Random();
                    Name = rd.Next(1, 1000).ToString();
                    Thread.Sleep(1000);
                }
            });
        }
    }
}
