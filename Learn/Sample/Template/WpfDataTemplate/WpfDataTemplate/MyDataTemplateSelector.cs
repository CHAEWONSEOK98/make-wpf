using System.Windows;
using System.Windows.Controls;

namespace WpfDataTemplate
{
    class MyDataTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;
            if(element != null && item is Product p)
            {
                if(p.Dep == Dep.Dairy)
                {
                    return element.FindResource("MyProductDT2") as DataTemplate;
                }
                else if (p.Dep == Dep.Snack)
                {
                    return element.FindResource("MyProductDT3") as DataTemplate;
                }
                else if (p.Dep == Dep.Soda)
                {
                    return element.FindResource("MyProductDT4") as DataTemplate;
                }
            }
            return element.FindResource("MyProductDTwithEnum") as DataTemplate;
        }
    }
}
