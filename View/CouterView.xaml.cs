namespace CounterApp
{
    public class CounterView : UserControl
    {
        public CounterView()
        {
            var button = new Button
            {
                Content = "Add",
                Width = 100,
                Height = 30
            };

            var textBlock = new TextBlock
            {
                Width = 100,
                Height = 30,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };

            textBlock.SetBinding(TextBlock.TextProperty, "Count");

            var stackPanel = new StackPanel();
            stackPanel.Children.Add(button);
            stackPanel.Children.Add(textBlock);

            Content = stackPanel;
        }
    }
}