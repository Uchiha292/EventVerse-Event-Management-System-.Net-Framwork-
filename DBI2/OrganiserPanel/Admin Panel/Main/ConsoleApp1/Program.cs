using System.Windows;

namespace AdminPanel
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Navigate to User Management Page
        private void UserManagement_Click(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new UserManagementPage());
        }

        // Navigate to Event Management Page
        private void EventManagement_Click(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new EventManagementPage());
        }

        // Navigate to Reports Page
        private void Reports_Click(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new ReportsPage());
        }

        // Navigate to Feedback Moderation Page
        private void FeedbackModeration_Click(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new FeedbackModerationPage());
        }

        // Navigate to Complaints Page
        private void Complaints_Click(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new ComplaintsPage());
        }
    }
}
