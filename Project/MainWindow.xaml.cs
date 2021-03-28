using System.Collections.ObjectModel;
using System.Windows;

namespace MyNamespace {
  public partial class MainWindow : Window {
    public ObservableCollection<int> MyItems { get; }
    public int? MySelectedItem {
      get => null;
      set { }
    }

    private void CheckInvariant(object _1, RoutedEventArgs _2) =>
      YesNoTextBlock.Text = MyDataGrid.SelectedItems.Count switch {
        0 => MyDataGrid.SelectedItem == null,
        1 => MyDataGrid.SelectedItems[0] == MyDataGrid.SelectedItem,
        _ => MyDataGrid.SelectedItems.Contains(MyDataGrid.SelectedItem)
      } ? "Yes" : "No";

    public MainWindow() {
      MyItems = new ObservableCollection<int> { 1 };
      DataContext = this;
      InitializeComponent();
    }
  }
}