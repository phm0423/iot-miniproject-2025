using MahApps.Metro.Controls.Dialogs;
using System.Windows;
using WpfMqttSubApp.Helpers;
using WpfMqttSubApp.Models;
using WpfMqttSubApp.ViewModels;
using WpfMqttSubApp.Views;

namespace WpfMqttSubApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // 애플리케이션이 종료 될때까지 계속 사용가능
        public static TotalConfig? Configuration { get; private set; }  // 설정파일을 저장할 정적 속성

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // config.json 파일로드
            Configuration = ConfigLoader.Load();    // config.json 파일 로드

            // 뷰화면 로드 후 띄우기
            var coordinator = DialogCoordinator.Instance;  // new DialogCoordinator() 와 동일
            var viewModel = new MainViewModel(coordinator);
            var view = new MainView
            {
                DataContext = viewModel,
            };
            view.ShowDialog();
        }
    }
}
