using System.Windows.Controls;
using DevExpress.Xpf.Grid;
using DevExpress.Data;

namespace DXTreeList_Totals {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            treeListControl1.ItemsSource = Stuff.GetStuff();
            treeListControl1.View.ExpandAllNodes();
            CreateTotal("Age", SummaryItemType.Min);
            CreateTotal("Age", SummaryItemType.Max);
            CreateTotal("Age", SummaryItemType.Average);
        }

        private void CreateTotal(string fieldName, SummaryItemType summaryType) {
            TreeListSummaryItem total = new TreeListSummaryItem() {
                FieldName = fieldName,
                SummaryType =  summaryType,
                ShowInColumn = fieldName
            };
            treeListControl1.TotalSummary.Add(total);
        }
    }
}
