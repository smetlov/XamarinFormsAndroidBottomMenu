namespace CustomBottomMenu.Pages
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();

            Title = CurrentPage?.Title;
        }
    }
}