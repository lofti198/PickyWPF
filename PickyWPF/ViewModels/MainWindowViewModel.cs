using PickyWPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PickyWPF.ViewModels
{
    public class MainWindowViewModel
    {

        public MainWindowViewModel()
        {
            NewTabCommand = new ActionCommand(p => NewTab());
            Tabs = new ObservableCollection<ITab>();
            Tabs.Add(new BrowserTab());
        }

        public ICommand NewTabCommand { get; }
        public ICollection<ITab> Tabs { get; }

        private void NewTab()
        {
            // Add logic here to create a new ITab and add it to the Tabs collection
            // For example:
            // Tabs.Add(new MyTabItem { Name = $"Tab {Tabs.Count + 1}" });
        }
    }
}
