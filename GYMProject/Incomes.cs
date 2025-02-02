﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ScottPlot;
using ScottPlot.Plottables;

namespace GYMProject
{
    public partial class Incomes : Form
    {
        private decimal monthlyIncome = 0;
        private decimal yearlyIncome = 0;
        private decimal productIncome = 0;

        public Incomes()
        {
            InitializeComponent();
        }

        private void Incomes_Load(object sender, EventArgs e)
        {
            // Database connection string
            string connectionString = GlobalVariables.ConnectionString;

            // Create SQL queries
            string monthlyIncomeQuery = @"
    SELECT SUM(Price) AS MonthlyIncome 
    FROM Membership 
    WHERE StartDate >= DATEADD(MONTH, -1, GETDATE()) 
    AND MembershipType = 'Month'";

            // Get yearly subscription income

            string yearlyIncomeQuery = @"
    SELECT SUM(Price) AS YearlyIncome 
    FROM Membership 
    WHERE StartDate >= DATEADD(YEAR, -1, GETDATE()) 
    AND MembershipType = 'Year'"; // Get product sales income
            string productIncomeQuery = @"
    SELECT SUM(P.Quantity * Pr.Price) AS ProductIncome
    FROM Purchase P
    JOIN Product Pr ON P.ProductID = Pr.ProductID
    WHERE P.PurchaseDate >= DATEADD(MONTH, -1, GETDATE())";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Execute monthly income query
                    SqlCommand cmdMonthlyIncome = new SqlCommand(monthlyIncomeQuery, conn);
                    SqlDataReader readerMonthlyIncome = cmdMonthlyIncome.ExecuteReader();
                    if (readerMonthlyIncome.Read())
                    {
                        monthlyIncome = readerMonthlyIncome.IsDBNull(0) ? 0 : readerMonthlyIncome.GetDecimal(0); // Monthly subscription income
                    }
                    readerMonthlyIncome.Close();

                    // Execute yearly income query
                    SqlCommand cmdYearlyIncome = new SqlCommand(yearlyIncomeQuery, conn);
                    SqlDataReader readerYearlyIncome = cmdYearlyIncome.ExecuteReader();
                    if (readerYearlyIncome.Read())
                    {
                        yearlyIncome = readerYearlyIncome.IsDBNull(0) ? 0 : readerYearlyIncome.GetDecimal(0); // Yearly subscription income
                    }
                    readerYearlyIncome.Close();

                    // Execute product sales income query
                    SqlCommand cmdProductIncome = new SqlCommand(productIncomeQuery, conn);
                    SqlDataReader readerProductIncome = cmdProductIncome.ExecuteReader();
                    if (readerProductIncome.Read())
                    {
                        productIncome = readerProductIncome.IsDBNull(0) ? 0 : readerProductIncome.GetDecimal(0); // Product sales income
                    }
                    readerProductIncome.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            PlotPieChart();
        }

        private void PlotPieChart()
        {
            // Create a new ScottPlot instance
            var myPlot = formsPlot2.Plot;

            // Values for pie chart
            double[] values = { (double)monthlyIncome, (double)yearlyIncome, (double)productIncome };

            // Add pie chart
            var pie = myPlot.Add.Pie(values);
            pie.ExplodeFraction = 0.1;
            pie.SliceLabelDistance = 0.5;

            // Set labels and legend text for pie slices
            double total = pie.Slices.Select(x => x.Value).Sum();
            for (int i = 0; i < pie.Slices.Count; i++)
            {
                pie.Slices[i].LabelFontSize = 20;
                pie.Slices[i].Label = $"{pie.Slices[i].Value}"; // Set slice labels
                pie.Slices[i].LegendText = $"{pie.Slices[i].Value} " +
                    $"({pie.Slices[i].Value / total:p1})"; // Set legend text
            }

            // Set title and other settings
            myPlot.Title("Income Distribution");
            myPlot.ShowLegend();

            // Hide unnecessary chart components
            myPlot.Axes.Frameless();
            myPlot.HideGrid();

            // Refresh the chart
            formsPlot2.Refresh();
        }
    }
}
