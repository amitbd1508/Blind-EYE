using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindEye_Lib.Utilities
{
    public class Constant
    {
        public static string NOTIFICATION_ERROR_DATA_SAVING = "Error in saving data.";
        public static string NOTIFICATION_ERROR_DATA_MODIFYING = "Error in modifying data.";
        public static string NOTIFICATION_ERROR_DATA_DELETING = "Error in deleting data.";
        public static string NOTIFICATION_SUCCESS_DATA_SAVING = "Data saved successfully.";
        public static string NOTIFICATION_SUCCESS_DATA_MODIFYING = "Data modified successfully.";
        public static string NOTIFICATION_SUCCESS_DATA_DELETING = "Data deleted successfully.";


        public static string NOTIFICATION_CAPTION_SAVE = "Saving Information";
        public static string NOTIFICATION_CAPTION_DELETE = "Deleting Information";

        public static string NOTIFICATION_CAPTION_FATAL_ERROR = "Fatal Error Occured";

        public static string NOTIFICATION_ERROR_ALREADY_EXIST = "Data already exist.";

        public static string NOTIFICATION_PRODUCT_CATEGORY_NAME_EXIST = "Duplicate product category is invalid.";

        public static string NOTIFICATION_ERROR_DATA_VALIDATION = "Error in data validation.";

        public static string NOTIFICATION_CAPTION_FIELD_BLANK_ISINVALID = "Blank filed is invalid.";
        public static string NOTIFICATION_CAPTION_COMBOBOX_SELECTION = "Invalid selection.";
        public static string NOTIFICATION_MESSEGE_COMBOBOX_SELECTION = "Please select a valid item.";

        public static string NOTIFICATION_ERROR_VALIDATION_FORMATE = "Input formate is invalid.";

        public static string NOTIFICATION_DATA_MUST_BE_INTEGER = "Data must be an integer.";
        public static string NOTIFICATION_MSG_INT = "Please give a valid input.";

        public static string NOTIFICATION_DATA_MUST_BE_FLOAT = "Data must be an float.";
        public static string NOTIFICATION_DATA_MUST_BE_Decimal = "Data must be in money.";

        public static string NOTIFICATION_CAPTION_COMBOBOX_VALIDATION = "Please select a valid item.";

        public static string NOTIFICATIO_VALIDATION_SELECTED_VENDOR_ISINVALID = "Vendor name is Invalid.";

        public static string NOTIFICATION_CAPTION_VALIDATION = "Validation: Required filed.";
        public static string NOTIFICATION_CAPTION_VALIDATION_FORMATE = "Validation: Filed formate is invalid.";

        public static string NOTIFICATIO_VALIDATION_ALL_FIELD_IS_REQUIRED = "All fields are required";

        public static string NOTIFICATION_INVALID_MONEY_FORMATE = "Invalid money formate.";

        public static string NOTIFICATION_USER_NAME_EXIST = "This User Name Already in use";

        public static string NOTIFICATION_CAPTION_STOP_MODIFICATION = "This Iteam already in Use.You are unable to Modify/Delete this data.";

        public static string NOTIFICATION_CAPTION_STOP_UPDATE = "Not authorised to Modify/Delete this data.";

        public static string DBErrorMsg { get; set; }

        public static string NOTIFICATION_INVALID_PASSWORD = "Please give a valid password.";

        public static string NOTIFICATION_CAPTION_INVALID_PASSWORD = "Invalid password";
    }
}
