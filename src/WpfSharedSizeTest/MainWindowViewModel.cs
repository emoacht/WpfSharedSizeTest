using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfSharedSizeTest
{
	public partial class MainWindowViewModel : ObservableObject
	{
		public ObservableCollection<ItemViewModel> Members { get; } = new();

		public MainWindowViewModel()
		{
			Members.Add(new ItemViewModel(10, "Alice"));
			Members.Add(new ItemViewModel(12, "Mary"));
			Members.Add(new ItemViewModel(21, "John"));
			Members.Add(new ItemViewModel(50, "Michel"));
		}
	}

	public partial class ItemViewModel : ObservableObject
	{
		[ObservableProperty]
		private int id;

		[ObservableProperty]
		private string name;

		public ItemViewModel(int id, string name)
		{
			this.id = id;
			this.name = name;
		}
	}
}