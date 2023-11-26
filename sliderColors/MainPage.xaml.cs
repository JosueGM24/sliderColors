namespace sliderColors
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Red_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Color color = new Color(((float)Red.Value), ((float)Green.Value), ((float)Blue.Value));
            boxColor.Color = color;
            nameColor.Text = color.ToArgbHex();
            nameColor.TextColor = color;
        }

        private void Green_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Color color = new Color(((float)Red.Value), ((float)Green.Value), ((float)Blue.Value));
            boxColor.Color = color;
            nameColor.Text = color.ToArgbHex();
            nameColor.TextColor = color;
        }

        private void Blue_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Color color = new Color(((float)Red.Value), ((float)Green.Value), ((float)Blue.Value));
            boxColor.Color = color;
            nameColor.Text = color.ToArgbHex();
            nameColor.TextColor = color;
        }
    }
}