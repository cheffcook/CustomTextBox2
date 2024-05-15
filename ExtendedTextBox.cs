using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CustomTextBox
{
    public class ExtendedTextBox : TextBox
    {
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (TextProperty != null && e.Key == Key.Enter) 
            {
                GetBindingExpression(TextProperty)?.UpdateSource();
            }
        }

        protected override void OnGotFocus(RoutedEventArgs e)
        {
            base.OnGotFocus(e);
            SelectAll();
        }

        /*protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e)
        {
            base.OnGotKeyboardFocus(e);
            SelectAll();
        }*/

        protected override void OnMouseUp(MouseButtonEventArgs e)
        { 
            base.OnMouseUp(e);
            Focus();
        }
    }
}
