using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace Testing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string _clipBoard = string.Empty;
        public MainWindow()
        {
            InitializeComponent();

            SpellCheck.SetIsEnabled(myTextBox, true);

            CommandBinding copyCommand = new CommandBinding(ApplicationCommands.Copy);
            this.CommandBindings.Add(copyCommand);
            copyCommand.Executed += new ExecutedRoutedEventHandler(copyCommand_Executed);

            CommandBinding pasteCommand = new CommandBinding(ApplicationCommands.Paste);
            this.CommandBindings.Add(pasteCommand);
            pasteCommand.Executed += new ExecutedRoutedEventHandler(pasteCommand_Executed);

            this.MouseEnter += new MouseEventHandler(MainWindow_MouseEnter);
            stack1.MouseEnter += new MouseEventHandler(stack1_MouseEnter);
            nestedStack.MouseEnter += new MouseEventHandler(nestedStack_MouseEnter);
            label1.MouseEnter += new MouseEventHandler(label1_MouseEnter);
            myTextBox.MouseEnter += new MouseEventHandler(myTextBox_MouseEnter);
            label2.MouseEnter += new MouseEventHandler(label2_MouseEnter);
            myTextBox1.MouseEnter += new MouseEventHandler(myTextBox1_MouseEnter);
            listBox.MouseEnter += new MouseEventHandler(listBox_MouseEnter);
            listItem1.MouseEnter += new MouseEventHandler(listItem1_MouseEnter);
            listItem2.MouseEnter += new MouseEventHandler(listItem2_MouseEnter);
            listItem3.MouseEnter += new MouseEventHandler(listItem3_MouseEnter);
            nestedStack2.MouseEnter += new MouseEventHandler(nestedStack2_MouseEnter);
            nestedListItem1.MouseEnter += new MouseEventHandler(nestedListItem1_MouseEnter);
            nestedListItem2.MouseEnter += new MouseEventHandler(nestedListItem2_MouseEnter);
            tree.MouseEnter += new MouseEventHandler(tree_MouseEnter);

            Button btn = new Button();
            btn.Content = "Added in Code";
            tree.Items.Add(btn);
            Button btn2 = new Button();
            btn2.Content = "Also Added in Code";
            btn2.Width = 150;
            stack1.Children.Add(btn2);

            stack1.AddHandler(Button.ClickEvent, new RoutedEventHandler(btn_Click));
        }

        void pasteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Paste Command Executed");
        }

        void copyCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (myTextBox.SelectedText.Count() > 0)
                _clipBoard = myTextBox.SelectedText;
            if (myTextBox1.SelectedText.Count() > 0)
                _clipBoard = myTextBox1.SelectedText;
            Debug.WriteLine("Copy Command Executed");
        }

        void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)e.Source;
            
            Debug.WriteLine("Mouse Down :" + e.Source);
            if (btn.Background == Brushes.Silver)
                btn.Background = Brushes.Orange;
            else
                btn.Background = Brushes.Silver;
        }

        void nestedListItem2_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse Enter: " + sender);
        }

        void nestedListItem1_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse Enter: " + sender);
        }

        void nestedStack2_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse Enter: " + sender);
        }

        void tree_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse Enter: " + sender);
        }

        void listItem3_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse Enter: " + sender);
        }

        void listItem2_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse Enter: " + sender);
        }

        void listItem1_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse Enter: " + sender);
        }

        void listBox_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse Enter: " + sender);
        }

        void myTextBox1_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse Enter: " + sender);
        }

        void label2_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse Enter: " + sender);
        }

        void myTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse Enter: " + sender);
        }

        void label1_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse Enter: " + sender);
        }

        void nestedStack_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse Enter: " + sender);
        }

        void stack1_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse Enter: " + sender);
        }

        void MainWindow_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse Enter: " + sender);
        }
    }
}
