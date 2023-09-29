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

namespace DAMWPFBinding
{
    /// <summary>
    /// Lógica de interacción para CodeBindingWindow.xaml
    /// </summary>
    public partial class CodeBindingWindow : Window
    {
        public CodeBindingWindow()
        {
            InitializeComponent();

            Binding binding = new Binding("Text");
            binding.Source = this.tbValue;
            this.tbNewValue.SetBinding(TextBlock.TextProperty, binding);
        }
    }
}
