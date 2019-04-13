# How to Customize the Excel-style Filter Drop-Down

This example demonstrates how to enable the Excel-style filter drop-down, adjust its settings and modify operators available in the Filter Rules tab.

A custom data template contains the [ExcelStyleFilterElement](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.FilteringUI.ExcelStyleFilterElement) whose [QueryOperators](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.FilteringUI.ExcelStyleFilterElement.QueryOperators) event is handled to modify the list of available operators and add a custom operator.

The data template is assigned to the [PivotGridField.CustomFilterPopupTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridField.CustomFilterPopupTemplate) property.

![screenshot](./images/screenshot.png)

> The project requires references to the DevExpress.Xpf.Core.Extensions, DevExpress.Xpf.Grid, DevExpress.Xpf.Grid.Core assemblies in addition to references created automatically when the PivotGrid control is added.

**API in this example:**

* [PivotGridField.CustomFilterPopupTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridField.CustomFilterPopupTemplate) property
* [ExcelStyleFilterElement](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.FilteringUI.ExcelStyleFilterElement) class
* [QueryOperators](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.FilteringUI.ExcelStyleFilterElement.QueryOperators) event
* [PivotGridControl.FieldFilterPopupMode](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.FieldFilterPopupMode) property
* [PivotGridControl.ShowOnlyAvailableFilterItems ](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.ShowOnlyAvailableFilterItem)
* [PivotGridField.ImmediateUpdateFieldFilter](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridField.ImmediateUpdateFieldFilter) property
* [ExcelStyleFilterElementOperatorItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.FilteringUI.ExcelStyleFilterElementOperatorItem) class
* [ExcelStyleFilterElementOperatorType](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.FilteringUI.ExcelStyleFilterElementOperatorType) enumeration
* [TextEditSettings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.TextEditSettings) class
* **ExcelItemsSource** extension

You can use any available filter element in the data template, create custom operators or even specify a data editor as an operand for an operator.

**See also:**

* [Drop-down Filter](https://docs.devexpress.com/WPF/10932)
* [Excel-style Drop-down Filter](https://docs.devexpress.com/WPF/120529)
* [Implementing Custom Functions](https://docs.devexpress.com/WindowsForms/9947)