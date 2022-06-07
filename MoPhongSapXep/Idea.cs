using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Idea
{
    internal class Idea
    {
        public void Selectionsort(ListBox lst_Code)
        {
            lst_Code.Items.Add("- Chọn phần tử nhỏ nhất(Lớn nhất) trong N phần tử trong dãy hiện hành ban đầu");
            lst_Code.Items.Add("- Đưa phần tử này về vị trí đầu dãy hiện hành");
            lst_Code.Items.Add("- Xem dãy hiện hành chỉ còn lại N-1 phần tử của dãy hiện hành ban đầu");
            lst_Code.Items.Add("    + Bắt đầu từ vị trí thứ 2");
            lst_Code.Items.Add("    + Lặp lại quá trình trên dãy cho hiện hành... đến khi dãy hiện hành chỉ còn 1 phần tử");
        }

        public void Bubblesort(ListBox lst_Code)
        {
            lst_Code.Items.Add("- Xuất phát từ cuối dãy, đổi chỗ các cặp phần tử kế cận để đưa phần tử nhỏ hơn trong cặp phần tử đó về vị trí đúng dãy hiện hành, sau đó sẽ không xét đến nó ở bước tiếp theo, do vậy ở lần xử lý thứ i sẽ có vị trí đầu dãy là i.");
            lst_Code.Items.Add("- Lặp lại xử lý trên cho đến khi không còn cặp phần tử nào để xét.");
        }
    }
}