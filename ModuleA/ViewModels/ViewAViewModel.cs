using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _title = " Hello from ViewAViewModel";

		public string Title
		{
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}

	}
}
