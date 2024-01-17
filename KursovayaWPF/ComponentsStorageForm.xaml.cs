using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KursovayaWPF
{
	/// <summary>
	/// Логика взаимодействия для ComponentsStorageForm.xaml
	/// </summary>
	public partial class ComponentsStorageForm : Window
	{
		public ComponentsStorageForm()
		{
			InitializeComponent();
		}

		private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			// Добавить или выделить элемент, зависит от контекста
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			// Удалить выбранные элемент
		}
	}
}
