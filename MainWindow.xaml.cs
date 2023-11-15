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

namespace Prog_122_L13_RadioButtonsCheckBoxes;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    List<RadioButton> sauces = new List<RadioButton>();
    List<CheckBox> toppings = new List<CheckBox>();

    public MainWindow()
    {
        InitializeComponent();

        sauces.Add(rbRed);
        sauces.Add(rbWhite);
        sauces.Add(rbGarlic);
        sauces.Add(rbBuffalo);
        sauces.Add(rbNoSauce);

        toppings.Add(ckChicken);
        toppings.Add(ckChicken_Copy);
        toppings.Add(ckMushroom);
        toppings.Add(ckPineapple);
        toppings.Add(ckJerkChicken);


    }

    public string Toppings()
    {
        string listOfToppings = "";
        foreach(CheckBox topping in toppings)
        {
            if(topping.IsChecked.Value)
            {
                listOfToppings += topping.Content.ToString() + "\n";
            }
        }

        return listOfToppings;
    }

    private void btnReceipt_Click(object sender, RoutedEventArgs e)
    {
        // What are nullable primitives ( strings, doubles, ints, bool )
        // variables that have a ? at the end of them
        // And can ALSO check for null values

        // Basic Version of checkbox
        // checkBoxName.IsChecked.Value - Return a true or false
        bool hasPineapple = ckPineapple.IsChecked.Value;
        bool hasMushroom = ckMushroom.IsChecked.Value;

        // bool = true or false
        // false == true
        // true == true

        rtbDisplay.Text = "Ingredients\n\n";
        rtbDisplay.Text += Toppings();
        //if(hasPineapple)
        //{
        //    rtbDisplay.Text += "Has Pineapple\n";
        //}


        //if (hasMushroom)
        //{
        //    rtbDisplay.Text += "Has Mushroom\n";
        //}

        //// Bypass declaring a variable, and pass the property right in
        //if (ckSausage.IsChecked.Value)
        //{
        //    rtbDisplay.Text += "Has Sausage\n";
        //}


        //if (ckChicken.IsChecked.Value)
        //{
        //    rtbDisplay.Text += "Has Chicken\n";
        //}

        //CheckBox jerk = ckJerkChicken;
        //if (jerk.IsChecked.Value)
        //{
        //    rtbDisplay.Text += $"Has {jerk.Content}\n";
        //}

        // Reminder if we have time, show off the really cool thing with controls and lists



        //if(hasPineapple == false) 
        //if(hasPineapple == null) 

        //MessageBox.Show(hasPineapple.ToString());

        rtbDisplay.Text += "\nCheese\n";

        bool hasCheddar = rbCheddar.IsChecked.Value;
        bool hasColby = rbColby.IsChecked.Value;


        if(hasCheddar)
        {
            rtbDisplay.Text += "Cheddar";
        }
        else if(hasColby)
        {
            rtbDisplay.Text += "Colby";

        }
        else if (rbMoz.IsChecked.Value)
        {
            rtbDisplay.Text += rbMoz.Content;

        }
        else 
        {
            rtbDisplay.Text += rbAmerican.Content;
        }

        // Display The Chosen Sauce
        rtbDisplay.Text += "\n\nChosen Sauce\n";
        rtbDisplay.Text += ChosenSauce();


        // Cheese
        /*
         * cheddar
            colby jack
            american
            mozzeralla
         */

        // Sauce
            // Red
            // White
            // Garlic
            // BBQ
            // No Sauce
        // Dough
        // Size



    }

    public string ChosenSauce()
    {

        foreach (RadioButton sauce in sauces)
        {
            if (sauce.IsChecked.Value)
            {
                return sauce.Content.ToString();

            }
        }

        return "";
    }

}