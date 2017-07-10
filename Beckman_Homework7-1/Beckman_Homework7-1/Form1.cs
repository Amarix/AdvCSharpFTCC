using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


// A project to take a list of sales from a txt doc
// and display the highest, lowest, average, and total sales
//
// 9/9/16
// CSC 253
// Allie Beckman

namespace Beckman_Homework7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // method to accept the average values of the array 
        private double Average(int[] iArray)
        {
            int total = 0;
            // Accumulator, initialized to 0
            double average;

            // add each item through the array
            for (int index = 0; index < iArray.Length; index++)
            {
                total += iArray[index];
            }
            // Calculate the average.
            average = (double)total / iArray.Length;
            // Return the average.
            return average;
        }

        // accepts the largest sales within the array
        private int largest(int[] iArray)
        {
            // make an int to hold the largest value
            int largest = iArray[0];
            
            // hold the largest value until a larger one is found
            for (int index = 1; index < iArray.Length; index++)
            {
                if (iArray[index] > largest)
                {
                    largest = iArray[index];
                }
            }
            // Return the highest value.
            return largest;
        }

        // method to find the lowest sale
        private int smallest(int[] iArray)
        {
            // int to hold the value of the lowest
            int smallest = iArray[0];
            
            // check each value in list for the smallest number
            for (int index = 1; index < iArray.Length; index++)
            {
                if (iArray[index] < smallest)
                {
                    smallest = iArray[index];
                }
            }
            // Return the lowest value.
            return smallest;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Local variables
                const int SIZE = 14;                     // Number of sales
                int[] sales = new int[SIZE];           // Array of sales
                int index = 0;                          // Loop counter
                StreamReader inputFile;                 // For file input  

                int largestSale;                       // To hold the largest sale  
                int smallestSale;                        // To hold the smallest sale  
                double averageSale;                    // To hold the average sale   

                // Open the file and get a StreamReader object.
                inputFile = File.OpenText("Sales.txt");

                // add the sales info to the array.
                while (!inputFile.EndOfStream && index < sales.Length)
                {
                    sales[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }

                // Close the file. 
                inputFile.Close();

                // Display sales
                foreach (int value in sales)
                {
                    salesListBox.Items.Add(value);
                }


                // Get the highest, lowest, and average sale.
                largestSale = largest(sales);
                smallestSale = smallest(sales);
                averageSale = Average(sales);

                // Display the values. 
                highestSaleLabel.Text = largestSale.ToString();
                lowestSaleLabel.Text = smallestSale.ToString();
                averageSaleLabel.Text = averageSale.ToString();
            }

            catch (Exception ex)
            {
                // Display an error message. 
                MessageBox.Show(ex.Message);
            }

        }

        private void calculateTotalSales_Click(object sender, EventArgs e)
        {
            // create a variable for the sum
            decimal totalSales = 0;

            // go through each number in the list box until there arent any more
            for (int i = 0; i < salesListBox.Items.Count; i++)
            {
                // add each number as it's read to the sum decimal
                totalSales += Convert.ToDecimal(salesListBox.Items[i].ToString());
            }
            
            // print the total to specified label once it's complete.
            totalSalesLabel.Text = Convert.ToString(totalSales);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // exit application
            this.Close();
        }
    }
}
