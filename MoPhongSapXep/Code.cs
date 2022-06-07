using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Code
{
    internal class Code
    {
        public void SelectionSort(ListBox lst_Code, Boolean tang)
        {
            lst_Code.Items.Add("void SelectionSort(int a[], int n) ");
            lst_Code.Items.Add("  {");
            if (tang)
                lst_Code.Items.Add("    int min, i, j; ");
            else
                lst_Code.Items.Add("    int max, i, j; ");
            lst_Code.Items.Add("    for (i = 0; i < n - 1; i++)");
            lst_Code.Items.Add("       {     ");
            if (tang)
                lst_Code.Items.Add("         min = i;      ");
            else
                lst_Code.Items.Add("         max = i;      ");
            lst_Code.Items.Add("         for (j = i + 1; j < n; j++)    ");
            if (tang)
            {
                lst_Code.Items.Add("           if (a[j] < a[min])     ");
                lst_Code.Items.Add("              min = j;      ");
                lst_Code.Items.Add("         if (min != i)      ");
                lst_Code.Items.Add("           Swap(a[min], a[i]);       ");
                lst_Code.Items.Add("       }          ");
                lst_Code.Items.Add("   }        ");
            }
            else
            {
                lst_Code.Items.Add("           if (a[j] > a[max])     ");
                lst_Code.Items.Add("              max = j;      ");
                lst_Code.Items.Add("         if (max != i)      ");
                lst_Code.Items.Add("           Swap(a[max], a[i]);       ");
                lst_Code.Items.Add("       }          ");
                lst_Code.Items.Add("   }        ");
            }
            lst_Code.Items.Add("  void Swap(int &a,int &b)  {");
            lst_Code.Items.Add("           int temp = a;");
            lst_Code.Items.Add("            a = b;");
            lst_Code.Items.Add("            b=temp;");
            lst_Code.Items.Add(" }");
        }

        public void BubbleSort(ListBox lst_Code, Boolean tang)
        {
            lst_Code.Items.Add("void BubbleSort(int a[],int n)");
            lst_Code.Items.Add("  {");
            lst_Code.Items.Add("     int i, j;");
            lst_Code.Items.Add("     for (i = 0 ; i<n-1; i++)");
            lst_Code.Items.Add("         for (j = n-1; j > i ; j --)");
            if (tang)
                lst_Code.Items.Add("            if (a[j] < a[j-1]) ");
            else
                lst_Code.Items.Add("            if (a[j] > a[j-1]) ");
            lst_Code.Items.Add("              Swap(a[j], a[j-1]);");
            lst_Code.Items.Add("  }");
            lst_Code.Items.Add("  void Swap(int &a,int &b)  {");
            lst_Code.Items.Add("           int temp = a;");
            lst_Code.Items.Add("            a = b;");
            lst_Code.Items.Add("            b=temp;");
            lst_Code.Items.Add(" }");
        }
    }
}