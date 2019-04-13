using DevExpress.Data.Filtering;
using DevExpress.Xpf.Core.FilteringUI;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.Settings;
using System;
using System.Windows;

namespace WpfPivotCustomFilterDropDownExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ThemedWindow_Loaded(object sender, RoutedEventArgs e)
        {
            pivotGridControl1.BestFitArea = DevExpress.Xpf.PivotGrid.FieldBestFitArea.FieldHeader;
            pivotGridControl1.BestFit();
        }

        private void OnExcelStyleFilterQueryOperators(object sender, ExcelStyleFilterElementQueryOperatorsEventArgs e)
        {
            e.Operators.Clear();
            e.Operators.Add(new ExcelStyleFilterElementOperatorItem(ExcelStyleFilterElementOperatorType.Between) { Caption = "Between" });
            e.Operators.Add(new ExcelStyleFilterElementOperatorItem(ExcelStyleFilterElementOperatorType.DateOperators) { Caption = "Date Operators" });
            e.Operators.Add(CreateLastYearsOperator());
        }

        private ExcelStyleFilterElementOperatorItem CreateLastYearsOperator()
        {
            const string CustomFunctionName = "LastYears";
            var currentYear = DateTime.Now.Year;
            ICustomFunctionOperatorBrowsable customFunction = CustomFunctionFactory.Create(CustomFunctionName,
                (DateTime date, int threshold) =>
                {
                    return currentYear >= date.Year && currentYear - date.Year <= threshold;
                }
                );
            CriteriaOperator.RegisterCustomFunction(customFunction);
            var customFunctionEditSettings = new BaseEditSettings[] {
                new TextEditSettings {
                    MaskType = MaskType.Numeric,
                    Mask = "D",
                    MaskUseAsDisplayFormat = true,
                    NullText ="Enter the number of years before..."}
            };
            return new ExcelStyleFilterElementOperatorItem(CustomFunctionName, customFunctionEditSettings) { Caption = "Last Years" };
        }
    }
}
