using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace NotarialOfficeCustomers
{
    public class RussianDataFilterLocalizationProvider : Telerik.WinControls.UI.DataFilterLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case DataFilterStringId.LogicalOperatorAnd:
                    return "Все";
                case DataFilterStringId.LogicalOperatorOr:
                    return "Любой";
                case DataFilterStringId.LogicalOperatorDescription:
                    return " of the following are true";

                case DataFilterStringId.FieldNullText:
                    return "Choose field";
                case DataFilterStringId.ValueNullText:
                    return "Enter a value";

                case DataFilterStringId.AddNewButtonText:
                    return "Добавить";
                case DataFilterStringId.AddNewButtonExpression:
                    return "Expression";
                case DataFilterStringId.AddNewButtonGroup:
                    return "Group";

                case DataFilterStringId.DialogTitle:
                    return "Фильтр";
                case DataFilterStringId.DialogOKButton:
                    return "OK";
                case DataFilterStringId.DialogCancelButton:
                    return "Отмена";
                case DataFilterStringId.DialogApplyButton:
                    return "Принять";

                case DataFilterStringId.ErrorAddNodeDialogTitle:
                    return "RadDataFilter Error";
                case DataFilterStringId.ErrorAddNodeDialogText:
                    return "Cannot add entries to the control - missing property descriptors. \nDataSource is not set and/or DataFilterDescriptorItems are not added to the Descriptors collection of the control.";

                case DataFilterStringId.FilterFunctionBetween:
                    return "Между";
                case DataFilterStringId.FilterFunctionContains:
                    return "Содержит";
                case DataFilterStringId.FilterFunctionDoesNotContain:
                    return "Does not contain";
                case DataFilterStringId.FilterFunctionEndsWith:
                    return "Ends with";
                case DataFilterStringId.FilterFunctionEqualTo:
                    return "Equals";
                case DataFilterStringId.FilterFunctionGreaterThan:
                    return "Greater than";
                case DataFilterStringId.FilterFunctionGreaterThanOrEqualTo:
                    return "Greater than or equal to";
                case DataFilterStringId.FilterFunctionIsEmpty:
                    return "Is empty";
                case DataFilterStringId.FilterFunctionIsNull:
                    return "Is null";
                case DataFilterStringId.FilterFunctionLessThan:
                    return "Less than";
                case DataFilterStringId.FilterFunctionLessThanOrEqualTo:
                    return "Less than or equal to";
                case DataFilterStringId.FilterFunctionNoFilter:
                    return "No filter";
                case DataFilterStringId.FilterFunctionIsContainedIn:
                    return "Is in list";
                case DataFilterStringId.FilterFunctionIsNotContainedIn:
                    return "Not in list";
                case DataFilterStringId.FilterFunctionNotBetween:
                    return "Not between";
                case DataFilterStringId.FilterFunctionNotEqualTo:
                    return "Not equal to";
                case DataFilterStringId.FilterFunctionNotIsEmpty:
                    return "Is not empty";
                case DataFilterStringId.FilterFunctionNotIsNull:
                    return "Is not null";
                case DataFilterStringId.FilterFunctionStartsWith:
                    return "Starts with";
                case DataFilterStringId.FilterFunctionCustom:
                    return "Custom";
            }
            return base.GetLocalizedString(id);
        }
    }
}
